// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleHooksResponseBody : TeaModel {
        /// <summary>
        /// The details of the lifecycle hooks.
        /// </summary>
        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public List<DescribeLifecycleHooksResponseBodyLifecycleHooks> LifecycleHooks { get; set; }
        public class DescribeLifecycleHooksResponseBodyLifecycleHooks : TeaModel {
            /// <summary>
            /// The next action that is performed after the lifecycle hook times out.
            /// </summary>
            [NameInMap("DefaultResult")]
            [Validation(Required=false)]
            public string DefaultResult { get; set; }

            /// <summary>
            /// The period of time before the lifecycle hook times out. When the lifecycle hook times out, Auto Scaling performs the action that is specified by DefaultResult.
            /// </summary>
            [NameInMap("HeartbeatTimeout")]
            [Validation(Required=false)]
            public int? HeartbeatTimeout { get; set; }

            /// <summary>
            /// The ID of the lifecycle hook.
            /// </summary>
            [NameInMap("LifecycleHookId")]
            [Validation(Required=false)]
            public string LifecycleHookId { get; set; }

            /// <summary>
            /// The name of the lifecycle hook.
            /// </summary>
            [NameInMap("LifecycleHookName")]
            [Validation(Required=false)]
            public string LifecycleHookName { get; set; }

            /// <summary>
            /// The status of the lifecycle hook. Valid values:
            /// 
            /// *   Active: The lifecycle hook is enabled.
            /// *   InActive: The lifecycle hook is disabled.
            /// </summary>
            [NameInMap("LifecycleHookStatus")]
            [Validation(Required=false)]
            public string LifecycleHookStatus { get; set; }

            /// <summary>
            /// The type of the scaling activity to which the lifecycle hook applies.
            /// </summary>
            [NameInMap("LifecycleTransition")]
            [Validation(Required=false)]
            public string LifecycleTransition { get; set; }

            /// <summary>
            /// The ARN of the notification recipient when the lifecycle hook takes effect. The value of this parameter is in one of the following formats:
            /// 
            /// *   If you did not specify this parameter, the return value is in the `acs:ess:{region-id}:{account-id}:null/null` format.
            /// *   If you specified a Message Service (MNS) queue as the notification recipient, the return value is in the `acs:mns:{region-id}:{account-id}:queue/{queuename}` format.
            /// *   If you specified an MNS topic as the notification recipient, the return value is in the `acs:mns:{region-id}:{account-id}:topic/{topicname}` format.
            /// *   If you specified a CloudOps Orchestration Service (OOS) template as the notification recipient, the return value is in the `acs:oos:{region-id}:{account-id}:template/{templatename}` format.
            /// *   If you specified an event bus as the notification recipient, the return value is in the `acs:eventbridge:{region-id}:{account-id}:eventbus/default` format.
            /// 
            /// The variables in the preceding formats have the following meanings:
            /// 
            /// *   region-id: the region ID of your scaling group.
            /// *   account-id: the ID of your Alibaba Cloud.
            /// *   queuename: the name of the MNS queue.
            /// *   topicname: the name of the MNS topic.
            /// *   templatename: the name of the OOS template.
            /// </summary>
            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            /// <summary>
            /// The fixed string that is included in a notification that Auto Scaling sends when the lifecycle hook takes effect.
            /// </summary>
            [NameInMap("NotificationMetadata")]
            [Validation(Required=false)]
            public string NotificationMetadata { get; set; }

            /// <summary>
            /// The ID of the scaling group.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of lifecycle hooks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
