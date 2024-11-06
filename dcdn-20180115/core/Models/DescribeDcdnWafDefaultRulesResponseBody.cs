// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDefaultRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The rule configurations.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafDefaultRulesResponseBodyContent> Content { get; set; }
        public class DescribeDcdnWafDefaultRulesResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The protection scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>waf_group</b>: basic web protection.</description></item>
            /// <item><description><b>anti_scan</b>: scan protection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>anti_scan</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafDefaultRulesResponseBodyContentRules> Rules { get; set; }
            public class DescribeDcdnWafDefaultRulesResponseBodyContentRules : TeaModel {
                /// <summary>
                /// <para>The default action of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>monitor</b></description></item>
                /// <item><description><b>deny</b></description></item>
                /// <item><description><b>block</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>block</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The default configuration of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;wafGroupIds\&quot;:\&quot;1012\&quot;}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The default name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default_WafGroup_Rule</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The default status of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>waf_group</b>: basic web protection.</description></item>
                /// <item><description><b>high_frequency</b>: high-frequency scanning blocking.</description></item>
                /// <item><description><b>directory_traversal</b>: directory traversal blocking.</description></item>
                /// <item><description><b>scan_tools</b>: scanner blocking.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>waf_group</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A123425345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
