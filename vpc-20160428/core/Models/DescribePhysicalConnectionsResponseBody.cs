// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **10**. Valid values: **1** to **50**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The list of Express Connect circuits.
        /// </summary>
        [NameInMap("PhysicalConnectionSet")]
        [Validation(Required=false)]
        public DescribePhysicalConnectionsResponseBodyPhysicalConnectionSet PhysicalConnectionSet { get; set; }
        public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSet : TeaModel {
            [NameInMap("PhysicalConnectionType")]
            [Validation(Required=false)]
            public List<DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionType> PhysicalConnectionType { get; set; }
            public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionType : TeaModel {
                /// <summary>
                /// The ID of the Express Connect circuit.
                /// </summary>
                [NameInMap("AccessPointId")]
                [Validation(Required=false)]
                public string AccessPointId { get; set; }

                /// <summary>
                /// The type of the access point.
                /// </summary>
                [NameInMap("AccessPointType")]
                [Validation(Required=false)]
                public string AccessPointType { get; set; }

                /// <summary>
                /// The information about the data center and rack.
                /// </summary>
                [NameInMap("AdDetailLocation")]
                [Validation(Required=false)]
                public string AdDetailLocation { get; set; }

                /// <summary>
                /// The location of the access point.
                /// </summary>
                [NameInMap("AdLocation")]
                [Validation(Required=false)]
                public string AdLocation { get; set; }

                /// <summary>
                /// The maximum bandwidth of the Express Connect circuit.
                /// 
                /// Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// The status of the Express Connect circuit. Valid values:
                /// 
                /// *   **Normal**: enabled
                /// *   **FinancialLocked**: locked due to overdue payments
                /// *   **SecurityLocked**: locked for security reasons
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// The billing method of the Express Connect circuit.
                /// 
                /// If **Prepaid** is returned, it indicates that the Express Connect circuit is billed on a subscription basis.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.
                /// </summary>
                [NameInMap("CircuitCode")]
                [Validation(Required=false)]
                public string CircuitCode { get; set; }

                /// <summary>
                /// The time when the Express Connect circuit was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the Express Connect circuit.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the Express Connect circuit was enabled.
                /// </summary>
                [NameInMap("EnabledTime")]
                [Validation(Required=false)]
                public string EnabledTime { get; set; }

                /// <summary>
                /// The time when the Express Connect circuit expires.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The estimated maximum bandwidth of the shared Express Connect circuit. The estimated bandwidth takes effect after you complete the payment.
                /// 
                /// Unit: **M** (Mbit/s) and **G** (Gbit/s).
                /// </summary>
                [NameInMap("ExpectSpec")]
                [Validation(Required=false)]
                public string ExpectSpec { get; set; }

                /// <summary>
                /// Indicates whether the data about pending orders is returned. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                /// <summary>
                /// The connectivity provider of the Express Connect circuit. Valid values:
                /// 
                /// *   **CT**: China Telecom.
                /// *   **CU**: China Unicom.
                /// *   **CM**: China Mobile.
                /// *   **CO**: other connectivity providers in the Chinese mainland.
                /// *   **Equinix**: Equinix.
                /// *   **Other**: other connectivity providers outside the Chinese mainland.
                /// </summary>
                [NameInMap("LineOperator")]
                [Validation(Required=false)]
                public string LineOperator { get; set; }

                /// <summary>
                /// The status of the letter of authorization (LOA). Valid values:
                /// 
                /// *   **Applying**: The LOA is pending for approval.
                /// *   **Accept**: The LOA is approved.
                /// *   **Available**: The LOA is available.
                /// *   **Rejected**: The LOA is rejected.
                /// *   **Completing**: The Express Connect circuit is under construction.
                /// *   **Complete**: The Express Connect circuit is installed.
                /// *   **Deleted**: The LOA is deleted.
                /// </summary>
                [NameInMap("LoaStatus")]
                [Validation(Required=false)]
                public string LoaStatus { get; set; }

                /// <summary>
                /// The name of the Express Connect circuit.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The payer for the hosted connection. Valid values:
                /// 
                /// *   **PayByPhysicalConnectionOwner**: The partner pays for the shared Express Connect circuit.
                /// *   **PayByVirtualPhysicalConnectionOwner**: The tenant pays for the shared Express Connect circuit.
                /// </summary>
                [NameInMap("OrderMode")]
                [Validation(Required=false)]
                public string OrderMode { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the parent Express Connect circuit belongs.
                /// </summary>
                [NameInMap("ParentPhysicalConnectionAliUid")]
                [Validation(Required=false)]
                public long? ParentPhysicalConnectionAliUid { get; set; }

                /// <summary>
                /// The ID of the parent Express Connect circuit.
                /// </summary>
                [NameInMap("ParentPhysicalConnectionId")]
                [Validation(Required=false)]
                public string ParentPhysicalConnectionId { get; set; }

                /// <summary>
                /// The geographical location of the data center.
                /// </summary>
                [NameInMap("PeerLocation")]
                [Validation(Required=false)]
                public string PeerLocation { get; set; }

                /// <summary>
                /// The ID of the Express Connect circuit.
                /// </summary>
                [NameInMap("PhysicalConnectionId")]
                [Validation(Required=false)]
                public string PhysicalConnectionId { get; set; }

                /// <summary>
                /// The ID of the port on the access device.
                /// </summary>
                [NameInMap("PortNumber")]
                [Validation(Required=false)]
                public string PortNumber { get; set; }

                /// <summary>
                /// The port type of the Express Connect circuit. Valid values:
                /// 
                /// *   **100Base-T**: 100 Mbit/s copper Ethernet port
                /// *   **1000Base-T**: 1,000 Mbit/s copper Ethernet port
                /// *   **1000Base-LX**: 1,000 Mbit/s single-mode optical port (10 km)
                /// *   **10GBase-T**: 10,000 Mbit/s copper Ethernet port
                /// *   **10GBase-LR**: 10,000 Mbit/s single-mode optical port (10 km)
                /// *   **40GBase-LR**: 40,000 Mbit/s single-mode optical port
                /// *   **100GBase-LR**: 100,000 Mbit/s single-mode optical port
                /// 
                /// > Whether 40GBase-LR and 100GBase-LR ports can be created depends on resource supplies. For more information, contact your account manager.
                /// </summary>
                [NameInMap("PortType")]
                [Validation(Required=false)]
                public string PortType { get; set; }

                /// <summary>
                /// The type of the Express Connect circuit. Valid values:
                /// 
                /// *   **VirtualPhysicalConnection**: shared Express Connect circuit
                /// *   **PhysicalConnection**: dedicated Express Connect circuit
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// The ID of the QoS policy.
                /// </summary>
                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                /// <summary>
                /// The ID of the standby Express Connect circuit.
                /// </summary>
                [NameInMap("RedundantPhysicalConnectionId")]
                [Validation(Required=false)]
                public string RedundantPhysicalConnectionId { get; set; }

                /// <summary>
                /// The time when the pending order takes effect.
                /// </summary>
                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                /// <summary>
                /// The billing method of the pending order.
                /// 
                /// If **PayByBandwidth** is returned, it indicates that the Express Connect circuit is billed on a pay-by-bandwidth basis.
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// The type of the pending order.
                /// 
                /// If the value is **RENEW**, it indicates that the order is placed for service renewal.
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                /// <summary>
                /// The resource group ID to which the instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The specification of the Express Connect circuit.
                /// 
                /// Unit: **G** (Gbit/s).
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The status of the Express Connect circuit. Valid values:
                /// 
                /// *   **Initial**
                /// *   **Approved**
                /// *   **Allocating**
                /// *   **Allocated**
                /// *   **Confirmed**
                /// *   **Enabled**
                /// *   **Rejected**
                /// *   **Canceled**
                /// *   **Allocation Failed**
                /// *   **Terminating**
                /// *   **Terminated**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags that are added to the cluster.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTags Tags { get; set; }
                public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTags : TeaModel {
                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTagsTags> Tags { get; set; }
                    public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTagsTags : TeaModel {
                        /// <summary>
                        /// The key of tag N added to the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.
                        /// 
                        /// The tag key can be up to 64 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of tag N added to the resource. You can specify up to 20 tag values. The tag value can be an empty string.
                        /// 
                        /// The tag value can be up to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The type of resource to which the Express Connect circuit is connected. Only **VPC** may be returned.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The number of Express Connect circuits that are established.
                /// </summary>
                [NameInMap("VirtualPhysicalConnectionCount")]
                [Validation(Required=false)]
                public int? VirtualPhysicalConnectionCount { get; set; }

                /// <summary>
                /// The VLAN ID of the shared Express Connect circuit.
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public string VlanId { get; set; }

                /// <summary>
                /// The status of the shared Express Connect circuit. Valid values:
                /// 
                /// *   **Confirmed**
                /// *   **UnConfirmed**
                /// *   **Deleted**
                /// </summary>
                [NameInMap("VpconnStatus")]
                [Validation(Required=false)]
                public string VpconnStatus { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
