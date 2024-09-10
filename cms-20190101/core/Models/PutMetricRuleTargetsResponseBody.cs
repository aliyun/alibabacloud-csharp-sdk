// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMetricRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The failed data.
        /// </summary>
        [NameInMap("FailData")]
        [Validation(Required=false)]
        public PutMetricRuleTargetsResponseBodyFailData FailData { get; set; }
        public class PutMetricRuleTargetsResponseBodyFailData : TeaModel {
            /// <summary>
            /// The information about the resources for which alerts are triggered.
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public PutMetricRuleTargetsResponseBodyFailDataTargets Targets { get; set; }
            public class PutMetricRuleTargetsResponseBodyFailDataTargets : TeaModel {
                [NameInMap("Target")]
                [Validation(Required=false)]
                public List<PutMetricRuleTargetsResponseBodyFailDataTargetsTarget> Target { get; set; }
                public class PutMetricRuleTargetsResponseBodyFailDataTargetsTarget : TeaModel {
                    /// <summary>
                    /// The ARN of the resource. Format: `acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message`. MNS, Auto Scaling, Simple Log Service, and Function Compute are supported. Example: `acs:mns:cn-hangzhou:120886317861****:/queues/test123/message`. The following part describes the ARN of MNS and the parameters in the ARN:
                    /// 
                    /// *   {Service name abbreviation}: mns.
                    /// 
                    /// *   {userId}: the ID of the Alibaba Cloud account.
                    /// 
                    /// *   {regionId}: the region ID of the message queue or topic.
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
                    /// </summary>
                    [NameInMap("Arn")]
                    [Validation(Required=false)]
                    public string Arn { get; set; }

                    /// <summary>
                    /// The ID of the resource for which alerts are triggered.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

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

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
