// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class SetEventSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The detailed information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetEventSubscriptionResponseBodyData Data { get; set; }
        public class SetEventSubscriptionResponseBodyData : TeaModel {
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
            /// The name of the contact who receives alert notifications. Multiple names are separated by commas (,).
            /// </summary>
            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// The supported event scenarios. Only **AllContext** is returned for this parameter, which indicates that all scenarios are supported.
            /// </summary>
            [NameInMap("eventContext")]
            [Validation(Required=false)]
            public string EventContext { get; set; }

            /// <summary>
            /// The instance ID.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The language of event notifications. Only **zh-CN** is returned for this parameter, which indicates that event notifications are sent in Chinese.
            /// </summary>
            [NameInMap("lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// The risk level of the events. Valid values:
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
            /// The minimum interval between consecutive event notifications. Unit: seconds.
            /// </summary>
            [NameInMap("minInterval")]
            [Validation(Required=false)]
            public int? MinInterval { get; set; }

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
