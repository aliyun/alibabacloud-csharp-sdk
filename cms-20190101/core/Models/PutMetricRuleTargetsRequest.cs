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
        /// For information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](~~114941~~).
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<PutMetricRuleTargetsRequestTargets> Targets { get; set; }
        public class PutMetricRuleTargetsRequestTargets : TeaModel {
            /// <summary>
            /// The ARN of the resource.
            /// 
            /// For information about how to obtain the ARN of a resource, see [DescribeMetricRuleTargets](~~121592~~).
            /// 
            /// Format: `acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message`. Example: `acs:mns:cn-hangzhou:120886317861****:/queues/test123/message`. Fields:
            /// 
            /// *   {Service name abbreviation}: the abbreviation of the service name. Valid value: mns.
            /// *   {userId}: the ID of the Alibaba Cloud account.
            /// *   {regionId}: the region ID of the message queue or topic.
            /// *   {Resource type}`: the type of the resource for which alerts are triggered. Valid values: - **queues** - **topics** {Resource name}: the name of the resource. - If the resource type is set to **queues**, the resource name is the name of the message queue. - If the resource type is set to **topics**, the resource name is the name of the topic.`
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The ID of the resource for which alerts are triggered.
            /// 
            /// For information about how to obtain the ID of a resource for which alerts are triggered, see [DescribeMetricRuleTargets](~~121592~~).
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The parameters of the alert callback. The parameters are in the JSON format.
            /// </summary>
            [NameInMap("JsonParams")]
            [Validation(Required=false)]
            public string JsonParams { get; set; }

            /// <summary>
            /// The level of the alert. Valid values:
            /// 
            /// *   INFO: information
            /// *   WARN: warning
            /// *   CRITICAL: critical
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

    }

}
