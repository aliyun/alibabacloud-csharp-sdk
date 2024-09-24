// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the management node.</para>
        /// </summary>
        [NameInMap("HoneypotNode")]
        [Validation(Required=false)]
        public GetHoneypotNodeResponseBodyHoneypotNode HoneypotNode { get; set; }
        public class GetHoneypotNodeResponseBodyHoneypotNode : TeaModel {
            /// <summary>
            /// <para>Indicates whether a honeypot is allowed to access the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The honeypot is allowed to access the Internet.</description></item>
            /// <item><description><b>false</b>: The honeypot is not allowed to access the Internet.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowHoneypotAccessInternet")]
            [Validation(Required=false)]
            public bool? AllowHoneypotAccessInternet { get; set; }

            /// <summary>
            /// <para>The time when the management node was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-02 17:13:43</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2vccskxjunf1ag6w****</para>
            /// </summary>
            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// <para>The maximum number of honeypots that can be deployed to the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HoneypotTotalCount")]
            [Validation(Required=false)]
            public int? HoneypotTotalCount { get; set; }

            /// <summary>
            /// <para>The number of honeypots that are deployed to the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HoneypotUsedCount")]
            [Validation(Required=false)]
            public int? HoneypotUsedCount { get; set; }

            /// <summary>
            /// <para>The ID of the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7409a58-bc60-41af-9d36-080d58ae****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The IP address of the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.37.XX.XX</para>
            /// </summary>
            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            /// <summary>
            /// <para>The name of the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gmmc</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The maximum number of probes that can be deployed for the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ProbeTotalCount")]
            [Validation(Required=false)]
            public int? ProbeTotalCount { get; set; }

            /// <summary>
            /// <para>The number of probes that are deployed for the management node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("ProbeUsedCount")]
            [Validation(Required=false)]
            public int? ProbeUsedCount { get; set; }

            /// <summary>
            /// <para>An array consisting of the CIDR blocks that are allowed to access the management node.</para>
            /// </summary>
            [NameInMap("SecurityGroupProbeIpList")]
            [Validation(Required=false)]
            public List<string> SecurityGroupProbeIpList { get; set; }

            /// <summary>
            /// <para>The status of the management node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: preparing</description></item>
            /// <item><description><b>1</b>: normal</description></item>
            /// <item><description><b>2</b>: abnormal</description></item>
            /// <item><description><b>4</b>: starting</description></item>
            /// <item><description><b>5</b>: upgrading</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalStatus")]
            [Validation(Required=false)]
            public int? TotalStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the management node can be upgraded. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UpgradeAvailable")]
            [Validation(Required=false)]
            public bool? UpgradeAvailable { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A453658-070B-5554-B46C-867425BE4FD4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
