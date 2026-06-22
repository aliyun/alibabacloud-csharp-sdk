// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectClientRuleStatusRequest : TeaModel {
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
        /// <para>The list of excluded rule IDs.</para>
        /// </summary>
        [NameInMap("ExcludeIdList")]
        [Validation(Required=false)]
        public List<long?> ExcludeIdList { get; set; }

        /// <summary>
        /// <para>The list of rule IDs.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<long?> IdList { get; set; }

        /// <summary>
        /// <para>The operating system type. Valid values:</para>
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
        /// <para>The rule action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>block</b>: Block.</para>
        /// </description></item>
        /// <item><description><para><b>monitor</b>: Monitor.</para>
        /// </description></item>
        /// <item><description><para><b>pass</b>: Allow.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

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
        /// <para>Specifies whether to select all rules.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SelectAll")]
        [Validation(Required=false)]
        public bool? SelectAll { get; set; }

        /// <summary>
        /// <para>The policy status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled.</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
