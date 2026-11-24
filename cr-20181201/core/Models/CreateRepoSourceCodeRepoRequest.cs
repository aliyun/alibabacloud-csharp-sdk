// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSourceCodeRepoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic building. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enables automatic building.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disables automatic building.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoBuild")]
        [Validation(Required=false)]
        public bool? AutoBuild { get; set; }

        /// <summary>
        /// <para>The name of the source code repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo</para>
        /// </summary>
        [NameInMap("CodeRepoName")]
        [Validation(Required=false)]
        public string CodeRepoName { get; set; }

        /// <summary>
        /// <para>The namespace name of the source code repository.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace</para>
        /// </summary>
        [NameInMap("CodeRepoNamespaceName")]
        [Validation(Required=false)]
        public string CodeRepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The type of the source code platform. Valid values: <c>GITHUB</c>, <c>GITLAB</c>, <c>GITEE</c>, <c>CODE</c>, and <c>CODEUP</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GITHUB</para>
        /// </summary>
        [NameInMap("CodeRepoType")]
        [Validation(Required=false)]
        public string CodeRepoType { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the build cache. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: disables the build cache.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: enables the build cache.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableCacheBuild")]
        [Validation(Required=false)]
        public bool? DisableCacheBuild { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-shac42yvqzvq****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable intelligent build acceleration for overseas sources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enables intelligent build acceleration for overseas sources.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disables intelligent build acceleration for overseas sources.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OverseaBuild")]
        [Validation(Required=false)]
        public bool? OverseaBuild { get; set; }

        /// <summary>
        /// <para>The image repository ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-gzsrlevmvoaq****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

    }

}
