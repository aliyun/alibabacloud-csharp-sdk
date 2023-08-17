// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisRecordsRequest : TeaModel {
        /// <summary>
        /// The source IP address.
        /// 
        /// > You can call the [DescribeDiagnosisDimensions](~~308210~~) operation to query the resource group, database name, username, and source IP address of the SQL statements to be queried.
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the information about all AnalyticDB for MySQL clusters within a region, including cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The database on which the SQL statements are executed.
        /// 
        /// > You can call the [DescribeDiagnosisDimensions](~~308210~~) operation to query the resource group, database name, username, and source IP address of the SQL statements to be queried.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
        /// The keyword for the query.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The language of file titles and error messages. Valid values:
        /// 
        /// *   **zh** (default): simplified Chinese.
        /// *   **en**: English.
        /// *   **ja**: Japanese.
        /// *   **zh-tw**: traditional Chinese.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The maximum peak memory of the SQL statements. Unit: bytes.
        /// </summary>
        [NameInMap("MaxPeakMemory")]
        [Validation(Required=false)]
        public long? MaxPeakMemory { get; set; }

        /// <summary>
        /// The maximum scan size of the SQL statements. Unit: bytes.
        /// </summary>
        [NameInMap("MaxScanSize")]
        [Validation(Required=false)]
        public long? MaxScanSize { get; set; }

        /// <summary>
        /// The minimum peak memory of the SQL statements. Unit: bytes.
        /// </summary>
        [NameInMap("MinPeakMemory")]
        [Validation(Required=false)]
        public long? MinPeakMemory { get; set; }

        /// <summary>
        /// The minimum scan size of the SQL statements. Unit: bytes.
        /// </summary>
        [NameInMap("MinScanSize")]
        [Validation(Required=false)]
        public long? MinScanSize { get; set; }

        /// <summary>
        /// The order in which to sort the retrieved SQL statements by field. Specify this value in the JSON format. The value is an ordered array that uses the order of the input array and contains the `Field` and `Type` fields. Example: `[{"Field":"StartTime", "Type": "desc" }]`. Fields:
        /// 
        /// *   `Field` specifies the field that is used to sort the retrieved SQL statements. Valid values:
        /// 
        ///     *   `StartTime`: the start time of the execution.
        ///     *   `Status`: the execution state.
        ///     *   `UserName`: the username.
        ///     *   `Cost`: the execution duration.
        ///     *   `PeakMemory`: the peak memory.
        ///     *   `ScanSize`: the amount of data to be scanned.
        ///     *   `Database`: the name of the database.
        ///     *   `ClientIp`: the source IP address.
        ///     *   `ResourceGroup`: the name of the resource group.
        ///     *   `QueueTime`: the amount of time that is consumed for queuing.
        ///     *   `OutputRows`: the number of output rows.
        ///     *   `OutputDataSize`: the amount of output data.
        ///     *   `ResourceCostRank`: the execution duration rank of operators that are used in the SQL statements. This field takes effect only when `QueryCondition` is set to `{"Type":"status","Value":"running"}`.
        /// 
        /// *   `Type` specifies the sorting order. Valid values (case-insensitive):
        /// 
        ///     *   `Desc`: descending order.
        ///     *   `Asc`: ascending order.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **30**, **50**, and **100**. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the SQL pattern.[](~~321868~~)
        /// </summary>
        [NameInMap("PatternId")]
        [Validation(Required=false)]
        public string PatternId { get; set; }

        /// <summary>
        /// The query condition for SQL statements, which can contain the `Type`, `Value`, and `Min` or `Max` fields. Specify the condition in the JSON format. `Type` specifies the query dimension. Valid values for Type: `maxCost`, `status`, and `cost`. `Value`, `Min`, or `Max` specifies the query range for the dimension. Valid values:
        /// 
        /// *   `{"Type":"maxCost","Value":"100"}`: queries the top 100 most time-consuming SQL statements. Set `Value` to 100.
        /// *   `{"Type":"status","Value":"finished"}`: queries executed SQL statements. You can set `Value` to `running` to query SQL statements that are being executed. You can also set Value to `failed` to query SQL statements that failed to be executed.
        /// *   `{"Type":"cost","Min":"10","Max":"200"}`: queries SQL statements whose execution durations are in the range of 10 to 200 milliseconds. You can also customize the maximum and minimum execution durations.
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group to which the SQL statements belong.
        /// 
        /// > You can call the [DescribeDiagnosisDimensions](~~308210~~) operation to query the resource group, database name, username, and source IP address of the SQL statements to be queried.
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// > Only data within the last 14 days can be queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The username that is used to execute the SQL statements.
        /// 
        /// > You can call the [DescribeDiagnosisDimensions](~~308210~~) operation to query the resource group, database name, username, and source IP address of the SQL statements to be queried.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
