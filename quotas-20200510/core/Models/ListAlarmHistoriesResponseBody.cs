// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListAlarmHistoriesResponseBody : TeaModel {
        /// <summary>
        /// The details of the alert records.
        /// </summary>
        [NameInMap("AlarmHistories")]
        [Validation(Required=false)]
        public List<ListAlarmHistoriesResponseBodyAlarmHistories> AlarmHistories { get; set; }
        public class ListAlarmHistoriesResponseBodyAlarmHistories : TeaModel {
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
            /// The notification methods of the quota alert. Valid values:
            /// 
            /// *   sms: short messages
            /// *   email: emails
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
            /// The used quota.
            /// </summary>
            [NameInMap("QuotaUsage")]
            [Validation(Required=false)]
            public float? QuotaUsage { get; set; }

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

        }

        /// <summary>
        /// The maximum number of records returned for the query.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to mark the location where the query is ended. An empty value indicates that all the data is queried.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of records returned for the query.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
