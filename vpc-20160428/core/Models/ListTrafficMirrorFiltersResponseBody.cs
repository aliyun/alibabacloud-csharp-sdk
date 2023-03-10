// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTrafficMirrorFiltersResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("TrafficMirrorFilters")]
        [Validation(Required=false)]
        public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFilters> TrafficMirrorFilters { get; set; }
        public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFilters : TeaModel {
            [NameInMap("EgressRules")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersEgressRules> EgressRules { get; set; }
            public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersEgressRules : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                [NameInMap("DestinationPortRange")]
                [Validation(Required=false)]
                public string DestinationPortRange { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("SourceCidrBlock")]
                [Validation(Required=false)]
                public string SourceCidrBlock { get; set; }

                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                [NameInMap("TrafficDirection")]
                [Validation(Required=false)]
                public string TrafficDirection { get; set; }

                [NameInMap("TrafficMirrorFilterId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterId { get; set; }

                [NameInMap("TrafficMirrorFilterRuleId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleId { get; set; }

                [NameInMap("TrafficMirrorFilterRuleStatus")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleStatus { get; set; }

            }

            [NameInMap("IngressRules")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersIngressRules> IngressRules { get; set; }
            public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersIngressRules : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                [NameInMap("DestinationPortRange")]
                [Validation(Required=false)]
                public string DestinationPortRange { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("SourceCidrBlock")]
                [Validation(Required=false)]
                public string SourceCidrBlock { get; set; }

                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                [NameInMap("TrafficDirection")]
                [Validation(Required=false)]
                public string TrafficDirection { get; set; }

                [NameInMap("TrafficMirrorFilterId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterId { get; set; }

                [NameInMap("TrafficMirrorFilterRuleId")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleId { get; set; }

                [NameInMap("TrafficMirrorFilterRuleStatus")]
                [Validation(Required=false)]
                public string TrafficMirrorFilterRuleStatus { get; set; }

            }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersTags> Tags { get; set; }
            public class ListTrafficMirrorFiltersResponseBodyTrafficMirrorFiltersTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("TrafficMirrorFilterDescription")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterDescription { get; set; }

            [NameInMap("TrafficMirrorFilterId")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterId { get; set; }

            [NameInMap("TrafficMirrorFilterName")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterName { get; set; }

            [NameInMap("TrafficMirrorFilterStatus")]
            [Validation(Required=false)]
            public string TrafficMirrorFilterStatus { get; set; }

        }

    }

}
