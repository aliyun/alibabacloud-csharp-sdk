// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMessageCallbackResponseBody : TeaModel {
        /// <summary>
        /// The configuration of the event notification.
        /// </summary>
        [NameInMap("MessageCallback")]
        [Validation(Required=false)]
        public GetMessageCallbackResponseBodyMessageCallback MessageCallback { get; set; }
        public class GetMessageCallbackResponseBodyMessageCallback : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The cryptographic key. This parameter is returned only for HTTP callbacks.
            /// </summary>
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            /// <summary>
            /// Indicates whether callback authentication is enabled. This parameter is returned only for HTTP callbacks. Valid values:
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
            /// The callback URL. This parameter is returned only for HTTP callbacks.
            /// </summary>
            [NameInMap("CallbackURL")]
            [Validation(Required=false)]
            public string CallbackURL { get; set; }

            /// <summary>
            /// The type of the callback event.
            /// </summary>
            [NameInMap("EventTypeList")]
            [Validation(Required=false)]
            public string EventTypeList { get; set; }

            /// <summary>
            /// The public endpoint of MNS. This parameter is returned only for MNS callbacks.
            /// </summary>
            [NameInMap("MnsEndpoint")]
            [Validation(Required=false)]
            public string MnsEndpoint { get; set; }

            /// <summary>
            /// The name of the Message Service (MNS) queue. This parameter is returned only for MNS callbacks.
            /// </summary>
            [NameInMap("MnsQueueName")]
            [Validation(Required=false)]
            public string MnsQueueName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
