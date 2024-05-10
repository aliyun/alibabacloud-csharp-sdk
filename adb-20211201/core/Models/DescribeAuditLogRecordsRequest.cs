// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAuditLogRecordsRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/454250.html) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the database on which the SQL statement was executed.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   The end time must be later than the start time.
        /// 
        /// *   The maximum time range that can be specified is 24 hours.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The IP address and port number of the client that is used to execute the SQL statement.
        /// </summary>
        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        /// <summary>
        /// The order in which to sort the retrieved entries by field. Specify this parameter in the JSON format. The value is an ordered array that uses the order of the input array and contains `Field` and `Type`. Example: `[{"Field":"ExecutionStartTime","Type":"Desc"},{"Field":"ScanRows","Type":"Asc"}]`. Fields:
        /// 
        /// *   `Field`: the field that is used to sort the retrieved entries. Valid values:
        /// 
        ///     *   **HostAddress**: the IP address of the client that is used to connect to the database.
        ///     *   **UserName**: the username.
        ///     *   **ExecutionStartTime**: the start time of the query execution.
        ///     *   **QueryTime**: the amount of time consumed to execute the SQL statement.
        ///     *   **PeakMemoryUsage**: the maximum memory usage when the SQL statement is executed.
        ///     *   **ScanRows**: the number of rows to be scanned from a data source in the task.
        ///     *   **ScanSize**: the amount of data to be scanned.
        ///     *   **ScanTime**: the total amount of time consumed to scan data.
        ///     *   **PlanningTime**: the amount of time consumed to generate execution plans.
        ///     *   **WallTime**: the accumulated CPU Time values of all operators in the query on each node.
        ///     *   **ProcessID**: the process ID.
        /// 
        /// *   `Type`: the sorting type of the retrieved entries. Valid values:
        /// 
        ///     *   **Desc**: descending order.
        ///     *   **Asc**: ascending order.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The sorting order of the retrieved entries. Valid values:
        /// 
        /// *   **asc**: sorts the retrieved entries by time in ascending order.
        /// *   **desc**: sorts the retrieved entries by time in descending order.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **10** (default)
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// A reserved parameter.
        /// </summary>
        [NameInMap("ProxyUser")]
        [Validation(Required=false)]
        public string ProxyUser { get; set; }

        /// <summary>
        /// The keyword based on which audit logs are queried. You can set this parameter to a value of the STRING type.
        /// </summary>
        [NameInMap("QueryKeyword")]
        [Validation(Required=false)]
        public string QueryKeyword { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/454314.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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

        /// <summary>
        /// The type of the SQL statement. Valid values:
        /// 
        /// *   **DELETE**
        /// *   **SELECT**
        /// *   **UPDATE**
        /// *   **INSERT INTO SELECT**
        /// *   **ALTER**
        /// *   **DROP**
        /// *   **CREATE**
        /// 
        /// >  You can query only a single type of SQL statements at a time. If you leave this parameter empty, the **SELECT** statements are queried.
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.
        /// 
        /// > SQL audit logs can be queried only when SQL audit is enabled. Only SQL audit logs within the last 30 days can be queried. If SQL audit was disabled and re-enabled, only SQL audit logs from the time when SQL audit was re-enabled can be queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Specifies whether the execution of the SQL statement succeeds. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Succeed")]
        [Validation(Required=false)]
        public string Succeed { get; set; }

        /// <summary>
        /// The username that is used to execute the SQL statement.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
