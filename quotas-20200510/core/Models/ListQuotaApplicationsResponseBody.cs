// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of records that are returned for the query.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position at which the query ends. An empty value indicates that all data is returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The details of the applications.
        /// </summary>
        [NameInMap("QuotaApplications")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsResponseBodyQuotaApplications> QuotaApplications { get; set; }
        public class ListQuotaApplicationsResponseBodyQuotaApplications : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// The time when the application was submitted.
            /// </summary>
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            /// <summary>
            /// The quota value that is approved.
            /// </summary>
            [NameInMap("ApproveValue")]
            [Validation(Required=false)]
            public float? ApproveValue { get; set; }

            /// <summary>
            /// The result of the application.
            /// </summary>
            [NameInMap("AuditReason")]
            [Validation(Required=false)]
            public string AuditReason { get; set; }

            /// <summary>
            /// The remarks of the application.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The quota value that is approved.
            /// </summary>
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public float? DesireValue { get; set; }

            /// <summary>
            /// The dimension of the application.
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimension { get; set; }

            /// <summary>
            /// The time when the application took effect.
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// The time when the application expired.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// Indicates whether Quota Center sends a notification about the application result. Valid values:
            /// 
            /// *   0: A notification about the application result is not sent.
            /// *   3: A notification about the application result is sent.
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public int? NoticeType { get; set; }

            /// <summary>
            /// The calculation cycle of the quota.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public ListQuotaApplicationsResponseBodyQuotaApplicationsPeriod Period { get; set; }
            public class ListQuotaApplicationsResponseBodyQuotaApplicationsPeriod : TeaModel {
                /// <summary>
                /// The unit of the calculation cycle. Valid values:
                /// 
                /// *   second
                /// *   minute
                /// *   hour
                /// *   day
                /// *   week
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// The value of the calculation cycle.
                /// </summary>
                [NameInMap("PeriodValue")]
                [Validation(Required=false)]
                public long? PeriodValue { get; set; }

            }

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
            /// The Alibaba Cloud Resource Name (ARN) of the quota.
            /// </summary>
            [NameInMap("QuotaArn")]
            [Validation(Required=false)]
            public string QuotaArn { get; set; }

            /// <summary>
            /// The description of the quota.
            /// </summary>
            [NameInMap("QuotaDescription")]
            [Validation(Required=false)]
            public string QuotaDescription { get; set; }

            /// <summary>
            /// The name of the quota.
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

            /// <summary>
            /// The unit of the new quota value.
            /// </summary>
            [NameInMap("QuotaUnit")]
            [Validation(Required=false)]
            public string QuotaUnit { get; set; }

            /// <summary>
            /// The reason for the application.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The status of the application. Valid values:
            /// 
            /// *   Disagree: The application is rejected.
            /// *   Agree: The application is approved.
            /// *   Process: The application is being reviewed.
            /// *   Cancel: The application is canceled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of applications.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
