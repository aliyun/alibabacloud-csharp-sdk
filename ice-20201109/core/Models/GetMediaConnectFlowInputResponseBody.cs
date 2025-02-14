// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConnectFlowInputResponseBody : TeaModel {
        /// <summary>
        /// <para>Response body</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetMediaConnectFlowInputResponseBodyContent Content { get; set; }
        public class GetMediaConnectFlowInputResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>IP whitelist, in CIDR format, multiple IP segments separated by commas</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.211.0.0/17</para>
            /// </summary>
            [NameInMap("Cidrs")]
            [Validation(Required=false)]
            public string Cidrs { get; set; }

            /// <summary>
            /// <para>Flow creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-18T01:29:24Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Input name</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliTestInput</para>
            /// </summary>
            [NameInMap("InputName")]
            [Validation(Required=false)]
            public string InputName { get; set; }

            /// <summary>
            /// <para>Input type</para>
            /// 
            /// <b>Example:</b>
            /// <para>RTMP-PUSH</para>
            /// </summary>
            [NameInMap("InputProtocol")]
            [Validation(Required=false)]
            public string InputProtocol { get; set; }

            /// <summary>
            /// <para>Input URL</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://1.2.3.4:1935/live/AliTestInput_8666ec062190f00e263012666319a5be</para>
            /// </summary>
            [NameInMap("InputUrl")]
            [Validation(Required=false)]
            public string InputUrl { get; set; }

            /// <summary>
            /// <para>Input bitrate, in bps</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000000</para>
            /// </summary>
            [NameInMap("MaxBitrate")]
            [Validation(Required=false)]
            public int? MaxBitrate { get; set; }

            /// <summary>
            /// <para>Peer Flow instance ID, required when the output type is Flow</para>
            /// 
            /// <b>Example:</b>
            /// <para>05c3adf4-aa0e-421d-a991-48ceae3e642e</para>
            /// </summary>
            [NameInMap("PairFlowId")]
            [Validation(Required=false)]
            public string PairFlowId { get; set; }

            /// <summary>
            /// <para>Peer Flow output name, required only when the input type is Flow</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliTestOutput</para>
            /// </summary>
            [NameInMap("PairOutputName")]
            [Validation(Required=false)]
            public string PairOutputName { get; set; }

            /// <summary>
            /// <para>SRT latency, in ms, required only when the input type is SRT-Listener/SRT-Caller</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("SrtLatency")]
            [Validation(Required=false)]
            public int? SrtLatency { get; set; }

            /// <summary>
            /// <para>SRT encryption key, required only when the input type is SRT-Listener/SRT-Caller</para>
            /// 
            /// <b>Example:</b>
            /// <para>FICUBPX4Q77DYHRF</para>
            /// </summary>
            [NameInMap("SrtPassphrase")]
            [Validation(Required=false)]
            public string SrtPassphrase { get; set; }

            /// <summary>
            /// <para>SRT encryption length, required only when the input type is SRT-Listener/SRT-Caller</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("SrtPbkeyLen")]
            [Validation(Required=false)]
            public int? SrtPbkeyLen { get; set; }

        }

        /// <summary>
        /// <para>Interface call description</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>请求ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4C231DF-103A-55FF-8D09-E699552457DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned error code, 0 indicates success</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

    }

}
