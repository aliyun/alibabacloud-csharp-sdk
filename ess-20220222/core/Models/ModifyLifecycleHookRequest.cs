// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyLifecycleHookRequest : TeaModel {
        /// <summary>
        /// <para>The action that you want Auto Scaling to perform after the lifecycle hook ends. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CONTINUE: Auto Scaling continues to respond to scaling requests.</description></item>
        /// <item><description>ABANDON: Auto Scaling releases Elastic Compute Service (ECS) instances that are created during scale-out activities, or removes ECS instances from the scaling group during scale-in activities.</description></item>
        /// </list>
        /// <para>If multiple lifecycle hooks in a scaling group are triggered during scale-in activities and you set the DefaultResult parameter to ABANDON for the lifecycle hook that you want to modify, Auto Scaling immediately performs the action after the lifecycle hook that you want to modify ends. As a result, other lifecycle hooks end ahead of schedule. In other cases, Auto Scaling performs the action only after all lifecycle hooks end.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTINUE</para>
        /// </summary>
        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        /// <summary>
        /// <para>The period of time before the lifecycle hook ends. Auto Scaling performs the specified action after the lifecycle hook ends. Valid values: 30 to 21600. Unit: seconds.</para>
        /// <para>You can call the RecordLifecycleActionHeartbeat operation to prolong the length of a lifecycle hook. You can also call the CompleteLifecycleAction operation to end a lifecycle hook ahead of schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("HeartbeatTimeout")]
        [Validation(Required=false)]
        public int? HeartbeatTimeout { get; set; }

        /// <summary>
        /// <para>The ID of the lifecycle hook that you want to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ash-bp1fxuqyi98w0aib****</para>
        /// </summary>
        [NameInMap("LifecycleHookId")]
        [Validation(Required=false)]
        public string LifecycleHookId { get; set; }

        /// <summary>
        /// <para>The name of the lifecycle hook that you want to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_SCALE_IN</para>
        /// </summary>
        [NameInMap("LifecycleHookName")]
        [Validation(Required=false)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// <para>The status into which you want to put the lifecycle hook. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active</description></item>
        /// <item><description>InActive</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the status of the lifecycle hook remains unchanged after you call this operation.</para>
        /// <remarks>
        /// <para>By default, a lifecycle hook is in the Active state after you create it.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LifecycleHookStatus")]
        [Validation(Required=false)]
        public string LifecycleHookStatus { get; set; }

        /// <summary>
        /// <para>The type of scaling activity to which the lifecycle hook applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SCALE_OUT</description></item>
        /// <item><description>SCALE_IN</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SCALE_IN</para>
        /// </summary>
        [NameInMap("LifecycleTransition")]
        [Validation(Required=false)]
        public string LifecycleTransition { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the notification recipient. Specify the value in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description>If you specify a Simple Message Queue (SMQ, formerly MNS) as the notification recipient, specify the value in the acs:mns:{region-id}:{account-id}:queue/{queuename} format.</description></item>
        /// <item><description>If you specify an SMQ topic as the notification recipient, specify the value in the acs:mns:{region-id}:{account-id}:topic/{topicname} format.</description></item>
        /// <item><description>If you specify a CloudOps Orchestration Service (OOS) template as the notification recipient, specify the value in the acs:oos:{region-id}:{account-id}:template/{templatename} format.</description></item>
        /// <item><description>If you specify an event bus as the notification recipient, specify the value in the acs:eventbridge:{region-id}:{account-id}:eventbus/default format.</description></item>
        /// </list>
        /// <para>The variables in the preceding value formats have the following meanings:</para>
        /// <list type="bullet">
        /// <item><description>region-id: the region ID of your scaling group.</description></item>
        /// <item><description>account-id: the ID of your Alibaba Cloud account.</description></item>
        /// <item><description>queuename: the name of the SMQ queue.</description></item>
        /// <item><description>topicname: the name of the SMQ topic.</description></item>
        /// <item><description>templatename: the name of the OOS template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:mns:cn-beijing:161456884340****:queue/modifyLifecycleHo****</para>
        /// </summary>
        [NameInMap("NotificationArn")]
        [Validation(Required=false)]
        public string NotificationArn { get; set; }

        /// <summary>
        /// <para>The fixed string that is included in a notification. Auto Scaling sends the notification when the lifecycle hook takes effect. The value of this parameter cannot exceed 4,096 characters in length.</para>
        /// <para>Auto Scaling sends the value specified for the NotificationMetadata parameter together with the notification. This helps you categorize your notifications. The NotificationMetadata parameter takes effect only after you specify the NotificationArn parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
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
        /// <para>The region ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group to which the lifecycle hook belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
