// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateArtifactResponseBody : TeaModel {
        /// <summary>
        /// <para>The build properties of the artifact, utilized for hosting and building the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;RegionId\&quot;:\&quot;xxx\&quot;, \&quot;SourceImageId\&quot;:\&quot;xxx\&quot;, \&quot;\&quot;:\&quot;xxx\&quot;, \&quot;CommandType\&quot;:\&quot;xxx\&quot;, \&quot;CommandContent\&quot;:\&quot;xxx\&quot;}&quot;</para>
        /// </summary>
        [NameInMap("ArtifactBuildProperty")]
        [Validation(Required=false)]
        public string ArtifactBuildProperty { get; set; }

        /// <summary>
        /// <para>The type of the deployment package to be built.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dockerfile</para>
        /// </summary>
        [NameInMap("ArtifactBuildType")]
        [Validation(Required=false)]
        public string ArtifactBuildType { get; set; }

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
        /// <para>The properties of the deployment object.</para>
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
        /// <para>The description of the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test artifact</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the deployment package was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The latest version of the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxVersion")]
        [Validation(Required=false)]
        public long? MaxVersion { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B1A0198B-F316-1B72-B8DD-28B6F6D6XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the deployment package. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The status of the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;/usr/local/share/aliyun-assist/work/script/t-hz04zm90y6og0sg.sh: line 1: pip: command not found&quot;</para>
        /// </summary>
        [NameInMap("StatusDetail")]
        [Validation(Required=false)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// <para>The ID of the region that supports the deployment package.</para>
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
        /// <para>The name of the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
