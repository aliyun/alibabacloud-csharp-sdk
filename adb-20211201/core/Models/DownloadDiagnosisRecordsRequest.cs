// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DownloadDiagnosisRecordsRequest : TeaModel {
        /// <summary>
        /// The source IP address.
        /// 
        /// >  You can call the [DescribeDiagnosisDimensions](~~308210~~) operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the database on which the SQL statements are executed.
        /// 
        /// >  You can call the [DescribeDiagnosisDimensions](~~308210~~) operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// The end of the time range to query. Set the time to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
        /// The query keyword of the SQL statements.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The language. Valid values:
        /// 
        /// *   **zh**: simplified Chinese.
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
        /// The query condition for SQL statements, which can contain the `Type`, `Value`, `Min`, and `Max` fields. Specify the condition in the JSON format. `Type` specifies the query dimension. Valid values for Type: `maxCost`, `status`, and `cost`. `Value`, `Min`, or `Max` specifies the query range for the dimension. Valid values:
        /// 
        /// *   `{"Type":"maxCost","Value":"100"}`: queries the top 100 most time-consuming SQL statements. Set `Value` to 100.
        /// *   `{"Type":"status","Value":"finished"}`: queries the executed SQL statements. You can set `Value` to `running` to query the SQL statements that are being executed. You can also set Value to `failed` to query the SQL statements that failed to be executed.
        /// *   `{"Type":"cost","Min":"10","Max":"200"}`: queries the SQL statements whose execution duration is in the range of 10 to 200 milliseconds. You can also specify custom values for the Min and Max fields.
        /// </summary>
        [NameInMap("QueryCondition")]
        [Validation(Required=false)]
        public string QueryCondition { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group to which the SQL statements belong.
        /// 
        /// >  You can call the [DescribeDiagnosisDimensions](~~308210~~) operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Set the time to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// >  You can query data only within the last 14 days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The username that is used to execute the SQL statements.
        /// 
        /// >  You can call the [DescribeDiagnosisDimensions](~~~~) operation to query the resource groups, database names, usernames, and source IP addresses of the SQL statements that meet a query condition.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
