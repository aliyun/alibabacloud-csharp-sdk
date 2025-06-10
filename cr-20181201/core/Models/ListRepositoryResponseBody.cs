// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepositoryResponseBody : TeaModel {
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
        /// <para>Indicates whether the request is successful.</para>
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The information about the repositories.</para>
        /// </summary>
        [NameInMap("Repositories")]
        [Validation(Required=false)]
        public List<ListRepositoryResponseBodyRepositories> Repositories { get; set; }
        public class ListRepositoryResponseBodyRepositories : TeaModel {
            /// <summary>
            /// <para>The time when the repository was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1564153576000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry instance to which the repository belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-kmsiwlxxdcv****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the repository was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1564153576000</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The type of the repository building. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>AUTO</c>: The repository is automatically built.</description></item>
            /// <item><description><c>MANUAL</c>: The repository is manually built.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MANUAL</para>
            /// </summary>
            [NameInMap("RepoBuildType")]
            [Validation(Required=false)]
            public string RepoBuildType { get; set; }

            /// <summary>
            /// <para>The ID of the repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-03cuozrsqhkw****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The name of the repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The name of the namespace to which the repository belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

            /// <summary>
            /// <para>The status of the repository.</para>
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
            /// <item><description><c>PUBLIC</c></description></item>
            /// <item><description><c>PRIVATE</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE</para>
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the repository belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm4n5kzyfxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The summary of the repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test OK</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>Indicates whether the feature of image tag immutability is enabled for the repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TagImmutability")]
            [Validation(Required=false)]
            public bool? TagImmutability { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5241C090-DA69-4B0F-8E3F-2F24FDE1110E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the queried image repositories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
