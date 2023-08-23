// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateLifecycleHookRequest : TeaModel {
        /// <summary>
        /// The action that you want Auto Scaling to perform after the lifecycle hook times out. Valid values:
        /// 
        /// *   CONTINUE: Auto Scaling continues to respond to scale-in or scale-out requests.
        /// *   ABANDON: Auto Scaling releases ECS instances that are created during scale-out activities or removes ECS instances from the scaling group during scale-in activities.
        /// *   ROLLBACK: For scale-in activities, Auto Scaling rejects the requests to release ECS instances but rolls back ECS instances. For scale-out activities, the ROLLBACK setting has the same effect as the ABANDON setting.
        /// 
        /// If a scaling group has multiple lifecycle hooks in effect and you set the DefaultResult parameter for one of the lifecycle hooks to ABANDON or ROLLBACK, the following rule applies to scale-in activities: When the lifecycle hook whose DefaultResult parameter is set to ABANDON or ROLLBACK times out, other lifecycle hooks time out ahead of schedule. In other cases, Auto Scaling performs the action only after all lifecycle hooks time out. The action that Auto Scaling performs is specified by the DefaultResult parameter of the last lifecycle hook that times out.
        /// 
        /// Default value: CONTINUE.
        /// </summary>
        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        /// <summary>
        /// The period of time before the lifecycle hook times out. When the lifecycle hook times out, Auto Scaling performs the action specified by the DefaultResult parameter. Valid values: 30 to 21600. Unit: seconds.
        /// 
        /// After you create a lifecycle hook, you can call the RecordLifecycleActionHeartbeat operation to extend the timeout period of the lifecycle hook. You can also call the CompleteLifecycleAction operation to end the timeout period ahead of schedule.
        /// 
        /// Default value: 600.
        /// </summary>
        [NameInMap("HeartbeatTimeout")]
        [Validation(Required=false)]
        public int? HeartbeatTimeout { get; set; }

        /// <summary>
        /// The name of the lifecycle hook. Each lifecycle hook name must be unique within a scaling group. The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (\_), hyphens (-), and periods (.). The name must start with a letter or a digit.
        /// 
        /// If you do not specify this parameter, the value of the LifecycleHookId parameter is used.
        /// </summary>
        [NameInMap("LifecycleHookName")]
        [Validation(Required=false)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// The type of the scaling activity to which you want to apply the lifecycle hook. Valid values:
        /// 
        /// *   SCALE_OUT: scale-out activity.
        /// *   SCALE_IN: scale-in activity.
        /// </summary>
        [NameInMap("LifecycleTransition")]
        [Validation(Required=false)]
        public string LifecycleTransition { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the notification method. If you do not specify this parameter, no notification is sent when the lifecycle hook takes effect. If you specify this parameter, the following rules apply:
        /// 
        /// *   If you use a Message Service (MNS) queue as the notification method, specify the value in the acs:mns:{region-id}:{account-id}:queue/{queuename} format.
        /// *   If you use an MNS topic as the notification method, specify the value in the acs:mns:{region-id}:{account-id}:topic/{topicname} format.
        /// *   If you use an OOS template as the notification method, specify the value in the acs:oos:{region-id}:{account-id}:template/{templatename} format.
        /// 
        /// The variables in the preceding formats have the following meanings:
        /// 
        /// *   region-id: the region ID of the scaling group.
        /// *   account-id: the ID of the Alibaba Cloud account. The ID of a RAM user is not supported.
        /// *   queuename: the name of the MNS queue.
        /// *   topicname: the name of the MNS topic.
        /// *   templatename: the name of the OOS template.
        /// </summary>
        [NameInMap("NotificationArn")]
        [Validation(Required=false)]
        public string NotificationArn { get; set; }

        /// <summary>
        /// The notification metadata that is sent when the lifecycle hook takes effect. This helps you manage and categorize notifications in an efficient manner. If you specify this parameter, you must also specify the NotificationArn parameter. The value of this parameter cannot exceed 4,096 characters in length.
        /// 
        /// The fixed string that is included in a notification that Auto Scaling sends when the lifecycle hook takes effect. Auto Scaling sends the value of the NotificationMetadata parameter together with the notification. This helps you categorize your notifications. For example, your OOS template includes the following parameters: `{"dbInstanceId": "dds-bp17661e0135****", "modifyMode": "Append"}`, `dbInstanceId`, and `modifyMode`. Specific parameters that are defined in your OOS template have default values. When you specify the NotificationMetadata parameter, specify parameters that do not have default values. If you specify parameters that have default values, the default values are overwritten. The default values of the following parameters must be retained to obtain information about scaling activities that are in progress:
        /// 
        /// *   `regionId`: the region ID of the scaling activity that is in progress. Default value: ${regionId}.
        /// *   `instanceIds`: the IDs of ECS instances that are scaled in the scaling activity. Default value: ${instanceIds}.
        /// *   `lifecycleHookId`: the ID of the lifecycle hook. Default value: ${lifecycleHookId}.
        /// *   `lifecycleActionToken`: the token of the lifecycle hook. You can use the token to end the timeout period of the lifecycle hook ahead of schedule. Default value: ${lifecycleActionToken}
        /// *   `scalingGroupId`: the ID of the scaling group in which the scaling activity is executed. Default value: ${scalingGroupId}.
        /// *   `lifecycleActionResult`: the action that Auto Scaling performs after the lifecycle hook times out. If the OOS template fails to be executed, the lifecycle hook times out ahead of schedule. If you set the DefalutResult parameter to ROLLBACK, the default value of this parameter is ROLLBACK. If you set the DefaultResult parameter to other values, the default value of this parameter is ABANDON.
        /// 
        /// > 
        /// 
        /// *   You can specify a value for the lifecycleActionResult parameter to overwrite the default value. Valid values: ABANDON, CONTINUE, ROLLBACK, and ${lifecycleActionResult}.
        /// 
        /// A value of ${lifecycleActionResult} specifies that the value of the lifecycleActionResult parameter is the same as the value of the DefaultResult parameter.
        /// 
        /// *   You can view the details of the OOS template that you specify in the [OOS](https://oos.console.aliyun.com/) console.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
