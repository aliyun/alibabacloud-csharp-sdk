// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConnectFlowOutputResponseBody : TeaModel {
        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetMediaConnectFlowOutputResponseBodyContent Content { get; set; }
        public class GetMediaConnectFlowOutputResponseBodyContent : TeaModel {
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

            [NameInMap("Forbid")]
            [Validation(Required=false)]
            public string Forbid { get; set; }

            /// <summary>
            /// <para>The output name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliTestInput</para>
            /// </summary>
            [NameInMap("OutputName")]
            [Validation(Required=false)]
            public string OutputName { get; set; }

            /// <summary>
            /// <para>The output type.</para>
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
            /// <para>SRT-PULL</para>
            /// </summary>
            [NameInMap("OutputProtocol")]
            [Validation(Required=false)]
            public string OutputProtocol { get; set; }

            /// <summary>
            /// <para>The output URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>srt://1.2.3.4:1025</para>
            /// </summary>
            [NameInMap("OutputUrl")]
            [Validation(Required=false)]
            public string OutputUrl { get; set; }

            /// <summary>
            /// <para>The ID of the destination flow. This parameter is returned when the output type is Flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>805fbdd0-575e-4146-b35d-ec7f63937b20</para>
            /// </summary>
            [NameInMap("PairFlowId")]
            [Validation(Required=false)]
            public string PairFlowId { get; set; }

            /// <summary>
            /// <para>The source name of the destination flow. This parameter is returned when the output type is Flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliTestInput</para>
            /// </summary>
            [NameInMap("PairInputName")]
            [Validation(Required=false)]
            public string PairInputName { get; set; }

            /// <summary>
            /// <para>The maximum number of viewers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("PlayerLimit")]
            [Validation(Required=false)]
            public int? PlayerLimit { get; set; }

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
        /// <para>0DB23DCE-0D69-598B-AA7C-7268D55E2F89</para>
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
