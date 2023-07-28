// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMetricRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **PutMetricRuleTargets**.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        [NameInMap("FailData")]
        [Validation(Required=false)]
        public PutMetricRuleTargetsResponseBodyFailData FailData { get; set; }
        public class PutMetricRuleTargetsResponseBodyFailData : TeaModel {
            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public PutMetricRuleTargetsResponseBodyFailDataTargets Targets { get; set; }
            public class PutMetricRuleTargetsResponseBodyFailDataTargets : TeaModel {
                [NameInMap("Target")]
                [Validation(Required=false)]
                public List<PutMetricRuleTargetsResponseBodyFailDataTargetsTarget> Target { get; set; }
                public class PutMetricRuleTargetsResponseBodyFailDataTargetsTarget : TeaModel {
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                    /// <summary>
                    /// For more information about common request parameters, see [Common parameters](~~199331~~).
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                }

            }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// For information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](~~114941~~).
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The level of the alert. Valid values:
        /// 
        /// *   INFO: information
        /// *   WARN: warning
        /// *   CRITICAL: critical
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
