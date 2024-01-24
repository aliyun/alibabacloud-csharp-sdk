// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ManagePrivateRdsRequest : TeaModel {
        /// <summary>
        /// The ID of the custom ApsaraDB RDS instance at the storage layer.
        /// 
        /// > You can call the [DescribeDrdsRdsInstances](~~215526~~) operation to query the details of all ApsaraDB RDS instances, including the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// 
        /// > You can call the [DescribeDrdsInstances](~~139284~~) operation to query the details of all PolarDB-X 1.0 instances within an Alibaba Cloud account, including the IDs of the instances.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The JSON string that consists of request parameters and the values of the request parameters of an operation that you need to call for the custom ApsaraDB RDS instance. The value of a request parameter is of the STRING type. Example: `{NodeId:"1797****"}`.
        /// 
        /// For more information about the request parameters and valid values of the request parameters of each operation, see the request parameter sections in the following topics:
        /// 
        /// *   [DescribeDBInstanceAttribute](~~26231~~)
        /// *   [DescribeAvailableClasses](~~196546~~)
        /// *   [DescribeSQLCollectorPolicy](~~26292~~)
        /// *   [ModifySQLCollectorPolicy](~~26293~~)
        /// *   [DescribeParameters](~~26285~~)
        /// *   [ModifyParameter](~~26286~~)
        /// *   [DescribeDBInstanceHAConfig](~~26244~~)
        /// *   [SwitchDBInstanceHA](~~26251~~)
        /// 
        /// > Among the required request parameters of the preceding operations, you do not need to specify the `Action` and `DBInstanceId` parameters. You must specify all the other required request parameters.
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// The operation that you want to perform on the custom ApsaraDB RDS instance. Valid values:
        /// 
        /// *   **DescribeDBInstanceAttribute**: queries the details of the custom ApsaraDB RDS instance.
        /// *   **DescribeAvailableClasses**: queries the specifications that are supported for a custom ApsaraDB RDS instance. The specifications include the instance type and the storage capacity.
        /// *   **DescribeSQLCollectorPolicy**: queries whether the SQL Explorer (SQL Audit) feature is enabled for custom ApsaraDB RDS instance.
        /// *   **ModifySQLCollectorPolicy**: enables or disables the SQL Explorer (SQL Audit) feature for the custom ApsaraDB RDS instance.
        /// *   **DescribeParameters**: queries the parameter settings of the custom ApsaraDB RDS instance.
        /// *   **ModifyParameter**: modifies the parameters of the custom ApsaraDB RDS instance.
        /// *   **DescribeDBInstanceHAConfig**: queries the high availability mode and data replication mode of the custom ApsaraDB RDS instance.
        /// *   **SwitchDBInstanceHA**: switches workloads between the primary and secondary custom ApsaraDB RDS instances.
        /// </summary>
        [NameInMap("RdsAction")]
        [Validation(Required=false)]
        public string RdsAction { get; set; }

        /// <summary>
        /// The ID of the region in which the PolarDB-X 1.0 instance resides.
        /// 
        /// > You can call the [DescribeDrdsInstances](~~139284~~) operation to query the details of all PolarDB-X 1.0 instances within an Alibaba Cloud account, including the IDs of regions in which the instances reside.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
