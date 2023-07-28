// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleTargetsResponseBody : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the resource. Format: `acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message`. Example: `acs:mns:cn-hangzhou:120886317861****:/queues/test123/message`. Fields:
        /// 
        /// *   {Service name abbreviation}: the abbreviation of the service name. Valid value: mns.
        /// *   {userId}: the ID of the Alibaba Cloud account.
        /// *   {regionId}: the region ID of the message queue or topic.
        /// *   {Resource type}`: the type of the resource for which alerts are triggered. Valid values: - **queues** - **topics** {Resource name}: the name of the resource. - If the resource type is set to **queues**, the resource name is the name of the message queue. - If the resource type is set to **topics**, the resource name is the name of the topic.`
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The ID of the resource for which alerts are triggered.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeMetricRuleTargets**.
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
                /// Queries the resources that are associated with a specified alert rule.
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("JsonParams")]
                [Validation(Required=false)]
                public string JsonParams { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

        }

    }

}
