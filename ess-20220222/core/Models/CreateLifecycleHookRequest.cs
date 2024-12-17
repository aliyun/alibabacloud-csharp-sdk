// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class CreateLifecycleHookRequest : TeaModel {
        /// <summary>
        /// <para>The action that you want Auto Scaling to perform after the lifecycle hook times out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CONTINUE: Auto Scaling continues to respond to scale-in or scale-out requests.</description></item>
        /// <item><description>ABANDON: Auto Scaling releases Elastic Compute Service (ECS) instances that are created during scale-out activities, or removes ECS instances from the scaling group during scale-in activities.</description></item>
        /// </list>
        /// <para>If multiple lifecycle hooks in a scaling group are triggered during scale-in activities and you set the DefaultResult parameter to ABANDON for one of the lifecycle hooks, Auto Scaling immediately performs the action after the lifecycle hook whose DefaultResult is set to ABANDON times out. As a result, other lifecycle hooks time out ahead of schedule. In other cases, Auto Scaling performs the action only after all lifecycle hooks time out.</para>
        /// <para>Default value: CONTINUE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTINUE</para>
        /// </summary>
        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        /// <summary>
        /// <para>The period of time before the lifecycle hook times out. After the lifecycle hook times out, Auto Scaling performs the default action. Valid values: 30 to 21600. Unit: seconds.</para>
        /// <para>After you create a lifecycle hook, you can call the RecordLifecycleActionHeartbeat operation to prolong the timeout period of the lifecycle hook. You can also call the CompleteLifecycleAction operation to end the timeout period of the lifecycle hook ahead of schedule.</para>
        /// <para>Default value: 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("HeartbeatTimeout")]
        [Validation(Required=false)]
        public int? HeartbeatTimeout { get; set; }

        /// <summary>
        /// <para>The name of the lifecycle hook. Each lifecycle hook name must be unique within a scaling group. The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (_), hyphens (-), and periods (.). It must start with a letter or a digit.</para>
        /// <para>If you do not specify this parameter, the value of the LifecycleHookId parameter is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lifecyclehook****</para>
        /// </summary>
        [NameInMap("LifecycleHookName")]
        [Validation(Required=false)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// <para>The type of the scaling activity to which the lifecycle hook applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SCALE_OUT</description></item>
        /// <item><description>SCALE_IN</description></item>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the notification recipient. If you do not specify this parameter, no notification is sent when the lifecycle hook takes effect. If you specify this parameter, the value must be in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description>If you specify a Simple Message Queue (SMQ, formerly MNS) as the notification recipient, specify the value in the acs:mns:{region-id}:{account-id}:queue/{queuename} format.</description></item>
        /// <item><description>If you specify an SMQ topic as the notification recipient, specify the value in the acs:mns:{region-id}:{account-id}:topic/{topicname} format.</description></item>
        /// <item><description>If you specify a CloudOps Orchestration Service (OOS) template as the notification recipient, specify the value in the acs:oos:{region-id}:{account-id}:template/{templatename} format.</description></item>
        /// <item><description>If you specify an event bus as the notification recipient, specify the value in the acs:eventbridge:{region-id}:{account-id}:eventbus/default format.</description></item>
        /// </list>
        /// <para>The variables in the preceding value formats have the following meanings:</para>
        /// <list type="bullet">
        /// <item><description>region-id: the region ID of your scaling group.</description></item>
        /// <item><description>account-id: the ID of the Alibaba Cloud account. IDs of Resource Access Management (RAM) users are not supported.</description></item>
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
        /// <para>The notification metadata that is sent when the lifecycle hook takes effect. This helps you manage and categorize notifications in an efficient manner. If you specify this parameter, you must specify the NotificationArn parameter. The parameter value cannot exceed 4,096 characters in length.</para>
        /// <para>If you use the NotificationArn parameter to specify a public or customOOS template, the value of the NotificationMetadata parameter must be a JSON string that contains the OOS template parameters. For example, your OOS template includes the following parameters: <c>{&quot;dbInstanceId&quot;: &quot;dds-bp17661e0135****&quot;, &quot;modifyMode&quot;: &quot;Append&quot;}</c>, <c>dbInstanceId</c>, and <c>modifyMode</c>. Some parameters defined in your OOS template have default values. When you specify the NotificationMetadata parameter, specify parameters that do not have default values. If you specify parameters that have default values, the default values are overwritten. However, the default values of the following parameters must be retained to obtain information about scaling activities that are in progress:</para>
        /// <list type="bullet">
        /// <item><description><c>regionId</c>: the region ID of the scaling activity that is in progress. Default value: ${regionId}.</description></item>
        /// <item><description><c>instanceIds</c>: the IDs of ECS instances that are scaled in in the scaling activity. Default value: ${instanceIds}.</description></item>
        /// <item><description><c>lifecycleHookId</c>: the ID of the lifecycle hook. Default value: ${lifecycleHookId}.</description></item>
        /// <item><description><c>lifecycleActionToken</c>: the token of the lifecycle action. You can use the token to end the timeout period of the lifecycle hook ahead of schedule. Default value: ${lifecycleActionToken}</description></item>
        /// <item><description><c>scalingGroupId</c>: the ID of the scaling group in which the scaling activity is executed. Default value: ${scalingGroupId}.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can obtain template parameter information in the <a href="https://oos.console.aliyun.com/">OOS console</a>.</para>
        /// </remarks>
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
