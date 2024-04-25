// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyEndpointRequest : TeaModel {
        /// <summary>
        /// The features that you want to enable for the proxy endpoint. If you specify more than one feature, separate the features with semicolons (;). Format: `Feature 1:Status;Feature 2:Status;...`. Do not add a semicolon (;) at the end of the value.
        /// 
        /// Valid feature values:
        /// 
        /// *   **ReadWriteSpliting**: read/write splitting
        /// *   **ConnectionPersist**: connection pooling
        /// *   **TransactionReadSqlRouteOptimizeStatus**: transaction splitting
        /// 
        /// Valid status values:
        /// 
        /// *   **1**: enabled
        /// *   **0**: disabled
        /// 
        /// >  If the instance runs PostgreSQL, you can enable only the read/write splitting feature, which is specified by **ReadWriteSpliting**.
        /// </summary>
        [NameInMap("ConfigDBProxyFeatures")]
        [Validation(Required=false)]
        public string ConfigDBProxyFeatures { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The ID of the proxy endpoint. You can call the DescribeDBProxyEndpoint operation to query the proxy endpoint ID.
        /// 
        /// > *   If the instance runs MySQL and you set **DbEndpointOperator** to **Delete** or **Modify**, you must specify DBProxyEndpointId.
        /// > *   If the instance runs PostgreSQL and you set **DbEndpointOperator** to **Delete**, **Modify**, or **Create**, you must specify DBProxyEndpointId.
        /// </summary>
        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        /// <summary>
        /// A deprecated parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The description of the proxy terminal.
        /// </summary>
        [NameInMap("DbEndpointAliases")]
        [Validation(Required=false)]
        public string DbEndpointAliases { get; set; }

        /// <summary>
        /// The type of operation that you want to perform. Valid values:
        /// 
        /// *   **Modify**: Modify a proxy terminal. This is the default value.
        /// *   **Create**: Create a proxy terminal.
        /// *   **Delete**: Delete a proxy terminal.
        /// </summary>
        [NameInMap("DbEndpointOperator")]
        [Validation(Required=false)]
        public string DbEndpointOperator { get; set; }

        /// <summary>
        /// The read and write attributes of the proxy terminal. Valid values:
        /// 
        /// *   **ReadWrite**: The proxy terminal connects to the primary instance and can receive both read and write requests.
        /// *   **ReadOnly**: The proxy terminal does not connect to the primary instance and can receive only read requests. This is the default value.
        /// 
        /// > *   If you set **DbEndpointOperator** to **Create**, you must also specify DbEndpointReadWriteMode.
        /// > *   If the instance runs MySQL and you change the value of this parameter from **ReadWrite** to **ReadOnly**, the transaction splitting feature is disabled.
        /// </summary>
        [NameInMap("DbEndpointReadWriteMode")]
        [Validation(Required=false)]
        public string DbEndpointReadWriteMode { get; set; }

        /// <summary>
        /// The type of the proxy terminal. This is a reserved parameter. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("DbEndpointType")]
        [Validation(Required=false)]
        public string DbEndpointType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The policy that is used to allocate read weights. Valid values:
        /// 
        /// *   **Standard**: The system automatically allocates read weights to the instance and its read-only instances based on the specifications of the instances.
        /// *   **Custom**: You must manually allocate read weights to the instance and its read-only instances.
        /// 
        /// > You must specify this parameter only when the read/write splitting feature is enabled. For more information about the permission allocation policy, see [Modify the latency threshold and read weights of ApsaraDB RDS for MySQL instances](~~96076~~) and [Enable and configure the database proxy feature for an ApsaraDB RDS for PostgreSQL instance](~~418272~~).
        /// </summary>
        [NameInMap("ReadOnlyInstanceDistributionType")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceDistributionType { get; set; }

        /// <summary>
        /// The latency threshold that is allowed for read/write splitting. If the latency on a read-only instance exceeds the threshold that you specified, the system no longer forwards read requests to the read-only instance. Unit: seconds If you do not specify this parameter, the original value of this parameter is retained. Valid values: **0** to **3600**. Default value: **30**.
        /// 
        /// > You must specify this parameter only when the read/write splitting feature is enabled.
        /// </summary>
        [NameInMap("ReadOnlyInstanceMaxDelayTime")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceMaxDelayTime { get; set; }

        /// <summary>
        /// The read weights of the instance and its read-only instances. A read weight must be a multiple of 100 and cannot exceed 10000. Formats:
        /// 
        /// *   Standard instance: `{"ID of the primary instance":"Weight","ID of the read-only instance":"Weight"...}`
        /// 
        ///     Example: `{"rm-uf6wjk5****":"500","rr-tfhfgk5xxx":"200"...}`
        /// 
        /// *   Instance on RDS Cluster Edition: `{"ID of the read-only instance":"Weight","DBClusterNode":{"ID of the primary node":"Weight","ID of the secondary node":"Weight","ID of the secondary node":"Weight"...}}`
        /// 
        ///     Example: `{"rr-tfhfgk5****":"200","DBClusterNode":{"rn-2z****":"0","rn-2z****":"400","rn-2z****":"400"...}}`
        /// 
        ///     > **DBClusterNode** is required if the instance runs RDS Cluster Edition. The DBClusterNode parameter includes information about **IDs** and **weights** of the primary and secondary nodes..
        /// </summary>
        [NameInMap("ReadOnlyInstanceWeight")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceWeight { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
