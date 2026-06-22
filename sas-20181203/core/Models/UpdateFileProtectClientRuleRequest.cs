// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectClientRuleRequest : TeaModel {
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
        /// <para>The list of users excluded from file protection.</para>
        /// </summary>
        [NameInMap("ExcludeUsers")]
        [Validation(Required=false)]
        public List<string> ExcludeUsers { get; set; }

        /// <summary>
        /// <para>The list of operations performed on the file.</para>
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
        /// <para>The list of protected file types.</para>
        /// </summary>
        [NameInMap("FileTypes")]
        [Validation(Required=false)]
        public List<string> FileTypes { get; set; }

        /// <summary>
        /// <para>The unique ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>245</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The list of process listening paths. Wildcards are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProcPaths")]
        [Validation(Required=false)]
        public List<string> ProcPaths { get; set; }

        /// <summary>
        /// <para>The action of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>block</b>: Block.</para>
        /// </description></item>
        /// <item><description><para><b>monitor</b>: Monitor.</para>
        /// </description></item>
        /// <item><description><para><b>pass</b>: Allow.</para>
        /// </description></item>
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
        /// <para>text-001</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled</description></item>
        /// <item><description><b>1</b>: enabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
