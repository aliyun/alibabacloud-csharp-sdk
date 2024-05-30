// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCCRulesV2ResponseBody : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("WebCCRules")]
        [Validation(Required=false)]
        public List<DescribeWebCCRulesV2ResponseBodyWebCCRules> WebCCRules { get; set; }
        public class DescribeWebCCRulesV2ResponseBodyWebCCRules : TeaModel {
            [NameInMap("Expires")]
            [Validation(Required=false)]
            public long? Expires { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("RuleDetail")]
            [Validation(Required=false)]
            public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail RuleDetail { get; set; }
            public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Condition")]
                [Validation(Required=false)]
                public List<DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition> Condition { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    [NameInMap("MatchMethod")]
                    [Validation(Required=false)]
                    public string MatchMethod { get; set; }

                }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RateLimit")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailRateLimit RateLimit { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailRateLimit : TeaModel {
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    [NameInMap("SubKey")]
                    [Validation(Required=false)]
                    public string SubKey { get; set; }

                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public int? Threshold { get; set; }

                    [NameInMap("Ttl")]
                    [Validation(Required=false)]
                    public int? Ttl { get; set; }

                }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics Statistics { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                }

                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode StatusCode { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("CountThreshold")]
                    [Validation(Required=false)]
                    public int? CountThreshold { get; set; }

                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("RatioThreshold")]
                    [Validation(Required=false)]
                    public int? RatioThreshold { get; set; }

                    [NameInMap("UseRatio")]
                    [Validation(Required=false)]
                    public bool? UseRatio { get; set; }

                }

                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

        }

    }

}
