// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyContainerPluginRuleRequest : TeaModel {
        /// <summary>
        /// <para>The language type for requests and responses. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The action mode of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Alert.</description></item>
        /// <item><description><b>2</b>: Block.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2623606.html">ListSasContainerWebDefenseRule</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100012</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public int? RuleId { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: User-defined.</description></item>
        /// <item><description><b>1</b>: System built-in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The list of rule items.</para>
        /// </summary>
        [NameInMap("SelectedPolicy")]
        [Validation(Required=false)]
        public List<string> SelectedPolicy { get; set; }

        /// <summary>
        /// <para>The list of whitelisted images.</para>
        /// </summary>
        [NameInMap("WhiteImages")]
        [Validation(Required=false)]
        public List<string> WhiteImages { get; set; }

    }

}
