// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebPreciseAccessRuleResponseBody : TeaModel {
        /// <summary>
        /// The configuration of the accurate access control rule that is created for the website.
        /// </summary>
        [NameInMap("PreciseAccessConfigList")]
        [Validation(Required=false)]
        public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigList> PreciseAccessConfigList { get; set; }
        public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigList : TeaModel {
            /// <summary>
            /// The domain name of the website.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The scheduling rules.
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleList> RuleList { get; set; }
            public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleList : TeaModel {
                /// <summary>
                /// The action triggered if the rule is matched. Valid values:
                /// 
                /// *   **accept**: The requests that match the rule are allowed.
                /// *   **block**: The requests that match the rule are blocked.
                /// *   **challenge**: Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA) verification for the requests that match the rule is implemented.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The match conditions.
                /// </summary>
                [NameInMap("ConditionList")]
                [Validation(Required=false)]
                public List<DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleListConditionList> ConditionList { get; set; }
                public class DescribeWebPreciseAccessRuleResponseBodyPreciseAccessConfigListRuleListConditionList : TeaModel {
                    /// <summary>
                    /// The match content.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("ContentList")]
                    [Validation(Required=false)]
                    public List<string> ContentList { get; set; }

                    /// <summary>
                    /// The match field.
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// The custom HTTP request header.
                    /// 
                    /// >  This parameter takes effect only when **Field** is set to **header**.
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// The logical operator.
                    /// </summary>
                    [NameInMap("MatchMethod")]
                    [Validation(Required=false)]
                    public string MatchMethod { get; set; }

                }

                /// <summary>
                /// The validity period of the rule. Unit: seconds. This parameter takes effect only when **action** of a rule is **block**. Access requests that match the rule are blocked within the specified validity period of the rule. The value **0** indicates that the whitelist takes effect all the time.
                /// </summary>
                [NameInMap("Expires")]
                [Validation(Required=false)]
                public long? Expires { get; set; }

                /// <summary>
                /// The name of the scheduling rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The source of the rule. Valid values:
                /// 
                /// *   **manual** (default): manually created.
                /// *   **auto**: automatically generated.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
