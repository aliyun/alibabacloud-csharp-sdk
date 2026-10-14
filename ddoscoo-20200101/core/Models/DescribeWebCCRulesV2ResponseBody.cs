// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCCRulesV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name of the website.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of frequency control rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The frequency control (HTTP flood mitigation) custom rules.</para>
        /// </summary>
        [NameInMap("WebCCRules")]
        [Validation(Required=false)]
        public List<DescribeWebCCRulesV2ResponseBodyWebCCRules> WebCCRules { get; set; }
        public class DescribeWebCCRulesV2ResponseBodyWebCCRules : TeaModel {
            /// <summary>
            /// <para>The validity period of the rule. Unit: seconds. This parameter takes effect when the matching action is set to block (action is block). Access requests are blocked within the validity period. A value of 0 indicates that the rule is permanently effective.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Expires")]
            [Validation(Required=false)]
            public long? Expires { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wq</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The source of the rule. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The rule details.</para>
            /// </summary>
            [NameInMap("RuleDetail")]
            [Validation(Required=false)]
            public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail RuleDetail { get; set; }
            public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail : TeaModel {
                /// <summary>
                /// <para>The matching action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>accept</b>: Allow.</description></item>
                /// <item><description><b>block</b>: Block.</description></item>
                /// <item><description><b>challenge</b>: JavaScript Challenge.</description></item>
                /// <item><description><b>watch</b>: Monitor.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>block</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The list of matching conditions.</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public List<DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition> Condition { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition : TeaModel {
                    /// <summary>
                    /// <para>The matching content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.0.XX.XX</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The matching content when the matching method is set to equal to one of multiple values.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;2&quot;,&quot;3&quot;,&quot;ad&quot;]</para>
                    /// </summary>
                    [NameInMap("ContentList")]
                    [Validation(Required=false)]
                    public List<string> ContentList { get; set; }

                    /// <summary>
                    /// <para>The matching field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ip</para>
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <para>The name of the custom HTTP header field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The matching method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>belong</para>
                    /// </summary>
                    [NameInMap("MatchMethod")]
                    [Validation(Required=false)]
                    public string MatchMethod { get; set; }

                }

                /// <summary>
                /// <para>The legacy rule format. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deprecated</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The legacy rule format. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The legacy rule format. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deprecated</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccauto14</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The frequency statistics.</para>
                /// </summary>
                [NameInMap("RateLimit")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailRateLimit RateLimit { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailRateLimit : TeaModel {
                    /// <summary>
                    /// <para>The statistical period. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// <para>The field name. This parameter is required only when the statistics source is set to header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>action</para>
                    /// </summary>
                    [NameInMap("SubKey")]
                    [Validation(Required=false)]
                    public string SubKey { get; set; }

                    /// <summary>
                    /// <para>The statistics source. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ip</para>
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public string Target { get; set; }

                    /// <summary>
                    /// <para>The trigger threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public int? Threshold { get; set; }

                    /// <summary>
                    /// <para>The blocking duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15</para>
                    /// </summary>
                    [NameInMap("Ttl")]
                    [Validation(Required=false)]
                    public int? Ttl { get; set; }

                }

                /// <summary>
                /// <para>The deduplication statistics. This parameter is optional. If this parameter is not specified, deduplication is not performed.</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics Statistics { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics : TeaModel {
                    /// <summary>
                    /// <para>The statistics source. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ip</b>: by IP address</description></item>
                    /// <item><description><b>header</b>: by header</description></item>
                    /// <item><description><b>uri</b>: by URI</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>uri</para>
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <para>This parameter is required only when the statistics source is set to header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hello</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The deduplication mode. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>count</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                }

                /// <summary>
                /// <para>The status code.</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode StatusCode { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode : TeaModel {
                    /// <summary>
                    /// <para>The status code. Valid values: <b>100</b> to <b>599</b>.</para>
                    /// <list type="bullet">
                    /// <item><description><b>200</b>: Successful.</description></item>
                    /// <item><description>Other values: An error code.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <para>When the ratio is not used, the action is triggered only when the corresponding status code reaches <b>CountThreshold</b>. Valid range: <b>2</b> to <b>50000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("CountThreshold")]
                    [Validation(Required=false)]
                    public int? CountThreshold { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the feature is enabled. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>When the ratio is used, the action is triggered only when the corresponding status code reaches <b>RatioThreshold</b>. Valid range: <b>1</b> to <b>100</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("RatioThreshold")]
                    [Validation(Required=false)]
                    public int? RatioThreshold { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to use the ratio:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("UseRatio")]
                    [Validation(Required=false)]
                    public bool? UseRatio { get; set; }

                }

                /// <summary>
                /// <para>The legacy rule format. This parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                /// <summary>
                /// <para>The legacy rule format. This parameter is deprecated.</para>
                /// 
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
