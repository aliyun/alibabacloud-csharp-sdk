// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyLifecycleHookRequest : TeaModel {
        /// <summary>
        /// <para>The subsequent action to perform after the wait state ends. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>CONTINUE: Continues the response to the scale-out or scale-down activity.</description></item>
        /// <item><description>ABANDON: Releases the ECS instances created during the scale-out activity or removes the ECS instances from the scaling group during the scale-down activity.</description></item>
        /// <item><description>ROLLBACK: Rejects the release of ECS instances and rolls back the scale-down activity. For a scale-out activity, releases the created ECS instances, which has the same effect as ABANDON.</description></item>
        /// </list>
        /// <para>If a scale-down activity is triggered and multiple lifecycle hooks are invoked, and the DefaultResult of one lifecycle hook is set to ABANDON or ROLLBACK, the wait states of other lifecycle hooks are ended in advance when the wait state of this hook ends. In other cases, the subsequent action is determined by the last lifecycle hook that ends its wait state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTINUE</para>
        /// </summary>
        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        /// <summary>
        /// <para>The wait time set by the lifecycle hook for the scaling activity. The subsequent action is performed after the wait state times out. Valid values: 30 to 21600. Unit: seconds.</para>
        /// <para>You can call the RecordLifecycleActionHeartbeat operation to extend the wait time of the ECS instance, or call the CompleteLifecycleAction operation to end the wait state of the scaling activity in advance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("HeartbeatTimeout")]
        [Validation(Required=false)]
        public int? HeartbeatTimeout { get; set; }

        /// <summary>
        /// <para>The specific scenarios that trigger the lifecycle hook.</para>
        /// </summary>
        [NameInMap("LifecycleActionSources")]
        [Validation(Required=false)]
        public List<string> LifecycleActionSources { get; set; }

        /// <summary>
        /// <para>The ID of the lifecycle hook to be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ash-bp1fxuqyi98w0aib****</para>
        /// </summary>
        [NameInMap("LifecycleHookId")]
        [Validation(Required=false)]
        public string LifecycleHookId { get; set; }

        /// <summary>
        /// <para>The name of the lifecycle hook to be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_SCAL****</para>
        /// </summary>
        [NameInMap("LifecycleHookName")]
        [Validation(Required=false)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// <para>The status of the lifecycle hook. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: Enables the lifecycle hook.</description></item>
        /// <item><description>InActive: Disables the lifecycle hook.</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the status of the lifecycle hook remains unchanged.</para>
        /// <remarks>
        /// <para>After a lifecycle hook is created, it is enabled by default.</para>
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
        /// <item><description>SCALE_OUT: Scale-out activity of the scaling group.</description></item>
        /// <item><description>SCALE_IN: Scale-in activity of the scaling group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SCALE_IN</para>
        /// </summary>
        [NameInMap("LifecycleTransition")]
        [Validation(Required=false)]
        public string LifecycleTransition { get; set; }

        /// <summary>
        /// <para>The identifier of the notification recipient for the lifecycle hook. The following notification methods are supported:</para>
        /// <list type="bullet">
        /// <item><description>Message Service (MNS) queue. Format: acs:mns:{region-id}:{account-id}:queue/{queuename}.</description></item>
        /// <item><description>MNS topic. Format: acs:mns:{region-id}:{account-id}:topic/{topicname}.</description></item>
        /// <item><description>Operation Orchestration Service (OOS) template. Format: acs:oos:{region-id}:{account-id}:template/{templatename}.</description></item>
        /// <item><description>EventBridge. Format: acs:eventbridge:{region-id}:{account-id}:eventbus/default.</description></item>
        /// </list>
        /// <para>Variables in the formats:</para>
        /// <list type="bullet">
        /// <item><description>region-id: The ID of the region where the scaling group resides.</description></item>
        /// <item><description>account-id: The Alibaba Cloud account ID.</description></item>
        /// <item><description>queuename: The name of the MNS queue.</description></item>
        /// <item><description>topicname: The name of the MNS topic.</description></item>
        /// <item><description>templatename: The name of the OOS template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:mns:cn-beijing:161456884340****:queue/modifyLifecycleHo****</para>
        /// </summary>
        [NameInMap("NotificationArn")]
        [Validation(Required=false)]
        public string NotificationArn { get; set; }

        /// <summary>
        /// <para>The fixed string information for the wait state of the scaling activity. The value can be up to 4,096 characters in length.</para>
        /// <para>When Auto Scaling pushes a message to the notification recipient, it also sends the predefined NotificationMetadata value to help you manage and tag different types of notifications. This parameter takes effect only when the NotificationArn parameter is specified.</para>
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
