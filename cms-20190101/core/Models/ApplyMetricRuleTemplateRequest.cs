// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ApplyMetricRuleTemplateRequest : TeaModel {
        /// <summary>
        /// The template application policy. Valid values:
        /// 
        /// *   all (default): deletes all the rules that are created by using the alert template from the selected application group, and then creates alert rules based on the template.
        /// *   append: deletes the rules that are created by using the alert template from the selected application group, and then creates alert rules based on the existing template.
        /// </summary>
        [NameInMap("AppendMode")]
        [Validation(Required=false)]
        public string AppendMode { get; set; }

        /// <summary>
        /// The mode in which the alert template is applied. Valid values:
        /// 
        /// *   GROUP_INSTANCE_FIRST: The metrics in the application group take precedence. If a metric specified in the alert template does not exist in the application group, the system does not generate an alert rule for the metric based on the alert template.
        /// *   ALARM_TEMPLATE_FIRST: The metrics specified in the alert template take precedence. If a metric specified in the alert template does not exist in the application group, the system still generates an alert rule for the metric based on the alert template.
        /// </summary>
        [NameInMap("ApplyMode")]
        [Validation(Required=false)]
        public string ApplyMode { get; set; }

        /// <summary>
        /// The end of the time period during which the alert rule is effective. Valid values: 00 to 23. A value of 00 indicates 00:59 and a value of 23 indicates 23:59.
        /// </summary>
        [NameInMap("EnableEndTime")]
        [Validation(Required=false)]
        public long? EnableEndTime { get; set; }

        /// <summary>
        /// The beginning of the time period during which the alert rule is effective. Valid values: 00 to 23. A value of 00 indicates 00:00 and a value of 23 indicates 23:00.
        /// </summary>
        [NameInMap("EnableStartTime")]
        [Validation(Required=false)]
        public long? EnableStartTime { get; set; }

        /// <summary>
        /// The ID of the application group to which the alert template is applied.
        /// 
        /// For more information about how to query the ID of an application group, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The alert notification method. Valid values:
        /// 
        /// Set the value to 4. A value of 4 indicates that alert notifications are sent by using TradeManager and DingTalk chatbots.
        /// </summary>
        [NameInMap("NotifyLevel")]
        [Validation(Required=false)]
        public long? NotifyLevel { get; set; }

        /// <summary>
        /// The mute period during which notifications are not repeatedly sent for an alert. Unit: seconds. Default value: 86400.
        /// 
        /// >  Only one alert notification is sent during each mute period even if the metric value exceeds the alert threshold several times.
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        /// <summary>
        /// The ID of the alert template.
        /// 
        /// For more information about how to query the IDs of alert templates, see [DescribeMetricRuleTemplateList](https://help.aliyun.com/document_detail/114982.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public string TemplateIds { get; set; }

        /// <summary>
        /// The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
