// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskFlowNotificationResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The notification settings specified by the user.
        /// </summary>
        [NameInMap("Notification")]
        [Validation(Required=false)]
        public GetTaskFlowNotificationResponseBodyNotification Notification { get; set; }
        public class GetTaskFlowNotificationResponseBodyNotification : TeaModel {
            /// <summary>
            /// Indicates whether notifications for failed task flows are enabled. Valid values:
            /// 
            /// *   **true**: enabled
            /// *   **false**: disabled
            /// </summary>
            [NameInMap("DagNotificationFail")]
            [Validation(Required=false)]
            public bool? DagNotificationFail { get; set; }

            /// <summary>
            /// Indicates whether service level agreement (SLA) global notifications for task flows are enabled. Valid values:
            /// 
            /// *   **true**: enabled
            /// *   **false**: disabled
            /// </summary>
            [NameInMap("DagNotificationSla")]
            [Validation(Required=false)]
            public bool? DagNotificationSla { get; set; }

            /// <summary>
            /// Indicates whether notifications for successful task flows are enabled. Valid values:
            /// 
            /// *   **true**: enabled
            /// *   **false**: disabled
            /// </summary>
            [NameInMap("DagNotificationSuccess")]
            [Validation(Required=false)]
            public bool? DagNotificationSuccess { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
