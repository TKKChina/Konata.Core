﻿using System;

namespace Konata.Msf.Packets.Tlv
{
    public class T198Body : TlvBody
    {
        public readonly byte _devLockMobileType;

        public T198Body(byte devLockMobileType)
            : base()
        {
            _devLockMobileType = devLockMobileType;

            PutByte(_devLockMobileType);
        }

        public T198Body(byte[] data)
            : base(data)
        {
            TakeByte(out _devLockMobileType);
        }
    }
}
