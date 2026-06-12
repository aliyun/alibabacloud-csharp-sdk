// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateArtifactResponseBody : TeaModel {
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
        /// <para>The type of the built artifact.</para>
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
        /// <para>2022-11-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The latest version of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxVersion")]
        [Validation(Required=false)]
        public long? MaxVersion { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E73F09DC-6C13-5CB1-A10F-7A4E125ABD2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
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
        ///             &quot;cn-beijing&quot;,
        ///             &quot;cn-hangzhou&quot;,
        ///             &quot;cn-shanghai&quot;
        ///         ]</para>
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

}
