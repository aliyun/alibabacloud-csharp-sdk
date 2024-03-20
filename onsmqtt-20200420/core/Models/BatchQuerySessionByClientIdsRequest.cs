// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class BatchQuerySessionByClientIdsRequest : TeaModel {
        /// <summary>
        /// The ApsaraMQ for MQTT clients.
        /// </summary>
        [NameInMap("ClientIdList")]
        [Validation(Required=false)]
        public List<string> ClientIdList { get; set; }

        /// <summary>
        /// The ID of the ApsaraMQ for MQTT instance. The ID must be consistent with the ID of the instance that the ApsaraMQ for MQTT client uses. You can obtain the instance ID on the **Instance Details** page that corresponds to the instance in the [ApsaraMQ for MQTT console](https://mqtt.console.aliyun.com).
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
