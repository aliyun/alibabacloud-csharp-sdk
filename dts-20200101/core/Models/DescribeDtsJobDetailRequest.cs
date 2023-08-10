// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsJobDetailRequest : TeaModel {
        /// <summary>
        /// DescribeDtsJobDetail
        /// </summary>
        [NameInMap("DtsInstanceID")]
        [Validation(Required=false)]
        public string DtsInstanceID { get; set; }

        /// <summary>
        /// The state of the data migration or data synchronization task.
        /// 
        /// Valid values for a data migration task:
        /// 
        /// *   **NotStarted**: The migration is not started.
        /// *   **Migrating**: The migration is in progress.
        /// *   **Failed**: The migration failed.
        /// *   **Finished**: The migration is complete.
        /// 
        /// Valid values for a data synchronization task:
        /// 
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is in precheck.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **Initializing**: The task is performing initial synchronization.
        /// *   **InitializeFailed**: Initial synchronization failed.
        /// *   **Synchronizing**: The task is in progress.
        /// *   **Failed**: The task failed to synchronize data.
        /// *   **Suspending**: The task is paused.
        /// *   **Modifying**: The objects in the task are being modified.
        /// *   **Finished**: The task is complete.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking task.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SyncSubJobHistory")]
        [Validation(Required=false)]
        public bool? SyncSubJobHistory { get; set; }

        /// <summary>
        /// Queries the details of a data migration, data synchronization, or change tracking task.
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

    }

}
