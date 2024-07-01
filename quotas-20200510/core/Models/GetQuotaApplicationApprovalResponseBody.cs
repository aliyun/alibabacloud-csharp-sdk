// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaApplicationApprovalResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether retries are allowed. Valid values:
        /// 
        /// *   false
        /// *   true
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// The dynamic error code.
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// The dynamic error message.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// The parameters whose values are invalid.
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The information about quota application approval.
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public GetQuotaApplicationApprovalResponseBodyModule Module { get; set; }
        public class GetQuotaApplicationApprovalResponseBodyModule : TeaModel {
            /// <summary>
            /// The average amount of time required to approve quota applications. Unit: hour.
            /// </summary>
            [NameInMap("ApprovalHours")]
            [Validation(Required=false)]
            public int? ApprovalHours { get; set; }

            /// <summary>
            /// The interval between two consecutive approval reminders. Unit: hour.
            /// </summary>
            [NameInMap("ReminderIntervalHours")]
            [Validation(Required=false)]
            public int? ReminderIntervalHours { get; set; }

            /// <summary>
            /// Indicates whether approval reminders are supported for quota applications. Valid values:
            /// 
            /// *   false
            /// *   true
            /// </summary>
            [NameInMap("SupportReminder")]
            [Validation(Required=false)]
            public bool? SupportReminder { get; set; }

            /// <summary>
            /// The reason why approval reminders are not supported for quota applications.
            /// </summary>
            [NameInMap("UnsupportReminderReason")]
            [Validation(Required=false)]
            public string UnsupportReminderReason { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
