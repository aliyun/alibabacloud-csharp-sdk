// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ApplyMetricRuleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template application policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all (default): deletes all the rules that are created by using the alert template from the selected application group, and then creates alert rules based on the template.</description></item>
        /// <item><description>append: deletes the rules that are created by using the alert template from the selected application group, and then creates alert rules based on the existing template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("AppendMode")]
        [Validation(Required=false)]
        public string AppendMode { get; set; }

        /// <summary>
        /// <para>The mode in which the alert template is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GROUP_INSTANCE_FIRST: The metrics in the application group take precedence. If a metric specified in the alert template does not exist in the application group, the system does not generate an alert rule for the metric based on the alert template.</description></item>
        /// <item><description>ALARM_TEMPLATE_FIRST: The metrics specified in the alert template take precedence. If a metric specified in the alert template does not exist in the application group, the system still generates an alert rule for the metric based on the alert template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GROUP_INSTANCE_FIRST</para>
        /// </summary>
        [NameInMap("ApplyMode")]
        [Validation(Required=false)]
        public string ApplyMode { get; set; }

        /// <summary>
        /// <para>The end of the time period during which the alert rule is effective. Valid values: 00 to 23. A value of 00 indicates 00:59 and a value of 23 indicates 23:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("EnableEndTime")]
        [Validation(Required=false)]
        public long? EnableEndTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time period during which the alert rule is effective. Valid values: 00 to 23. A value of 00 indicates 00:00 and a value of 23 indicates 23:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00</para>
        /// </summary>
        [NameInMap("EnableStartTime")]
        [Validation(Required=false)]
        public long? EnableStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the application group to which the alert template is applied.</para>
        /// <para>For more information about how to query the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
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
        /// <para>Set the value to 4. A value of 4 indicates that alert notifications are sent by using TradeManager and DingTalk chatbots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NotifyLevel")]
        [Validation(Required=false)]
        public long? NotifyLevel { get; set; }

        /// <summary>
        /// <para>The mute period during which notifications are not repeatedly sent for an alert. Unit: seconds. Default value: 86400.</para>
        /// <remarks>
        /// <para> Only one alert notification is sent during each mute period even if the metric value exceeds the alert threshold several times.</para>
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
        /// <para>For more information about how to query the IDs of alert templates, see <a href="https://help.aliyun.com/document_detail/114982.html">DescribeMetricRuleTemplateList</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>700****</para>
        /// </summary>
        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public string TemplateIds { get; set; }

        /// <summary>
        /// <para>The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
