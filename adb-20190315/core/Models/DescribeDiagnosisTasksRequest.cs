// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisTasksRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The IP address from which the query was initiated.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The order in which to sort the tasks by field. Specify the value in the JSON format. Example: `[{"Field":"CreateTime", "Type":"desc"}]`.
        /// 
        /// > 
        /// 
        /// *   `Field` indicates the field that is used to sort the tasks. Valid values of Field: `State`, `CreateTime`, `DBName`, `ProcessID`, `UpdateTime`, `JobName`, and `ProcessRows`.
        /// 
        /// *   `Type` indicates the sort type. Valid values of Type: `Desc` and `Asc`. The values are case-insensitive.
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   30 (default)
        /// *   50
        /// *   100
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The query ID.
        /// 
        /// > You can call the [DescribeProcessList](~~190092~~) operation to query the IDs of queries that are being executed.
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of a stage in the query that is specified by the `ProcessId` parameter.
        /// </summary>
        [NameInMap("StageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        /// <summary>
        /// The state of the asynchronous import or export task to be queried. Valid values:
        /// 
        /// *   **RUNNING**
        /// *   **FINISHED**
        /// *   **FAILED**
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
