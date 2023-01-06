// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaApplicationResponseBody : TeaModel {
        /// <summary>
        /// The details about the application.
        /// </summary>
        [NameInMap("QuotaApplication")]
        [Validation(Required=false)]
        public GetQuotaApplicationResponseBodyQuotaApplication QuotaApplication { get; set; }
        public class GetQuotaApplicationResponseBodyQuotaApplication : TeaModel {
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
            /// The approved quota value.
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
            /// The quota for which you apply.
            /// </summary>
            [NameInMap("DesireValue")]
            [Validation(Required=false)]
            public int? DesireValue { get; set; }

            /// <summary>
            /// The quota dimensions.
            /// 
            /// Format: `{"regionId":"Region"}`.
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public Dictionary<string, object> Dimension { get; set; }

            /// <summary>
            /// The time when the quota took effect.
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// The time when the quota expired.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The notification method. Valid values:
            /// 
            /// *   0: Quota Center does not send a notification.
            /// *   1: Quota Center sends an email notification.
            /// *   2: Quota Center sends an SMS notification.
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public long? NoticeType { get; set; }

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
            /// The unit of the quota.
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
            /// *   Process: The application is pending approval.
            /// *   Cancel: The application is closed.
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

    }

}
