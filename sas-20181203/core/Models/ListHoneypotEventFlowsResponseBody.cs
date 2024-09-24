// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotEventFlowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The attack timelines.</para>
        /// </summary>
        [NameInMap("HoneypotEventFlows")]
        [Validation(Required=false)]
        public List<ListHoneypotEventFlowsResponseBodyHoneypotEventFlows> HoneypotEventFlows { get; set; }
        public class ListHoneypotEventFlowsResponseBodyHoneypotEventFlows : TeaModel {
            /// <summary>
            /// <para>The ID of the probe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d3c0dafa-5059-4eb0-8c28-7d40f58*****</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The name of the probe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hw-d***</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The ID of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eca09895****</para>
            /// </summary>
            [NameInMap("DockerId")]
            [Validation(Required=false)]
            public string DockerId { get; set; }

            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112.126.205.***</para>
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// <para>The destination port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            /// <summary>
            /// <para>The UUID of the connection in the attack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd7f1ff4-0c4b-41cb-99ad-0724349d****</para>
            /// </summary>
            [NameInMap("EventConnection")]
            [Validation(Required=false)]
            public string EventConnection { get; set; }

            /// <summary>
            /// <para>The extended information about the attack payload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;payload\&quot;:{\&quot;format\&quot;:\&quot;line\&quot;,\&quot;name\&quot;:{\&quot;cn\&quot;:\&quot;payload\&quot;,\&quot;en\&quot;:\&quot;payload\&quot;},\&quot;value\&quot;:\&quot;\&quot;},\&quot;uid\&quot;:{\&quot;format\&quot;:\&quot;line\&quot;,\&quot;name\&quot;:{\&quot;cn\&quot;:\&quot;\&quot;,\&quot;en\&quot;:\&quot;\&quot;},\&quot;uid\&quot;:\&quot;5fa2ece9-aa08-4bbd-a272-5d27*********\&quot;,\&quot;value\&quot;:\&quot;\&quot;}}</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The extension information about the virtual private cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;vpc_id\&quot;:\&quot;\&quot;,\&quot;vpc_dest_port\&quot;:\&quot;\&quot;,\&quot;vpc_dest_ip\&quot;:\&quot;\&quot;}</para>
            /// </summary>
            [NameInMap("Extra1")]
            [Validation(Required=false)]
            public string Extra1 { get; set; }

            /// <summary>
            /// <para>The Object Storage Service (OSS) URL of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://pop-test-file-upload.oss-cn-beijing.aliyuncs.com/5626_26331">https://pop-test-file-upload.oss-cn-beijing.aliyuncs.com/5626_26331</a>*****</para>
            /// </summary>
            [NameInMap("FileOssUrl")]
            [Validation(Required=false)]
            public string FileOssUrl { get; set; }

            /// <summary>
            /// <para>The timestamp when the intrusion event was first occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1686621122000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The ID of the intrusion event. The value is a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19bec028-d98b-45c4-a4d9-cc3d593f****</para>
            /// </summary>
            [NameInMap("HoneypotEventId")]
            [Validation(Required=false)]
            public string HoneypotEventId { get; set; }

            /// <summary>
            /// <para>The ID of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>911df9d6fe20451c059edbcffa1d1c33452f6a71e59d4826da067af224*****</para>
            /// </summary>
            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

            /// <summary>
            /// <para>The name of the honeypot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hw-zhi*****</para>
            /// </summary>
            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }

            /// <summary>
            /// <para>The timestamp when the intrusion event was last occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1686622222000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: low</description></item>
            /// <item><description><b>3</b>: medium</description></item>
            /// <item><description><b>4</b>: high</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The ID of the intrusion event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>306527555</para>
            /// </summary>
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.41.48.***</para>
            /// </summary>
            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            /// <summary>
            /// <para>The source media access control (MAC) address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:0C:29:CA:<b>:</b></para>
            /// </summary>
            [NameInMap("SrcMac")]
            [Validation(Required=false)]
            public string SrcMac { get; set; }

            /// <summary>
            /// <para>The source port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public int? SrcPort { get; set; }

            /// <summary>
            /// <para>The handling status of the intrusion event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: pending handling</description></item>
            /// <item><description><b>2</b>: ignored</description></item>
            /// <item><description><b>4</b>: confirmed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the attack type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web_access</para>
            /// </summary>
            [NameInMap("TypeId")]
            [Validation(Required=false)]
            public string TypeId { get; set; }

            /// <summary>
            /// <para>The UUID of an attack in the intrusion event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5fa2ece9-aa08-4bbd-a272-5d27d1c6*****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

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
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotEventFlowsResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotEventFlowsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>78</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F4E6157-9600-5588-86B9-38F09067****</para>
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
