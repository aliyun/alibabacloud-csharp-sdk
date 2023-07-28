// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ApplyMetricRuleTemplateResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the call succeeds. Valid values:
        /// 
        /// *   true: The call succeeds.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The resources that are affected by the alert rule.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the application group to which the alert template is applied.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The response code.
        /// 
        /// >  The HTTP status code 200 indicates that the call succeeds.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ApplyMetricRuleTemplateResponseBodyResource Resource { get; set; }
        public class ApplyMetricRuleTemplateResponseBodyResource : TeaModel {
            /// <summary>
            /// Indicates whether the call succeeds. Valid values:
            /// 
            /// *   true: The call succeeds.
            /// *   false: The call fails.
            /// </summary>
            [NameInMap("AlertResults")]
            [Validation(Required=false)]
            public List<ApplyMetricRuleTemplateResponseBodyResourceAlertResults> AlertResults { get; set; }
            public class ApplyMetricRuleTemplateResponseBodyResourceAlertResults : TeaModel {
                /// <summary>
                /// The name of the alert rule.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The ID of the alert rule.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// In this example, the `700****` alert template is applied to the `123456` application group. For the generated alert rule, the ID is `applyTemplate8ab74c6b-9f27-47ab-8841-de01dc08****`, and the name is `test123`.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// The returned information.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

        }

        /// <summary>
        /// The details of the generated alert rule.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
