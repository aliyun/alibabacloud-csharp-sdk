// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QuerySessionByClientIdResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the ApsaraMQ for MQTT client is connected to the ApsaraMQ for MQTT broker. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("OnlineStatus")]
        [Validation(Required=false)]
        public bool? OnlineStatus { get; set; }

        /// <summary>
        /// The request ID. This parameter is a common parameter.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
