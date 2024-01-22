// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBProxyEndpointResponseBody : TeaModel {
        /// <summary>
        /// The proxy endpoint queried.
        /// </summary>
        [NameInMap("DBProxyConnectString")]
        [Validation(Required=false)]
        public string DBProxyConnectString { get; set; }

        /// <summary>
        /// The network type of the proxy endpoint. Valid values:
        /// 
        /// *   **InnerString**: internal network
        /// *   **OuterString**: Internet
        /// </summary>
        [NameInMap("DBProxyConnectStringNetType")]
        [Validation(Required=false)]
        public string DBProxyConnectStringNetType { get; set; }

        /// <summary>
        /// The port number that is associated with the proxy endpoint.
        /// </summary>
        [NameInMap("DBProxyConnectStringPort")]
        [Validation(Required=false)]
        public string DBProxyConnectStringPort { get; set; }

        /// <summary>
        /// The ID of the proxy endpoint.
        /// </summary>
        [NameInMap("DBProxyEndpointId")]
        [Validation(Required=false)]
        public string DBProxyEndpointId { get; set; }

        /// <summary>
        /// An internal parameter. You can ignore this parameter.
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// The configuration of the proxy terminal. The value of this parameter is a JSON string that consists of the following fields:
        /// 
        /// *   **TransactionReadSqlRouteOptimizeStatus**: the status of the transaction splitting feature. Valid values: **0** and **1**. The value 0 indicates that the feature is disabled. The value 1 indicates that the feature is enabled.
        /// *   **ConnectionPersist**: the status of the connection pooling feature. Valid values: **0**, **1**, and **2**. The value 0 indicates that the connection pooling feature is disabled. The value 1 indicates that the session connection pooling feature is enabled. The value 2 indicates that the transaction connection pooling feature is enabled.
        /// *   **ReadWriteSpliting**: the status of the read/write splitting feature. Valid values: **0** and **1**. The value 0 indicates that the feature is disabled. The value 1 indicates that the feature is enabled.
        /// *   **PinPreparedStmt**: an internal field that is available only for ApsaraDB RDS for PostgreSQL instances.
        /// 
        /// >  If the instance runs PostgreSQL, you can change only the value of the **ReadWriteSpliting** field. The **TransactionReadSqlRouteOptimizeStatus** and **PinPreparedStmt** fields are set to their default values 1.
        /// </summary>
        [NameInMap("DBProxyFeatures")]
        [Validation(Required=false)]
        public string DBProxyFeatures { get; set; }

        /// <summary>
        /// The description of the proxy terminal.
        /// </summary>
        [NameInMap("DbProxyEndpointAliases")]
        [Validation(Required=false)]
        public string DbProxyEndpointAliases { get; set; }

        /// <summary>
        /// The read and write attributes of the proxy terminal. Valid values:
        /// 
        /// *   **ReadWrite**: The proxy terminal supports read and write requests.
        /// *   **ReadOnly**: The proxy terminal supports only read requests.
        /// </summary>
        [NameInMap("DbProxyEndpointReadWriteMode")]
        [Validation(Required=false)]
        public string DbProxyEndpointReadWriteMode { get; set; }

        /// <summary>
        /// An array that consists of the information about the proxy endpoint.
        /// </summary>
        [NameInMap("EndpointConnectItems")]
        [Validation(Required=false)]
        public DescribeDBProxyEndpointResponseBodyEndpointConnectItems EndpointConnectItems { get; set; }
        public class DescribeDBProxyEndpointResponseBodyEndpointConnectItems : TeaModel {
            [NameInMap("EndpointConnectItems")]
            [Validation(Required=false)]
            public List<DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems> EndpointConnectItems { get; set; }
            public class DescribeDBProxyEndpointResponseBodyEndpointConnectItemsEndpointConnectItems : TeaModel {
                /// <summary>
                /// The proxy endpoint queried.
                /// </summary>
                [NameInMap("DbProxyEndpointConnectString")]
                [Validation(Required=false)]
                public string DbProxyEndpointConnectString { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **0**: Internet
                /// *   **1**: classic network
                /// *   **2**: virtual private cloud (VPC)
                /// </summary>
                [NameInMap("DbProxyEndpointNetType")]
                [Validation(Required=false)]
                public string DbProxyEndpointNetType { get; set; }

                /// <summary>
                /// The port number that is associated with the proxy endpoint. Default value: **3306**.
                /// </summary>
                [NameInMap("DbProxyEndpointPort")]
                [Validation(Required=false)]
                public string DbProxyEndpointPort { get; set; }

            }

        }

        /// <summary>
        /// The method that is used to assign read weights. For more information, see [Modify the latency threshold and read weights of ApsaraDB RDS for MySQL instances](~~96076~~). Valid values:
        /// 
        /// *   **Standard**: The system automatically assigns read weights to the instance and its read-only instances based on the specifications of these instances.
        /// *   **Custom**: You must manually assign read weights to the instance and its read-only instances.
        /// </summary>
        [NameInMap("ReadOnlyInstanceDistributionType")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceDistributionType { get; set; }

        /// <summary>
        /// The latency threshold that is allowed for read/write splitting. If the latency on a read-only instance exceeds the specified threshold, ApsaraDB RDS no longer forwards read requests to the read-only instance.
        /// </summary>
        [NameInMap("ReadOnlyInstanceMaxDelayTime")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceMaxDelayTime { get; set; }

        /// <summary>
        /// The read weights of the instance and its read-only instances. The value of this parameter is a JSON string that consists of the following parameters:
        /// 
        /// *   **DBInstanceId**: the ID of the instance.
        /// *   **DBInstanceType**: the role of the instance. Valid values: **Master** and **ReadOnly**.
        /// *   **NodeID**: The IDs of the primary and secondary nodes of the cluster. An instance that runs RDS Cluster Edition refers to a cluster.
        /// *   **NodeType**: The node type. Valid values: **Primary** and **Secondary**.
        /// *   **Weight**: the read weight of the instance. The read weight increases in increments of **100** and cannot exceed **10000**.
        /// </summary>
        [NameInMap("ReadOnlyInstanceWeight")]
        [Validation(Required=false)]
        public string ReadOnlyInstanceWeight { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
