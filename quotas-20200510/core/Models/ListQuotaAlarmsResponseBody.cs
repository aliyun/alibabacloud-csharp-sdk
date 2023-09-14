// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaAlarmsResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of records that are returned for the query.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position at which the query ends.
        /// 
        /// > An empty value indicates that all data is returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The details about the quota alert.
        /// </summary>
        [NameInMap("QuotaAlarms")]
        [Validation(Required=false)]
        public List<ListQuotaAlarmsResponseBodyQuotaAlarms> QuotaAlarms { get; set; }
        public class ListQuotaAlarmsResponseBodyQuotaAlarms : TeaModel {
            /// <summary>
            /// The ID of the alert.
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public string AlarmId { get; set; }

            /// <summary>
            /// The name of the alert event.
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
            /// Indicates whether the alert threshold was reached. Valid values:
            /// 
            /// *   false
            /// *   true
            /// </summary>
            [NameInMap("ExceedThreshold")]
            [Validation(Required=false)]
            public bool? ExceedThreshold { get; set; }

            [NameInMap("NotifyChannels")]
            [Validation(Required=false)]
            public List<string> NotifyChannels { get; set; }

            /// <summary>
            /// The alert contact. The value is accountContact.
            /// </summary>
            [NameInMap("NotifyTarget")]
            [Validation(Required=false)]
            public string NotifyTarget { get; set; }

            /// <summary>
            /// The abbreviation of the Alibaba Cloud service name.
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
            /// The quota dimensions.
            /// </summary>
            [NameInMap("QuotaDimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> QuotaDimensions { get; set; }

            /// <summary>
            /// The used quota.
            /// </summary>
            [NameInMap("QuotaUsage")]
            [Validation(Required=false)]
            public float? QuotaUsage { get; set; }

            /// <summary>
            /// The value of the quota.
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
            /// The webhook URL.
            /// </summary>
            [NameInMap("WebHook")]
            [Validation(Required=false)]
            public string WebHook { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of quota alerts.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
