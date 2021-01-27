// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateEndpointGroupRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndpointGroupRegion")]
        [Validation(Required=false)]
        public string EndpointGroupRegion { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("TrafficPercentage")]
        [Validation(Required=false)]
        public int? TrafficPercentage { get; set; }

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

        [NameInMap("ThresholdCount")]
        [Validation(Required=false)]
        public int? ThresholdCount { get; set; }

        [NameInMap("EndpointConfigurations")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupRequestEndpointConfigurations> EndpointConfigurations { get; set; }
        public class CreateEndpointGroupRequestEndpointConfigurations : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("EnableClientIPPreservation")]
            [Validation(Required=false)]
            public bool? EnableClientIPPreservation { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

        }

        [NameInMap("EndpointRequestProtocol")]
        [Validation(Required=false)]
        public string EndpointRequestProtocol { get; set; }

        [NameInMap("EndpointGroupType")]
        [Validation(Required=false)]
        public string EndpointGroupType { get; set; }

        [NameInMap("PortOverrides")]
        [Validation(Required=false)]
        public List<CreateEndpointGroupRequestPortOverrides> PortOverrides { get; set; }
        public class CreateEndpointGroupRequestPortOverrides : TeaModel {
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            [NameInMap("EndpointPort")]
            [Validation(Required=false)]
            public int? EndpointPort { get; set; }

        }

    }

}
