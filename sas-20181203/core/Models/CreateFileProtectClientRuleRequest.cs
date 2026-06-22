// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileProtectClientRuleRequest : TeaModel {
        /// <summary>
        /// <para>The alert notification level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no alert</description></item>
        /// <item><description>1: reminder</description></item>
        /// <item><description>2: suspicious</description></item>
        /// <item><description>3: high-risk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AlertLevel")]
        [Validation(Required=false)]
        public int? AlertLevel { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The list of excluded users.</para>
        /// </summary>
        [NameInMap("ExcludeUsers")]
        [Validation(Required=false)]
        public List<string> ExcludeUsers { get; set; }

        /// <summary>
        /// <para>The list of operations performed on files.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileOps")]
        [Validation(Required=false)]
        public List<string> FileOps { get; set; }

        /// <summary>
        /// <para>The list of monitored file paths. Wildcards are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FilePaths")]
        [Validation(Required=false)]
        public List<string> FilePaths { get; set; }

        /// <summary>
        /// <para>The list of monitored file types.</para>
        /// </summary>
        [NameInMap("FileTypes")]
        [Validation(Required=false)]
        public List<string> FileTypes { get; set; }

        /// <summary>
        /// <para>The operating system type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows.</description></item>
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
        /// <para>The list of process monitoring paths. Wildcards are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProcPaths")]
        [Validation(Required=false)]
        public List<string> ProcPaths { get; set; }

        /// <summary>
        /// <para>The action to take when the policy is hit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>monitor</b>: Alert.</description></item>
        /// <item><description><b>block</b>: Block.</description></item>
        /// <item><description><b>pass</b>: Allow.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>规则****</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The switch ID associated with the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FILE_PROTECT_RULE_SWITCH_TYPE_0000</para>
        /// </summary>
        [NameInMap("SwitchId")]
        [Validation(Required=false)]
        public string SwitchId { get; set; }

    }

}
