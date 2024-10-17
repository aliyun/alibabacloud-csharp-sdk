// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidTid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69161997-6030-53BA-A333-DBEC83B732FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The details of users.</para>
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
                /// <para>The number of queries that were performed on the current day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurExecuteCount")]
                [Validation(Required=false)]
                public long? CurExecuteCount { get; set; }

                /// <summary>
                /// <para>The number of rows that were queried on the current day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CurResultCount")]
                [Validation(Required=false)]
                public long? CurResultCount { get; set; }

                /// <summary>
                /// <para>The DingTalk chatbot URL that is used to receive notifications.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>The system returns this parameter if you have set a DingTalk chatbot URL in the console. To set a DingTalk chatbot URL in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to <b>Notice</b>.</para>
                /// </description></item>
                /// <item><description><para>The system does not return this parameter if you have not set a DingTalk chatbot URL.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://XXX.dingtalk.com/robot/send?access_token=9b7a4a562cbe7fcdea9962afac7b9d7b4504d564948083419750f9cafa78e4ef">https://XXX.dingtalk.com/robot/send?access_token=9b7a4a562cbe7fcdea9962afac7b9d7b4504d564948083419750f9cafa78e4ef</a></para>
                /// </summary>
                [NameInMap("DingRobot")]
                [Validation(Required=false)]
                public string DingRobot { get; set; }

                /// <summary>
                /// <para>The email address that is used to receive notifications.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>The system returns this parameter if you have set an email address in the console. To set an email address in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to <b>Notice</b>.</para>
                /// </description></item>
                /// <item><description><para>The system does not return this parameter if you have not set an email address.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The time when the user last logged on to the console.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-08 13:43:43</para>
                /// </summary>
                [NameInMap("LastLoginTime")]
                [Validation(Required=false)]
                public string LastLoginTime { get; set; }

                /// <summary>
                /// <para>The maximum number of queries that can be performed on the current day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("MaxExecuteCount")]
                [Validation(Required=false)]
                public long? MaxExecuteCount { get; set; }

                /// <summary>
                /// <para>The maximum number of rows that can be queried on the current day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("MaxResultCount")]
                [Validation(Required=false)]
                public long? MaxResultCount { get; set; }

                /// <summary>
                /// <para>The mobile phone number of the user.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>The system returns this parameter if you have set a mobile phone number in the console. To set a mobile phone number in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to <b>Notice</b>.</para>
                /// </description></item>
                /// <item><description><para>The system does not return this parameter if you have not set a mobile phone number.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1389999****</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>The nickname of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_NickName</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// <para>The notification method. The system returns one or more values. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SMS</b>: text message</description></item>
                /// <item><description><b>EMAIL</b>: email.</description></item>
                /// <item><description><b>DINGDING</b>: DingTalk.</description></item>
                /// <item><description><b>DINGROBOT</b>: DingTalk chatbot.</description></item>
                /// <item><description><b>WEBHOOK</b>: webhook.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DINGROBOT</para>
                /// </summary>
                [NameInMap("NotificationMode")]
                [Validation(Required=false)]
                public string NotificationMode { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140692647406****</para>
                /// </summary>
                [NameInMap("ParentUid")]
                [Validation(Required=false)]
                public string ParentUid { get; set; }

                /// <summary>
                /// <para>The IDs of the roles.</para>
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
                /// <para>The names of roles.</para>
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
                /// <para>The signature method that is used to secure connections when a webhook URL is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NONE</b>: no signature.</description></item>
                /// <item><description><b>HMAC_SHA1</b>: HMAC_SHA1.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HMAC_SHA1</para>
                /// </summary>
                [NameInMap("SignatureMethod")]
                [Validation(Required=false)]
                public string SignatureMethod { get; set; }

                /// <summary>
                /// <para>The status of the user. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NORMAL</b>: The user is normal.</description></item>
                /// <item><description><b>DISABLE</b>: The user is disabled.</description></item>
                /// <item><description><b>DELETE</b>: The user is deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>167382665015****</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The webhook URL that is used to receive notifications.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>If you have set a webhook URL, DMS sends notifications to the specified URL.</para>
                /// </description></item>
                /// <item><description><para>The system does not return this parameter if you have not set a webhook URL.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://dms-XXX.aliyun.com:8">http://dms-XXX.aliyun.com:8</a>***</para>
                /// </summary>
                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

    }

}
