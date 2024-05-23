// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// The filter condition that is used to return tasks based on the settings of task cancellation. Default value: -1. Valid values:
        /// 
        /// *   **-1**: returns all tasks.
        /// *   **0**: returns only tasks that cannot be canceled.
        /// *   **1**: returns only tasks that can be canceled.
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public int? AllowCancel { get; set; }

        /// <summary>
        /// The filter condition that is used to return tasks based on the settings of the switching time. Default value: -1. Valid values:
        /// 
        /// *   **-1**: returns all tasks.
        /// *   **0**: returns only tasks for which the switching time cannot be changed.
        /// *   **1**: returns only tasks for which the switching time can be changed.
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public int? AllowChange { get; set; }

        /// <summary>
        /// The filter condition that is used to return tasks based on the task level. Default value: all. Valid values:
        /// 
        /// *   **all**: all types
        /// *   **S0**: returns the tasks of the exception fixing level.
        /// *   **S1**: returns the tasks of the system O\\&M level.
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// The type of the database. Default value: all. Valid values: mysql, pgsql, and mssql.
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The name of the instance. You can leave this parameter empty. If you configure this parameter, you can specify the name only of one instance.
        /// </summary>
        [NameInMap("InsName")]
        [Validation(Required=false)]
        public string InsName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 25. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the service. Valid values: RDS, POLARDB, MongoDB, and Redis. For RDS instances, set the value to RDS.
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The region ID of the pending event. You can call the DescribeRegions operation to query the most recent region list.
        /// 
        /// >  The value **all** indicates all regions.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The status of the task, which is used as a filter condition to return tasks.
        /// 
        /// *   **-1**: all tasks
        /// *   **3**: pending
        /// *   **4**: being processed
        /// *   **5**: completed
        /// *   **6**: failed
        /// *   **7**: canceled
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// *   **rds_apsaradb_ha**: primary/secondary switchover
        /// *   **rds_apsaradb_transfer**: instance migration
        /// *   **rds_apsaradb_upgrade**: update of the minor engine version
        /// *   **rds_apsaradb_maxscale**: update of the minor version of the proxy
        /// *   **all**: all types
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
