// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeBaseRuleChangeLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FBF08CB-8691-5B65-BBF8-***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of ruleset changes.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeBaseRuleChangeLogResponseBodyRules> Rules { get; set; }
        public class DescribeBaseRuleChangeLogResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The CVE ID of the vulnerability associated with the system rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2021-34538</para>
            /// </summary>
            [NameInMap("CveId")]
            [Validation(Required=false)]
            public string CveId { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>add: Add.</para>
            /// </description></item>
            /// <item><description><para>modify: Modify.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42755</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Header XSS Scanner Behavior</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The update time of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665460629000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of rule change entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
