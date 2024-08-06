// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewaysResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewaysResponseBodyData Data { get; set; }
        public class ListGatewaysResponseBodyData : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewaysResponseBodyDataItems> Items { get; set; }
            public class ListGatewaysResponseBodyDataItems : TeaModel {
                [NameInMap("chargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("createFrom")]
                [Validation(Required=false)]
                public string CreateFrom { get; set; }

                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("expireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                [NameInMap("loadBalancers")]
                [Validation(Required=false)]
                public List<ListGatewaysResponseBodyDataItemsLoadBalancers> LoadBalancers { get; set; }
                public class ListGatewaysResponseBodyDataItemsLoadBalancers : TeaModel {
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
                    public List<ListGatewaysResponseBodyDataItemsLoadBalancersPorts> Ports { get; set; }
                    public class ListGatewaysResponseBodyDataItemsLoadBalancersPorts : TeaModel {
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
                public ListGatewaysResponseBodyDataItemsSecurityGroup SecurityGroup { get; set; }
                public class ListGatewaysResponseBodyDataItemsSecurityGroup : TeaModel {
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
                public ListGatewaysResponseBodyDataItemsVSwitch VSwitch { get; set; }
                public class ListGatewaysResponseBodyDataItemsVSwitch : TeaModel {
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("vpc")]
                [Validation(Required=false)]
                public ListGatewaysResponseBodyDataItemsVpc Vpc { get; set; }
                public class ListGatewaysResponseBodyDataItemsVpc : TeaModel {
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                [NameInMap("zones")]
                [Validation(Required=false)]
                public List<ListGatewaysResponseBodyDataItemsZones> Zones { get; set; }
                public class ListGatewaysResponseBodyDataItemsZones : TeaModel {
                    [NameInMap("vSwitch")]
                    [Validation(Required=false)]
                    public ListGatewaysResponseBodyDataItemsZonesVSwitch VSwitch { get; set; }
                    public class ListGatewaysResponseBodyDataItemsZonesVSwitch : TeaModel {
                        [NameInMap("vSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                    }

                    [NameInMap("zoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
