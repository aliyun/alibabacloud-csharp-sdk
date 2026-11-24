// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepositoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The creation time, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570759546000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The detailed information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-kmsiwlxxdcva****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The last modification time, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1570759546100</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <para>The repository build type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>MANUAL</c>: manually triggered build.</para>
        /// </description></item>
        /// <item><description><para><c>AUTO</c>: automatically triggered build.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MANUAL</para>
        /// </summary>
        [NameInMap("RepoBuildType")]
        [Validation(Required=false)]
        public string RepoBuildType { get; set; }

        /// <summary>
        /// <para>The repository ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-l5eoubonp0l****</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// <para>The repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The namespace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// <para>The repository status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("RepoStatus")]
        [Validation(Required=false)]
        public string RepoStatus { get; set; }

        /// <summary>
        /// <para>The repository type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PUBLIC</c>: public repository.</para>
        /// </description></item>
        /// <item><description><para><c>PRIVATE</c>: private repository.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("RepoType")]
        [Validation(Required=false)]
        public string RepoType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>915E6734-3E50-4640-8DBA-126D2D94DE29</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmv36i4is****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The summary information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Automatically created repository</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The image tag immutability setting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TagImmutability")]
        [Validation(Required=false)]
        public bool? TagImmutability { get; set; }

    }

}
