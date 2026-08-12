// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeBotRuleLabelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page in a paged query. Valid values: 1 to 200. Default value: 20. This parameter is used for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. If a value is returned for this parameter, the next page exists.</para>
        /// <remarks>
        /// <para>If this parameter has a return value, the next page exists. Use the returned NextToken value as a request parameter to retrieve the next page of data. Repeat until no value is returned, which indicates that all data has been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19****5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of bot management rule tags.</para>
        /// </summary>
        [NameInMap("RuleLabels")]
        [Validation(Required=false)]
        public List<DescribeBotRuleLabelsResponseBodyRuleLabels> RuleLabels { get; set; }
        public class DescribeBotRuleLabelsResponseBodyRuleLabels : TeaModel {
            /// <summary>
            /// <para>The crawler behavior corresponding to the rule tag.</para>
            /// <list type="bullet">
            /// <item><description><b>malicious</b>: malicious crawler.</description></item>
            /// <item><description><b>suspicious</b>: suspected crawler.</description></item>
            /// <item><description><b>normal</b>: normal crawler.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>malicious</para>
            /// </summary>
            [NameInMap("BotBehavior")]
            [Validation(Required=false)]
            public string BotBehavior { get; set; }

            /// <summary>
            /// <para>The default action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>block</b>: Block.</description></item>
            /// <item><description><b>monitor</b>: Monitor.</description></item>
            /// <item><description><b>js</b>: JavaScript verification.</description></item>
            /// <item><description><b>captcha</b>: slider CAPTCHA.</description></item>
            /// <item><description><b>captcha_strict</b>: strict slider CAPTCHA.</description></item>
            /// <item><description><b>bypass</b>: Allow.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("DefaultAction")]
            [Validation(Required=false)]
            public string DefaultAction { get; set; }

            /// <summary>
            /// <para>The default configurations corresponding to the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;crawlerStatusMap&quot;:{&quot;360&quot;:1,&quot;bytedance&quot;:1}}</para>
            /// </summary>
            [NameInMap("DefaultConfig")]
            [Validation(Required=false)]
            public string DefaultConfig { get; set; }

            /// <summary>
            /// <para>The default status of the tag rule.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The rule is enabled.</description></item>
            /// <item><description><b>0</b>: The rule is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DefaultStatus")]
            [Validation(Required=false)]
            public int? DefaultStatus { get; set; }

            /// <summary>
            /// <para>The bot management rule tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>malicious_crawler_python</para>
            /// </summary>
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }

            /// <summary>
            /// <para>The tag status.</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: Online.</description></item>
            /// <item><description><b>wait_offline</b>: Pending offline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("LabelStatus")]
            [Validation(Required=false)]
            public string LabelStatus { get; set; }

            /// <summary>
            /// <para>The type of the bot rule tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>human_machine_challenge</para>
            /// </summary>
            [NameInMap("LabelType")]
            [Validation(Required=false)]
            public string LabelType { get; set; }

            /// <summary>
            /// <para>The set of bot management protection scenarios to which the rule belongs. Multiple scenarios are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>web</b>: Web protection scenario.</description></item>
            /// <item><description><b>app</b>: App protection scenario.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>web,app</para>
            /// </summary>
            [NameInMap("SubScene")]
            [Validation(Required=false)]
            public string SubScene { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
