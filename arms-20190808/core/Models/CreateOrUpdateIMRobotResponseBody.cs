// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateIMRobotResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the IM chatbot.</para>
        /// </summary>
        [NameInMap("AlertRobot")]
        [Validation(Required=false)]
        public CreateOrUpdateIMRobotResponseBodyAlertRobot AlertRobot { get; set; }
        public class CreateOrUpdateIMRobotResponseBodyAlertRobot : TeaModel {
            /// <summary>
            /// <para>The configurations of the alert card template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{     &quot;button&quot;: [         &quot;claim&quot;,         &quot;close&quot;,         &quot;follow&quot;,         &quot;send_itsm&quot;,         &quot;block&quot;,         &quot;unResolvedIncident&quot;     ],     &quot;field&quot;: [         {             &quot;fieldName&quot;: &quot;alarmName&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;notificationPolicy&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;alarmContent&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;alarmTime&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;seriesChart&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;includeEvent&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;assigned&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;similarAlarm&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;operator&quot;,             &quot;visible&quot;: true         }     ] }</para>
            /// </summary>
            [NameInMap("CardTemplate")]
            [Validation(Required=false)]
            public string CardTemplate { get; set; }

            /// <summary>
            /// <para>Indicates whether daily statistics are sent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>false</c> (default): Daily statistics are not sent.</description></item>
            /// <item><description><c>true</c>: Daily statistics are sent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DailyNoc")]
            [Validation(Required=false)]
            public bool? DailyNoc { get; set; }

            /// <summary>
            /// <para>The point in time at which the daily statistics are sent. The information that ARMS sends at the specified points in time includes the total number of alerts generated on the current day, the number of cleared alerts, and the number of alerts to be cleared.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:30,17:00</para>
            /// </summary>
            [NameInMap("DailyNocTime")]
            [Validation(Required=false)]
            public string DailyNocTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the Outgoing feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableOutgoing")]
            [Validation(Required=false)]
            public bool? EnableOutgoing { get; set; }

            /// <summary>
            /// <para>The webhook URL of the IM chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=e1a049121">https://oapi.dingtalk.com/robot/send?access_token=e1a049121</a>******</para>
            /// </summary>
            [NameInMap("RobotAddress")]
            [Validation(Required=false)]
            public string RobotAddress { get; set; }

            /// <summary>
            /// <para>The ID of the IM chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("RobotId")]
            [Validation(Required=false)]
            public float? RobotId { get; set; }

            /// <summary>
            /// <para>The name of the IM chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Chatbot name</para>
            /// </summary>
            [NameInMap("RobotName")]
            [Validation(Required=false)]
            public string RobotName { get; set; }

            /// <summary>
            /// <para>The token required to enable the Outgoing feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1656558719183be1245ab44********</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <para>The type of the IM chatbot. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>dingding</c>: DingTalk chatbot</description></item>
            /// <item><description><c>wechat</c>: WeCom chatbot</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dingding</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16AF921B-8187-489F-9913-43C808B4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
