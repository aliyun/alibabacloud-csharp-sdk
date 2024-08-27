// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class BatchQuerySessionByClientIdsResponseBody : TeaModel {
        /// <summary>
        /// The status list of all queried ApsaraMQ for MQTT clients.
        /// </summary>
        [NameInMap("OnlineStatusList")]
        [Validation(Required=false)]
        public List<BatchQuerySessionByClientIdsResponseBodyOnlineStatusList> OnlineStatusList { get; set; }
        public class BatchQuerySessionByClientIdsResponseBodyOnlineStatusList : TeaModel {
            /// <summary>
            /// The ID of the ApsaraMQ for MQTT client. For more information about client IDs, see [Terms](https://help.aliyun.com/document_detail/42420.html).
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// Indicates whether the ApsaraMQ for MQTT client is online. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("OnlineStatus")]
            [Validation(Required=false)]
            public bool? OnlineStatus { get; set; }

        }

        /// <summary>
        /// The request ID. This parameter is a common parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
