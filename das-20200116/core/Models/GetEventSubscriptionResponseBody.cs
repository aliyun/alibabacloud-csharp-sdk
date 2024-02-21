// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetEventSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEventSubscriptionResponseBodyData Data { get; set; }
        public class GetEventSubscriptionResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the event subscription feature is enabled. Valid values:
            /// 
            /// *   **0**: The event subscription feature is disabled.
            /// *   **1**: The event subscription feature is enabled.
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public int? Active { get; set; }

            /// <summary>
            /// The notification method. Valid values:
            /// 
            /// *   **hdm_alarm_sms**: text message.
            /// *   **dingtalk**: DingTalk chatbot.
            /// *   **hdm_alarm_sms_and_email**: text message and email.
            /// *   **hdm_alarm_sms,dingtalk**: text message and DingTalk chatbot.
            /// </summary>
            [NameInMap("channelType")]
            [Validation(Required=false)]
            public string ChannelType { get; set; }

            /// <summary>
            /// The name of the contact group that receives alert notifications. Multiple names are separated by commas (,).
            /// </summary>
            [NameInMap("contactGroupName")]
            [Validation(Required=false)]
            public string ContactGroupName { get; set; }

            /// <summary>
            /// The alert contact groups.
            /// </summary>
            [NameInMap("contactGroups")]
            [Validation(Required=false)]
            public List<GetEventSubscriptionResponseBodyDataContactGroups> ContactGroups { get; set; }
            public class GetEventSubscriptionResponseBodyDataContactGroups : TeaModel {
                /// <summary>
                /// The members of the alert contact group.
                /// </summary>
                [NameInMap("contacts")]
                [Validation(Required=false)]
                public string Contacts { get; set; }

                /// <summary>
                /// The description of the alert contact group.
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the alert contact group.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The name of the subscriber who receives alert notifications. Multiple names are separated by commas (,).
            /// </summary>
            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public List<GetEventSubscriptionResponseBodyDataContacts> Contacts { get; set; }
            public class GetEventSubscriptionResponseBodyDataContacts : TeaModel {
                /// <summary>
                /// The webhook URL of the DingTalk chatbot.
                /// </summary>
                [NameInMap("dingtalkHook")]
                [Validation(Required=false)]
                public string DingtalkHook { get; set; }

                /// <summary>
                /// The email address of the alert contact.
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The contact groups to which the alert contact belongs.
                /// </summary>
                [NameInMap("groups")]
                [Validation(Required=false)]
                public List<string> Groups { get; set; }

                /// <summary>
                /// Indicates whether the alert contact name is the same as the contact name on CloudMonitor.
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("isCmsReduplicated")]
                [Validation(Required=false)]
                public bool? IsCmsReduplicated { get; set; }

                /// <summary>
                /// The name of the alert contact.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The mobile number of the alert contact.
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The supported event scenarios. Only **AllContext** may be returned, which indicates that all scenarios are supported.
            /// </summary>
            [NameInMap("eventContext")]
            [Validation(Required=false)]
            public string EventContext { get; set; }

            /// <summary>
            /// The supported event scenarios in which event subscription can be sent.
            /// </summary>
            [NameInMap("eventSendGroup")]
            [Validation(Required=false)]
            public List<string> EventSendGroup { get; set; }

            /// <summary>
            /// The time when event subscription was enabled. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The time when the event subscription settings were most recently modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The primary key ID of the database.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The language of event notifications. Only **zh-CN** may be returned, which indicates that event notifications are sent in Chinese.
            /// </summary>
            [NameInMap("lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// The risk level of the events that trigger notifications. Valid values:
            /// 
            /// *   **Notice**
            /// *   **Optimization**
            /// *   **Warn**
            /// *   **Critical**
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The minimum interval between event notifications. Unit: seconds.
            /// </summary>
            [NameInMap("minInterval")]
            [Validation(Required=false)]
            public string MinInterval { get; set; }

            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
