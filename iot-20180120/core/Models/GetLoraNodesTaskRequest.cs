// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetLoraNodesTaskRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// You can obtain the **ID** of the instance on the **Overview** page in the IoT Platform console. If your instance has an ID, you must specify this parameter. Otherwise, the request fails.
        /// 
        /// > The ID of a public instance may not be displayed on the Overview page. For more information about how to obtain the instance ID, see [How do I obtain an instance ID?](~~267533~~)
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The ID of the task for creating the LoRaWAN devices. You can call the [CreateLoRaNodesTask](~~109299~~) operation and obtain the task ID from the value of the **TaskId** response parameter.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
