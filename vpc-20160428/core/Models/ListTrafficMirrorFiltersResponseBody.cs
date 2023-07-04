// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorFiltersResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next queries are sent.
        /// *   If the return value of **NextToken** is not empty, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// The details about the filters.
        /// </summary>
        [NameInMap("TrafficMirrorFilters")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFilters> TrafficMirrorFilters { get; set; }
        public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFilters : TeaModel {
            /// <summary>
            /// The details about the outbound rules.
            /// </summary>
            [NameInMap("EgressRules")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersEgressRules> EgressRules { get; set; }
            public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersEgressRules : TeaModel {
                /// <summary>
                /// The action of the outbound rule. Valid values:
                /// 
                /// *   **accept**: collects network traffic.
                /// *   **drop**: does not collect network traffic.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The destination CIDR block of the outbound traffic.
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// The destination port range of the outbound traffic.
                /// </summary>
                [NameInMap("DestinationPortRange")]
                [Validation(Required=false)]
                public string DestinationPortRange { get; set; }

                /// <summary>
                /// The priority of the outbound rule. A smaller value indicates a higher priority.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The protocol that is used by the outbound traffic to be mirrored. Valid values:
                /// 
                /// *   **ALL**: all protocols
                /// *   **ICMP**: ICMP
                /// *   **TCP**: TCP
                /// *   **UDP**: UDP
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The source CIDR block of the outbound traffic.
                /// </summary>
                [NameInMap("SourceCidrBlock")]
                [Validation(Required=false)]
                public string SourceCidrBlock { get; set; }

                /// <summary>
                /// The source port range of the outbound traffic.
                /// </summary>
                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                /// <summary>
                /// The direction of the network traffic. Valid values:
                /// 
                /// *   **egress**: outbound
                /// *   **ingress**: inbound
                /// </summary>
                [NameInMap("TrafficDirection")]
                [Validation(Required=false)]
                public string TrafficDirection { get; set; }

                /// <summary>
                /// The ID of the filter associated with the outbound rule.
                /// </summary>
                [NameInMap("TrafficMirrorFilterId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterId { get; set; }

                /// <summary>
                /// The ID of the outbound rule.
                /// </summary>
                [NameInMap("TrafficMirrorFilterRuleId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleId { get; set; }

                /// <summary>
                /// The status of the outbound rule. Valid values:
                /// 
                /// *   **Creating**
                /// *   **Created**
                /// *   **Modifying**
                /// *   **Deleting**
                /// </summary>
                [NameInMap("TrafficMirrorFilterRuleStatus")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleStatus { get; set; }

            }

            /// <summary>
            /// The details about the inbound rules.
            /// </summary>
            [NameInMap("IngressRules")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersIngressRules> IngressRules { get; set; }
            public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersIngressRules : TeaModel {
                /// <summary>
                /// The action of the inbound rule. Valid values:
                /// 
                /// *   **accept**: accepts network traffic.
                /// *   **drop**: does not collect network traffic.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The destination CIDR block of the inbound traffic.
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// The destination port range of the inbound traffic.
                /// </summary>
                [NameInMap("DestinationPortRange")]
                [Validation(Required=false)]
                public string DestinationPortRange { get; set; }

                /// <summary>
                /// The priority of the inbound rule. A smaller value indicates a higher priority.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The protocol that is used by the inbound traffic to be mirrored. Valid values:
                /// 
                /// *   **ALL**: all protocols
                /// *   **ICMP**: ICMP
                /// *   **TCP**: TCP
                /// *   **UDP**: UDP
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The source CIDR block of the inbound traffic.
                /// </summary>
                [NameInMap("SourceCidrBlock")]
                [Validation(Required=false)]
                public string SourceCidrBlock { get; set; }

                /// <summary>
                /// The destination port range of the inbound traffic.
                /// </summary>
                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                /// <summary>
                /// The direction of the network traffic. Valid values:
                /// 
                /// *   **egress**: outbound
                /// *   **ingress**: inbound
                /// </summary>
                [NameInMap("TrafficDirection")]
                [Validation(Required=false)]
                public string TrafficDirection { get; set; }

                /// <summary>
                /// The ID of the filter associated with the inbound rule.
                /// </summary>
                [NameInMap("TrafficMirrorFilterId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterId { get; set; }

                /// <summary>
                /// The ID of the inbound rule.
                /// </summary>
                [NameInMap("TrafficMirrorFilterRuleId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleId { get; set; }

                /// <summary>
                /// The status of the inbound rule. Valid values:
                /// 
                /// *   **Creating**
                /// *   **Created**
                /// *   **Modifying**
                /// *   **Deleting**
                /// </summary>
                [NameInMap("TrafficMirrorFilterRuleStatus")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleStatus { get; set; }

            }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The list of tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersTags> Tags { get; set; }
            public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The description of the filter.
            /// </summary>
            [NameInMap("TrafficMirrorFilterDescription")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterDescription { get; set; }

            /// <summary>
            /// The ID of the filter.
            /// </summary>
            [NameInMap("TrafficMirrorFilterId")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterId { get; set; }

            /// <summary>
            /// The name of the filter.
            /// </summary>
            [NameInMap("TrafficMirrorFilterName")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterName { get; set; }

            /// <summary>
            /// The status of the filter. Valid values:
            /// 
            /// *   **Creating**
            /// *   **Created**
            /// *   **Modifying**
            /// *   **Deleting**
            /// </summary>
            [NameInMap("TrafficMirrorFilterStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterStatus { get; set; }

        }

    }

}
