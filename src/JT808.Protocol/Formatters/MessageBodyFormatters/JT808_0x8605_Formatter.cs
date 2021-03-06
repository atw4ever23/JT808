﻿using JT808.Protocol.Extensions;
using JT808.Protocol.MessageBody;
using JT808.Protocol.Interfaces;
using System;
using System.Collections.Generic;

namespace JT808.Protocol.Formatters.MessageBodyFormatters
{
    public class JT808_0x8605_Formatter : IJT808Formatter<JT808_0x8605>
    {
        public JT808_0x8605 Deserialize(ReadOnlySpan<byte> bytes, out int readSize, IJT808Config config)
        {
            int offset = 0;
            JT808_0x8605 jT808_0X8605 = new JT808_0x8605
            {
                AreaCount = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset),
                AreaIds = new List<uint>()
            };
            if (jT808_0X8605.AreaCount > 0)
            {
                for (var i = 0; i < jT808_0X8605.AreaCount; i++)
                {
                    jT808_0X8605.AreaIds.Add(JT808BinaryExtensions.ReadUInt32Little(bytes, ref offset));
                }
            }
            readSize = offset;
            return jT808_0X8605;
        }

        public int Serialize(ref byte[] bytes, int offset, JT808_0x8605 value, IJT808Config config)
        {
            if (value.AreaIds != null)
            {
                offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset, (byte)value.AreaIds.Count);
                foreach (var item in value.AreaIds)
                {
                    offset += JT808BinaryExtensions.WriteUInt32Little(bytes, offset, item);
                }
            }
            return offset;
        }
    }
}
