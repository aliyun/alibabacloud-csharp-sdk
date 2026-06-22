// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteFileProtectClientRuleRequest : TeaModel {
        /// <summary>
        /// <para>The alert notification level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: no alert</para>
        /// </description></item>
        /// <item><description><para>1: reminder</para>
        /// </description></item>
        /// <item><description><para>2: suspicious</para>
        /// </description></item>
        /// <item><description><para>3: high-risk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AlertLevel")]
        [Validation(Required=false)]
        public int? AlertLevel { get; set; }

        /// <summary>
        /// <para>The list of excluded policy IDs.</para>
        /// </summary>
        [NameInMap("ExcludeIdList")]
        [Validation(Required=false)]
        public List<long?> ExcludeIdList { get; set; }

        /// <summary>
        /// <para>The list of policy IDs.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<long?> IdList { get; set; }

        /// <summary>
        /// <para>The type of the operating system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows</description></item>
        /// <item><description><b>linux</b>: Linux.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The action to take when the rule is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>monitor</b>: Alert.</description></item>
        /// <item><description><b>block</b>: Block.</description></item>
        /// <item><description><b>pass</b>: Allow.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-001</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Specifies whether to select all rules.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SelectAll")]
        [Validation(Required=false)]
        public bool? SelectAll { get; set; }

    }

}
