// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMetricRuleTargetsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// For information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// N/A.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<PutMetricRuleTargetsRequestTargets> Targets { get; set; }
        public class PutMetricRuleTargetsRequestTargets : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the resource. Message Service (MNS), Auto Scaling, Simple Log Service, and Function Compute are supported.
            /// 
            /// The following part describes the ARN of MNS and the parameters provided by the ARN:
            /// 
            /// `acs:mns:{regionId}:{userId}:/{Resource type}/{Resource name}/message`.
            /// 
            /// *   {regionId}: the region ID of the message queue or topic.
            /// 
            /// *   {userId}: the ID of the Alibaba Cloud account that owns the resource.
            /// 
            /// *   {Resource type}: the type of the resource for which alerts are triggered. Valid values:
            /// 
            ///     *   **queues**
            ///     *   **topics**
            /// 
            /// *   {Resource name}: the resource name.
            /// 
            ///     *   If the resource type is **queues**, the resource name is the queue name.
            ///     *   If the resource type is **topics**, the resource name is the topic name.
            /// 
            /// ARN of Auto Scaling:
            /// 
            /// acs:ess:{regionId}:{userId}:scalingGroupId/{Scaling group ID}:scalingRuleId/{Scaling rule ID}
            /// 
            /// ARN of Simple Log Service:
            /// 
            /// acs:log:{regionId}:{userId}:project/{Project name}/logstore/{Logstore name}
            /// 
            /// ARN of Function Compute:
            /// 
            /// acs:fc:{regionId}:{userId}:services/{Service name}/functions/{Function name}
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The ID of the resource for which alerts are triggered.
            /// 
            /// For more information about how to obtain the ID of the resource for which alerts are triggered, see [DescribeMetricRuleTargets](https://help.aliyun.com/document_detail/121592.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The JSON-formatted parameters of the alert callback.
            /// </summary>
            [NameInMap("JsonParams")]
            [Validation(Required=false)]
            public string JsonParams { get; set; }

            /// <summary>
            /// The alert level. Valid values:
            /// 
            /// *   INFO
            /// *   WARN
            /// *   CRITICAL
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

    }

}
