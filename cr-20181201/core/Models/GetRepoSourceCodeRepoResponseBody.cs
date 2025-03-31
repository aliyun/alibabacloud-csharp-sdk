// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoSourceCodeRepoResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether image building is automatically triggered when source code is committed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Image building is automatically triggered when source code is committed.</description></item>
        /// <item><description><c>false</c>: Image building is not triggered when source code is committed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoBuild")]
        [Validation(Required=false)]
        public string AutoBuild { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The address of the source code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://github.com">https://github.com</a></para>
        /// </summary>
        [NameInMap("CodeRepoDomain")]
        [Validation(Required=false)]
        public string CodeRepoDomain { get; set; }

        /// <summary>
        /// <para>The name of the source code repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo</para>
        /// </summary>
        [NameInMap("CodeRepoName")]
        [Validation(Required=false)]
        public string CodeRepoName { get; set; }

        /// <summary>
        /// <para>The namespace to which the source code repository belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace</para>
        /// </summary>
        [NameInMap("CodeRepoNamespaceName")]
        [Validation(Required=false)]
        public string CodeRepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The type of the code hosting platform. Valid values: <c>GITHUB</c>, <c>GITLAB</c>, <c>GITEE</c>, <c>CODE</c>, and <c>CODEUP</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GITHUB</para>
        /// </summary>
        [NameInMap("CodeRepoType")]
        [Validation(Required=false)]
        public string CodeRepoType { get; set; }

        /// <summary>
        /// <para>Indicates whether build cache is disabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Build cache is disabled.</description></item>
        /// <item><description><c>false</c>: Build cache is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableCacheBuild")]
        [Validation(Required=false)]
        public string DisableCacheBuild { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: successful</description></item>
        /// <item><description><c>false</c>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>Indicates whether image building is accelerated for servers outside the Chinese mainland. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Image building is accelerated for servers outside the Chinese mainland.</description></item>
        /// <item><description><c>false</c>: Image building is not accelerated for servers outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OverseaBuild")]
        [Validation(Required=false)]
        public string OverseaBuild { get; set; }

        /// <summary>
        /// <para>The ID of the repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-gzsrlevmvoaq****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4CE1F661-75DD-4EBD-A4AD-057B26834ABB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
