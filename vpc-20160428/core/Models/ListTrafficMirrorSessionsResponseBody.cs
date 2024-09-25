// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next queries are sent.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value is the token that is used for the subsequent query.</description></item>
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
        /// <para>The details about the traffic mirror session.</para>
        /// </summary>
        [NameInMap("TrafficMirrorSessions")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessions> TrafficMirrorSessions { get; set; }
        public class ListTrafficMirrorSessionsResponseBodyTrafficMirrorSessions : TeaModel {
            /// <summary>
            /// <para>The time when the session is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-05T15:26Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the traffic mirror session was enabled.</para>
            /// <list type="bullet">
            /// <item><description><b>false</b> </description></item>
            /// <item><description><b>true</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The maximum transmission unit.</para>
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
            /// <para>The ID of the resource group to which the traffic mirror session belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-bp67acfmxazb4ph****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tag list.</para>
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
            /// <para>The ID of the filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tmf-j6cmls82xnc86vtpe****</para>
            /// </summary>
            [NameInMap("TrafficMirrorFilterId")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterId { get; set; }

            /// <summary>
            /// <para>The status of the traffic mirror session.</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b></description></item>
            /// <item><description><b>FinancialLocked</b></description></item>
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
            /// <para>The ID of the traffic mirror session.</para>
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
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>Created</b></description></item>
            /// <item><description><b>Modifying</b></description></item>
            /// <item><description><b>Deleting</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("TrafficMirrorSessionStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorSessionStatus { get; set; }

            /// <summary>
            /// <para>The ID of the traffic mirror source.</para>
            /// </summary>
            [NameInMap("TrafficMirrorSourceIds")]
            [Validation(Required=false)]
            public List<string> TrafficMirrorSourceIds { get; set; }

            /// <summary>
            /// <para>The ID of the traffic mirror destination.</para>
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
            /// <item><description><b>NetworkInterface</b>: an elastic network interface (ENI)</description></item>
            /// <item><description><b>SLB</b>: an internal-facing Server Load Balancer (SLB) instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NetworkInterface</para>
            /// </summary>
            [NameInMap("TrafficMirrorTargetType")]
            [Validation(Required=false)]
            public string TrafficMirrorTargetType { get; set; }

            /// <summary>
            /// <para>You can specify VNIs to distinguish different mirrored traffic.</para>
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
