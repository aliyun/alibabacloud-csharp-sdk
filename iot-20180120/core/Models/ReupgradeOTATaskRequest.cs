// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ReupgradeOTATaskRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can view the ID of an instance on the **Overview** page in the IoT Platform console.****
        /// 
        /// >*   If the instance has an ID, you must specify the **IotInstanceId** parameter. If you do not specify this parameter, the call fails.
        /// >*   If the instance does not have an **ID** or no **Overview** page is displayed for the instance, you do not need to specify this parameter.
        /// 
        /// For more information, see [Instance overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the update batch.
        /// 
        /// After you call the [CreateOTAStaticUpgradeJob](~~147496~~) or [CreateOTADynamicUpgradeJob](~~147887~~) operation to create an update batch, the **JobId** parameter is returned.
        /// 
        /// You can also view the **batch ID** on the **Firmware Details** page in the IoT Platform console.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public List<string> TaskId { get; set; }

    }

}
