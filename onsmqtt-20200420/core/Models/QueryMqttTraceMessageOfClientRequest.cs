// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryMqttTraceMessageOfClientRequest : TeaModel {
        /// <summary>
        /// The beginning of the time range to query. The value of this parameter is a UNIX timestamp in milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// The client ID of the device whose messages you want to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. If the input parameter value is greater than the total number of pages, the returned result is empty.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The end of the time range to query. The value of this parameter is a UNIX timestamp in milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The ID of the ApsaraMQ for MQTT instance. The ID must be consistent with the ID of the instance that the ApsaraMQ for MQTT client uses. You can view the instance ID in the **Basic Information** section of the **Instance Details** page that corresponds to the instance in the ApsaraMQ for MQTT console.
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
        /// The number of entries to return on each page. Valid values: 1 to 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Specifies whether the returned results are displayed in reverse chronological order. Valid values:
        /// 
        /// *   **true**: The returned results are displayed in reverse order of the time when messages are sent or received. This means that the latest sent or received message is displayed as the first entry and the earliest sent or received message is displayed as the last entry.
        /// *   **false**: The returned results are displayed in order of the time when messages are sent or received. This means that the earliest sent or received message is displayed as the first entry and the latest sent or received message is displayed as the last entry.
        /// 
        /// If this parameter is not specified, the returned results are displayed in order of the time when messages are sent or received.
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

    }

}
