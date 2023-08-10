// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSubscriptionInstanceRequest : TeaModel {
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureSubscriptionInstanceRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// The name of the source database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The IP address of the source database.
            /// 
            /// >  This parameter is required only when the source database is a self-managed database.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the source database.
            /// 
            /// >  This parameter is required only when the source database is an ApsaraDB RDS for MySQL instance, a PolarDB-X 1.0 instance, or a PolarDB for MySQL cluster.
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// The type of the source database. Valid values:
            /// 
            /// *   **RDS**: ApsaraDB RDS for MySQL instance
            /// *   **PolarDB**: PolarDB for MySQL cluster
            /// *   **LocalInstance**: self-managed database with a public IP address
            /// *   **ECS**: self-managed database hosted on an Elastic Compute Service (ECS) instance
            /// *   **Express**: self-managed database connected over Express Connect
            /// *   **CEN**: self-managed database connected over Cloud Enterprise Network (CEN)
            /// *   **dg**: self-managed database connected over Database Gateway
            /// 
            /// >  The engine of a self-managed database can be MySQL or Oracle. You must specify the engine type when you call the [CreateSubscriptionInstance](~~49436~~) operation.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The system ID (SID) of the Oracle database.
            /// 
            /// >  This parameter is required only when the source database is a self-managed Oracle database and is not deployed in the Real Application Clusters (RAC) architecture.
            /// </summary>
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the source database belongs.
            /// 
            /// >  This parameter is required only when you track data changes across different Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// The password of the account that is used to connect to the source database.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The service port number of the source database.
            /// 
            /// >  This parameter is required only when the source database is a self-managed database.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The RAM role that is authorized to access the source database. This parameter is required if the source database does not belong to the Alibaba Cloud account that you use to configure the change tracking instance. In this case, you must authorize the Alibaba Cloud account to access the source database by using a RAM role.
            /// 
            /// >  For more information about the permissions that are required for the RAM role and how to grant permissions to the RAM role, see [Configure RAM authorization for cross-account data migration and synchronization](~~48468~~).
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The username of the account that is used to connect to the source database.
            /// 
            /// >  The permissions that are required for the database account vary with the change tracking scenario. For more information, see [Overview of change tracking scenarios](~~145715~~).
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("SubscriptionDataType")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSubscriptionDataType SubscriptionDataType { get; set; }
        public class ConfigureSubscriptionInstanceRequestSubscriptionDataType : TeaModel {
            /// <summary>
            /// Specifies whether to track DDL statements. Default value: true. Valid values:
            /// 
            /// *   **true**: tracks DDL statements.
            /// *   **false**: does not track DDL statements.
            /// </summary>
            [NameInMap("DDL")]
            [Validation(Required=false)]
            public bool? DDL { get; set; }

            /// <summary>
            /// Specifies whether to track DML statements. Default value: true. Valid values:
            /// 
            /// *   **true**: tracks DML statements.
            /// *   **false**: does not tack DML statements.
            /// </summary>
            [NameInMap("DML")]
            [Validation(Required=false)]
            public bool? DML { get; set; }

        }

        [NameInMap("SubscriptionInstance")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSubscriptionInstance SubscriptionInstance { get; set; }
        public class ConfigureSubscriptionInstanceRequestSubscriptionInstance : TeaModel {
            /// <summary>
            /// The ID of the VPC in which the change tracking instance is deployed.
            /// 
            /// >  This parameter is required only when the **SubscriptionInstanceNetworkType** parameter is set to **vpc**.
            /// </summary>
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }

            /// <summary>
            /// The ID of the vSwitch in the specified VPC.
            /// 
            /// >  This parameter is required only when the **SubscriptionInstanceNetworkType** parameter is set to **vpc**.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter is discontinued.
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
        /// The ID of the region in which the change tracking instance resides. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

        /// <summary>
        /// The ID of the change tracking instance. You can call the [DescribeSubscriptionInstances](~~49442~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("SubscriptionInstanceName")]
        [Validation(Required=false)]
        public string SubscriptionInstanceName { get; set; }

        /// <summary>
        /// The network type of the change tracking instance. Set the value to **vpc**. A value of vpc indicates the Virtual Private Cloud (VPC) network type.
        /// 
        /// > 
        /// *   To use the new version of the change tracking feature, you must specify the SubscriptionInstanceNetworkType parameter. You must also specify the **SubscriptionInstance.VPCId** and **SubscriptionInstance.VSwitchID** parameters. If you do not specify the SubscriptionInstanceNetworkType parameter, the previous version of the change tracking feature is used.
        /// *   The previous version of the change tracking feature supports self-managed MySQL databases, ApsaraDB RDS for MySQL instances, and PolarDB-X 1.0 instances. The new version of the change tracking feature supports self-managed MySQL databases, ApsaraDB RDS for MySQL instances, PolarDB for MySQL clusters, and Oracle databases.
        /// </summary>
        [NameInMap("SubscriptionInstanceNetworkType")]
        [Validation(Required=false)]
        public string SubscriptionInstanceNetworkType { get; set; }

        /// <summary>
        /// The objects for which you want to track data changes. The value is a JSON string and can contain regular expressions. For more information, see [SubscriptionObjects](~~141902~~).
        /// </summary>
        [NameInMap("SubscriptionObject")]
        [Validation(Required=false)]
        public string SubscriptionObject { get; set; }

    }

}
