// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouterInterfaceAttributeResponseBody : TeaModel {
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
        /// The status of the router interface. Valid values:
        /// 
        /// *   **Normal**
        /// *   **FinancialLocked**
        /// *   **SecurityLocked**
        /// </summary>
        [NameInMap("BusinessStatus")]
        [Validation(Required=false)]
        public string BusinessStatus { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   **AfterPay**: pay-as-you-go
        /// *   **PrePaid**: subscription
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The time when the connection was established.
        /// </summary>
        [NameInMap("ConnectedTime")]
        [Validation(Required=false)]
        public string ConnectedTime { get; set; }

        /// <summary>
        /// The time when the router interface was created.
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Indicates whether the connection is a cross-border connection. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
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
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Indicates whether the VBR that is created in the Fast Link mode is uplinked to the router interface. The Fast Link mode helps automatically connect router interfaces that are created for the VBR and its peer VPC. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// 
        /// > 
        /// 
        /// *   This parameter takes effect only when **RouterType** is set to **VBR** and **OppositeRouterType** is set to **VRouter**.
        /// 
        /// *   When **FastLinkMode** is set to **true**, **Role** must be set to **InitiatingSide**. **AccessPointId**, **OppositeRouterType**, **OpppsiteRouterId**, and **OppositeInterfaceOwnerId** are required.
        /// </summary>
        [NameInMap("FastLinkMode")]
        [Validation(Required=false)]
        public string FastLinkMode { get; set; }

        /// <summary>
        /// The time when the router interface was modified.
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// Indicates whether renewal data is included. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// </summary>
        [NameInMap("HasReservationData")]
        [Validation(Required=false)]
        public string HasReservationData { get; set; }

        /// <summary>
        /// The rate of health checks. Unit: seconds. The value indicates the interval at which probe packets are sent during a health check.
        /// </summary>
        [NameInMap("HcRate")]
        [Validation(Required=false)]
        public int? HcRate { get; set; }

        /// <summary>
        /// The healthy threshold. This value indicates the number of probe packets that are sent during a health check. Unit: packets.
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
        /// The status of the health check. Valid values:
        /// 
        /// *   **Abnormal**
        /// *   **Normal**
        /// *   **NoRedundantRoute**
        /// *   **NoHealthCheckConfig**
        /// </summary>
        [NameInMap("HealthCheckStatus")]
        [Validation(Required=false)]
        public string HealthCheckStatus { get; set; }

        /// <summary>
        /// The destination IP address that is used for the health check.
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The name of the router interface.
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
        /// The service status of the peer router interface. Valid values:
        /// 
        /// *   **Normal**
        /// *   **FinancialLocked**
        /// *   **SecurityLocked**
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
        /// The specification of the peer router interface. Valid values:
        /// 
        /// *   **Mini.2**: 2 Mbit/s
        /// *   **Mini.5**: 5 Mbit/s
        /// *   **Small.1**: 10 Mbit/s
        /// *   **Small.2**: 20 Mbit/s
        /// *   **Small.5**: 50 Mbit/s
        /// *   **Middle.1**: 100 Mbit/s
        /// *   **Middle.2**: 200 Mbit/s
        /// *   **Middle.5**: 500 Mbit/s
        /// *   **Large.1**: 1,000 Mbit/s
        /// *   **Large.2**: 2,000 Mbit/s
        /// *   **Large.5**: 5,000 Mbit/s
        /// *   **Xlarge.1**: 10,000 Mbit/s
        /// *   **Negative**: not applicable
        /// </summary>
        [NameInMap("OppositeInterfaceSpec")]
        [Validation(Required=false)]
        public string OppositeInterfaceSpec { get; set; }

        /// <summary>
        /// The status of the peer router interface. Valid values:
        /// 
        /// *   **Idle**
        /// *   **AcceptingConnecting**
        /// *   **Connecting**
        /// *   **Activating**
        /// *   **Active**
        /// *   **Modifying**
        /// *   **Deactivating**
        /// *   **Inactive**
        /// *   **Deleting**
        /// *   **Deleted**
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
        /// The type of the router to which the peer router interface belongs. Valid values:
        /// 
        /// *   **VRouter**
        /// *   **VBR**
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The time when the renewal takes effect.
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
        /// The metering method that is used after the renewal takes effect. Valid values: If **PayByBandwidth** is returned, it indicates that the Express Connect circuit is billed on a pay-by-bandwidth basis.
        /// </summary>
        [NameInMap("ReservationInternetChargeType")]
        [Validation(Required=false)]
        public string ReservationInternetChargeType { get; set; }

        /// <summary>
        /// The type of the renewal order. Only **RENEW** may be returned, which indicates that the order is placed for service renewal.
        /// </summary>
        [NameInMap("ReservationOrderType")]
        [Validation(Required=false)]
        public string ReservationOrderType { get; set; }

        /// <summary>
        /// The resource group ID.
        /// 
        /// For more information about resource groups, see [What is a resource group?](https://help.aliyun.com/document_detail/94475.html)
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The role of the router interface in the peering connection.
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The ID of the router to which the router interface belongs.
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
        /// The specification of the router interface. Valid values:
        /// 
        /// *   **Mini.2**: 2 Mbit/s
        /// *   **Mini.5**: 5 Mbit/s
        /// *   **Small.1**: 10 Mbit/s
        /// *   **Small.2**: 20 Mbit/s
        /// *   **Small.5**: 50 Mbit/s
        /// *   **Middle.1**: 100 Mbit/s
        /// *   **Middle.2**: 200 Mbit/s
        /// *   **Middle.5**: 500 Mbit/s
        /// *   **Large.1**: 1,000 Mbit/s
        /// *   **Large.2**: 2,000 Mbit/s
        /// *   **Large.5**: 5,000 Mbit/s
        /// *   **Xlarge.1**: 10,000 Mbit/s
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// The status of the router interface. Valid values:
        /// 
        /// *   **Idle**
        /// *   **AcceptingConnecting**
        /// *   **Connecting**
        /// *   **Activating**
        /// *   **Active**
        /// *   **Modifying**
        /// *   **Deactivating**
        /// *   **Inactive**
        /// *   **Deleting**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The tag of the resource.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeRouterInterfaceAttributeResponseBodyTags Tags { get; set; }
        public class DescribeRouterInterfaceAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeRouterInterfaceAttributeResponseBodyTagsTags> Tags { get; set; }
            public class DescribeRouterInterfaceAttributeResponseBodyTagsTags : TeaModel {
                /// <summary>
                /// The key of tag N added to the resource. You must enter at least one tag key and at most 20 tag keys. The tag key cannot be an empty string.
                /// 
                /// The tag key can be up to 64 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of tag N added to the resource. You can specify at most 20 tag values. The tag value can be an empty string.
                /// 
                /// It can be up to 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the router interface belongs.
        /// </summary>
        [NameInMap("VpcInstanceId")]
        [Validation(Required=false)]
        public string VpcInstanceId { get; set; }

    }

}
