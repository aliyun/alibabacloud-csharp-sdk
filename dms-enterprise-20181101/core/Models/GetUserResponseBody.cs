// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The information about the user.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            /// <summary>
            /// The number of queries that are performed on the current day.
            /// </summary>
            [NameInMap("CurExecuteCount")]
            [Validation(Required=false)]
            public long? CurExecuteCount { get; set; }

            /// <summary>
            /// The number of rows that are queried on the current day.
            /// </summary>
            [NameInMap("CurResultCount")]
            [Validation(Required=false)]
            public long? CurResultCount { get; set; }

            /// <summary>
            /// The DingTalk chatbot URL that is used to receive notifications.
            /// 
            /// > 
            /// 
            /// *   The system returns this parameter if the user has set a DingTalk chatbot URL in the console. To set a DingTalk chatbot URL in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to **Notice**.
            /// 
            /// *   The system does not return this parameter if the user has not set a DingTalk chatbot URL.
            /// </summary>
            [NameInMap("DingRobot")]
            [Validation(Required=false)]
            public string DingRobot { get; set; }

            /// <summary>
            /// The email address that is used to receive notifications.
            /// 
            /// > 
            /// 
            /// *   The system returns this parameter if the user has set an email address in the console. To set an email address in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to **Notice**.
            /// 
            /// *   The system does not return this parameter if the user has not set an email address.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The last point in time when the user logged on to the console.
            /// </summary>
            [NameInMap("LastLoginTime")]
            [Validation(Required=false)]
            public string LastLoginTime { get; set; }

            /// <summary>
            /// The maximum number of queries that can be performed on the current day.
            /// </summary>
            [NameInMap("MaxExecuteCount")]
            [Validation(Required=false)]
            public long? MaxExecuteCount { get; set; }

            /// <summary>
            /// The maximum number of rows that can be queried on the current day.
            /// </summary>
            [NameInMap("MaxResultCount")]
            [Validation(Required=false)]
            public long? MaxResultCount { get; set; }

            /// <summary>
            /// The mobile number of the user.
            /// 
            /// > 
            /// 
            /// *   The system returns this parameter if the user has set a mobile phone number in the console. To set a mobile phone number in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to **Notice**.
            /// 
            /// *   The system does not return this parameter if the user has not set a mobile phone number.
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// The nickname of the user.
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// The notification method. The system returns one or more values. Valid values:
            /// 
            /// *   **SMS**: text message
            /// *   **EMAIL**: email.
            /// *   **DINGDING**: DingTalk.
            /// *   **DINGROBOT**: DingTalk chatbot.
            /// *   **WEBHOOK**: webhook.
            /// </summary>
            [NameInMap("NotificationMode")]
            [Validation(Required=false)]
            public string NotificationMode { get; set; }

            /// <summary>
            /// The UID of the Alibaba Cloud account of the user.
            /// 
            /// > An Alibaba Cloud account can contain one or more RAM users.
            /// </summary>
            [NameInMap("ParentUid")]
            [Validation(Required=false)]
            public long? ParentUid { get; set; }

            /// <summary>
            /// The list of role IDs.
            /// </summary>
            [NameInMap("RoleIdList")]
            [Validation(Required=false)]
            public GetUserResponseBodyUserRoleIdList RoleIdList { get; set; }
            public class GetUserResponseBodyUserRoleIdList : TeaModel {
                [NameInMap("RoleIds")]
                [Validation(Required=false)]
                public List<int?> RoleIds { get; set; }

            }

            /// <summary>
            /// The list of role names.
            /// </summary>
            [NameInMap("RoleNameList")]
            [Validation(Required=false)]
            public GetUserResponseBodyUserRoleNameList RoleNameList { get; set; }
            public class GetUserResponseBodyUserRoleNameList : TeaModel {
                [NameInMap("RoleNames")]
                [Validation(Required=false)]
                public List<string> RoleNames { get; set; }

            }

            /// <summary>
            /// The signature method that is used to secure connections when a webhook URL is used. Valid values:
            /// 
            /// *   **NONE**: no signature.
            /// *   **HMAC_SHA1**: HMAC_SHA1.
            /// </summary>
            [NameInMap("SignatureMethod")]
            [Validation(Required=false)]
            public string SignatureMethod { get; set; }

            /// <summary>
            /// The status of the user. Valid values:
            /// 
            /// *   **NORMAL**: The user is normal.
            /// *   **DISABLE**: The user is disabled.
            /// *   **DELETE**: The user is deleted.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The UID of the user.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The webhook URL that is used to receive notifications.
            /// 
            /// > 
            /// 
            /// *   If the user has set a webhook URL, DMS sends notifications to the specified URL.
            /// 
            /// *   The system does not return this parameter if the user has not set a webhook URL.
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

    }

}
