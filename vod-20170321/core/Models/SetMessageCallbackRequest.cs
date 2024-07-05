// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetMessageCallbackRequest : TeaModel {
        /// <summary>
        /// The ID of the application. If you leave this parameter empty, the default value **app-1000000** is used.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The authentication key. The key can be up to 32 characters in length and must contain uppercase letters, lowercase letters, and digits. This parameter takes effect only when you set CallbackType to **HTTP**.
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// Specifies whether to enable callback authentication. This parameter takes effect only when you set CallbackType to **HTTP**. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("AuthSwitch")]
        [Validation(Required=false)]
        public string AuthSwitch { get; set; }

        /// <summary>
        /// The callback method. Valid values:
        /// 
        /// *   **HTTP**
        /// *   **MNS**
        /// </summary>
        [NameInMap("CallbackType")]
        [Validation(Required=false)]
        public string CallbackType { get; set; }

        /// <summary>
        /// The callback URL. This parameter is required if you set CallbackType to **HTTP**. The callback URL cannot exceed 256 bytes in length. You can specify only one callback URL.
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// The type of the callback event. If you do not set this parameter, notifications for all types of events are disabled. If you set this parameter to **ALL**, notifications for all types of events are enabled. You can specify the event types for which notifications are enabled. Separate multiple event types with commas (,). For more information about the valid values of this parameter, see [Overview](https://help.aliyun.com/document_detail/55627.html).
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public string EventTypeList { get; set; }

        /// <summary>
        /// The public endpoint of Message Service (MNS). This parameter only takes effect when the CallbackType parameter is set to **MNS**. To obtain the public endpoint, log on to the [MNS console](https://account.aliyun.com/login/login.html) and click **Get Endpoint** in the upper-right corner of the Topics page. For more information, see [Endpoint](https://help.aliyun.com/document_detail/27480.html).
        /// </summary>
        [NameInMap("MnsEndpoint")]
        [Validation(Required=false)]
        public string MnsEndpoint { get; set; }

        /// <summary>
        /// The name of the MNS queue. You can obtain the name of the MNS queue on the **Queues** page in the [MNS console](https://account.aliyun.com/login/login.html). This parameter is required when you set CallbackType to **MNS**.
        /// </summary>
        [NameInMap("MnsQueueName")]
        [Validation(Required=false)]
        public string MnsQueueName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

    }

}
