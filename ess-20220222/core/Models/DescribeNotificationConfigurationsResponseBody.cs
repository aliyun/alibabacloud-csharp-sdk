// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeNotificationConfigurationsResponseBody : TeaModel {
        /// <summary>
        /// The notification settings.
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
            /// The types of the notifications.
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

            /// <summary>
            /// The time zone of the notification. The value must be in UTC. For example, a value of UTC+8 indicates that the time is 8 hours ahead of Coordinated Universal Time, and a value of UTC-7 indicates that the time is 7 hours behind Coordinated Universal Time.
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
