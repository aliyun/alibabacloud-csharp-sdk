// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddContainerPluginRuleRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The action that you want to specify for the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: triggers alerts.</description></item>
        /// <item><description><b>2</b>: blocks escapes.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

        /// <summary>
        /// <para>The name of the rule. The name must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_). The names of rules that are created for the same user must be unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tyest111</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The ID of the rule template. You can call the ListSystemClientRules operation to query the ID of the rule template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86863</para>
        /// </summary>
        [NameInMap("RuleTemplateId")]
        [Validation(Required=false)]
        public int? RuleTemplateId { get; set; }

        /// <summary>
        /// <para>The type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: custom rule</description></item>
        /// <item><description><b>1</b>: system rule</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The check items that are enabled for the rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SelectedPolicy")]
        [Validation(Required=false)]
        public List<string> SelectedPolicy { get; set; }

        /// <summary>
        /// <para>The images that are added to the whitelist.</para>
        /// </summary>
        [NameInMap("WhiteImages")]
        [Validation(Required=false)]
        public List<string> WhiteImages { get; set; }

    }

}
