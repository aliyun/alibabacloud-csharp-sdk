// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomEventRuleRequest : TeaModel {
        /// <summary>
        /// The alert contact group that receives alert notifications. Separate multiple contact groups with commas (,).
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
        /// The name of the custom event. For more information about how to obtain the event name, see [DescribeCustomEventAttribute](https://help.aliyun.com/document_detail/115262.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The ID of the application group. For more information about how to obtain the group ID, see [DescribeCustomEventAttribute](https://help.aliyun.com/document_detail/115262.html).
        /// 
        /// >  The value 0 indicates that the reported custom event does not belong to any application Group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The level of the alert. Valid values:
        /// 
        /// *   CRITICAL: critical issue
        /// *   WARN: warning
        /// *   INFO: information
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The cycle that is used to aggregate monitoring data of the custom event. Unit: seconds. Set the value to an integral multiple of 60. Default value: 300.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The alert threshold.
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
