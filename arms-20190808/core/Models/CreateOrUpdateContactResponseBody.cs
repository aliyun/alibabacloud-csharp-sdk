// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateContactResponseBody : TeaModel {
        /// <summary>
        /// The object of the alert contact.
        /// </summary>
        [NameInMap("AlertContact")]
        [Validation(Required=false)]
        public CreateOrUpdateContactResponseBodyAlertContact AlertContact { get; set; }
        public class CreateOrUpdateContactResponseBodyAlertContact : TeaModel {
            /// <summary>
            /// The ID of the alert contact.
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public float? ContactId { get; set; }

            /// <summary>
            /// The name of the alert contact.
            /// </summary>
            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// The webhook URL of the DingTalk chatbot.
            /// </summary>
            [NameInMap("DingRobotUrl")]
            [Validation(Required=false)]
            public string DingRobotUrl { get; set; }

            /// <summary>
            /// The email address of the alert contact.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// Indicates whether the mobile number was verified. Valid values:
            /// 
            /// *   `false` (default value): No
            /// *   `true`: Yes
            /// 
            /// You can call the **SendTTSVerifyLink** operation to verify the mobile number of an alert contact. Only verified mobile numbers can be specified in a notification policy to receive phone calls.
            /// </summary>
            [NameInMap("IsVerify")]
            [Validation(Required=false)]
            public bool? IsVerify { get; set; }

            /// <summary>
            /// The mobile number of the alert contact.
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// The operation that you want to perform if phone calls fail to be answered. Valid values: 0: No operation is performed. 1: A phone call is made again. 2: A text message is sent. 3 (default value): The global default value is used.
            /// </summary>
            [NameInMap("ReissueSendNotice")]
            [Validation(Required=false)]
            public long? ReissueSendNotice { get; set; }

            /// <summary>
            /// Indicates whether the email address was verified.
            /// </summary>
            [NameInMap("isEmailVerify")]
            [Validation(Required=false)]
            public bool? IsEmailVerify { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
