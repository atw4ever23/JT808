﻿using JT808.Protocol.Extensions;
using JT808.Protocol.MessageBody;
using JT808.Protocol.Interfaces;
using System;

namespace JT808.Protocol.Formatters.MessageBodyFormatters
{
    public class JT808_0x8103_0x0050_Formatter : IJT808Formatter<JT808_0x8103_0x0050>
    {
        public JT808_0x8103_0x0050 Deserialize(ReadOnlySpan<byte> bytes, out int readSize, IJT808Config config)
        {
            int offset = 0;
            JT808_0x8103_0x0050 jT808_0x8103_0x0050 = new JT808_0x8103_0x0050
            {
                ParamLength = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset),
                ParamValue = JT808BinaryExtensions.ReadUInt32Little(bytes, ref offset)
            };
            readSize = offset;
            return jT808_0x8103_0x0050;
        }

        public int Serialize(ref byte[] bytes, int offset, JT808_0x8103_0x0050 value, IJT808Config config)
        {
            offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset, value.ParamLength);
            offset += JT808BinaryExtensions.WriteUInt32Little(bytes, offset, value.ParamValue);
            return offset;
        }
    }
}
