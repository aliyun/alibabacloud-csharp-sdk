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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned custom frequency control rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The custom frequency control rules.</para>
        /// </summary>
        [NameInMap("WebCCRules")]
        [Validation(Required=false)]
        public List<DescribeWebCCRulesV2ResponseBodyWebCCRules> WebCCRules { get; set; }
        public class DescribeWebCCRulesV2ResponseBodyWebCCRules : TeaModel {
            /// <summary>
            /// <para>The validity period of the rule. Unit: seconds. If the Action parameter is set to block, the system blocks the requests that match the rule within the validity period of the rule. The value 0 indicates that the rule is permanently valid.</para>
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
            /// <para>The method used to create the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>manual</b> (default): manually created.</description></item>
            /// <item><description><b>clover</b>: automatically created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The details of the rule.</para>
            /// </summary>
            [NameInMap("RuleDetail")]
            [Validation(Required=false)]
            public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail RuleDetail { get; set; }
            public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetail : TeaModel {
                /// <summary>
                /// <para>The action triggered if the rule is matched. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>accept</b>: The requests that match the rule are allowed.</description></item>
                /// <item><description><b>block</b>: The requests that match the rule are blocked.</description></item>
                /// <item><description><b>challenge</b>: Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA) verification for the requests that match the rule is implemented.</description></item>
                /// <item><description><b>watch</b>: The requests that match the rule are recorded in logs and allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>block</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The match conditions.</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public List<DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition> Condition { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailCondition : TeaModel {
                    /// <summary>
                    /// <para>The match content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.0.XX.XX</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The match content when the match method is Equals to One of Multiple Values.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;2&quot;,&quot;3&quot;,&quot;ad&quot;]</para>
                    /// </summary>
                    [NameInMap("ContentList")]
                    [Validation(Required=false)]
                    public string ContentList { get; set; }

                    /// <summary>
                    /// <para>The match field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ip</para>
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <para>The custom HTTP request header.</para>
                    /// <remarks>
                    /// <para> This parameter takes effect only when <b>Field</b> is set to <b>header</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The match method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>belong</para>
                    /// </summary>
                    [NameInMap("MatchMethod")]
                    [Validation(Required=false)]
                    public string MatchMethod { get; set; }

                }

                /// <summary>
                /// <para>The parameter is deprecated.</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The parameter is deprecated.</para>
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
                    /// <para>The name of the field. This parameter is required only when the Target parameter is set to header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>action</para>
                    /// </summary>
                    [NameInMap("SubKey")]
                    [Validation(Required=false)]
                    public string SubKey { get; set; }

                    /// <summary>
                    /// <para>The statistical method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ip</b></description></item>
                    /// <item><description><b>header</b></description></item>
                    /// </list>
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
                /// <para>The statistics after deduplication. By default, the system collects statistics before deduplication.</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics Statistics { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatistics : TeaModel {
                    /// <summary>
                    /// <para>The statistical method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ip</b></description></item>
                    /// <item><description><b>header</b></description></item>
                    /// <item><description><b>uri</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>uri</para>
                    /// </summary>
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    /// <summary>
                    /// <para>The name of the header. This parameter is required only when the Field parameter is set to header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hello</para>
                    /// </summary>
                    [NameInMap("HeaderName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the system collects statistics after deduplication. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>count</b>: The system collects statistics before deduplication.</description></item>
                    /// <item><description><b>distinct</b>: The system collects statistics after deduplication.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>count</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                }

                /// <summary>
                /// <para>The status codes.</para>
                /// </summary>
                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode StatusCode { get; set; }
                public class DescribeWebCCRulesV2ResponseBodyWebCCRulesRuleDetailStatusCode : TeaModel {
                    /// <summary>
                    /// <para>The status code. Valid values: <b>100</b> to <b>599</b>.</para>
                    /// <list type="bullet">
                    /// <item><description><b>200</b>: The request was successful.</description></item>
                    /// <item><description>Other codes: The request failed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <para>If a ratio is not used, the handling action is triggered only when the number of requests of the corresponding status code reaches the value of <b>CountThreshold</b>. Valid values: <b>2</b> to <b>50000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("CountThreshold")]
                    [Validation(Required=false)]
                    public int? CountThreshold { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the status code is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>If a ratio is used, the handling action is triggered only when the number of requests of the corresponding status code reaches the value of <b>RatioThreshold</b>. Valid values: <b>1</b> to <b>100</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("RatioThreshold")]
                    [Validation(Required=false)]
                    public int? RatioThreshold { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to use a ratio.</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("UseRatio")]
                    [Validation(Required=false)]
                    public bool? UseRatio { get; set; }

                }

                /// <summary>
                /// <para>The parameter is deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                /// <summary>
                /// <para>The parameter is deprecated.</para>
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
