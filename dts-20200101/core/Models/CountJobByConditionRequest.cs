// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CountJobByConditionRequest : TeaModel {
        /// <summary>
        /// The type of the destination database.
        /// </summary>
        [NameInMap("DestDbType")]
        [Validation(Required=false)]
        public string DestDbType { get; set; }

        /// <summary>
        /// The ID of the DTS task.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The type of the DTS task. Valid values:
        /// 
        /// *   **MIGRATION**: data migration task
        /// *   **SYNC**: data synchronization task
        /// *   **SUBSCRIBE**: change tracking task
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// The content of the query condition, which corresponds to the value of the JobType parameter.
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// One of the query conditions. The ID of the region. For more information, see [Supported regions](~~141033~~).
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The ID of the region in which the DTS instance resides. For more information, see [Supported regions](~~141033~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The type of the source database.
        /// </summary>
        [NameInMap("SrcDbType")]
        [Validation(Required=false)]
        public string SrcDbType { get; set; }

        /// <summary>
        /// The status of the DTS task.
        /// 
        /// Valid values for a data migration task:
        /// 
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is in precheck.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **PreCheckPass**: The task passed the precheck.
        /// *   **NotConfigured**: The task is not configured.
        /// *   **Migrating**: The task is in progress.
        /// *   **Suspending**: The task is paused.
        /// *   **MigrationFailed**: The task failed to migrate data.
        /// *   **Finished**: The task is complete.
        /// *   **Retrying**: The task is being retried.
        /// *   **Upgrade**: The task is being upgraded.
        /// *   **Locked**: The task is locked.
        /// *   **Downgrade**: The task is being downgraded.
        /// 
        /// Valid values for a data synchronization task:
        /// 
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is in precheck.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **PreCheckPass**: The task passed the precheck.
        /// *   **NotConfigured**: The task is not configured.
        /// *   **Initializing**: The task is performing initial synchronization.
        /// *   **InitializeFailed**: Initial synchronization failed.
        /// *   **Synchronizing**: The task is in progress.
        /// *   **Failed**: The task failed to synchronize data.
        /// *   **Suspending**: The task is paused.
        /// *   **Modifying**: The objects in the task are being modified.
        /// *   **Finished**: The task is complete.
        /// *   **Retrying**: The task is being retried.
        /// *   **Upgrade**: The task is being upgraded.
        /// *   **Locked**: The task is locked.
        /// *   **Downgrade**: The task is being downgraded.
        /// 
        /// Valid values for a change tracking task:
        /// 
        /// *   **NotConfigured**: The task is not configured.
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is in precheck.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **PreCheckPass**: The task passed the precheck.
        /// *   **Starting**: The task is being started.
        /// *   **Normal**: The task is running as expected.
        /// *   **Retrying**: The task is being retried.
        /// *   **Abnormal**: The task is not running as expected.
        /// *   **Upgrade**: The task is being upgraded.
        /// *   **Locked**: The task is locked.
        /// *   **Downgrade**: The task is being downgraded.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The content of the query condition. Valid values:
        /// 
        /// *   **name**: the name of the task
        /// *   **rds**: the ID of the destination instance
        /// *   **instance**: the ID of the Data Transmission Service (DTS) instance
        /// *   **srcRds**: the ID of the source instance
        /// 
        /// > The value of this parameter corresponds to the value of the **JobType** parameter.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
