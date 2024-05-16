// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateNotificationConfigurationRequest : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the notification method. The following list describes the value formats of this parameter:
        /// 
        /// *   If you use CloudMonitor as the notification method, the value format of this parameter is acs:ess:{region-id}:{account-id}:cloudmonitor.
        /// *   If you use an MNS queue as the notification method, the value format of this parameter is acs:mns:{region-id}:{account-id}:queue/{queuename}.
        /// *   If you use an MNS topic as the notification method, the value format of this parameter is acs:mns:{region-id}:{account-id}:topic/{topicname}.
        /// 
        /// The variables in the preceding formats have the following meanings:
        /// 
        /// *   region-id: the region ID of the scaling group.
        /// *   account-id: the ID of the Alibaba Cloud account.
        /// *   queuename: the name of the MNS queue.
        /// *   topicname: the name of the MNS topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NotificationArn")]
        [Validation(Required=false)]
        public string NotificationArn { get; set; }

        /// <summary>
        /// The types of the notifications that you want to create. You can create one to eight notifications. Specify multiple values in the repeated list form.
        /// 
        /// You can call the DescribeNotificationTypes operation to query the values of this parameter.
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

    }

}
