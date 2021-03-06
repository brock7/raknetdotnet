using System;
using System.Collections.Generic;
using ProtocolGenerator.Helpers;

namespace ProtocolGenerator.Generators
{
    internal sealed class EventHandlersGenerator : IGenerator
    {
        public EventHandlersGenerator(string handlersName, IList<EventInfo> eventInfos)
        {
            this.handlersName = handlersName;
            this.eventInfos = eventInfos;
        }

        public void AddChildGenerator(IGenerator generator)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void RemoveChildGenerator(IGenerator generator)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public void Write(ICodeWriter o)
        {
            o.WriteLine("[Transient]");
            o.BeginBlock("internal sealed class {0} : IEventHandlers {{", handlersName);
            WriteCallHandler(o);
            WriteEvents(o);
            o.EndBlock("}");
        }

        private void WriteCallHandler(ICodeWriter o)
        {
            o.BeginBlock("public void CallHandler(IEvent e) {");
            o.BeginBlock("switch (e.Id) {");
            foreach (EventInfo ei in eventInfos)
            {
                o.BeginBlock("case {0}:", ei.EventId);
                string handlerName = GetHandlerName(ei.Type.Name);
                o.BeginBlock("if ({0} != null)", handlerName);
                o.WriteLine("{0}(({1})e);", handlerName, ei.Type.Name);
                o.EndBlock("break;");
                o.EndBlock("");
            }
            o.BeginBlock("default:");
            o.WriteLine("throw new UnknownEventIdException(e.Id, \"{0}\");", handlersName + ".CallHandler()");
            o.EndBlock("");
            o.EndBlock("}");
            o.EndBlock("}");
        }

        private void WriteEvents(ICodeWriter o)
        {
            foreach (EventInfo ei in eventInfos)
            {
                o.WriteLine("public event GenericEventHandler<{0}> {1};", ei.Type.Name, GetHandlerName(ei.Type.Name));
            }
        }

        private static string GetHandlerName(string typeName)
        {
            return NamingHelper.GetPrefix(typeName, "Event");
        }

        private string handlersName;
        private IList<EventInfo> eventInfos;
    }
}