// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyLifecycleHookRequest : TeaModel {
        /// <summary>
        /// The action that you want Auto Scaling to perform after the lifecycle hook times out. Valid values:
        /// 
        /// *   CONTINUE: Auto Scaling continues to respond to scale-in or scale-out requests.
        /// *   ABANDON: Auto Scaling releases Elastic Compute Service (ECS) instances that are created during scale-out activities or removes ECS instances from the scaling group during scale-in activities.
        /// *   ROLLBACK: For scale-in activities, Auto Scaling rejects the requests to release ECS instances but rolls back ECS instances. For scale-out activities, the ROLLBACK setting has the same effect as the ABANDON setting.
        /// 
        /// If a scaling group has multiple lifecycle hooks in effect and you set the DefaultResult parameter for one of the lifecycle hooks to ABANDON or ROLLBACK, the following rule applies to scale-in activities: When the lifecycle hook whose DefaultResult parameter is set to ABANDON or ROLLBACK times out, other lifecycle hooks time out ahead of schedule. In other cases, Auto Scaling performs the action only after all lifecycle hooks time out. The action that Auto Scaling performs is specified by the DefaultResult parameter of the last lifecycle hook that times out.
        /// </summary>
        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        /// <summary>
        /// The period of time before the lifecycle hook times out. When the lifecycle hook times out, Auto Scaling performs the action specified by the DefaultResult parameter. Valid values: 30 to 21600. Unit: seconds.
        /// 
        /// You can call the RecordLifecycleActionHeartbeat operation to extend the period of time before a lifecycle hook times out. You can also call the CompleteLifecycleAction operation to end a lifecycle hook ahead of schedule.
        /// </summary>
        [NameInMap("HeartbeatTimeout")]
        [Validation(Required=false)]
        public int? HeartbeatTimeout { get; set; }

        /// <summary>
        /// The ID of the lifecycle hook that you want to modify.
        /// </summary>
        [NameInMap("LifecycleHookId")]
        [Validation(Required=false)]
        public string LifecycleHookId { get; set; }

        /// <summary>
        /// The name of the lifecycle hook that you want to modify.
        /// </summary>
        [NameInMap("LifecycleHookName")]
        [Validation(Required=false)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// The status that you want to specify for the lifecycle hook. Valid values:
        /// 
        /// *   Active
        /// *   InActive
        /// 
        /// If you do not specify this parameter, the status of the lifecycle hook remains unchanged after you call this operation.
        /// 
        /// > By default, a lifecycle hook is in the Active state after you create it.
        /// </summary>
        [NameInMap("LifecycleHookStatus")]
        [Validation(Required=false)]
        public string LifecycleHookStatus { get; set; }

        /// <summary>
        /// The type of the scaling activity to which the lifecycle hook applies. Valid values:
        /// 
        /// *   SCALE_OUT: scale-out activity
        /// *   SCALE_IN: scale-in activity
        /// </summary>
        [NameInMap("LifecycleTransition")]
        [Validation(Required=false)]
        public string LifecycleTransition { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the notification method.
        /// 
        /// *   If the notification method is a Message Service (MNS) queue, specify the value in the acs:mns:{region-id}:{account-id}:queue/{queuename} format.
        /// *   If the notification method is an MNS topic, specify the value in the acs:mns:{region-id}:{account-id}:topic/{topicname} format.
        /// *   If the notification method is an Operation Orchestration Service (OOS) template, specify the value in the acs:oos:{region-id}:{account-id}:template/{templatename} format.
        /// 
        /// The variables in the preceding formats have the following meanings:
        /// 
        /// *   region-id: the region ID of the scaling group.
        /// *   account-id: the ID of the Alibaba Cloud account.
        /// *   queuename: the name of the MNS queue.
        /// *   topicname: the name of the MNS topic.
        /// *   templatename: the name of the OOS template.
        /// </summary>
        [NameInMap("NotificationArn")]
        [Validation(Required=false)]
        public string NotificationArn { get; set; }

        /// <summary>
        /// The fixed string that is included in a notification. Auto Scaling sends the notification when the lifecycle hook takes effect. The value of this parameter cannot exceed 4,096 characters in length.
        /// 
        /// Auto Scaling sends the value of the NotificationMetadata parameter together with the notification. This helps you categorize your notifications. If you specify the NotificationMetadata parameter, you must also specify the NotificationArn parameter.
        /// </summary>
        [NameInMap("NotificationMetadata")]
        [Validation(Required=false)]
        public string NotificationMetadata { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

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
        /// The ID of the scaling group to which the lifecycle hook belongs.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
