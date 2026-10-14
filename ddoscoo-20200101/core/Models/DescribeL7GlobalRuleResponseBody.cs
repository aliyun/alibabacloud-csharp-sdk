// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeL7GlobalRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The global template rule information.</para>
        /// </summary>
        [NameInMap("GlobalRules")]
        [Validation(Required=false)]
        public List<DescribeL7GlobalRuleResponseBodyGlobalRules> GlobalRules { get; set; }
        public class DescribeL7GlobalRuleResponseBodyGlobalRules : TeaModel {
            /// <summary>
            /// <para>The action that the rule performs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>watch</b>: Monitor.</description></item>
            /// <item><description><b>block</b>: Block.</description></item>
            /// <item><description><b>challenge</b>: JavaScript Challenge.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>watch</para>
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>The default action of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>watch</b>: Monitor.</description></item>
            /// <item><description><b>block</b>: Block.</description></item>
            /// <item><description><b>challenge</b>: JavaScript Challenge.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>watch</para>
            /// </summary>
            [NameInMap("ActionDefault")]
            [Validation(Required=false)]
            public string ActionDefault { get; set; }

            /// <summary>
            /// <para>The rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP请求疑似模拟浏览器，校验浏览器Header等组合特征#4</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public long? Enabled { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>global_1</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>模拟浏览器请求</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
