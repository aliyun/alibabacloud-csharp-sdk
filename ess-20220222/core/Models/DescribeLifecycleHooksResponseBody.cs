// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleHooksResponseBody : TeaModel {
        /// <summary>
        /// Details of the lifecycle hooks.
        /// </summary>
        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public List<DescribeLifecycleHooksResponseBodyLifecycleHooks> LifecycleHooks { get; set; }
        public class DescribeLifecycleHooksResponseBodyLifecycleHooks : TeaModel {
            /// <summary>
            /// The action that Auto Scaling performs after the lifecycle hook ends.
            /// </summary>
            [NameInMap("DefaultResult")]
            [Validation(Required=false)]
            public string DefaultResult { get; set; }

            /// <summary>
            /// The period of time before the lifecycle hook ends. Auto Scaling performs the specified action after the lifecycle hook ends.
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
            /// *   Active
            /// *   InActive
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
            /// The Alibaba Cloud Resource Name (ARN) of the method that is used by Auto Scaling to send notifications when the lifecycle hook takes effect. Specify the value in one of the following formats:
            /// 
            /// *   If you do not create a notification rule, specify the value in the `acs:ess:{region-id}:{account-id}:null/null` format.
            /// *   If you specify a Message Service (MNS) queue as the notification method, specify the value in the `acs:mns:{region-id}:{account-id}:queue/{queuename}` format.
            /// *   If you specify an MNS topic as the notification method, specify the value in the `acs:mns:{region-id}:{account-id}:topic/{topicname}` format.
            /// *   If you specify an Operation Orchestration Service (OOS) template as the notification method, specify the value in the `acs:oos:{region-id}:{account-id}:template/{templatename}` format.
            /// 
            /// The variables in the preceding parameter formats have the following meanings:
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
            /// The fixed string that is included in a notification. Auto Scaling sends the notification when the lifecycle hook takes effect.
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
