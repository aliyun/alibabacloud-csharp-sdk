// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAegisContainerPluginRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAegisContainerPluginRuleResponseBodyData Data { get; set; }
        public class GetAegisContainerPluginRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp when the rule was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671607025000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The timestamp when the rule was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671607025000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The action mode of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: allows escape behavior.</description></item>
            /// <item><description><b>1</b>: triggers alerts.</description></item>
            /// <item><description><b>2</b>: blocks escape behavior.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autoTest</para>
            /// </summary>
            [NameInMap("RuleDescription")]
            [Validation(Required=false)]
            public string RuleDescription { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21**</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto_test_rule-EmzIXZ</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The template ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100**</para>
            /// </summary>
            [NameInMap("RuleTemplateId")]
            [Validation(Required=false)]
            public string RuleTemplateId { get; set; }

            /// <summary>
            /// <para>The template name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template01</para>
            /// </summary>
            [NameInMap("RuleTemplateName")]
            [Validation(Required=false)]
            public string RuleTemplateName { get; set; }

            /// <summary>
            /// <para>The rule items.</para>
            /// </summary>
            [NameInMap("SelectedPolicy")]
            [Validation(Required=false)]
            public List<string> SelectedPolicy { get; set; }

            /// <summary>
            /// <para>The ID of the switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER-CONTAINER-RULE-SWITCH-TYPE_***</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The images that are added to the whitelist.</para>
            /// </summary>
            [NameInMap("WhiteImages")]
            [Validation(Required=false)]
            public List<string> WhiteImages { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-***0DEF8BF6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
