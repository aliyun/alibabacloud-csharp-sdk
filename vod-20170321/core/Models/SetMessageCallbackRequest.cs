// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SetMessageCallbackRequest : TeaModel {
        /// <summary>
        /// The ID of the application. If you do not set this parameter, the default value **app-1000000** is used.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The cryptographic key. This parameter only takes effect when the CallbackType parameter is set to HTTP. The key can be up to 32 characters in length and must contain uppercase letters, lowercase letters, and digits.
        /// </summary>
        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        /// <summary>
        /// Specifies whether to enable callback authentication. This parameter only takes effect when the CallbackType parameter is set to HTTP. Valid values:
        /// 
        /// *   **on**: enables authentication.
        /// *   **off**: disables authentication.
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
        /// The callback URL. This parameter only takes effect when the CallbackType parameter is set to HTTP.
        /// </summary>
        [NameInMap("CallbackURL")]
        [Validation(Required=false)]
        public string CallbackURL { get; set; }

        /// <summary>
        /// The type of the callback event. If you do not set this parameter, notifications for all types of events are disabled. If you set this parameter to ALL, notifications for all types of events are enabled. You can specify the event types for which notifications are enabled. Separate multiple event types with commas (,). For more information about the valid values of this parameter, see [Event type](~~55627~~).
        /// </summary>
        [NameInMap("EventTypeList")]
        [Validation(Required=false)]
        public string EventTypeList { get; set; }

        /// <summary>
        /// The public endpoint of Message Service (MNS). This parameter only takes effect when the CallbackType parameter is set to MNS. For more information, see [Endpoint](~~27480#concept-2028913~~ "An endpoint is the address that you specify for a subscription to receive messages. When messages are published to a topic, Message Service (MNS) pushes the messages to the specified endpoints. You can specify the same endpoint for multiple subscriptions.").
        /// </summary>
        [NameInMap("MnsEndpoint")]
        [Validation(Required=false)]
        public string MnsEndpoint { get; set; }

        /// <summary>
        /// The name of the MNS queue. This parameter only takes effect when the CallbackType parameter is set to MNS.
        /// </summary>
        [NameInMap("MnsQueueName")]
        [Validation(Required=false)]
        public string MnsQueueName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

    }

}
