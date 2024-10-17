// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unknown server error</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>804BB128-CAFA-5DD0-BA1E-43DDE488****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The information about the user.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The number of queries that are performed on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CurExecuteCount")]
            [Validation(Required=false)]
            public long? CurExecuteCount { get; set; }

            /// <summary>
            /// <para>The number of rows that are queried on the current day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("CurResultCount")]
            [Validation(Required=false)]
            public long? CurResultCount { get; set; }

            /// <summary>
            /// <para>The DingTalk chatbot URL that is used to receive notifications.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The system returns this parameter if the user has set a DingTalk chatbot URL in the console. To set a DingTalk chatbot URL in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to <b>Notice</b>.</para>
            /// </description></item>
            /// <item><description><para>The system does not return this parameter if the user has not set a DingTalk chatbot URL.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://XXX.dingtalk.com/robot/send?access_token=">https://XXX.dingtalk.com/robot/send?access_token=</a>***</para>
            /// </summary>
            [NameInMap("DingRobot")]
            [Validation(Required=false)]
            public string DingRobot { get; set; }

            /// <summary>
            /// <para>The email address that is used to receive notifications.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The system returns this parameter if the user has set an email address in the console. To set an email address in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to <b>Notice</b>.</para>
            /// </description></item>
            /// <item><description><para>The system does not return this parameter if the user has not set an email address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Uesr_email</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The last point in time when the user logged on to the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-08 11:26:21</para>
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
            /// <para>10000</para>
            /// </summary>
            [NameInMap("MaxResultCount")]
            [Validation(Required=false)]
            public long? MaxResultCount { get; set; }

            /// <summary>
            /// <para>The mobile number of the user.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>The system returns this parameter if the user has set a mobile phone number in the console. To set a mobile phone number in the console, move the pointer over the profile picture in the upper-right corner and click the Edit icon next to <b>Notice</b>.</para>
            /// </description></item>
            /// <item><description><para>The system does not return this parameter if the user has not set a mobile phone number.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1389223****</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>The nickname of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User_NickName</para>
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
            /// <para>EMAIL</para>
            /// </summary>
            [NameInMap("NotificationMode")]
            [Validation(Required=false)]
            public string NotificationMode { get; set; }

            /// <summary>
            /// <para>The UID of the Alibaba Cloud account of the user.</para>
            /// <remarks>
            /// <para>An Alibaba Cloud account can contain one or more RAM users.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("ParentUid")]
            [Validation(Required=false)]
            public long? ParentUid { get; set; }

            /// <summary>
            /// <para>The list of role IDs.</para>
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
            /// <para>The list of role names.</para>
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
            /// <para>The signature method that is used to secure connections when a webhook URL is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NONE</b>: no signature.</description></item>
            /// <item><description><b>HMAC_SHA1</b>: HMAC_SHA1.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NONE</para>
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
            /// <para>The UID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22275482072787****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The webhook URL that is used to receive notifications.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>If the user has set a webhook URL, DMS sends notifications to the specified URL.</para>
            /// </description></item>
            /// <item><description><para>The system does not return this parameter if the user has not set a webhook URL.</para>
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
