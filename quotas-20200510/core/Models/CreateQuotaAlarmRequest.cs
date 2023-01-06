/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class CreateQuotaAlarmRequest : TeaModel {
        /// <summary>
        /// The name of the quota alert.
        /// </summary>
        [NameInMap("AlarmName")]
        [Validation(Required=false)]
        public string AlarmName { get; set; }

        /// <summary>
        /// The abbreviation of the cloud service name.
        /// 
        /// >  For more information, see [Alibaba Cloud services that support Quota Center](~~182368~~).
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The ID of the quota.
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        [NameInMap("QuotaDimensions")]
        [Validation(Required=false)]
        public List<CreateQuotaAlarmRequestQuotaDimensions> QuotaDimensions { get; set; }
        public class CreateQuotaAlarmRequestQuotaDimensions : TeaModel {
            /// <summary>
            /// The dimension keys.
            /// 
            /// The value range of N changes based on the number of dimensions that are supported by the related cloud service.
            /// 
            /// >  If you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess, this parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The dimension values.
            /// 
            /// The value range of N changes based on the number of dimensions that are supported by the related cloud service.
            /// 
            /// >  If you set the ProductCode parameter to ecs, ecs-spec, actiontrail, or ess, this parameter is required.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The numeric value of the alert threshold. The value must meet the following requirements:
        /// 
        /// *   If the `ThresholdType` parameter is set to `used` and the used quota is greater than or equal to a specified value, you receive an alert. The alert threshold must be greater than the current used quota.
        /// *   If the `ThresholdType` parameter is set to `usable` and the available quota is less than or equal to a specified value, you received an alert. The alert threshold must be less than the current available quota.
        /// 
        /// >  You must set one of the Threshold and ThresholdPercent parameters.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

        /// <summary>
        /// The percentage of the alert threshold. Valid values:
        /// 
        /// *   If the `ThresholdType` parameter is set to `used` and the percentage of the used quota in the total quota is greater than or equal to a specified value, you receive an alert. Value range: (50%, 100%].
        /// *   If the `ThresholdType` parameter is set to `usable` and the percentage of the available quota in the total quota is less than or equal to a specified value, you receive an alert. Value range: (0%, 50%].
        /// 
        /// >  You must set one of the Threshold and ThresholdPercent parameters.
        /// </summary>
        [NameInMap("ThresholdPercent")]
        [Validation(Required=false)]
        public float? ThresholdPercent { get; set; }

        /// <summary>
        /// The type of the quota alert. Valid values:
        /// 
        /// *   used: The alert is created for the used quota.
        /// *   usable: The alert is created for the available quota.
        /// </summary>
        [NameInMap("ThresholdType")]
        [Validation(Required=false)]
        public string ThresholdType { get; set; }

        /// <summary>
        /// The webhook URL. Quota Center sends the alert notification to a specified URL by using an HTTP POST request.
        /// </summary>
        [NameInMap("WebHook")]
        [Validation(Required=false)]
        public string WebHook { get; set; }

    }

}
