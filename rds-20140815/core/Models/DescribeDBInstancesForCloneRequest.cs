// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesForCloneRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The connection mode of the instance. Valid values:
        /// 
        /// *   **Standard**: standard mode
        /// *   **Safe**: database proxy mode
        /// 
        /// By default, this operation queries the instances that use any of the supported connection modes.
        /// </summary>
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// The ID of the current instance.
        /// </summary>
        [NameInMap("CurrentInstanceId")]
        [Validation(Required=false)]
        public string CurrentInstanceId { get; set; }

        /// <summary>
        /// The instance type of the instance. For more information, see [Instance types](https://help.aliyun.com/document_detail/26312.html).
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The status of the instance. For more information, see [Instance state table](https://help.aliyun.com/document_detail/26315.html).
        /// </summary>
        [NameInMap("DBInstanceStatus")]
        [Validation(Required=false)]
        public string DBInstanceStatus { get; set; }

        /// <summary>
        /// The role of the instance that you want to query. Valid values:
        /// 
        /// *   **Primary**: primary instance
        /// *   **Readonly**: read-only instance
        /// *   **Guard**: disaster recovery instance
        /// *   **Temp**: temporary instance
        /// 
        /// By default, this operation queries the instances of all roles.
        /// </summary>
        [NameInMap("DBInstanceType")]
        [Validation(Required=false)]
        public string DBInstanceType { get; set; }

        /// <summary>
        /// The database engine of the instance. Valid values:
        /// 
        /// *   MySQL
        /// *   SQLServer
        /// *   PostgreSQL
        /// *   PPAS
        /// *   MariaDB
        /// 
        /// By default, this operation queries the instances that run any of the supported database engine types.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version of the database engine.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Specifies whether the instance expires. Valid values:
        /// 
        /// *   **True**: queries the instances that have expired.
        /// *   **False**: does not query instances that have expired.
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **Classic**
        /// *   **VPC**
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The type of the database node. Valid values:
        /// 
        /// *   **Master**: the primary node
        /// *   **Slave**: the secondary node
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1 to 100**.
        /// 
        /// Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **Postpaid**: pay-as-you-go
        /// *   **Prepaid**: subscription
        /// 
        /// By default, this operation queries the instances that use any of the supported billing methods.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The keyword that is used for the search. The keyword can be part of an instance ID or an instance description.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The zone ID of the instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// The ID of the proxy mode.
        /// </summary>
        [NameInMap("proxyId")]
        [Validation(Required=false)]
        public string ProxyId { get; set; }

    }

}
