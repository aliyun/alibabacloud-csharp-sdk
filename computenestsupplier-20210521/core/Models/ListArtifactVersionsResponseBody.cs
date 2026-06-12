// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the artifact versions.</para>
        /// </summary>
        [NameInMap("Artifacts")]
        [Validation(Required=false)]
        public List<ListArtifactVersionsResponseBodyArtifacts> Artifacts { get; set; }
        public class ListArtifactVersionsResponseBodyArtifacts : TeaModel {
            /// <summary>
            /// <para>The content used to build the artifact. This parameter is used for managed artifact builds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;RegionId\&quot;:\&quot;xxx\&quot;, \&quot;SourceImageId\&quot;:\&quot;xxx\&quot;, \&quot;\&quot;:\&quot;xxx\&quot;, \&quot;CommandType\&quot;:\&quot;xxx\&quot;, \&quot;CommandContent\&quot;:\&quot;xxx\&quot;}&quot;</para>
            /// </summary>
            [NameInMap("ArtifactBuildProperty")]
            [Validation(Required=false)]
            public string ArtifactBuildProperty { get; set; }

            /// <summary>
            /// <para>The artifact build type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dockerfile</para>
            /// </summary>
            [NameInMap("ArtifactBuildType")]
            [Validation(Required=false)]
            public string ArtifactBuildType { get; set; }

            /// <summary>
            /// <para>The artifact ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>artifact-eea08d1e2d3a43ae****</para>
            /// </summary>
            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// <para>The properties of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;CommodityCode\&quot;:\&quot;cmjj0005****\&quot;,\&quot;CommodityVersion\&quot;:\&quot;V2022****\&quot;}</para>
            /// </summary>
            [NameInMap("ArtifactProperty")]
            [Validation(Required=false)]
            public string ArtifactProperty { get; set; }

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
            /// <para>The version of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ArtifactVersion")]
            [Validation(Required=false)]
            public string ArtifactVersion { get; set; }

            /// <summary>
            /// <para>The time when the artifact was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-20T02:19:53Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the artifact was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-20T02:19:55Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The result of the image distribution.</para>
            /// </summary>
            [NameInMap("ImageDelivery")]
            [Validation(Required=false)]
            public Dictionary<string, string> ImageDelivery { get; set; }

            /// <summary>
            /// <para>The distribution progress of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The file that contains the security scan results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>仅当安全扫描结果的返回值为AtRisk时才会展示。</para>
            /// </summary>
            [NameInMap("ResultFile")]
            [Validation(Required=false)]
            public string ResultFile { get; set; }

            /// <summary>
            /// <para>The security scan result.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Normal: The artifact is normal and has no threats.</para>
            /// </description></item>
            /// <item><description><para>AtRisk: The artifact has security threats.</para>
            /// </description></item>
            /// <item><description><para>Processing: The security scan is in progress.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SecurityAuditResult")]
            [Validation(Required=false)]
            public string SecurityAuditResult { get; set; }

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
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The description of the artifact status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;/usr/local/share/aliyun-assist/work/script/t-hz04zm90y6og0sg.sh: line 1: pip: command not found&quot;</para>
            /// </summary>
            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

            /// <summary>
            /// <para>The IDs of the regions to which the artifact is distributed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///                     &quot;cn-beijing&quot;,
            ///                     &quot;cn-hangzhou&quot;,
            ///                     &quot;cn-shanghai&quot;
            ///                 ]</para>
            /// </summary>
            [NameInMap("SupportRegionIds")]
            [Validation(Required=false)]
            public string SupportRegionIds { get; set; }

            /// <summary>
            /// <para>The name of the artifact version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

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
        /// <para>The token that is used to retrieve the next page of results. If the results are not complete, this token is returned. To retrieve the next page of results, include this token in the next request.</para>
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
        /// <para>4DB0F536-B3BE-4F0D-BD29-E83FB56D550C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the query criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
