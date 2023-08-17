// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSlowLogRecordsRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the cluster IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a specific region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time must be in UTC.
        /// 
        /// >  The end time must be later than the start time. The specified time range must be less than seven days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The order in which to sort the retrieved entries by field. Specify this parameter in the JSON format. The value is an ordered array that uses the order of the input array and contains `Field` and `Type`. Example: `[{"Field":"ExecutionStartTime","Type":"Desc"},{"Field":"ScanRows","Type":"Asc"}]`.
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
        ///     *   **ProcessID**: the ID of the process.
        /// 
        /// *   `Type`: the sorting type of the retrieved entries. Valid values:
        /// 
        ///     *   **Desc**: descending order
        ///     *   **Asc**: ascending order
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **30**, **50**, and **100**. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the process.
        /// </summary>
        [NameInMap("ProcessID")]
        [Validation(Required=false)]
        public string ProcessID { get; set; }

        /// <summary>
        /// The range conditions used to filter specified fields, including `Max` and `Min`. Specify this parameter in the JSON format. Example: `[{"Field":"ScanSize","Min":"1000000","Max":"10000000"},{"Field":"QueryTime","Min":"1000","Max":"10000"}]`.
        /// 
        /// `Field`: the field to be filtered. Valid values:
        /// 
        /// *   **ScanSize**: the amount of data to be scanned. Unit: KB.
        /// *   **QueryTime**: the amount of time consumed to execute the statement. Unit: milliseconds.
        /// *   **PeakMemoryUsage**: the maximum memory usage when the SQL statement is executed. Unit: KB.
        /// 
        /// >  `Min` indicates the minimum value of the query range (left operand). `Max` indicates the maximum value of the query range (right operand). Max and Min are both of the String type.
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The state of the query. Valid values:
        /// 
        /// *   **Successed**: successful
        /// *   **Failed**: failed
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
