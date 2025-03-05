// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about deployment packages.</para>
        /// </summary>
        [NameInMap("Artifacts")]
        [Validation(Required=false)]
        public List<ListArtifactsResponseBodyArtifacts> Artifacts { get; set; }
        public class ListArtifactsResponseBodyArtifacts : TeaModel {
            /// <summary>
            /// <para>The build properties of the artifact, utilized for hosting and building the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;CodeRepo\&quot;:{\&quot;Owner\&quot;:\&quot;wenle\&quot;,\&quot;Platform\&quot;:\&quot;github\&quot;,\&quot;Branch\&quot;:\&quot;main\&quot;,\&quot;RepoName\&quot;:\&quot;aliyun-computenest/java-springboot-demo\&quot;}}</para>
            /// </summary>
            [NameInMap("ArtifactBuildProperty")]
            [Validation(Required=false)]
            public string ArtifactBuildProperty { get; set; }

            /// <summary>
            /// <para>The ID of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>artifact-eea08d1e2d3a43aexxxx</para>
            /// </summary>
            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// <para>The type of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EcsImage</para>
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// <para>The description of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the deployment package was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-20T02:19:55Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The latest version of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxVersion")]
            [Validation(Required=false)]
            public string MaxVersion { get; set; }

            /// <summary>
            /// <para>The name of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek25rexxxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the deployment package. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created: The deployment package is created.</description></item>
            /// <item><description>Scanning: The deployment package is being scanned.</description></item>
            /// <item><description>ScanFailed: The deployment package failed to be scanned.</description></item>
            /// <item><description>Delivering: The deployment package is being distributed.</description></item>
            /// <item><description>Available: The deployment package is available.</description></item>
            /// <item><description>Deleted: The deployment package is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListArtifactsResponseBodyArtifactsTags> Tags { get; set; }
            public class ListArtifactsResponseBodyArtifactsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLbfVwapgMwCN1wYzPVzLbItEdB0uWSY7AGnM3qCgm/YnjuEfwSnMwiMkcUoI0hRQzE=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46577928-3162-15A6-9084-69820EB9xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
