// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaApplicationsForTemplateResponseBody : TeaModel {
        /// <summary>
        /// The maximum number of records that can be returned for the query.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position from which you want to start the query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The queried quota application records.
        /// </summary>
        [NameInMap("QuotaBatchApplications")]
        [Validation(Required=false)]
        public List<ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplications> QuotaBatchApplications { get; set; }
        public class ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplications : TeaModel {
            /// <summary>
            /// The Alibaba Cloud accounts for which the quotas are applied.
            /// </summary>
            [NameInMap("AliyunUids")]
            [Validation(Required=false)]
            public List<string> AliyunUids { get; set; }

            /// <summary>
            /// The time when the quota increase application was submitted. The value is displayed in UTC.
            /// </summary>
            [NameInMap("ApplyTime")]
            [Validation(Required=false)]
            public string ApplyTime { get; set; }

            /// <summary>
            /// The number of applications in different approval states.
            /// </summary>
            [NameInMap("AuditStatusVos")]
            [Validation(Required=false)]
            public List<ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplicationsAuditStatusVos> AuditStatusVos { get; set; }
            public class ListQuotaApplicationsForTemplateResponseBodyQuotaBatchApplicationsAuditStatusVos : TeaModel {
                /// <summary>
                /// The number of approval documents.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The approval status of the quota increase application. Valid values:
                /// 
                /// *   Disagree: The application is rejected.
                /// *   Agree: The application is approved.
                /// *   Process: The application is pending approval.
                /// *   Cancel: The application is canceled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The ID of the quota application batch.
            /// </summary>
            [NameInMap("BatchQuotaApplicationId")]
            [Validation(Required=false)]
            public string BatchQuotaApplicationId { get; set; }

            /// <summary>
            /// The requested value of the quota.
            /// </summary>
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public double? DesireValue { get; set; }

            /// <summary>
            /// The quota dimensions.
            /// 
            /// Format: {"regionId":"cn-hangzhou"}.
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimensions { get; set; }

            /// <summary>
            /// The start time of the validity period of the quota. The value is displayed in UTC.
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// The end time of the validity period of the quota. The value is displayed in UTC.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The abbreviation of the Alibaba Cloud service name.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The quota ID.
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// The quota type. Valid values:
            /// 
            /// *   CommonQuota: general quota
            /// *   FlowControl: API rate limit
            /// *   WhiteListLabel: privilege
            /// </summary>
            [NameInMap("QuotaCategory")]
            [Validation(Required=false)]
            public string QuotaCategory { get; set; }

            /// <summary>
            /// The reason for the quota increase application.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of records that are returned for the query.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
