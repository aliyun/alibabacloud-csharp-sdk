// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowNotificationRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable notifications for successful task flows. Notifications are disabled by default. You can enable notifications based on your business requirements.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("DagNotificationFail")]
        [Validation(Required=false)]
        public bool? DagNotificationFail { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **UpdateTaskFlowNotification**.
        /// </summary>
        [NameInMap("DagNotificationSla")]
        [Validation(Required=false)]
        public bool? DagNotificationSla { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("DagNotificationSuccess")]
        [Validation(Required=false)]
        public bool? DagNotificationSuccess { get; set; }

        /// <summary>
        /// Specifies whether to enable notifications for failed task flows. Notifications are disabled by default. You can enable notifications based on your business requirements.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
