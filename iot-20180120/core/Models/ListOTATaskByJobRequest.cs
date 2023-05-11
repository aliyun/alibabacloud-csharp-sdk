// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTATaskByJobRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Pages start from page 1.
        /// 
        /// > The product of the value of the **CurrentPage** parameter and the value of the **PageSize** parameter must be less than or equal to 100,000.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DeviceNames")]
        [Validation(Required=false)]
        public List<string> DeviceNames { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must specify the ID for this parameter. Otherwise, the call fails.
        /// >*   If no **Overview** page or ID is generated for your instance, you do not need to configure this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the update batch. This ID uniquely identifies the update batch. You can obtain the ID from the value of the **JobId** parameter that is returned after you call the [CreateOTAVerifyJob](~~147480~~), [CreateOTAStaticUpgradeJob](~~147496~~), or [CreateOTADynamicUpgradeJob](~~147887~~) operation. You can also view the batch ID on the **Firmware Details** page of the IoT Platform console.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100.
        /// 
        /// 
        /// 
        /// > The product of the value of the **CurrentPage** parameter and the value of the **PageSize** parameter must be less than or equal to 100,000.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// If you specify a value for this parameter, only the update tasks that are in the specified state are queried. Valid values:
        /// 
        /// *   **CONFIRM**: The update task is pending confirmation.
        /// *   **QUEUED**: The update notification is to be pushed.
        /// *   **NOTIFIED**: The update notification is pushed to the device.
        /// *   **IN_PROGRESS**: The update task is in progress.
        /// *   **SUCCEEDED**: The update is successful.
        /// *   **FAILED**: The update failed.
        /// *   **CANCELED**: The update batch is canceled.
        /// 
        /// If you do not specify a value for this parameter, all update tasks of the specified batch are queried.
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
