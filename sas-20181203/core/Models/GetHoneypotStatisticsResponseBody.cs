// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code that is returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The honeypot usage statistics.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotStatisticsResponseBodyData Data { get; set; }
        public class GetHoneypotStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of honeypots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalHoneypotCount")]
            [Validation(Required=false)]
            public int? TotalHoneypotCount { get; set; }

            /// <summary>
            /// <para>The health status of the management node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: normal</description></item>
            /// <item><description>2: abnormal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalNodeStatus")]
            [Validation(Required=false)]
            public int? TotalNodeStatus { get; set; }

            /// <summary>
            /// <para>The total number of authorized probes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("TotalProbeCount")]
            [Validation(Required=false)]
            public int? TotalProbeCount { get; set; }

            /// <summary>
            /// <para>The number of deployed honeypots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("UsedHoneypotCount")]
            [Validation(Required=false)]
            public int? UsedHoneypotCount { get; set; }

            /// <summary>
            /// <para>The number of deployed host probes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("UsedHostProbeCount")]
            [Validation(Required=false)]
            public int? UsedHostProbeCount { get; set; }

            /// <summary>
            /// <para>The number of deployed probes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("UsedProbeCount")]
            [Validation(Required=false)]
            public int? UsedProbeCount { get; set; }

            /// <summary>
            /// <para>The number of deployed VPC probes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("UsedVpcProbeCount")]
            [Validation(Required=false)]
            public int? UsedVpcProbeCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB7181CB-32F3-5189-A935-4E24DD1A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
