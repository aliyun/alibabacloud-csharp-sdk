// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleHooksResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the lifecycle hooks.</para>
        /// </summary>
        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public List<DescribeLifecycleHooksResponseBodyLifecycleHooks> LifecycleHooks { get; set; }
        public class DescribeLifecycleHooksResponseBodyLifecycleHooks : TeaModel {
            /// <summary>
            /// <para>The next action that is performed after the lifecycle hook times out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTINUE</para>
            /// </summary>
            [NameInMap("DefaultResult")]
            [Validation(Required=false)]
            public string DefaultResult { get; set; }

            /// <summary>
            /// <para>The period of time before the lifecycle hook times out. When the lifecycle hook times out, Auto Scaling performs the action that is specified by DefaultResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("HeartbeatTimeout")]
            [Validation(Required=false)]
            public int? HeartbeatTimeout { get; set; }

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
            /// <item><description>Active: The lifecycle hook is enabled.</description></item>
            /// <item><description>InActive: The lifecycle hook is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LifecycleHookStatus")]
            [Validation(Required=false)]
            public string LifecycleHookStatus { get; set; }

            /// <summary>
            /// <para>The type of the scaling activity to which the lifecycle hook applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SCALE_OUT</para>
            /// </summary>
            [NameInMap("LifecycleTransition")]
            [Validation(Required=false)]
            public string LifecycleTransition { get; set; }

            /// <summary>
            /// <para>The ARN of the notification recipient when the lifecycle hook takes effect. The value of this parameter must be in one of the following formats:</para>
            /// <list type="bullet">
            /// <item><description>If you do not create a notification rule, specify the value in the <c>acs:ess:{region-id}:{account-id}:null/null</c> format.</description></item>
            /// <item><description>If you specify a Simple Message Queue (SMQ, formerly MNS) queue as the notification recipient, specify the value in the <c>acs:mns:{region-id}:{account-id}:queue/{queuename}</c> format.</description></item>
            /// <item><description>If you specify an SMQ as the notification recipient, specify the value in the <c>acs:mns:{region-id}:{account-id}:topic/{topicname}</c> format.</description></item>
            /// <item><description>If you specify a CloudOps Orchestration Service (OOS) template as the notification recipient, specify the value in the <c>acs:oos:{region-id}:{account-id}:template/{templatename}</c> format.</description></item>
            /// <item><description>If you specify an event bus as the notification recipient, specify the value in the <c>acs:eventbridge:{region-id}:{account-id}:eventbus/default</c> format.</description></item>
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
            /// <para>acs:ess:cn-beijing:161456884340****:null/null</para>
            /// </summary>
            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            /// <summary>
            /// <para>The fixed string that is included in a notification that Auto Scaling sends when the lifecycle hook takes effect.</para>
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
