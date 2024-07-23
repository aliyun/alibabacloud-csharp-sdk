// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class SetEventSubscriptionResponseBody : TeaModel {
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
        /// <para>The detailed information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetEventSubscriptionResponseBodyData Data { get; set; }
        public class SetEventSubscriptionResponseBodyData : TeaModel {
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
            /// <para>The name of the contact who receives alert notifications. Multiple names are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default contact</para>
            /// </summary>
            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The supported event scenarios. Only <b>AllContext</b> is returned for this parameter, which indicates that all scenarios are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AllContext</para>
            /// </summary>
            [NameInMap("eventContext")]
            [Validation(Required=false)]
            public string EventContext { get; set; }

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
            /// <para>The language of event notifications. Only <b>zh-CN</b> is returned for this parameter, which indicates that event notifications are sent in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh_CN</para>
            /// </summary>
            [NameInMap("lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// <para>The risk level of the events. Valid values:</para>
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
            /// <para>The minimum interval between consecutive event notifications. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("minInterval")]
            [Validation(Required=false)]
            public int? MinInterval { get; set; }

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
        /// <para>097F0C56-B252-515A-B602-FC56EF93EF8A</para>
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
