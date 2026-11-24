// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateLifecycleHookRequest : TeaModel {
        /// <summary>
        /// <para>The action to be performed after the wait state ends. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>CONTINUE: Continues the response to the scale-out or scale-in activity.</description></item>
        /// <item><description>ABANDON: Releases the ECS instances created by the scale-out activity or removes the ECS instances in the scale-in activity from the scaling group. </description></item>
        /// <item><description>ROLLBACK: Rejects the release of ECS instances and rolls back the scale-in activity. For a scale-out activity, this value directly releases the created ECS instances, which has the same effect as ABANDON.</description></item>
        /// </list>
        /// <para>When a scale-in activity occurs in the scaling group and multiple lifecycle hooks are triggered, if the DefaultResult of one lifecycle hook is set to ABANDON or ROLLBACK and the wait state of the hook ends, the wait states of other lifecycle hooks are ended in advance. In other cases, the action to be performed is subject to the action of the last lifecycle hook whose wait state ends.</para>
        /// <para>Default value: CONTINUE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTINUE</para>
        /// </summary>
        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        /// <summary>
        /// <para>The wait time configured by the lifecycle hook for the scaling activity. After the wait state times out, the next action is performed. Valid values: 30 to 21600. Unit: seconds.</para>
        /// <para>After you create a lifecycle hook, you can call RecordLifecycleActionHeartbeat to extend the wait time of the ECS instance, or call CompleteLifecycleAction to end the wait state of the scaling activity in advance. </para>
        /// <para>Default value: 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("HeartbeatTimeout")]
        [Validation(Required=false)]
        public int? HeartbeatTimeout { get; set; }

        /// <summary>
        /// <para>The specific scenarios triggered by the lifecycle hook.</para>
        /// </summary>
        [NameInMap("LifecycleActionSources")]
        [Validation(Required=false)]
        public List<string> LifecycleActionSources { get; set; }

        /// <summary>
        /// <para>The name of the lifecycle hook. The name must be unique among all lifecycle hooks in the current scaling group. It must be 2 to 64 characters in length, start with a digit, an uppercase or lowercase letter, or a Chinese character, and can contain digits, underscores (_), hyphens (-), and periods (.).</para>
        /// <para>Default value: the value of LifecycleHookId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lifecyclehook****</para>
        /// </summary>
        [NameInMap("LifecycleHookName")]
        [Validation(Required=false)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// <para>The type of scaling activity to which the lifecycle hook applies. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>SCALE_OUT: scale-out activity of the scaling group. </description></item>
        /// <item><description>SCALE_IN: scale-in activity of the scaling group.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCALE_OUT</para>
        /// </summary>
        [NameInMap("LifecycleTransition")]
        [Validation(Required=false)]
        public string LifecycleTransition { get; set; }

        /// <summary>
        /// <para>The identifier of the notification recipient for the lifecycle hook. If you do not specify this parameter, no notifications are sent. If you specify this parameter, the following notification methods are supported:</para>
        /// <list type="bullet">
        /// <item><description>MNS queue. Format: acs:mns:{region-id}:{account-id}:queue/{queuename}.</description></item>
        /// <item><description>MNS topic. Format: acs:mns:{region-id}:{account-id}:topic/{topicname}.</description></item>
        /// <item><description>OOS template. Format: acs:oos:{region-id}:{account-id}:template/{templatename}.</description></item>
        /// <item><description>EventBridge. Format: acs:eventbridge:{region-id}:{account-id}:eventbus/default.</description></item>
        /// </list>
        /// <para>The variables in the formats have the following meanings:</para>
        /// <list type="bullet">
        /// <item><description>region-id: the ID of the region where the scaling group resides.</description></item>
        /// <item><description>account-id: the Alibaba Cloud account ID. The ID of a Resource Access Management (RAM) user is not supported.</description></item>
        /// <item><description>queuename: the name of the MNS queue.</description></item>
        /// <item><description>topicname: the name of the MNS topic.</description></item>
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
        /// <para>The notification message pushed to the NotificationArn (notification recipient) when the lifecycle hook pauses the scaling activity. This parameter helps you manage and mark different types of notification messages. You must specify NotificationArn together with this parameter. The value can be up to 4,096 characters in length.</para>
        /// <para>If NotificationArn is set to an OOS template, including a public or custom template, NotificationMetadata must be specified as a JSON string that matches the parameters of the OOS template. For example, <c>{&quot;dbInstanceId&quot;: &quot;dds-bp17661e0135****&quot;, &quot;modifyMode&quot;: &quot;Append&quot;}</c>, where <c>dbInstanceId</c> and <c>modifyMode</c> are parameters defined in the OOS template. Some parameters of the OOS template have default values. You must specify parameters without default values in NotificationMetadata. If you specify parameters with default values, the original default values are overwritten. However, keep the default values for the following parameters to obtain relevant information at runtime:</para>
        /// <list type="bullet">
        /// <item><description><para><c>regionId</c>: the region where the scaling activity is executed. Default value: ${regionId}.</para>
        /// </description></item>
        /// <item><description><para><c>instanceIds</c>: the list of instances associated with the scaling activity. Default value: ${instanceIds}.</para>
        /// </description></item>
        /// <item><description><para><c>lifecycleHookId</c>: the ID of the lifecycle hook. Default value: ${lifecycleHookId}.</para>
        /// </description></item>
        /// <item><description><para><c>lifecycleActionToken</c>: the wait state identifier for the scaling activity, which is used to end the current suspended activity in advance. Default value: ${lifecycleActionToken}.</para>
        /// </description></item>
        /// <item><description><para><c>scalingGroupId</c>: the ID of the scaling group to which the scaling activity belongs. Default value: ${scalingGroupId}.</para>
        /// </description></item>
        /// <item><description><para><c>lifecycleActionResult</c>: the action to be performed after the wait state of the lifecycle hook ends. This parameter is used to end the current suspended activity in advance when the OOS template execution fails. When DefaultResult is set to ROLLBACK, the default value of this parameter is ROLLBACK. In other cases, the default value is ABANDON.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can configure the value of lifecycleActionResult to overwrite the current default value as needed. Valid values: ABANDON, CONTINUE, ROLLBACK, and ${lifecycleActionResult}.
        /// Among these values, ${lifecycleActionResult} indicates that the value of lifecycleActionResult is the same as that of DefaultResult.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can obtain detailed information about the parameters of the corresponding template in the <a href="https://oos.console.aliyun.com/">OOS console</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Test lifecycle hook.</para>
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
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1eyv4qn8ssgv43****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
