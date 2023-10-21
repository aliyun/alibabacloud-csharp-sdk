// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ApplyMetricRuleTemplateResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// >  The HTTP status code 200 indicates that the call succeeds.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The error message returned.
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
        /// The resources that are affected by the alert rule.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ApplyMetricRuleTemplateResponseBodyResource Resource { get; set; }
        public class ApplyMetricRuleTemplateResponseBodyResource : TeaModel {
            /// <summary>
            /// The details of the generated alert rule.
            /// </summary>
            [NameInMap("AlertResults")]
            [Validation(Required=false)]
            public List<ApplyMetricRuleTemplateResponseBodyResourceAlertResults> AlertResults { get; set; }
            public class ApplyMetricRuleTemplateResponseBodyResourceAlertResults : TeaModel {
                /// <summary>
                /// The response code.
                /// 
                /// >  The HTTP status code 200 indicates that the call succeeds.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The returned information.
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
                /// Indicates whether the call succeeds. Valid values:
                /// 
                /// *   true: The call succeeds.
                /// *   false: The call fails.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// The ID of the application group to which the alert template is applied.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

        }

        /// <summary>
        /// Indicates whether the call succeeds. Valid values:
        /// 
        /// *   true: The call succeeds.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
