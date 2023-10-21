// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMetricRulesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

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
        /// The details of the alert rules.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public CreateGroupMetricRulesResponseBodyResources Resources { get; set; }
        public class CreateGroupMetricRulesResponseBodyResources : TeaModel {
            [NameInMap("AlertResult")]
            [Validation(Required=false)]
            public List<CreateGroupMetricRulesResponseBodyResourcesAlertResult> AlertResult { get; set; }
            public class CreateGroupMetricRulesResponseBodyResourcesAlertResult : TeaModel {
                /// <summary>
                /// The status code that is returned for the alert rule.
                /// 
                /// >  The status code 200 indicates that the call is successful.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// The error message that is returned for the alert rule.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The ID of the alert rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The name of the alert rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// Indicates whether the alert rule was created. Valid value:
                /// 
                /// - true: The alert rule was created.
                /// - false: The alert rule failed to be created.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the call is successful. Valid value:
        /// 
        /// - true: The call is successful.
        /// - false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
