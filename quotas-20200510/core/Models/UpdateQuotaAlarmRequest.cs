// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class UpdateQuotaAlarmRequest : TeaModel {
        /// <summary>
        /// The ID of the quota alert.
        /// 
        /// >  You can call the [ListQuotaAlarms](https://help.aliyun.com/document_detail/440561.html) operation to obtain the ID of a quota alert.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public string AlarmId { get; set; }

        /// <summary>
        /// The name of the quota alert.
        /// 
        /// >  You can call the [ListQuotaAlarms](https://help.aliyun.com/document_detail/440561.html) operation to obtain the name of a quota alert.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlarmName")]
        [Validation(Required=false)]
        public string AlarmName { get; set; }

        /// <summary>
        /// The numeric value of the alert threshold. Valid values:
        /// 
        /// *   If you set the `ThresholdType` parameter to `used`, you will receive an alert notification when the used quota is greater than or equal to the preset alert threshold. The alert threshold must be greater than the current used quota.
        /// *   If you set the `ThresholdType` parameter to `usable`, you will receive an alert notification when the available quota is less than or equal to the preset alert threshold. The alert threshold must be less than the current available quota.
        /// 
        /// > You must set one of the Threshold and ThresholdPercent parameters.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        /// <summary>
        /// The percentage of the alert threshold. Valid values:
        /// 
        /// *   If you set `ThresholdType` to `used`, you receive an alert notification when the used quota is greater than or equal to the preset percentage of the alert threshold. Value range: (50%, 100%].
        /// *   If you set `ThresholdType` to `usable`, you receive an alert notification when the available quota is less than or equal to the preset percentage of the alert threshold. Value range: (0%, 50%].
        /// 
        /// >  You must set one of Threshold and ThresholdPercent.
        /// </summary>
        [NameInMap("ThresholdPercent")]
        [Validation(Required=false)]
        public float? ThresholdPercent { get; set; }

        /// <summary>
        /// The type of the quota alert. Valid values:
        /// 
        /// *   used (default): The alert is created for the used quota.
        /// *   usable: The alert is created for the available quota.
        /// </summary>
        [NameInMap("ThresholdType")]
        [Validation(Required=false)]
        public string ThresholdType { get; set; }

        /// <summary>
        /// The webhook URL. Quota Center sends alert notifications to the specified URL by using HTTP POST requests.
        /// </summary>
        [NameInMap("WebHook")]
        [Validation(Required=false)]
        public string WebHook { get; set; }

    }

}
