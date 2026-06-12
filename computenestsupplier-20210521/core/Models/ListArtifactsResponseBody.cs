// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the artifacts.</para>
        /// </summary>
        [NameInMap("Artifacts")]
        [Validation(Required=false)]
        public List<ListArtifactsResponseBodyArtifacts> Artifacts { get; set; }
        public class ListArtifactsResponseBodyArtifacts : TeaModel {
            /// <summary>
            /// <para>The content used to build the artifact. This parameter is used for hosted artifact builds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;CodeRepo\&quot;:{\&quot;Owner\&quot;:\&quot;wenle\&quot;,\&quot;Platform\&quot;:\&quot;github\&quot;,\&quot;Branch\&quot;:\&quot;main\&quot;,\&quot;RepoName\&quot;:\&quot;heroku/node-js-getting-started\&quot;}}</para>
            /// </summary>
            [NameInMap("ArtifactBuildProperty")]
            [Validation(Required=false)]
            public string ArtifactBuildProperty { get; set; }

            /// <summary>
            /// <para>The artifact ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>artifact-eea08d1e2d3a43aexxxx</para>
            /// </summary>
            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// <para>The artifact type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EcsImage</para>
            /// </summary>
            [NameInMap("ArtifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// <para>The description of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Redhat8_0 image</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the artifact was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-20T02:19:55Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxVersion")]
            [Validation(Required=false)]
            public string MaxVersion { get; set; }

            /// <summary>
            /// <para>The artifact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Redhat8_5 image</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The permission field. This parameter is valid for artifacts of the container image, Helm chart, and file types. For other types of artifacts, you can only change the permission from Automatic to Public.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Public</para>
            /// </description></item>
            /// <item><description><para>Automatic</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("PermissionType")]
            [Validation(Required=false)]
            public string PermissionType { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzmhzoaa****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the artifact.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Created: The artifact is created.</para>
            /// </description></item>
            /// <item><description><para>Scanning: The artifact is being scanned.</para>
            /// </description></item>
            /// <item><description><para>ScanFailed: The artifact failed to be scanned.</para>
            /// </description></item>
            /// <item><description><para>Delivering: The artifact is being distributed.</para>
            /// </description></item>
            /// <item><description><para>Available: The artifact is available.</para>
            /// </description></item>
            /// <item><description><para>Deleted: The artifact is deleted.</para>
            /// </description></item>
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
        /// <para>The number of entries returned per page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set it to the NextToken value returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLbfVwapgMwCN1wYzPVzLbItEdB0uWSY7AGnM3qCgm/YnjuEfwSnMwiMkcUoI0hR****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B7AE429-B53E-5E73-A5EC-DC91F614F2D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
