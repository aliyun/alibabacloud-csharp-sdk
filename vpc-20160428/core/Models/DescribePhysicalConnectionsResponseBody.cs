// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The number of the returned page. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Default value: **10**. Valid values: **1** to **50**.
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
                /// The ID of the access point.
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

                [NameInMap("AdDetailLocation")]
                [Validation(Required=false)]
                public string AdDetailLocation { get; set; }

                /// <summary>
                /// The geographical location of the access device.
                /// </summary>
                [NameInMap("AdLocation")]
                [Validation(Required=false)]
                public string AdLocation { get; set; }

                /// <summary>
                /// The maximum bandwidth of the Express Connect circuit.
                /// 
                /// Unit: Gbit/s.
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
                /// If the value is set to **Prepaid**, it indicates that the Express Connect circuit is billed on a subscription basis.
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
                /// The estimated bandwidth value of the hosted connection. The estimated bandwidth takes effect after you complete the payment.
                /// 
                /// **M** indicates Mbit/s and **G** indicates Gbit/s.
                /// </summary>
                [NameInMap("ExpectSpec")]
                [Validation(Required=false)]
                public string ExpectSpec { get; set; }

                /// <summary>
                /// Indicates whether the data about pending orders is returned. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
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
                /// *   **Applying**: The LOA is pending approval.
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
                /// *   **PayByPhysicalConnectionOwner**: The partner pays for the hosted connection.
                /// *   **PayByVirtualPhysicalConnectionOwner**: The tenant pays for the hosted connection.
                /// </summary>
                [NameInMap("OrderMode")]
                [Validation(Required=false)]
                public string OrderMode { get; set; }

                /// <summary>
                /// The Alibaba Cloud account ID of the Express Connect circuit that is used to create the hosted connection.
                /// </summary>
                [NameInMap("ParentPhysicalConnectionAliUid")]
                [Validation(Required=false)]
                public long? ParentPhysicalConnectionAliUid { get; set; }

                /// <summary>
                /// The ID of the Express Connect circuit that is used to create the hosted connection.
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
                /// The port type. Valid values:
                /// 
                /// *   **100Base-T**: 100 Mbit/s copper Ethernet port
                /// *   **1000Base-T**: 1,000 Mbit/s copper Ethernet port
                /// *   **1000Base-LX**: 1,000 Mbit/s single-mode optical port (10 km)
                /// *   **10GBase-T**: 10,000 Mbit/s copper Ethernet port
                /// *   **10GBase-LR**: 10,000 Mbit/s single-mode optical port (10 km)
                /// *   **40GBase-LR**: 40,000 Mbit/s single-mode optical port
                /// *   **100GBase-LR**: 100,000 Mbit/s single-mode optical port
                /// 
                /// >  Whether 40GBase-LR and 100GBase-LR ports can be created is based on resource supplies. For more information, contact your business manager.
                /// </summary>
                [NameInMap("PortType")]
                [Validation(Required=false)]
                public string PortType { get; set; }

                /// <summary>
                /// The type of the Express Connect circuit. Valid values:
                /// 
                /// *   **VirtualPhysicalConnection**: a shared Express Connect circuit
                /// *   **PhysicalConnection**: a dedicated Express Connect circuit
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// The ID of the redundant Express Connect circuit.
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
                /// The value is set to **PayByBandwidth**, which indicates the pay-by-bandwidth metering method.
                /// </summary>
                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                /// <summary>
                /// The type of the pending order.
                /// 
                /// If the value is set to **RENEW**, it indicates that the order is placed for service renewal.
                /// </summary>
                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

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
                /// *   **Initial**: The application is under review.
                /// *   **Approved**: The application is approved.
                /// *   **Allocating**: The system is allocating resources.
                /// *   **Allocated**: The Express Connect circuit is under construction.
                /// *   **Confirmed**: The Express Connect circuit is pending user confirmation.
                /// *   **Enabled**: The Express Connect circuit is enabled.
                /// *   **Rejected**: The application is rejected.
                /// *   **Canceled**: The application is canceled.
                /// *   **Allocation Failed**: The system failed to allocate resources.
                /// *   **Terminating**: The Express Connect circuit is being disabled.
                /// *   **Terminated**: The Express Connect circuit is disabled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTags Tags { get; set; }
                public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTags : TeaModel {
                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTagsTags> Tags { get; set; }
                    public class DescribePhysicalConnectionsResponseBodyPhysicalConnectionSetPhysicalConnectionTypeTagsTags : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The type of the Express Connect circuit. The value is set to **VPC**.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The number of hosted connections that are established over the Express Connect circuit.
                /// </summary>
                [NameInMap("VirtualPhysicalConnectionCount")]
                [Validation(Required=false)]
                public int? VirtualPhysicalConnectionCount { get; set; }

                /// <summary>
                /// The VLAN ID of the hosted connection.
                /// </summary>
                [NameInMap("VlanId")]
                [Validation(Required=false)]
                public string VlanId { get; set; }

                /// <summary>
                /// The status of the hosted connection. Valid values:
                /// 
                /// *   **Confirmed**: accepted
                /// *   **UnConfirmed**: pending acceptance
                /// *   **Deleted**: deleted
                /// </summary>
                [NameInMap("VpconnStatus")]
                [Validation(Required=false)]
                public string VpconnStatus { get; set; }

            }

        }

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
        public int? TotalCount { get; set; }

    }

}
