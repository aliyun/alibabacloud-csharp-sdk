// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceMessagePublishRequest : TeaModel {
        /// <summary>
        /// The beginning of the time range to query. The value of this parameter is a UNIX timestamp in milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// The end of the time range to query. The value of this parameter is a UNIX timestamp in milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the ApsaraMQ for MQTT instance. The ID must be consistent with the ID of the instance that the ApsaraMQ for MQTT client uses. You can view the instance ID in the **Basic Information** section on the **Instance Details** page that corresponds to the instance in the ApsaraMQ for MQTT console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the region where the ApsaraMQ for MQTT instance resides. For more information, see [Endpoints](https://help.aliyun.com/document_detail/181438.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MqttRegionId")]
        [Validation(Required=false)]
        public string MqttRegionId { get; set; }

        /// <summary>
        /// The message ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MsgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

    }

}
