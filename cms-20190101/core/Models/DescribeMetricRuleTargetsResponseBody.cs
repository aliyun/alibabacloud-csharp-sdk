// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The information about the resource for which alerts are triggered.
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public DescribeMetricRuleTargetsResponseBodyTargets Targets { get; set; }
        public class DescribeMetricRuleTargetsResponseBodyTargets : TeaModel {
            [NameInMap("Target")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleTargetsResponseBodyTargetsTarget> Target { get; set; }
            public class DescribeMetricRuleTargetsResponseBodyTargetsTarget : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the resource. Format: `acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message`. Example: `acs:mns:cn-hangzhou:120886317861****:/queues/test123/message`. Fields:
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

}
