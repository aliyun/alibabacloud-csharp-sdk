// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetUpgradeStatusResponseBody : TeaModel {
        /// <summary>
        /// The error message returned during the update.
        /// </summary>
        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the precheck report.
        /// </summary>
        [NameInMap("precheck_report_id")]
        [Validation(Required=false)]
        public string PrecheckReportId { get; set; }

        /// <summary>
        /// The status of the update. Valid values:
        /// 
        /// *   `success`: The update is successful.
        /// *   `fail`: The update failed.
        /// *   `pause`: The update is paused.
        /// *   `running`: The update is in progress.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The current phase of the update. Valid values:
        /// 
        /// *   `not_start`: The update is not started.
        /// *   `prechecking`: The precheck is in progress.
        /// *   `upgrading`: The cluster is being updated.
        /// *   `pause`: The update is paused.
        /// *   `success`: The update is successful.
        /// </summary>
        [NameInMap("upgrade_step")]
        [Validation(Required=false)]
        public string UpgradeStep { get; set; }

        /// <summary>
        /// The details of the update task.
        /// </summary>
        [NameInMap("upgrade_task")]
        [Validation(Required=false)]
        public GetUpgradeStatusResponseBodyUpgradeTask UpgradeTask { get; set; }
        public class GetUpgradeStatusResponseBodyUpgradeTask : TeaModel {
            /// <summary>
            /// The description of the update task.
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The status of the update task. Valid values:
            /// 
            /// *   `running`: The update task is being executed.
            /// *   `Success`: The update task is successfully executed.
            /// *   `Failed`: The update task failed.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
