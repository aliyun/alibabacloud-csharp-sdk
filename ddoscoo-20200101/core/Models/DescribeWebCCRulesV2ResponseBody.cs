// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCCRulesV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("WebCCRules")]
        [Validation(Required=false)]
        public List<DescribeWebCCRulesV2ResponseBodyWebCCRules> WebCCRules { get; set; }
        public class DescribeWebCCRulesV2ResponseBodyWebCCRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Expires")]
            [Validation(Required=false)]
            public long? Expires { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wq</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("RuleDetail")]
            [Validation(Required=false)]
            public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail RuleDetail { get; set; }
            public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>block</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Condition")]
                [Validation(Required=false)]
                public List<DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition> Condition { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>192.0.XX.XX</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("ContentList")]
                    [Validation(Required=false)]
                    public List<string> ContentList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ip</para>
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>belong</para>
                    /// </summary>
                    [NameInMap("MatchMethod")]
                    [Validation(Required=false)]
                    public string MatchMethod { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>废弃</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>废弃</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccauto14</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RateLimit")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailRateLimit RateLimit { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailRateLimit : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>action</para>
                    /// </summary>
                    [NameInMap("SubKey")]
                    [Validation(Required=false)]
                    public string SubKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ip</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public int? Threshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>15</para>
                    /// </summary>
                    [NameInMap("Ttl")]
                    [Validation(Required=false)]
                    public int? Ttl { get; set; }

                }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics Statistics { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>uri</para>
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hello</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>count</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                }

                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode StatusCode { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("CountThreshold")]
                    [Validation(Required=false)]
                    public int? CountThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("RatioThreshold")]
                    [Validation(Required=false)]
                    public int? RatioThreshold { get; set; }

                    [NameInMap("UseRatio")]
                    [Validation(Required=false)]
                    public bool? UseRatio { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/p3shijihao</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

        }

    }

}
