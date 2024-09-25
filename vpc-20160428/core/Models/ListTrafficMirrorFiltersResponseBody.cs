// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorFiltersResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>739CA01C-92EB-4C69-BCC0-280149C6F41E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The information about the filters.</para>
        /// </summary>
        [NameInMap("TrafficMirrorFilters")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFilters> TrafficMirrorFilters { get; set; }
        public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFilters : TeaModel {
            /// <summary>
            /// <para>The time when the filter is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-05T15:26Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The information about the outbound rules.</para>
            /// </summary>
            [NameInMap("EgressRules")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersEgressRules> EgressRules { get; set; }
            public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersEgressRules : TeaModel {
                /// <summary>
                /// <para>The action of the outbound rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>accept</b></description></item>
                /// <item><description><b>drop</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accept</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The destination CIDR block of the outbound traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/24</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>The destination port range of the outbound traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22/40</para>
                /// </summary>
                [NameInMap("DestinationPortRange")]
                [Validation(Required=false)]
                public string DestinationPortRange { get; set; }

                /// <summary>
                /// <para>The priority of the outbound rule. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The protocol that is used by the outbound traffic to be mirrored. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ALL</b></description></item>
                /// <item><description><b>ICMP</b></description></item>
                /// <item><description><b>TCP</b></description></item>
                /// <item><description><b>UDP</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The source CIDR block of the outbound traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.0/24</para>
                /// </summary>
                [NameInMap("SourceCidrBlock")]
                [Validation(Required=false)]
                public string SourceCidrBlock { get; set; }

                /// <summary>
                /// <para>The source port range of the outbound traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22/40</para>
                /// </summary>
                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                /// <summary>
                /// <para>The direction of the network traffic. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>egress</b></description></item>
                /// <item><description><b>ingress</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>egress</para>
                /// </summary>
                [NameInMap("TrafficDirection")]
                [Validation(Required=false)]
                public string TrafficDirection { get; set; }

                /// <summary>
                /// <para>The ID of the filter associated with the outbound rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tmf-j6cmls82xnc86vtpe****</para>
                /// </summary>
                [NameInMap("TrafficMirrorFilterId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterId { get; set; }

                /// <summary>
                /// <para>The ID of the outbound rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tmr-j6c89rzmtd3hhdugq****</para>
                /// </summary>
                [NameInMap("TrafficMirrorFilterRuleId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleId { get; set; }

                /// <summary>
                /// <para>The status of the outbound rule. Valid values:</para>
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
                [NameInMap("TrafficMirrorFilterRuleStatus")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleStatus { get; set; }

            }

            /// <summary>
            /// <para>The information about the inbound rules.</para>
            /// </summary>
            [NameInMap("IngressRules")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersIngressRules> IngressRules { get; set; }
            public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersIngressRules : TeaModel {
                /// <summary>
                /// <para>The action of the inbound rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>accept</b></description></item>
                /// <item><description><b>drop</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>accept</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The destination CIDR block of the inbound traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>The destination port range of the inbound traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1/-1</para>
                /// </summary>
                [NameInMap("DestinationPortRange")]
                [Validation(Required=false)]
                public string DestinationPortRange { get; set; }

                /// <summary>
                /// <para>The priority of the inbound rule. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The protocol that is used by the inbound traffic to be mirrored. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ALL</b></description></item>
                /// <item><description><b>ICMP</b></description></item>
                /// <item><description><b>TCP</b></description></item>
                /// <item><description><b>UDP</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALL</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The source CIDR block of the inbound traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("SourceCidrBlock")]
                [Validation(Required=false)]
                public string SourceCidrBlock { get; set; }

                /// <summary>
                /// <para>The destination port range of the inbound traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1/-1</para>
                /// </summary>
                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                /// <summary>
                /// <para>The direction of the network traffic. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>egress</b></description></item>
                /// <item><description><b>ingress</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ingress</para>
                /// </summary>
                [NameInMap("TrafficDirection")]
                [Validation(Required=false)]
                public string TrafficDirection { get; set; }

                /// <summary>
                /// <para>The ID of the filter associated with the inbound rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tmf-j6cmls82xnc86vtpe****</para>
                /// </summary>
                [NameInMap("TrafficMirrorFilterId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterId { get; set; }

                /// <summary>
                /// <para>The ID of the inbound rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tmr-j6cezu8e68rnpepet****</para>
                /// </summary>
                [NameInMap("TrafficMirrorFilterRuleId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleId { get; set; }

                /// <summary>
                /// <para>The status of the inbound rule. Valid values:</para>
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
                [NameInMap("TrafficMirrorFilterRuleStatus")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleStatus { get; set; }

            }

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
            public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersTags> Tags { get; set; }
            public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersTags : TeaModel {
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
            /// <para>The description of the filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a filter.</para>
            /// </summary>
            [NameInMap("TrafficMirrorFilterDescription")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterDescription { get; set; }

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
            /// <para>The filter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("TrafficMirrorFilterName")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterName { get; set; }

            /// <summary>
            /// <para>The status of the filter. Valid values:</para>
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
            [NameInMap("TrafficMirrorFilterStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterStatus { get; set; }

        }

    }

}
