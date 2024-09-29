// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateIMRobotRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the alert card template. For more information about the parameters in the template, see the following section.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;button&quot;: [         &quot;claim&quot;,         &quot;close&quot;,         &quot;follow&quot;,         &quot;send_itsm&quot;,         &quot;block&quot;,         &quot;unResolvedIncident&quot;     ],     &quot;field&quot;: [         {             &quot;fieldName&quot;: &quot;alarmName&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;notificationPolicy&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;alarmContent&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;alarmTime&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;seriesChart&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;includeEvent&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;assigned&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;similarAlarm&quot;,             &quot;visible&quot;: true         },         {             &quot;fieldName&quot;: &quot;operator&quot;,             &quot;visible&quot;: true         }     ] }</para>
        /// </summary>
        [NameInMap("CardTemplate")]
        [Validation(Required=false)]
        public string CardTemplate { get; set; }

        /// <summary>
        /// <para>Specifies whether to send daily statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>false</c> (default): Daily statistics are not sent.</description></item>
        /// <item><description><c>true</c>: Daily statistics are sent. If you set the value to <c>true</c>, the <b>DailyNocTime</b> parameter is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DailyNoc")]
        [Validation(Required=false)]
        public bool? DailyNoc { get; set; }

        /// <summary>
        /// <para>The points in time at which the daily statistics are sent. Separate multiple points in time with commas (,). The points in time are in the HH:SS format. The information that ARMS sends at the specified points in time includes the total number of alerts generated on the current day, the number of cleared alerts, and the number of alerts to be cleared.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09:30,17:00</para>
        /// </summary>
        [NameInMap("DailyNocTime")]
        [Validation(Required=false)]
        public string DailyNocTime { get; set; }

        /// <summary>
        /// <para>The signature key of DingTalk. If you specify a signature key, DingTalk authentication is performed by using the signature key. If you do not specify a signature key, a whitelist is used for authentication by default. The keyword of the whitelist is <b>Alert</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DingSignKey")]
        [Validation(Required=false)]
        public string DingSignKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Outgoing feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableOutgoing")]
        [Validation(Required=false)]
        public bool? EnableOutgoing { get; set; }

        /// <summary>
        /// <para>The webhook URL of the IM chatbot.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=e1a049121">https://oapi.dingtalk.com/robot/send?access_token=e1a049121</a>******</para>
        /// </summary>
        [NameInMap("RobotAddress")]
        [Validation(Required=false)]
        public string RobotAddress { get; set; }

        /// <summary>
        /// <para>The ID of the IM chatbot.</para>
        /// <remarks>
        /// <para>If you do not specify the parameter, a new IM chatbot is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("RobotId")]
        [Validation(Required=false)]
        public long? RobotId { get; set; }

        /// <summary>
        /// <para>The name of the IM chatbot.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><c>feishu</c>: Lark chatbot</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingding</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
