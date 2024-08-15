// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancesRequest : TeaModel {
        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   **Basic**: RDS Basic Edition
        /// *   **HighAvailability**: RDS High-availability Edition
        /// *   **cluster**: RDS Cluster Edition
        /// *   **serverless_basic**: RDS Serverless Basic Edition
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

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
        /// The endpoint of the instance. You must specify this parameter only when you want to query a single instance.
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The instance type of the instance. For information, see [Primary ApsaraDB RDS instance types](https://help.aliyun.com/document_detail/26312.html).
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The status of the instance. For more information, see [Instance states](https://help.aliyun.com/document_detail/26315.html).
        /// </summary>
        [NameInMap("DBInstanceStatus")]
        [Validation(Required=false)]
        public string DBInstanceStatus { get; set; }

        /// <summary>
        /// The role of the instance. Valid values:
        /// 
        /// *   **Primary**: primary instance
        /// *   **Readonly**: read-only instance
        /// *   **Guard**: disaster recovery instance
        /// *   **Temp**: temporary instance
        /// 
        /// By default, this operation returns the instances that assume any of the supported roles.
        /// </summary>
        [NameInMap("DBInstanceType")]
        [Validation(Required=false)]
        public string DBInstanceType { get; set; }

        /// <summary>
        /// The dedicated cluster ID.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The host ID of the instance in the dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The database engine of the instance. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **SQLServer**
        /// *   **PostgreSQL**
        /// *   **MariaDB**
        /// 
        /// By default, this operation returns the instances that run any of the supported database engines.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Specifies whether to query instances that have expired. Valid values:
        /// 
        /// *   **True**: queries instances that have expired.
        /// *   **False**: does not query instances that have expired.
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public string Expired { get; set; }

        /// <summary>
        /// The JSON string that consists of filter condition parameters and their values.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// Specifies whether to return the RDS edition of the instance by using the Category parameter. Valid values:
        /// 
        /// *   **0**: returns the RDS edition of the instance.
        /// *   **1**: does not return the RDS edition of the instance.
        /// </summary>
        [NameInMap("InstanceLevel")]
        [Validation(Required=false)]
        public int? InstanceLevel { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **VPC**
        /// *   **Classic**
        /// 
        /// By default, this operation returns the instances that reside in any of the supported network types.
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// The number of entries to return per page. Valid values: **1 to 100**.
        /// 
        /// Default value: **30**.
        /// 
        /// > If you specify this parameter, **PageSize** and **PageNumber** are unavailable.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to display the next page. You must set this parameter to the value that is returned from the most recent call of the **DescribeDBInstances** operation for **NextToken**. If the returned entries are displayed on multiple pages, the next page can be displayed when you call this operation again with this parameter specified.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Valid values: any non-zero positive integer.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**.
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
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
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
        /// The keyword that is used for fuzzy search. The keyword can be part of an instance ID or an instance description.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The tag that is added to the instance. Each tag is a key-value pair that consists of two fields: TagKey and TagValue. You can specify a maximum of five tags in the following format for each request: {"key1":"value1","key2":"value2"...}.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The vSwitch ID.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The VPC ID.
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
        /// A deprecated parameter. You do not need to configure this parameter.
        /// </summary>
        [NameInMap("proxyId")]
        [Validation(Required=false)]
        public string ProxyId { get; set; }

    }

}
