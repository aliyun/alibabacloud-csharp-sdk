// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ApplyMetricRuleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The application policy of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>all: deletes all rules created by using alert templates on the selected group and then creates new alert rules based on the template. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>append: deletes the rules created by using the current alert template on the selected group and then creates new alert rules based on the current template.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("AppendMode")]
        [Validation(Required=false)]
        public string AppendMode { get; set; }

        /// <summary>
        /// <para>The application mode of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GROUP_INSTANCE_FIRST: application group instances take precedence. When the alert template is applied, the instances in the application group take precedence. If an instance specified in the template does not exist in the application group, the rule for the instance in the template is ignored.</para>
        /// </description></item>
        /// <item><description><para>ALARM_TEMPLATE_FIRST: alert template instances take precedence. When the alert template is applied, alert rules are created regardless of whether the instances exist in the application group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GROUP_INSTANCE_FIRST</para>
        /// </summary>
        [NameInMap("ApplyMode")]
        [Validation(Required=false)]
        public string ApplyMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run and does not bind a security group to the instance. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the dry run, an error is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: performs a normal request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The end time of the effective period for the alert, in hours. The value is a two-digit string, such as &quot;00&quot;, &quot;18&quot;, or &quot;23&quot;. Valid values: 00 to 23. The value specifies the hour of the end time, and the actual effective period ends at the 59th minute of the hour. For example, &quot;23&quot; indicates that the effective period ends at 23:59. The default time zone is UTC+8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("EnableEndTime")]
        [Validation(Required=false)]
        public long? EnableEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the effective period for the alert, in hours. The value is a two-digit string, such as &quot;00&quot;, &quot;09&quot;, or &quot;23&quot;. Valid values: 00 to 23, which represent 00:00 to 23:00. The default time zone is UTC+8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00</para>
        /// </summary>
        [NameInMap("EnableStartTime")]
        [Validation(Required=false)]
        public long? EnableStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>For more information about how to obtain the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The alert notification method. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- 2: phone call, text message, mailbox, TradeManager, and DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- 3: text message, mailbox, TradeManager, and DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- 4: TradeManager and DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;4: TradeManager and DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;4: TradeManager and DingTalk chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NotifyLevel")]
        [Validation(Required=false)]
        public long? NotifyLevel { get; set; }

        /// <summary>
        /// <para>The mute for. Unit: seconds. Default value: 86400.</para>
        /// <remarks>
        /// <para>If the monitoring data continuously exceeds the threshold of the alert rule, the system sends only one alert notification within each epoch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        /// <summary>
        /// <para>The ID of the alert template.</para>
        /// <para>For more information about how to obtain the ID of an alert template, see <a href="https://help.aliyun.com/document_detail/114982.html">DescribeMetricRuleTemplateList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700****</para>
        /// </summary>
        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public string TemplateIds { get; set; }

        /// <summary>
        /// <para>The webhook URL to which a POST request is sent when an alert is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
