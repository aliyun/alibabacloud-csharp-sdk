// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeBotRuleLabelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned per page. Valid values: 1 to 200. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. This parameter is returned if a next page exists.</para>
        /// <remarks>
        /// <para>If a value is returned for this parameter, it indicates that more results are available. Use the returned <b>NextToken</b> value in the next request to retrieve the next page of results. Repeat this process until no value is returned for this parameter. This indicates that all results have been retrieved.</para>
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
        /// <para>The list of bot management rule labels.</para>
        /// </summary>
        [NameInMap("RuleLabels")]
        [Validation(Required=false)]
        public List<DescribeBotRuleLabelsResponseBodyRuleLabels> RuleLabels { get; set; }
        public class DescribeBotRuleLabelsResponseBodyRuleLabels : TeaModel {
            /// <summary>
            /// <para>The bot behavior that corresponds to the rule label. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>malicious</b>: malicious bot.</para>
            /// </description></item>
            /// <item><description><para><b>suspicious</b>: suspected bot.</para>
            /// </description></item>
            /// <item><description><para><b>normal</b>: normal bot.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>malicious</para>
            /// </summary>
            [NameInMap("BotBehavior")]
            [Validation(Required=false)]
            public string BotBehavior { get; set; }

            /// <summary>
            /// <para>The key of the bot management rule label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>malicious_crawler_python</para>
            /// </summary>
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }

            /// <summary>
            /// <para>The type of the bot rule label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>human_machine_challenge</para>
            /// </summary>
            [NameInMap("LabelType")]
            [Validation(Required=false)]
            public string LabelType { get; set; }

            /// <summary>
            /// <para>The bot management scenarios to which the rule belongs. Multiple scenarios are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>web</b>: web protection.</para>
            /// </description></item>
            /// <item><description><para><b>app</b>: app protection.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Web,app</para>
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
