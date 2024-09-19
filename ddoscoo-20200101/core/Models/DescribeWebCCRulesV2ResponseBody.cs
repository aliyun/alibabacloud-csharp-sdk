// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCCRulesV2ResponseBody : TeaModel {
        /// <summary>
        /// The domain name of the website.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned custom frequency control rules.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// The custom frequency control rules.
        /// </summary>
        [NameInMap("WebCCRules")]
        [Validation(Required=false)]
        public List<DescribeWebCCRulesV2ResponseBodyWebCCRules> WebCCRules { get; set; }
        public class DescribeWebCCRulesV2ResponseBodyWebCCRules : TeaModel {
            /// <summary>
            /// The validity period of the rule. Unit: seconds. If the Action parameter is set to block, the system blocks the requests that match the rule within the validity period of the rule. The value 0 indicates that the rule is permanently valid.
            /// </summary>
            [NameInMap("Expires")]
            [Validation(Required=false)]
            public long? Expires { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The method used to create the rule. Valid values:
            /// 
            /// *   **manual** (default): manually created.
            /// *   **clover**: automatically created.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The details of the rule.
            /// </summary>
            [NameInMap("RuleDetail")]
            [Validation(Required=false)]
            public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail RuleDetail { get; set; }
            public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail : TeaModel {
                /// <summary>
                /// The action triggered if the rule is matched. Valid values:
                /// 
                /// *   **accept**: The requests that match the rule are allowed.
                /// *   **block**: The requests that match the rule are blocked.
                /// *   **challenge**: Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA) verification for the requests that match the rule is implemented.
                /// *   **watch**: The requests that match the rule are recorded in logs and allowed.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The match conditions.
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public List<DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition> Condition { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition : TeaModel {
                    /// <summary>
                    /// The match content.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The match content when the match method is Equals to One of Multiple Values.
                    /// </summary>
                    [NameInMap("ContentList")]
                    [Validation(Required=false)]
                    public string ContentList { get; set; }

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
                    /// The match method.
                    /// </summary>
                    [NameInMap("MatchMethod")]
                    [Validation(Required=false)]
                    public string MatchMethod { get; set; }

                }

                /// <summary>
                /// The parameter is deprecated.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The parameter is deprecated.
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// The parameter is deprecated.
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// The name of the rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The frequency statistics.
                /// </summary>
                [NameInMap("RateLimit")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailRateLimit RateLimit { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailRateLimit : TeaModel {
                    /// <summary>
                    /// The statistical period. Unit: seconds.
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// The name of the field. This parameter is required only when the Target parameter is set to header.
                    /// </summary>
                    [NameInMap("SubKey")]
                    [Validation(Required=false)]
                    public string SubKey { get; set; }

                    /// <summary>
                    /// The statistical method. Valid values:
                    /// 
                    /// *   **ip**
                    /// *   **header**
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                    /// <summary>
                    /// The trigger threshold.
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public int? Threshold { get; set; }

                    /// <summary>
                    /// The blocking duration. Unit: seconds.
                    /// </summary>
                    [NameInMap("Ttl")]
                    [Validation(Required=false)]
                    public int? Ttl { get; set; }

                }

                /// <summary>
                /// The statistics after deduplication. By default, the system collects statistics before deduplication.
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics Statistics { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics : TeaModel {
                    /// <summary>
                    /// The statistical method. Valid values:
                    /// 
                    /// *   **ip**
                    /// *   **header**
                    /// *   **uri**
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// The name of the header. This parameter is required only when the Field parameter is set to header.
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// Indicates whether the system collects statistics after deduplication. Valid values:
                    /// 
                    /// *   **count**: The system collects statistics before deduplication.
                    /// *   **distinct**: The system collects statistics after deduplication.
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                }

                /// <summary>
                /// The status codes.
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode StatusCode { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode : TeaModel {
                    /// <summary>
                    /// The status code. Valid values: **100** to **599**.
                    /// 
                    /// *   **200**: The request was successful.
                    /// *   Other codes: The request failed.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// If a ratio is not used, the handling action is triggered only when the number of requests of the corresponding status code reaches the value of **CountThreshold**. Valid values: **2** to **50000**.
                    /// </summary>
                    [NameInMap("CountThreshold")]
                    [Validation(Required=false)]
                    public int? CountThreshold { get; set; }

                    /// <summary>
                    /// Indicates whether the status code is enabled. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// If a ratio is used, the handling action is triggered only when the number of requests of the corresponding status code reaches the value of **RatioThreshold**. Valid values: **1** to **100**.
                    /// </summary>
                    [NameInMap("RatioThreshold")]
                    [Validation(Required=false)]
                    public int? RatioThreshold { get; set; }

                    /// <summary>
                    /// Indicates whether to use a ratio.
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("UseRatio")]
                    [Validation(Required=false)]
                    public bool? UseRatio { get; set; }

                }

                /// <summary>
                /// The parameter is deprecated.
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                /// <summary>
                /// The parameter is deprecated.
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

        }

    }

}
