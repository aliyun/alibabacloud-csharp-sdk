// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeNotificationTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The types of the notifications.</para>
        /// <list type="bullet">
        /// <item><description>AUTOSCALING:SCALE_OUT_SUCCESS: The scale-out activity succeeds.</description></item>
        /// <item><description>AUTOSCALING:SCALE_IN_SUCCESS: The scale-in activity succeeds.</description></item>
        /// <item><description>AUTOSCALING:SCALE_OUT_ERROR: The scale-out activity fails.</description></item>
        /// <item><description>AUTOSCALING:SCALE_IN_ERROR: The scale-in activity fails.</description></item>
        /// <item><description>AUTOSCALING:SCALE_REJECT: The request for scaling activities is rejected.</description></item>
        /// <item><description>AUTOSCALING:SCALE_OUT_START: The scale-out activity starts.</description></item>
        /// <item><description>AUTOSCALING:SCALE_IN_START: The scale-in activity starts.</description></item>
        /// <item><description>AUTOSCALING:SCHEDULE_TASK_EXPIRING: Auto Scaling sends a notification when a scheduled task is about to expire.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NotificationTypes")]
        [Validation(Required=false)]
        public List<string> NotificationTypes { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
