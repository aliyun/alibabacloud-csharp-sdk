// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAegisContainerPluginRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
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
            /// <para>The rule action mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: allow</description></item>
            /// <item><description><b>1</b>: alert</description></item>
            /// <item><description><b>2</b>: block</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>The rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autoTest</para>
            /// </summary>
            [NameInMap("RuleDescription")]
            [Validation(Required=false)]
            public string RuleDescription { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21**</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto_test_rule-EmzIXZ</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The rule template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100**</para>
            /// </summary>
            [NameInMap("RuleTemplateId")]
            [Validation(Required=false)]
            public string RuleTemplateId { get; set; }

            /// <summary>
            /// <para>The rule template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template01</para>
            /// </summary>
            [NameInMap("RuleTemplateName")]
            [Validation(Required=false)]
            public string RuleTemplateName { get; set; }

            /// <summary>
            /// <para>The list of selected rule items.</para>
            /// </summary>
            [NameInMap("SelectedPolicy")]
            [Validation(Required=false)]
            public List<string> SelectedPolicy { get; set; }

            /// <summary>
            /// <para>The ID of the corresponding switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER-CONTAINER-RULE-SWITCH-TYPE_***</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The list of whitelisted images.</para>
            /// </summary>
            [NameInMap("WhiteImages")]
            [Validation(Required=false)]
            public List<string> WhiteImages { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-***0DEF8BF6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
