// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SwitchSynchronizationEndpointRequest : TeaModel {
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public SwitchSynchronizationEndpointRequestEndpoint Endpoint { get; set; }
        public class SwitchSynchronizationEndpointRequestEndpoint : TeaModel {
            /// <summary>
            /// The IP address of the database.
            /// 
            /// >  You must specify the IP address only if the **Endpoint.InstanceType** parameter is set to **Express**.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the ECS instance or the virtual private cloud (VPC).
            /// 
            /// > 
            /// *   If the **Endpoint.InstanceType** parameter is set to **ECS**, you must specify the ID of the ECS instance.
            /// *   If the **Endpoint.InstanceType** parameter is set to **Express**, you must specify the ID of the VPC.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The instance type of the database. Valid values:
            /// 
            /// *   **LocalInstance**: self-managed database with a public IP address
            /// *   **ECS**: self-managed database that is hosted on ECS
            /// *   **Express**: self-managed database that is connected over Express Connect
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The service port number of the database.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// Specifies whether to update the connection settings of the source instance or the destination instance. Valid values:
            /// 
            /// *   **Source**
            /// *   **Destination**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public SwitchSynchronizationEndpointRequestSourceEndpoint SourceEndpoint { get; set; }
        public class SwitchSynchronizationEndpointRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the source instance belongs. You must specify this parameter only if the source instance and the destination instance belong to different Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// The authorized Resource Access Management (RAM) role of the source instance. You must specify the RAM role only if the source instance and the destination instance belong to different Alibaba Cloud accounts. You can use the RAM role to allow the Alibaba Cloud account that owns the destination instance to access the source instance.
            /// 
            /// >  For information about the permissions and authorization methods of the RAM role, see [Configure RAM authorization for cross-account data migration and synchronization](~~48468~~).
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The synchronization direction. Valid values:
        /// 
        /// *   **Forward**
        /// *   **Reverse**
        /// 
        /// >  Default value: **Forward**.
        /// 
        /// The value **Reverse** takes effect only if the topology of the data synchronization instance is two-way synchronization.
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// The ID of the data synchronization instance. You can call the DescribeSynchronizationJobs operation to query the instance ID.
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

    }

}
