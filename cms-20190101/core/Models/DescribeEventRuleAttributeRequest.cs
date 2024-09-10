// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleAttributeRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the event-triggered alert rule.
        /// 
        /// For information about how to obtain the name of an event-triggered alert rule, see [DescribeEventRuleList](https://help.aliyun.com/document_detail/114996.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The mute period during which new alert notifications are not sent even if the trigger conditions are met.
        /// 
        /// Unit: seconds. Default value: 86400, which indicates one day.
        /// 
        /// >  Only one alert notification is sent during each mute period even if the metric value exceeds the alert threshold several times.
        /// </summary>
        [NameInMap("SilenceTime")]
        [Validation(Required=false)]
        public string SilenceTime { get; set; }

    }

}
