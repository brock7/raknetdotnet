/******************************************************/
/*          NULLFX FREE SOFTWARE LICENSE              */
/******************************************************/
/*  CRC32 Library                                     */
/*  by: Steve Whitley                                 */
/*  © 2005 NullFX Software                            */
/*                                                    */
/* NULLFX SOFTWARE DISCLAIMS ALL WARRANTIES,          */
/* RESPONSIBILITIES, AND LIABILITIES ASSOCIATED WITH  */
/* USE OF THIS CODE IN ANY WAY, SHAPE, OR FORM        */
/* REGARDLESS HOW IMPLICIT, EXPLICIT, OR OBSCURE IT   */
/* IS. IF THERE IS ANYTHING QUESTIONABLE WITH REGARDS */
/* TO THIS SOFTWARE BREAKING AND YOU GAIN A LOSS OF   */
/* ANY NATURE, WE ARE NOT THE RESPONSIBLE PARTY. USE  */
/* OF THIS SOFTWARE CREATES ACCEPTANCE OF THESE TERMS */
/*                                                    */
/* USE OF THIS CODE MUST RETAIN ALL COPYRIGHT NOTICES */
/* AND LICENSES (MEANING THIS TEXT).                  */
/*                                                    */
/******************************************************/


namespace NullFX.Security
{
    using System;
    public class Crc32
    {
        uint[] table;

        public uint ComputeChecksum(byte[] bytes)
        {
            uint crc = 0xffffffff;
            for (int i = 0; i < bytes.Length; i++)
            {
                byte index = (byte)(((crc) & 0xff) ^ bytes[i]);
                crc = (uint)((crc >> 8) ^ table[index]);
            }
            return ~crc;
        }

        public Crc32()
        {
            uint poly = 0xedb88320;
            table = new uint[256];
            uint temp = 0;
            for (uint i = 0; i < table.Length; i++)
            {
                temp = i;
                for (int j = 8; j > 0; j--)
                {
                    if ((temp & 1) == 1)
                    {
                        temp = (uint)((temp >> 1) ^ poly);
                    }
                    else
                    {
                        temp >>= 1;
                    }
                }
                table[i] = temp;
            }
        }
    }
}
