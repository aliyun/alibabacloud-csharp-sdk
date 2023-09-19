// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeNotificationConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// Details of the notifications.
        /// </summary>
        [NameInMap("NotificationConfigurationModels")]
        [Validation(Required=false)]
        public List<DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModels> NotificationConfigurationModels { get; set; }
        public class DescribeNotificationConfigurationsResponseBodyNotificationConfigurationModels : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the notification method. The following list describes the value formats of this parameter:
            /// 
            /// *   If you use CloudMonitor as the notification method, the value format of this parameter is acs:ess:{region-id}:{account-id}:cloudmonitor.
            /// *   If you use a Message Service (MNS) queue as the notification method, the value format of this parameter is acs:mns:{region-id}:{account-id}:queue/{queuename}.
            /// *   If you use an MNS topic as the notification method, the value format of this parameter is acs:mns:{region-id}:{account-id}:topic/{topicname}.
            /// 
            /// The variables in the preceding formats have the following meanings:
            /// 
            /// *   region-id: the region ID of the scaling group.
            /// *   account-id: the ID of the Alibaba Cloud account.
            /// *   queuename: the name of the MNS queue.
            /// *   topicname: the name of the MNS topic.
            /// </summary>
            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            /// <summary>
            /// The types of notifications for scaling activities and resource changes.
            /// 
            /// *   AUTOSCALING:SCALE_OUT_SUCCESS: The scale-out event is successful.
            /// *   AUTOSCALING:SCALE_IN_SUCCESS: The scale-in event is successful.
            /// *   AUTOSCALING:SCALE_OUT_ERROR: The scale-out event fails.
            /// *   AUTOSCALING:SCALE_IN_ERROR: The scale-in event fails.
            /// *   AUTOSCALING:SCALE_REJECT: The scaling activity is rejected.
            /// *   AUTOSCALING:SCALE_OUT_START: The scale-out event is started.
            /// *   AUTOSCALING:SCALE_IN_START: The scale-in event is started.
            /// *   AUTOSCALING:SCHEDULE_TASK_EXPIRING: Auto Scaling sends a notification when a scheduled task is about to expire.
            /// </summary>
            [NameInMap("NotificationTypes")]
            [Validation(Required=false)]
            public List<string> NotificationTypes { get; set; }

            /// <summary>
            /// The ID of the scaling group.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
