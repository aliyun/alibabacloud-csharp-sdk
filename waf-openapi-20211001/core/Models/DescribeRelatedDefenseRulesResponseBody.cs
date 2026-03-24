// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRelatedDefenseRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to query the next page of results. If more results are available, this parameter is returned.</para>
        /// <remarks>
        /// <para>If this parameter is returned, more results are available. Use the returned NextToken value as a request parameter to retrieve the next page of data. Repeat this process until the <b>NextToken</b> parameter is not returned. This indicates that all data has been retrieved.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D****E840</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of associated rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeRelatedDefenseRulesResponseBodyRules> Rules { get; set; }
        public class DescribeRelatedDefenseRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The protection scenario of the rule. For more information, see the description of the <b>DefenseScene</b> parameter in <a href="https://help.aliyun.com/document_detail/461426.html">DescribeDefenseRules</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom_acl</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The type of the protection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>template</b> (default): a template rule.</para>
            /// </description></item>
            /// <item><description><para><b>resource</b>: a rule for a protected object.</para>
            /// </description></item>
            /// <item><description><para><b>global</b>: a global rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>template</para>
            /// </summary>
            [NameInMap("DefenseType")]
            [Validation(Required=false)]
            public string DefenseType { get; set; }

            /// <summary>
            /// <para>The ID of the protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2456789</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ruleTest</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The ID of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81501</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
