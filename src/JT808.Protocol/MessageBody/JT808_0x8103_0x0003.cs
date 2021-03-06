﻿using JT808.Protocol.Attributes;
using JT808.Protocol.Formatters.MessageBodyFormatters;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// TCP 消息重传次数
    /// 0x8103_0x0003
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x0003_Formatter))]
    public class JT808_0x8103_0x0003 : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x0003;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 4;
        /// <summary>
        /// TCP 消息重传次数
        /// </summary>
        public uint ParamValue { get; set; }
    }
}
