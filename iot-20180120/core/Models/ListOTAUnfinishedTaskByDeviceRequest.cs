// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAUnfinishedTaskByDeviceRequest : TeaModel {
        /// <summary>
        /// The DeviceName of the device.
        /// 
        /// > If you specify this parameter, you must also specify the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the device.
        /// 
        /// > If you specify this parameter, you do not need to specify **ProductKey** or **DeviceName**. The **IotId** parameter specifies a globally unique identifier (GUID) of the device, which corresponds to a combination of **ProductKey** and **DeviceName**. If you specify both **IotId** and the combination of **ProductKey** and **DeviceName**, **IotId** takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not set this parameter, the call fails.
        /// >*   If your instance has no **Overview** page or ID, you do not need to set this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The name of the OTA module.
        /// 
        /// *   If you specify this parameter, update tasks of the specified module are queried.
        /// *   If you do not specify this parameter, update tasks of all modules are queried.
        /// </summary>
        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// The ProductKey of the product to which the device belongs.
        /// 
        /// > If you specify this parameter, you must also specify the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The status of the update task.
        /// 
        /// *   **CONFIRM**: The update task is pending confirmation.
        /// *   **QUEUED**: The update notification is to be pushed.
        /// *   **NOTIFIED**: The update notification is pushed to the device.
        /// *   **IN_PROGRESS**: The update task is in progress.
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TaskStatusList")]
        [Validation(Required=false)]
        public List<string> TaskStatusList { get; set; }

    }

}
