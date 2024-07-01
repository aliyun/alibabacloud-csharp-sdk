// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaAlarmResponseBody : TeaModel {
        /// <summary>
        /// The details of the quota alert.
        /// </summary>
        [NameInMap("QuotaAlarm")]
        [Validation(Required=false)]
        public GetQuotaAlarmResponseBodyQuotaAlarm QuotaAlarm { get; set; }
        public class GetQuotaAlarmResponseBodyQuotaAlarm : TeaModel {
            /// <summary>
            /// The ID of the quota alert.
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public string AlarmId { get; set; }

            /// <summary>
            /// The name of the quota alert.
            /// </summary>
            [NameInMap("AlarmName")]
            [Validation(Required=false)]
            public string AlarmName { get; set; }

            /// <summary>
            /// The time when the quota alert was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The alert notification methods.
            /// </summary>
            [NameInMap("NotifyChannels")]
            [Validation(Required=false)]
            public List<string> NotifyChannels { get; set; }

            /// <summary>
            /// The alert contact.
            /// </summary>
            [NameInMap("NotifyTarget")]
            [Validation(Required=false)]
            public string NotifyTarget { get; set; }

            /// <summary>
            /// The abbreviation of the cloud service name.
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

            /// <summary>
            /// The quota dimension.
            /// </summary>
            [NameInMap("QuotaDimension")]
            [Validation(Required=false)]
            public Dictionary<string, object> QuotaDimension { get; set; }

            /// <summary>
            /// The used quota.
            /// </summary>
            [NameInMap("QuotaUsage")]
            [Validation(Required=false)]
            public float? QuotaUsage { get; set; }

            /// <summary>
            /// The quota value.
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public float? QuotaValue { get; set; }

            /// <summary>
            /// The numeric value of the alert threshold.
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

            /// <summary>
            /// The percentage of the alert threshold.
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
            /// The webhook URL. Quota Center sends alert notifications to the specified URL by using HTTP POST requests.
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
