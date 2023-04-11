// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
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
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The details of users.
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public ListUsersResponseBodyUserList UserList { get; set; }
        public class ListUsersResponseBodyUserList : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersResponseBodyUserListUser> User { get; set; }
            public class ListUsersResponseBodyUserListUser : TeaModel {
                /// <summary>
                /// The number of queries that were performed on the current day.
                /// </summary>
                [NameInMap("CurExecuteCount")]
                [Validation(Required=false)]
                public long? CurExecuteCount { get; set; }

                /// <summary>
                /// The number of rows that were queried on the current day.
                /// </summary>
                [NameInMap("CurResultCount")]
                [Validation(Required=false)]
                public long? CurResultCount { get; set; }

                /// <summary>
                /// The DingTalk chatbot URL that is used to receive notifications.
                /// 
                /// > 
                /// 
                /// *   The system returns this parameter if you have set a DingTalk chatbot URL in the console. To set a DingTalk chatbot URL in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to **Notice**.
                /// 
                /// *   The system does not return this parameter if you have not set a DingTalk chatbot URL.
                /// </summary>
                [NameInMap("DingRobot")]
                [Validation(Required=false)]
                public string DingRobot { get; set; }

                /// <summary>
                /// The email address that is used to receive notifications.
                /// 
                /// > 
                /// 
                /// *   The system returns this parameter if you have set an email address in the console. To set an email address in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to **Notice**.
                /// 
                /// *   The system does not return this parameter if you have not set an email address.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The time when the user last logged on to the console.
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
                /// The mobile phone number of the user.
                /// 
                /// > 
                /// 
                /// *   The system returns this parameter if you have set a mobile phone number in the console. To set a mobile phone number in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to **Notice**.
                /// 
                /// *   The system does not return this parameter if you have not set a mobile phone number.
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
                /// The ID of the Alibaba Cloud account of the user.
                /// </summary>
                [NameInMap("ParentUid")]
                [Validation(Required=false)]
                public string ParentUid { get; set; }

                /// <summary>
                /// The IDs of the roles.
                /// </summary>
                [NameInMap("RoleIdList")]
                [Validation(Required=false)]
                public ListUsersResponseBodyUserListUserRoleIdList RoleIdList { get; set; }
                public class ListUsersResponseBodyUserListUserRoleIdList : TeaModel {
                    [NameInMap("RoleIds")]
                    [Validation(Required=false)]
                    public List<int?> RoleIds { get; set; }

                }

                /// <summary>
                /// The names of roles.
                /// </summary>
                [NameInMap("RoleNameList")]
                [Validation(Required=false)]
                public ListUsersResponseBodyUserListUserRoleNameList RoleNameList { get; set; }
                public class ListUsersResponseBodyUserListUserRoleNameList : TeaModel {
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
                /// The ID of the Alibaba Cloud account.
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
                /// *   If you have set a webhook URL, DMS sends notifications to the specified URL.
                /// 
                /// *   The system does not return this parameter if you have not set a webhook URL.
                /// </summary>
                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

    }

}
