// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CancelOTATaskByJobRequest : TeaModel {
        /// <summary>
        /// Specifies whether to cancel the update tasks that are in the **IN_PROGRESS** state in an update batch. Default value: false. Valid values:
        /// 
        /// *   **true**: cancel the update tasks that are in the IN_PROGRESS state.
        /// *   **false**: do not cancel the update tasks that are in the IN_PROGRESS state.
        /// </summary>
        [NameInMap("CancelInProgressTask")]
        [Validation(Required=false)]
        public bool? CancelInProgressTask { get; set; }

        /// <summary>
        /// Specifies whether to cancel the update tasks that are in the **NOTIFIED** state in an update batch. Default value: false. Valid values:
        /// 
        /// *   **true**: cancel the update tasks that are in the NOTIFIED state.
        /// *   **false**: do not cancel the update tasks that are in the NOTIFIED state.
        /// </summary>
        [NameInMap("CancelNotifiedTask")]
        [Validation(Required=false)]
        public bool? CancelNotifiedTask { get; set; }

        /// <summary>
        /// Specifies whether to cancel the update tasks that are in the **QUEUED** state in an update batch. Default value: false. Valid values:
        /// 
        /// *   **true**: cancel the update tasks that are in the NOTIFIED state.
        /// *   **false**: do not cancel the update tasks that are in the NOTIFIED state.
        /// 
        /// > If you set this parameter to **true** and specify the **CancelUnconfirmedTask** parameter, only the update tasks that are in the QUEUED state are canceled. If you do not specify the **CancelUnconfirmedTask** parameter, the update tasks that are in the QUEUED or CONFIRM state are canceled.
        /// </summary>
        [NameInMap("CancelQueuedTask")]
        [Validation(Required=false)]
        public bool? CancelQueuedTask { get; set; }

        /// <summary>
        /// Specifies whether to cancel update tasks of a scheduled update batch. If you specify the **ScheduleTime** parameter when you call the [CreateOTAStaticUpgradeJob](~~147496~~) operation, a scheduled update batch is created. Default value: false. Valid values:
        /// 
        /// *   **true**: cancel update tasks of a scheduled update batch.
        /// *   **false**: do not cancel update tasks of a scheduled update batch.
        /// </summary>
        [NameInMap("CancelScheduledTask")]
        [Validation(Required=false)]
        public bool? CancelScheduledTask { get; set; }

        /// <summary>
        /// Specifies whether to cancel the update tasks that are in the **CONFIRM** state in an update batch. Default value: false. Valid values:
        /// 
        /// *   **true**: cancel the update tasks that are in the CONFIRM state.
        /// *   **false**: do not cancel the update tasks that are in the CONFIRM state.
        /// 
        /// This parameter is empty by default.
        /// 
        /// > If you do not specify this parameter and set the **CancelQueuedTask** parameter to **true**, the update tasks that are in the CONFIRM state are canceled. If you set the **CancelQueuedTask** parameter to **false**, the update tasks that are in the CONFIRM state are not canceled.
        /// </summary>
        [NameInMap("CancelUnconfirmedTask")]
        [Validation(Required=false)]
        public bool? CancelUnconfirmedTask { get; set; }

        /// <summary>
        /// The ID of the instance. You can obtain the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify this parameter. Otherwise, the call fails.
        /// >*   If the **Overview** page or an instance ID is not displayed in the IoT Platform console, ignore this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the update batch.
        /// 
        /// Use the value that is returned for the **JobId** parameter contained in the response of the [CreateOTAStaticUpgradeJob](~~147496~~) or [CreateOTADynamicUpgradeJob](~~147887~~) operation. You can also obtain the batch ID on the **Firmware Details** page of the IoT Platform console.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
