// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateScanRuleRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-4abntrj42twd****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of namespaces.</para>
        /// <list type="bullet">
        /// <item><description>When the scan scope is NAMESPACE, this parameter cannot be empty.</description></item>
        /// <item><description>If the scan scope is REPO, you must specify a unique Namespace for this parameter.</description></item>
        /// </list>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<string> Namespaces { get; set; }

        /// <summary>
        /// <para>The list of repositories.</para>
        /// <list type="bullet">
        /// <item><description>When the scan scope is NAMESPACE, this parameter must be empty.</description></item>
        /// <item><description>When the scan scope is REPO, this parameter cannot be empty.</description></item>
        /// </list>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RepoNames")]
        [Validation(Required=false)]
        public List<string> RepoNames { get; set; }

        /// <summary>
        /// <para>The tag filtering rules.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-.*</para>
        /// </summary>
        [NameInMap("RepoTagFilterPattern")]
        [Validation(Required=false)]
        public string RepoTagFilterPattern { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scan-test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crscnr-3qmkeiuggfpjkfrq</para>
        /// </summary>
        [NameInMap("ScanRuleId")]
        [Validation(Required=false)]
        public string ScanRuleId { get; set; }

        /// <summary>
        /// <para>The scan scope.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NAMESPACE: namespace.</description></item>
        /// <item><description>REPO: repository.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REPO</para>
        /// </summary>
        [NameInMap("ScanScope")]
        [Validation(Required=false)]
        public string ScanScope { get; set; }

        /// <summary>
        /// <para>The trigger type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AUTO: automatically triggers.</description></item>
        /// <item><description>MANUAL: manually triggers.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
