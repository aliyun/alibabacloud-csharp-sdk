// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChartRepositoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of repositories.</para>
        /// </summary>
        [NameInMap("Repositories")]
        [Validation(Required=false)]
        public List<ListChartRepositoryResponseBodyRepositories> Repositories { get; set; }
        public class ListChartRepositoryResponseBodyRepositories : TeaModel {
            /// <summary>
            /// <para>The time when the repository was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1571926644000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-xkx6vujuhay0****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the repository was last modified. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1571930329000</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The repository ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crcr-gpsu7b8chmxk****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>repo1</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace of the repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ns1</para>
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

            /// <summary>
            /// <para>The status of the repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>NORMAL</c>: Normal.</para>
            /// </description></item>
            /// <item><description><para><c>DELETING</c>: The repository is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("RepoStatus")]
            [Validation(Required=false)]
            public string RepoStatus { get; set; }

            /// <summary>
            /// <para>The type of the repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PRIVATE</c>: a private repository.</description></item>
            /// <item><description><c>PUBLIC</c>: a public repository.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2ikd5rxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The summary of the repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AB62FB8-6873-4032-8515-4578D27523B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
