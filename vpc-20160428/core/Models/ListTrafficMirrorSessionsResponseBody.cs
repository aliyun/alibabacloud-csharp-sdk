// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query is available.</description></item>
        /// <item><description>If <b>NextToken</b> returns a value, the value is the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>739CA01C-92EB-4C69-BCC0-280149C6F41E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The details of the traffic mirror sessions.</para>
        /// </summary>
        [NameInMap("TrafficMirrorSessions")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessions> TrafficMirrorSessions { get; set; }
        public class ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessions : TeaModel {
            /// <summary>
            /// <para>The creation time of the traffic mirror session. The time is specified in the ISO 8601 standard in UTC. The example is accurate to the minute in the YYYY-MM-DDThh:mmZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-05T15:26Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the traffic mirror session is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>false</b> (default): The traffic mirror session is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>true</b>: The traffic mirror session is enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The length of the original mirrored packet, excluding the length of the VXLAN packet. Default value: <b>1500</b>. Valid values: <b>64</b> to <b>8500</b>. Unit: bytes.</para>
            /// <list type="bullet">
            /// <item><description><para>The value of this parameter affects the length of the packet received by the traffic mirror destination. For more information, see the &quot;Mirrored packet length and MTU limits&quot; section in <a href="https://help.aliyun.com/document_detail/207513.html">Traffic mirroring overview</a>.</para>
            /// </description></item>
            /// <item><description><para>This parameter is available only in specific regions. For more information, see the description of the mirrored packet length parameter in <a href="https://help.aliyun.com/document_detail/207514.html">Create and manage traffic mirroring</a>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("PacketLength")]
            [Validation(Required=false)]
            public int? PacketLength { get; set; }

            /// <summary>
            /// <para>The priority of the traffic mirror session.</para>
            /// <para>A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the traffic mirroring belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-bp67acfmxazb4ph****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessionsTags> Tags { get; set; }
            public class ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessionsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The instance ID of the traffic mirror filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tmf-j6cmls82xnc86vtpe****</para>
            /// </summary>
            [NameInMap("TrafficMirrorFilterId")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterId { get; set; }

            /// <summary>
            /// <para>The business status of the traffic mirror session. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: The traffic mirror session is working as expected.</para>
            /// </description></item>
            /// <item><description><para><b>FinancialLocked</b>: locked due to overdue payment.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("TrafficMirrorSessionBusinessStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionBusinessStatus { get; set; }

            /// <summary>
            /// <para>The description of the traffic mirror session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a session.</para>
            /// </summary>
            [NameInMap("TrafficMirrorSessionDescription")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionDescription { get; set; }

            /// <summary>
            /// <para>The instance ID of the traffic mirror session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tms-j6cla50buc44ap8tu****</para>
            /// </summary>
            [NameInMap("TrafficMirrorSessionId")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionId { get; set; }

            /// <summary>
            /// <para>The name of the traffic mirror session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("TrafficMirrorSessionName")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionName { get; set; }

            /// <summary>
            /// <para>The status of the traffic mirror session. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The traffic mirror session is being created.</description></item>
            /// <item><description><b>Created</b>: The traffic mirror session is created.</description></item>
            /// <item><description><b>Modifying</b>: The traffic mirror session is being modified.</description></item>
            /// <item><description><b>Deleting</b>: The traffic mirror session is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("TrafficMirrorSessionStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionStatus { get; set; }

            /// <summary>
            /// <para>The instance IDs of the traffic mirror sources.</para>
            /// </summary>
            [NameInMap("TrafficMirrorSourceIds")]
            [Validation(Required=false)]
            public List<string> TrafficMirrorSourceIds { get; set; }

            /// <summary>
            /// <para>The instance ID of the traffic mirror destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-j6c2fp57q8rr47rp****</para>
            /// </summary>
            [NameInMap("TrafficMirrorTargetId")]
            [Validation(Required=false)]
            public string TrafficMirrorTargetId { get; set; }

            /// <summary>
            /// <para>The type of the traffic mirror destination. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NetworkInterface</b>: an elastic network interface (ENI).</para>
            /// </description></item>
            /// <item><description><para><b>SLB</b>: an internal-facing SLB instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NetworkInterface</para>
            /// </summary>
            [NameInMap("TrafficMirrorTargetType")]
            [Validation(Required=false)]
            public string TrafficMirrorTargetType { get; set; }

            /// <summary>
            /// <para>The VNI that is used to distinguish different mirrored traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("VirtualNetworkId")]
            [Validation(Required=false)]
            public int? VirtualNetworkId { get; set; }

        }

    }

}
