// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListEndpointGroupsResponseBody : TeaModel {
        [NameInMap("EndpointGroups")]
        [Validation(Required=false)]
        public List<ListEndpointGroupsResponseBodyEndpointGroups> EndpointGroups { get; set; }
        public class ListEndpointGroupsResponseBodyEndpointGroups : TeaModel {
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EndpointConfigurations")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations> EndpointConfigurations { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsEndpointConfigurations : TeaModel {
                [NameInMap("EnableClientIPPreservation")]
                [Validation(Required=false)]
                public bool? EnableClientIPPreservation { get; set; }

                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("EndpointId")]
                [Validation(Required=false)]
                public string EndpointId { get; set; }

                [NameInMap("ProbePort")]
                [Validation(Required=false)]
                public int? ProbePort { get; set; }

                [NameInMap("ProbeProtocol")]
                [Validation(Required=false)]
                public string ProbeProtocol { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            [NameInMap("EndpointGroupId")]
            [Validation(Required=false)]
            public string EndpointGroupId { get; set; }

            [NameInMap("EndpointGroupIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupIpList { get; set; }

            [NameInMap("EndpointGroupRegion")]
            [Validation(Required=false)]
            public string EndpointGroupRegion { get; set; }

            [NameInMap("EndpointGroupType")]
            [Validation(Required=false)]
            public string EndpointGroupType { get; set; }

            [NameInMap("EndpointGroupUnconfirmedIpList")]
            [Validation(Required=false)]
            public List<string> EndpointGroupUnconfirmedIpList { get; set; }

            [NameInMap("EndpointRequestProtocol")]
            [Validation(Required=false)]
            public string EndpointRequestProtocol { get; set; }

            [NameInMap("ForwardingRuleIds")]
            [Validation(Required=false)]
            public List<string> ForwardingRuleIds { get; set; }

            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            [NameInMap("HealthCheckIntervalSeconds")]
            [Validation(Required=false)]
            public int? HealthCheckIntervalSeconds { get; set; }

            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public int? HealthCheckPort { get; set; }

            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PortOverrides")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsPortOverrides> PortOverrides { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsPortOverrides : TeaModel {
                [NameInMap("EndpointPort")]
                [Validation(Required=false)]
                public int? EndpointPort { get; set; }

                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

            }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListEndpointGroupsResponseBodyEndpointGroupsTags> Tags { get; set; }
            public class ListEndpointGroupsResponseBodyEndpointGroupsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("ThresholdCount")]
            [Validation(Required=false)]
            public int? ThresholdCount { get; set; }

            [NameInMap("TrafficPercentage")]
            [Validation(Required=false)]
            public int? TrafficPercentage { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
