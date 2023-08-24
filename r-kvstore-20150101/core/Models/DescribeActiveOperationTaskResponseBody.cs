// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeActiveOperationTaskResponseBody : TeaModel {
        /// <summary>
        /// The time when the system performs the switchover operation. The time in UTC is displayed in the *yyyy-MM-dd*T*HH:mm:ss*Z format.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeActiveOperationTaskResponseBodyItems> Items { get; set; }
        public class DescribeActiveOperationTaskResponseBodyItems : TeaModel {
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// Queries the information about operations and maintenance (O&M) tasks for an ApsaraDB for Redis instance.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The time when the O\&M task was modified. The time in UTC is displayed in the *yyyy-MM-dd*T*HH:mm:ss*Z format.
            /// </summary>
            [NameInMap("Deadline")]
            [Validation(Required=false)]
            public string Deadline { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("InsName")]
            [Validation(Required=false)]
            public string InsName { get; set; }

            /// <summary>
            /// The maximum number of entries that were returned per page.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// *   **rds_apsaradb_ha**: switchover between a master node and a replica node.
            /// *   **rds_apsaradb_transfer**: instance migration task.
            /// *   **rds_apsaradb_upgrade**: minor version upgrade.
            /// *   **all**: all task types.
            /// </summary>
            [NameInMap("PrepareInterval")]
            [Validation(Required=false)]
            public string PrepareInterval { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The required preparation period between the task start time and the switchover time. The time is displayed in the *HH:mm:ss* format.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

            /// <summary>
            /// The number of entries to return on each page. Specify a value greater than **10**. Default value: **30**.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// The number of the page to return. It must be an integer that is greater than **0** and less than or equal to the maximum value supported by the integer data type. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The time when the O\&M task was executed. The time in UTC is displayed in the *yyyy-MM-dd*T*HH:mm:ss*Z format.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the region to which pending events belong. You can call the [DescribeRegions](~~61012~~) operation to query the region IDs.
        /// 
        /// >  A value of **all** indicates all region IDs.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
