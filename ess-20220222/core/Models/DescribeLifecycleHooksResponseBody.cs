// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleHooksResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of lifecycle hooks.</para>
        /// </summary>
        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public List<DescribeLifecycleHooksResponseBodyLifecycleHooks> LifecycleHooks { get; set; }
        public class DescribeLifecycleHooksResponseBodyLifecycleHooks : TeaModel {
            /// <summary>
            /// <para>The action to perform after the wait state of the instance ends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTINUE</para>
            /// </summary>
            [NameInMap("DefaultResult")]
            [Validation(Required=false)]
            public string DefaultResult { get; set; }

            /// <summary>
            /// <para>The wait time configured in the lifecycle hook for the scaling activity. The next action is performed after the wait time expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("HeartbeatTimeout")]
            [Validation(Required=false)]
            public int? HeartbeatTimeout { get; set; }

            /// <summary>
            /// <para>The specific scenarios in which the lifecycle hook is triggered.</para>
            /// </summary>
            [NameInMap("LifecycleActionSources")]
            [Validation(Required=false)]
            public List<string> LifecycleActionSources { get; set; }

            /// <summary>
            /// <para>The ID of the lifecycle hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ash-bp19d1032y9kij96****</para>
            /// </summary>
            [NameInMap("LifecycleHookId")]
            [Validation(Required=false)]
            public string LifecycleHookId { get; set; }

            /// <summary>
            /// <para>The name of the lifecycle hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lifecyclehook****</para>
            /// </summary>
            [NameInMap("LifecycleHookName")]
            [Validation(Required=false)]
            public string LifecycleHookName { get; set; }

            /// <summary>
            /// <para>The status of the lifecycle hook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active: The lifecycle hook is active.</description></item>
            /// <item><description>InActive: The lifecycle hook is inactive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LifecycleHookStatus")]
            [Validation(Required=false)]
            public string LifecycleHookStatus { get; set; }

            /// <summary>
            /// <para>The scaling activity type associated with the lifecycle hook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SCALE_OUT</para>
            /// </summary>
            [NameInMap("LifecycleTransition")]
            [Validation(Required=false)]
            public string LifecycleTransition { get; set; }

            /// <summary>
            /// <para>The identifier of the notification recipient for the lifecycle hook. The parameter format is as follows:</para>
            /// <list type="bullet">
            /// <item><description>Notifications not configured: <c>acs:ess:{region-id}:{account-id}:null/null</c>.</description></item>
            /// <item><description>MNS queue: <c>acs:mns:{region-id}:{account-id}:queue/{queuename}</c>.</description></item>
            /// <item><description>MNS topic: <c>acs:mns:{region-id}:{account-id}:topic/{topicname}</c>.</description></item>
            /// <item><description>OOS template: <c>acs:oos:{region-id}:{account-id}:template/{templatename}</c>.</description></item>
            /// <item><description>EventBridge: <c>acs:eventbridge:{region-id}:{account-id}:eventbus/default</c>.</description></item>
            /// </list>
            /// <para>The variables in the parameter format have the following meanings:</para>
            /// <list type="bullet">
            /// <item><description>region-id: The ID of the region where the scaling group resides.</description></item>
            /// <item><description>account-id: The Alibaba Cloud account ID.</description></item>
            /// <item><description>queuename: The name of the MNS queue.</description></item>
            /// <item><description>topicname: The name of the MNS topic.</description></item>
            /// <item><description>templatename: The name of the OOS template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ess:cn-beijing:161456884340****:null/null</para>
            /// </summary>
            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            /// <summary>
            /// <para>The fixed string information for the wait state of the scaling activity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test Lifecycle Hook.</para>
            /// </summary>
            [NameInMap("NotificationMetadata")]
            [Validation(Required=false)]
            public string NotificationMetadata { get; set; }

            /// <summary>
            /// <para>The ID of the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asg-bp1igpak5ft1flyp****</para>
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of lifecycle hooks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
