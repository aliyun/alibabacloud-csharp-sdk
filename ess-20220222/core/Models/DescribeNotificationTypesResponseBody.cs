// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeNotificationTypesResponseBody : TeaModel {
        /// <summary>
        /// The types of the notifications.
        /// 
        /// *   AUTOSCALING:SCALE_OUT_SUCCESS: The scale-out activity succeeds.
        /// *   AUTOSCALING:SCALE_IN_SUCCESS: The scale-in activity succeeds.
        /// *   AUTOSCALING:SCALE_OUT_ERROR: The scale-out activity fails.
        /// *   AUTOSCALING:SCALE_IN_ERROR: The scale-in activity fails.
        /// *   AUTOSCALING:SCALE_REJECT: The request for scaling activities is rejected.
        /// *   AUTOSCALING:SCALE_OUT_START: The scale-out activity starts.
        /// *   AUTOSCALING:SCALE_IN_START: The scale-in activity starts.
        /// *   AUTOSCALING:SCHEDULE_TASK_EXPIRING: Auto Scaling sends a notification when a scheduled task is about to expire.
        /// </summary>
        [NameInMap("NotificationTypes")]
        [Validation(Required=false)]
        public List<string> NotificationTypes { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
