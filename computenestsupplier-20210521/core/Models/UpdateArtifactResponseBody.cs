// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateArtifactResponseBody : TeaModel {
        /// <summary>
        /// <para>The properties for building the artifact. This is used for managed artifact builds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;RegionId\&quot;:\&quot;xxx\&quot;, \&quot;SourceImageId\&quot;:\&quot;xxx\&quot;, \&quot;\&quot;:\&quot;xxx\&quot;, \&quot;CommandType\&quot;:\&quot;xxx\&quot;, \&quot;CommandContent\&quot;:\&quot;xxx\&quot;}&quot;</para>
        /// </summary>
        [NameInMap("ArtifactBuildProperty")]
        [Validation(Required=false)]
        public string ArtifactBuildProperty { get; set; }

        /// <summary>
        /// <para>The build type of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;RegionId\&quot;:\&quot;xxx\&quot;, \&quot;SourceImageId\&quot;:\&quot;xxx\&quot;, \&quot;\&quot;:\&quot;xxx\&quot;, \&quot;CommandType\&quot;:\&quot;xxx\&quot;, \&quot;CommandContent\&quot;:\&quot;xxx\&quot;}&quot;</para>
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
        /// <para>The content of the artifact.</para>
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
        /// <para>The artifact version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9F350409-2ACC-5B61-ACD9-3C8995792F8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The details of the artifact status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;/usr/local/share/aliyun-assist/work/script/t-hz04zm90y6og0sg.sh: line 1: pip: command not found&quot;</para>
        /// </summary>
        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// <para>The IDs of the regions to which the artifact can be distributed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///             &quot;cn-beijing&quot;,
        ///             &quot;cn-hangzhou&quot;,
        ///             &quot;cn-shanghai&quot;
        ///         ]</para>
        /// </summary>
        [NameInMap("SupportRegionIds")]
        [Validation(Required=false)]
        public string SupportRegionIds { get; set; }

        /// <summary>
        /// <para>The version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
