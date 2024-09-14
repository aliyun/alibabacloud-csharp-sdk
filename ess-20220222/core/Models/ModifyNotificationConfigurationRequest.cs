// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyNotificationConfigurationRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the notification method. The following list describes the value formats of this parameter:
        /// 
        /// *   If you use CloudMonitor as the notification method, specify the value in the `acs:ess:{region-id}:{account-id}:cloudmonitor` format.
        /// *   If you use an MNS queue as the notification method, specify the value in the `acs:mns:{region-id}:{account-id}:queue/{queuename}` format.
        /// *   If you use an MNS topic as the notification method, specify the value in the `acs:mns:{region-id}:{account-id}:topic/{topicname}` format.
        /// 
        /// The variables in the preceding formats have the following meanings:
        /// 
        /// *   region-id: the region ID of your scaling group.
        /// *   account-id: the ID of your Alibaba Cloud.
        /// *   queuename: the name of the MNS queue.
        /// *   topicname: the name of the MNS topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NotificationArn")]
        [Validation(Required=false)]
        public string NotificationArn { get; set; }

        /// <summary>
        /// The event types.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NotificationTypes")]
        [Validation(Required=false)]
        public List<string> NotificationTypes { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the scaling group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The time zone of the notification. Specify the value in UTC. For example, a value of UTC+8 specifies that the time is 8 hours ahead of Coordinated Universal Time, and a value of UTC-7 specifies that the time is 7 hours behind Coordinated Universal Time.
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
