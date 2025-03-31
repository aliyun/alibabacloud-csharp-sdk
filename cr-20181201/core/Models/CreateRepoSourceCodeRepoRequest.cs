// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSourceCodeRepoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to trigger image building when source code is committed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: triggers image building when source code is committed.</description></item>
        /// <item><description><c>false</c>: does not trigger image building when source code is committed.</description></item>
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
        /// <para>The namespace to which the source code repository belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace</para>
        /// </summary>
        [NameInMap("CodeRepoNamespaceName")]
        [Validation(Required=false)]
        public string CodeRepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The type of the source code hosting platform. Valid values: <c>GITHUB</c>, <c>GITLAB</c>, <c>GITEE</c>, <c>CODE</c>, and <c>CODEUP</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GITHUB</para>
        /// </summary>
        [NameInMap("CodeRepoType")]
        [Validation(Required=false)]
        public string CodeRepoType { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable building caches. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: disables building caches.</description></item>
        /// <item><description><c>false</c>: enables building caches.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableCacheBuild")]
        [Validation(Required=false)]
        public bool? DisableCacheBuild { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-shac42yvqzvq****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Build With Servers Deployed Outside Chinese Mainland. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables Build With Servers Deployed Outside Chinese Mainland.</description></item>
        /// <item><description><c>false</c>: does not enable Build With Servers Deployed Outside Chinese Mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OverseaBuild")]
        [Validation(Required=false)]
        public bool? OverseaBuild { get; set; }

        /// <summary>
        /// <para>The ID of the image repository.</para>
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
