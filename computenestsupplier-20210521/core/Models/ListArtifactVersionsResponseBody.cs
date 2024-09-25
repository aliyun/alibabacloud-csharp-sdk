// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The version information about the deployment package.</para>
        /// </summary>
        [NameInMap("Artifacts")]
        [Validation(Required=false)]
        public List<ListArtifactVersionsResponseBodyArtifacts> Artifacts { get; set; }
        public class ListArtifactVersionsResponseBodyArtifacts : TeaModel {
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
            /// <para>The properties of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;CommodityCode\&quot;:\&quot;cmjj0005xxxx\&quot;,\&quot;CommodityVersion\&quot;:\&quot;V2022xxxx\&quot;}</para>
            /// </summary>
            [NameInMap("ArtifactProperty")]
            [Validation(Required=false)]
            public string ArtifactProperty { get; set; }

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
            /// <para>The version of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ArtifactVersion")]
            [Validation(Required=false)]
            public string ArtifactVersion { get; set; }

            /// <summary>
            /// <para>The time when the certificate was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-20T02:19:53Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

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
            /// <para>The distribution result of the image.</para>
            /// </summary>
            [NameInMap("ImageDelivery")]
            [Validation(Required=false)]
            public Dictionary<string, string> ImageDelivery { get; set; }

            /// <summary>
            /// <para>The distribution progress of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The result file of the security scan.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://compute-nest-security-audit-bucket-ap-southeast-1.oss-ap-southeast-1.aliyuncs.com/51416747xxxx/xxxx">https://compute-nest-security-audit-bucket-ap-southeast-1.oss-ap-southeast-1.aliyuncs.com/51416747xxxx/xxxx</a></para>
            /// </summary>
            [NameInMap("ResultFile")]
            [Validation(Required=false)]
            public string ResultFile { get; set; }

            /// <summary>
            /// <para>The result of the security scan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal: No risks exist on the deployment package.</description></item>
            /// <item><description>AtRisk: Risks exist on the deployment package.</description></item>
            /// <item><description>Processing: The deployment package is being scanned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SecurityAuditResult")]
            [Validation(Required=false)]
            public string SecurityAuditResult { get; set; }

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
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the region that supports the deployment package.</para>
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
            /// <para>The version name of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

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
