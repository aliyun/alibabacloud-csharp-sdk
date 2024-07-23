// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetEventSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEventSubscriptionResponseBodyData Data { get; set; }
        public class GetEventSubscriptionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the event subscription feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The event subscription feature is disabled.</description></item>
            /// <item><description><b>1</b>: The event subscription feature is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public int? Active { get; set; }

            /// <summary>
            /// <para>The notification method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>hdm_alarm_sms</b>: text message.</description></item>
            /// <item><description><b>dingtalk</b>: DingTalk chatbot.</description></item>
            /// <item><description><b>hdm_alarm_sms_and_email</b>: text message and email.</description></item>
            /// <item><description><b>hdm_alarm_sms,dingtalk</b>: text message and DingTalk chatbot.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hdm_alarm_sms,dingtalk</para>
            /// </summary>
            [NameInMap("channelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// <para>The name of the contact group that receives alert notifications. Multiple names are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default contact group</para>
            /// </summary>
            [NameInMap("contactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            /// <summary>
            /// <para>The alert contact groups.</para>
            /// </summary>
            [NameInMap("contactGroups")]
            [Validation(Required=false)]
            public List<GetEventSubscriptionResponseBodyDataContactGroups> ContactGroups { get; set; }
            public class GetEventSubscriptionResponseBodyDataContactGroups : TeaModel {
                /// <summary>
                /// <para>The members of the alert contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;[\&quot;Mr. Zhang\&quot;,\&quot;Ms. Wang\&quot;,\&quot;Mr. Li\&quot;]&quot;</para>
                /// </summary>
                [NameInMap("contacts")]
                [Validation(Required=false)]
                public string Contacts { get; set; }

                /// <summary>
                /// <para>The description of the alert contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default contact</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the alert contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mr. Zhang</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1088760496****</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The name of the subscriber who receives alert notifications. Multiple names are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default contact</para>
            /// </summary>
            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<GetEventSubscriptionResponseBodyDataContacts> Contacts { get; set; }
            public class GetEventSubscriptionResponseBodyDataContacts : TeaModel {
                /// <summary>
                /// <para>The webhook URL of the DingTalk chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=68fa29a9eaf3ba9994f54fxxxc1aa9879700308f90e9c23ebfb3663642c9">https://oapi.dingtalk.com/robot/send?access_token=68fa29a9eaf3ba9994f54fxxxc1aa9879700308f90e9c23ebfb3663642c9</a>****</para>
                /// </summary>
                [NameInMap("dingtalkHook")]
                [Validation(Required=false)]
                public string DingtalkHook { get; set; }

                /// <summary>
                /// <para>The email address of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a***@example.net</para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The contact groups to which the alert contact belongs.</para>
                /// </summary>
                [NameInMap("groups")]
                [Validation(Required=false)]
                public List<string> Groups { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert contact name is the same as the contact name on CloudMonitor.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isCmsReduplicated")]
                [Validation(Required=false)]
                public bool? IsCmsReduplicated { get; set; }

                /// <summary>
                /// <para>The name of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mr. Zhang</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The mobile number of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1390000****</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1088760496****</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The supported event scenarios. Only <b>AllContext</b> may be returned, which indicates that all scenarios are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AllContext</para>
            /// </summary>
            [NameInMap("eventContext")]
            [Validation(Required=false)]
            public string EventContext { get; set; }

            /// <summary>
            /// <para>The supported event scenarios in which event subscription can be sent.</para>
            /// </summary>
            [NameInMap("eventSendGroup")]
            [Validation(Required=false)]
            public List<string> EventSendGroup { get; set; }

            /// <summary>
            /// <para>The time when event subscription was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1633071840000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the event subscription settings were most recently modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1633071850000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The primary key ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-2ze8g2am97624****</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The language of event notifications. Only <b>zh-CN</b> may be returned, which indicates that event notifications are sent in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh_CN</para>
            /// </summary>
            [NameInMap("lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The risk level of the events that trigger notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Notice</b></description></item>
            /// <item><description><b>Optimization</b></description></item>
            /// <item><description><b>Warn</b></description></item>
            /// <item><description><b>Critical</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Optimization</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The minimum interval between event notifications. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("minInterval")]
            [Validation(Required=false)]
            public string MinInterval { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1088760496****</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
