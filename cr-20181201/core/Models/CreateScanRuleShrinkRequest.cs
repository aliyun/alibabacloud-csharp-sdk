// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateScanRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-dqwc**********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The collection of namespaces.</para>
        /// <list type="bullet">
        /// <item><description>If the scan scope is NAMESPACE, this parameter cannot be empty.</description></item>
        /// <item><description>If the scan scope is REPO, specify exactly one namespace for this parameter.</description></item>
        /// </list>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public string NamespacesShrink { get; set; }

        /// <summary>
        /// <para>The list of repositories.</para>
        /// <list type="bullet">
        /// <item><description>If the scan scope is NAMESPACE, this parameter must be empty.</description></item>
        /// <item><description>If the scan scope is REPO, this parameter cannot be empty.</description></item>
        /// </list>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RepoNames")]
        [Validation(Required=false)]
        public string RepoNamesShrink { get; set; }

        /// <summary>
        /// <para>The regular expression used to match tags that trigger a scan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("RepoTagFilterPattern")]
        [Validation(Required=false)]
        public string RepoTagFilterPattern { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The scan scope.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NAMESPACE</para>
        /// </summary>
        [NameInMap("ScanScope")]
        [Validation(Required=false)]
        public string ScanScope { get; set; }

        /// <summary>
        /// <para>The scan type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>VUL</c>: Artifact vulnerability scanning.</description></item>
        /// <item><description><c>SBOM</c>: Artifact content analysis.</description></item>
        /// </list>
        /// <para>Default value: <c>VUL</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VUL</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <para>The trigger type.</para>
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
