// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomMetricRuleRequest : TeaModel {
        /// <summary>
        /// The comparison operator before the threshold. Valid values:
        /// 
        /// *   `>=`
        /// *   `=`
        /// *   `<=`
        /// *   `>`
        /// *   `<`
        /// *   `!=`
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ComparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// The alert group that receives alert notifications. Separate multiple alert groups with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// The time period during which the alert rule is effective. Valid values: 00:00 to 23:59.
        /// </summary>
        [NameInMap("EffectiveInterval")]
        [Validation(Required=false)]
        public string EffectiveInterval { get; set; }

        /// <summary>
        /// The subject of the alert notification email.
        /// </summary>
        [NameInMap("EmailSubject")]
        [Validation(Required=false)]
        public string EmailSubject { get; set; }

        /// <summary>
        /// The consecutive number of times for which the metric value is measured before an alert is triggered.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// The ID of the application group to which the custom monitoring data belongs.
        /// 
        /// >  The value 0 indicates that the reported custom monitoring data does not belong to an application group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The level of the alert. Valid values:
        /// 
        /// *   CRITICAL
        /// *   WARN
        /// *   INFO
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// >  For more information about how to obtain the metric name, see [DescribeCustomMetricList](https://help.aliyun.com/document_detail/115005.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The cycle that is used to aggregate custom monitoring data. Unit: seconds. Set the value to an integral multiple of 60. The original reporting cycle of custom monitoring data is used by default.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// The custom monitoring data to which the alert rule applies. The value includes the application group ID to which the custom monitoring data belongs and the dimension to which the metric belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// >  You can specify an existing ID to modify the corresponding alert rule or specify a new ID to create an alert rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The name of the alert rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The mute period during which notifications are not repeatedly sent for an alert. Unit: seconds. Default value: 86400. The default value indicates one day.
        /// 
        /// >  Only one alert notification is sent during each mute period even if the metric value consecutively exceeds the alert threshold several times.
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public int? SilenceTime { get; set; }

        /// <summary>
        /// The method that is used to calculate the metric values that trigger alerts.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// The threshold of the metric value.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

        /// <summary>
        /// The callback URL to which a POST request is sent when an alert is triggered based on the alert rule.
        /// </summary>
        [NameInMap("Webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
