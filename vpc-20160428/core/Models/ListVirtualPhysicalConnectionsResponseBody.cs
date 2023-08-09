// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned in this query.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If **NextToken** was not returned, it indicates that no additional results exist.
        /// *   If **NextToken** is not empty, the value indicates the token that is used for the next query.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of hosted connections returned.
        /// </summary>
        [NameInMap("VirtualPhysicalConnections")]
        [Validation(Required=false)]
        public List<ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections> VirtualPhysicalConnections { get; set; }
        public class ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnections : TeaModel {
            /// <summary>
            /// The ID of the access point that is associated with the Express Connect circuit.
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public string AccessPointId { get; set; }

            /// <summary>
            /// The geographical location of the access device.
            /// </summary>
            [NameInMap("AdLocation")]
            [Validation(Required=false)]
            public string AdLocation { get; set; }

            /// <summary>
            /// The Alibaba Cloud account ID of the hosted connection owner.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// The bandwidth of the Express Connect circuit. Unit: Mbit/s.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// The business status of the Express Connect circuit. Valid values:
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
            /// The value is set to **Prepaid**, which indicates the subscription billing method.
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
            /// The expiration date of the hosted connection.
            /// 
            /// The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
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
            /// The connectivity provider of the Express Connect circuit. Valid values:
            /// 
            /// *   **CT**: China Telecom
            /// *   **CU**: China Unicom
            /// *   **CM**: China Mobile
            /// *   **CO**: other connectivity providers in the Chinese mainland
            /// *   **Equinix**: Equinix
            /// *   **Other**: other connectivity providers outside the Chinese mainland
            /// </summary>
            [NameInMap("LineOperator")]
            [Validation(Required=false)]
            public string LineOperator { get; set; }

            /// <summary>
            /// The status of the LOA. Valid values:
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
            /// The payer of the hosted connection. Valid values:
            /// 
            /// *   **PayByPhysicalConnectionOwner**: the owner of the shared Express Connect circuit
            /// *   **PayByVirtualPhysicalConnectionOwner**: the owner of the hosted connection
            /// </summary>
            [NameInMap("OrderMode")]
            [Validation(Required=false)]
            public string OrderMode { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the Express Connect circuit belongs.
            /// </summary>
            [NameInMap("ParentPhysicalConnectionAliUid")]
            [Validation(Required=false)]
            public string ParentPhysicalConnectionAliUid { get; set; }

            /// <summary>
            /// The ID of the Express Connect circuit.
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
            /// The ID of the hosted connection.
            /// </summary>
            [NameInMap("PhysicalConnectionId")]
            [Validation(Required=false)]
            public string PhysicalConnectionId { get; set; }

            /// <summary>
            /// The port number of the access device.
            /// </summary>
            [NameInMap("PortNumber")]
            [Validation(Required=false)]
            public string PortNumber { get; set; }

            /// <summary>
            /// The port type. Valid values:
            /// 
            /// *   **100Base-T**: 100 Mbit/s copper Ethernet port
            /// *   **1000Base-T**: 1,000 Mbit/s copper Ethernet port
            /// *   **1000Base-LX**: 1,000 Mbit/s single-mode optical port (10 kilometers)
            /// *   **10GBase-T**: 10,000 Mbit/s copper Ethernet port
            /// *   **10GBase-LR**: 10,000 Mbit/s single-mode optical port (10 kilometers)
            /// *   **40GBase-LR**: 40,000 Mbit/s single-mode optical port
            /// *   **100GBase-LR**: 100,000 Mbit/s single-mode optical port
            /// </summary>
            [NameInMap("PortType")]
            [Validation(Required=false)]
            public string PortType { get; set; }

            /// <summary>
            /// The type of connection over the Express Connect circuit. Valid values:
            /// 
            /// *   **VirtualPhysicalConnection**: a hosted connection
            /// *   **PhysicalConnection**: a dedicated connection
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

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The bandwidth value of the hosted connection.
            /// 
            /// **M** indicates Mbit/s and **G** indicates Gbit/s.
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
            /// *   **Terminated**: The Express Connect circuit is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnectionsTags> Tags { get; set; }
            public class ListVirtualPhysicalConnectionsResponseBodyVirtualPhysicalConnectionsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The type of Express Connect circuit. Default value: **VPC**.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The service status of the hosted connection. Valid values:
            /// 
            /// *   **Confirmed**: accepted
            /// *   **UnConfirmed**: pending acceptance
            /// *   **Deleted**: deleted
            /// </summary>
            [NameInMap("VirtualPhysicalConnectionStatus")]
            [Validation(Required=false)]
            public string VirtualPhysicalConnectionStatus { get; set; }

            /// <summary>
            /// The VLAN ID of the hosted connection.
            /// </summary>
            [NameInMap("VlanId")]
            [Validation(Required=false)]
            public string VlanId { get; set; }

        }

    }

}
