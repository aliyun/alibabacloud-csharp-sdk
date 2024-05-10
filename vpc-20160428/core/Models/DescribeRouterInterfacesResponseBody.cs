// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouterInterfacesResponseBody : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the router interface.
        /// </summary>
        [NameInMap("RouterInterfaceSet")]
        [Validation(Required=false)]
        public DescribeRouterInterfacesResponseBodyRouterInterfaceSet RouterInterfaceSet { get; set; }
        public class DescribeRouterInterfacesResponseBodyRouterInterfaceSet : TeaModel {
            [NameInMap("RouterInterfaceType")]
            [Validation(Required=false)]
            public List<DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceType> RouterInterfaceType { get; set; }
            public class DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceType : TeaModel {
                /// <summary>
                /// The ID of the access point.
                /// </summary>
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                /// <summary>
                /// The bandwidth of the router interface. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// The service status of the router interface. Valid values:
                /// 
                /// *   **Normal**
                /// *   **FinancialLocked**
                /// *   **SecurityLocked**
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The billing method.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The time when the connection was established.
                /// 
                /// The time follows the ISO8601 standard in the `YYYY-MM-DDThh:mmZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ConnectedTime")]
                [Validation(Required=false)]
                public string ConnectedTime { get; set; }

                /// <summary>
                /// The time when the route table was created.
                /// 
                /// The time follows the ISO8601 standard in the `YYYY-MM-DDThh:mmZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// Indicates whether the connection is a cross-border connection.
                /// </summary>
                [NameInMap("CrossBorder")]
                [Validation(Required=false)]
                public bool? CrossBorder { get; set; }

                /// <summary>
                /// The description of the router interface.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The end of the time range during which data was queried.
                /// 
                /// The time follows the ISO8601 standard in the `YYYY-MM-DDThh:mmZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// Indicates whether the VBR that is created in the Fast Link mode is uplinked to the router interface. The Fast Link mode helps automatically connect router interfaces that are created for the VBR and its peer VPC. Valid values:
                /// 
                /// *   **true**
                /// *   **false** (default)
                /// </summary>
                [NameInMap("FastLinkMode")]
                [Validation(Required=false)]
                public bool? FastLinkMode { get; set; }

                /// <summary>
                /// Indicates whether renewal data is included.
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// The rate of heath checks.
                /// </summary>
                [NameInMap("HcRate")]
                [Validation(Required=false)]
                public int? HcRate { get; set; }

                /// <summary>
                /// The health check threshold.
                /// </summary>
                [NameInMap("HcThreshold")]
                [Validation(Required=false)]
                public int? HcThreshold { get; set; }

                /// <summary>
                /// The source IP address that is used for the health check.
                /// </summary>
                [NameInMap("HealthCheckSourceIp")]
                [Validation(Required=false)]
                public string HealthCheckSourceIp { get; set; }

                /// <summary>
                /// The destination IP address that is used for the health check.
                /// </summary>
                [NameInMap("HealthCheckTargetIp")]
                [Validation(Required=false)]
                public string HealthCheckTargetIp { get; set; }

                /// <summary>
                /// Indicates whether protection against malicious IPv6 traffic is enabled. Valid values:
                /// 
                /// *   **on**
                /// *   **off**
                /// *   **unsupport**
                /// </summary>
                [NameInMap("Ipv6Status")]
                [Validation(Required=false)]
                public string Ipv6Status { get; set; }

                /// <summary>
                /// The custom name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the peer access point.
                /// </summary>
                [NameInMap("OppositeAccessPointId")]
                [Validation(Required=false)]
                public string OppositeAccessPointId { get; set; }

                /// <summary>
                /// The maximum bandwidth of the peer router interface. Unit: Mbit/s.
                /// </summary>
                [NameInMap("OppositeBandwidth")]
                [Validation(Required=false)]
                public int? OppositeBandwidth { get; set; }

                /// <summary>
                /// The service status of the peer router interface.
                /// </summary>
                [NameInMap("OppositeInterfaceBusinessStatus")]
                [Validation(Required=false)]
                public string OppositeInterfaceBusinessStatus { get; set; }

                /// <summary>
                /// The ID of the peer router interface.
                /// </summary>
                [NameInMap("OppositeInterfaceId")]
                [Validation(Required=false)]
                public string OppositeInterfaceId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the peer router interface belongs.
                /// </summary>
                [NameInMap("OppositeInterfaceOwnerId")]
                [Validation(Required=false)]
                public string OppositeInterfaceOwnerId { get; set; }

                /// <summary>
                /// The specification of the peer router interface.
                /// </summary>
                [NameInMap("OppositeInterfaceSpec")]
                [Validation(Required=false)]
                public string OppositeInterfaceSpec { get; set; }

                /// <summary>
                /// The status of the peer router interface.
                /// </summary>
                [NameInMap("OppositeInterfaceStatus")]
                [Validation(Required=false)]
                public string OppositeInterfaceStatus { get; set; }

                /// <summary>
                /// The region ID of the peer router interface.
                /// </summary>
                [NameInMap("OppositeRegionId")]
                [Validation(Required=false)]
                public string OppositeRegionId { get; set; }

                /// <summary>
                /// The ID of the router to which the peer router interface belongs.
                /// </summary>
                [NameInMap("OppositeRouterId")]
                [Validation(Required=false)]
                public string OppositeRouterId { get; set; }

                /// <summary>
                /// The type of the router to which the peer router interface belongs.
                /// </summary>
                [NameInMap("OppositeRouterType")]
                [Validation(Required=false)]
                public string OppositeRouterType { get; set; }

                /// <summary>
                /// The ID of the peer VPC.
                /// </summary>
                [NameInMap("OppositeVpcInstanceId")]
                [Validation(Required=false)]
                public string OppositeVpcInstanceId { get; set; }

                /// <summary>
                /// The time when the renewal takes effect.
                /// 
                /// The time follows the ISO8601 standard in the `YYYY-MM-DDThh:mmZ` format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// The maximum bandwidth after the renewal takes effect. Unit: Mbit/s.
                /// </summary>
                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                /// <summary>
                /// The metering method that is used after the renewal takes effect. Valid values:
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// The type of the renewal order. Valid values:
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                /// <summary>
                /// Resource Group ID.
                /// 
                /// For more information about resource groups, please refer to [What is a Resource Group?](https://help.aliyun.com/document_detail/94475.html)
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether the router interface is the initiator or acceptor of the peering connection.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The ID of the router to which the route entry belongs.
                /// </summary>
                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                /// <summary>
                /// The ID of the router interface.
                /// </summary>
                [NameInMap("RouterInterfaceId")]
                [Validation(Required=false)]
                public string RouterInterfaceId { get; set; }

                /// <summary>
                /// The type of the router to which the route table belongs. Valid values:
                /// 
                /// *   **VRouter**
                /// *   **VBR**
                /// </summary>
                [NameInMap("RouterType")]
                [Validation(Required=false)]
                public string RouterType { get; set; }

                /// <summary>
                /// The specification of the router interface.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The status of the router interface.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags of the resource.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceTypeTags Tags { get; set; }
                public class DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceTypeTags : TeaModel {
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceTypeTagsTags> Tags { get; set; }
                    public class DescribeRouterInterfacesResponseBodyRouterInterfaceSetRouterInterfaceTypeTagsTags : TeaModel {
                        /// <summary>
                        /// The key of the resource tag. At least one tag key must be entered, and a maximum of 20 tag keys are supported. If this value needs to be passed in, it cannot be an empty string.
                        /// 
                        /// A tag key can support up to 128 characters, cannot start with \\"aliyun\\" or \\"acs:\\", and cannot contain \\"http://\\" or \\"https://\\".
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the resource tag. A maximum of 20 tag values can be entered. If this value needs to be passed in, an empty string can be entered.
                        /// 
                        /// A maximum of 128 characters are supported, it cannot start with \\"aliyun\\" or \\"acs:\\", and it cannot contain \\"http://\\" or \\"https://\\".
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the local virtual private cloud (VPC) in the peering connection.
                /// </summary>
                [NameInMap("VpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
