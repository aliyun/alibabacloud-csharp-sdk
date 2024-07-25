// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetGatewayResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetGatewayResponseBodyData Data { get; set; }
        public class GetGatewayResponseBodyData : TeaModel {
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("createFrom")]
            [Validation(Required=false)]
            public string CreateFrom { get; set; }

            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataEnvironments> Environments { get; set; }
            public class GetGatewayResponseBodyDataEnvironments : TeaModel {
                [NameInMap("alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("environmentId")]
                [Validation(Required=false)]
                public string EnvironmentId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("expireTimestamp")]
            [Validation(Required=false)]
            public long? ExpireTimestamp { get; set; }

            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("loadBalancers")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataLoadBalancers> LoadBalancers { get; set; }
            public class GetGatewayResponseBodyDataLoadBalancers : TeaModel {
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("addressIpVersion")]
                [Validation(Required=false)]
                public string AddressIpVersion { get; set; }

                [NameInMap("addressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                [NameInMap("gatewayDefault")]
                [Validation(Required=false)]
                public bool? GatewayDefault { get; set; }

                [NameInMap("loadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("ports")]
                [Validation(Required=false)]
                public List<GetGatewayResponseBodyDataLoadBalancersPorts> Ports { get; set; }
                public class GetGatewayResponseBodyDataLoadBalancersPorts : TeaModel {
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("replicas")]
            [Validation(Required=false)]
            public string Replicas { get; set; }

            [NameInMap("securityGroup")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataSecurityGroup SecurityGroup { get; set; }
            public class GetGatewayResponseBodyDataSecurityGroup : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

            }

            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("targetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

            [NameInMap("updateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

            [NameInMap("vSwitch")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataVSwitch VSwitch { get; set; }
            public class GetGatewayResponseBodyDataVSwitch : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("vpc")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataVpc Vpc { get; set; }
            public class GetGatewayResponseBodyDataVpc : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("zones")]
            [Validation(Required=false)]
            public List<GetGatewayResponseBodyDataZones> Zones { get; set; }
            public class GetGatewayResponseBodyDataZones : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("vSwitch")]
                [Validation(Required=false)]
                public GetGatewayResponseBodyDataZonesVSwitch VSwitch { get; set; }
                public class GetGatewayResponseBodyDataZonesVSwitch : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
