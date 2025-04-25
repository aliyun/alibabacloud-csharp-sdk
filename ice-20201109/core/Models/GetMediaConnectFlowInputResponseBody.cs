// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConnectFlowInputResponseBody : TeaModel {
        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetMediaConnectFlowInputResponseBodyContent Content { get; set; }
        public class GetMediaConnectFlowInputResponseBodyContent : TeaModel {
            [NameInMap("BackupCidrs")]
            [Validation(Required=false)]
            public string BackupCidrs { get; set; }

            [NameInMap("BackupCreateTime")]
            [Validation(Required=false)]
            public string BackupCreateTime { get; set; }

            [NameInMap("BackupInputName")]
            [Validation(Required=false)]
            public string BackupInputName { get; set; }

            [NameInMap("BackupInputStatus")]
            [Validation(Required=false)]
            public string BackupInputStatus { get; set; }

            [NameInMap("BackupInputUrl")]
            [Validation(Required=false)]
            public string BackupInputUrl { get; set; }

            [NameInMap("BackupMaxBitrate")]
            [Validation(Required=false)]
            public int? BackupMaxBitrate { get; set; }

            [NameInMap("BackupSrtLatency")]
            [Validation(Required=false)]
            public int? BackupSrtLatency { get; set; }

            [NameInMap("BackupSrtPassphrase")]
            [Validation(Required=false)]
            public string BackupSrtPassphrase { get; set; }

            [NameInMap("BackupSrtPbkeyLen")]
            [Validation(Required=false)]
            public int? BackupSrtPbkeyLen { get; set; }

            /// <summary>
            /// <para>The IP address whitelist in CIDR format. CIDR blocks are separated with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.211.0.0/17</para>
            /// </summary>
            [NameInMap("Cidrs")]
            [Validation(Required=false)]
            public string Cidrs { get; set; }

            /// <summary>
            /// <para>The time when the flow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-18T01:29:24Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The source name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliTestInput</para>
            /// </summary>
            [NameInMap("InputName")]
            [Validation(Required=false)]
            public string InputName { get; set; }

            /// <summary>
            /// <para>The source type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RTMP-PUSH</description></item>
            /// <item><description>SRT-Caller</description></item>
            /// <item><description>RTMP-PULL</description></item>
            /// <item><description>SRT-Listener</description></item>
            /// <item><description>Flow</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RTMP-PUSH</para>
            /// </summary>
            [NameInMap("InputProtocol")]
            [Validation(Required=false)]
            public string InputProtocol { get; set; }

            [NameInMap("InputStatus")]
            [Validation(Required=false)]
            public string InputStatus { get; set; }

            /// <summary>
            /// <para>The source URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://1.2.3.4:1935/live/AliTestInput_8666ec062190f00e263012666319a5be</para>
            /// </summary>
            [NameInMap("InputUrl")]
            [Validation(Required=false)]
            public string InputUrl { get; set; }

            /// <summary>
            /// <para>The maximum bitrate. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000000</para>
            /// </summary>
            [NameInMap("MaxBitrate")]
            [Validation(Required=false)]
            public int? MaxBitrate { get; set; }

            /// <summary>
            /// <para>The ID of the source flow. This parameter is returned when the source type is Flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>05c3adf4-aa0e-421d-a991-48ceae3e642e</para>
            /// </summary>
            [NameInMap("PairFlowId")]
            [Validation(Required=false)]
            public string PairFlowId { get; set; }

            /// <summary>
            /// <para>The output of the source flow. This parameter is returned when the source type is Flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliTestOutput</para>
            /// </summary>
            [NameInMap("PairOutputName")]
            [Validation(Required=false)]
            public string PairOutputName { get; set; }

            /// <summary>
            /// <para>The latency for the SRT stream. Unit: milliseconds. This parameter is returned when the source type is SRT-Listener or SRT-Caller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("SrtLatency")]
            [Validation(Required=false)]
            public int? SrtLatency { get; set; }

            /// <summary>
            /// <para>The SRT key. This parameter is returned when the source type is SRT-Listener or SRT-Caller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FICUBPX4Q77DYHRF</para>
            /// </summary>
            [NameInMap("SrtPassphrase")]
            [Validation(Required=false)]
            public string SrtPassphrase { get; set; }

            /// <summary>
            /// <para>The encryption key length. This parameter is returned when the source type is SRT-Listener or SRT-Caller.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0</description></item>
            /// <item><description>16</description></item>
            /// <item><description>24</description></item>
            /// <item><description>32</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("SrtPbkeyLen")]
            [Validation(Required=false)]
            public int? SrtPbkeyLen { get; set; }

        }

        /// <summary>
        /// <para>The call description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4C231DF-103A-55FF-8D09-E699552457DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned error code. A value of 0 indicates the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

    }

}
