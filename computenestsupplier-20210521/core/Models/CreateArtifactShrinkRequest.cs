// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateArtifactShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The content used to build the artifact. This parameter is used for managed artifact builds.</para>
        /// </summary>
        [NameInMap("ArtifactBuildProperty")]
        [Validation(Required=false)]
        public string ArtifactBuildPropertyShrink { get; set; }

        /// <summary>
        /// <para>The type of the artifact to be built. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>EcsImage: builds an ECS image.</para>
        /// </description></item>
        /// <item><description><para>Dockerfile: builds a container image based on a Dockerfile.</para>
        /// </description></item>
        /// <item><description><para>Buildpacks: builds a container image based on Buildpacks.</para>
        /// </description></item>
        /// <item><description><para>ContainerImage: builds a container image by renaming an existing container image.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Dockerflie</para>
        /// </summary>
        [NameInMap("ArtifactBuildType")]
        [Validation(Required=false)]
        public string ArtifactBuildType { get; set; }

        /// <summary>
        /// <para>The artifact ID.</para>
        /// <para>This parameter is required to create a new version of an existing artifact.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/469993.html">ListArtifacts</a> operation to obtain the artifact ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>artifact-eea08d1e2d3a43ae****</para>
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// <para>The content of the artifact.</para>
        /// </summary>
        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public string ArtifactPropertyShrink { get; set; }

        /// <summary>
        /// <para>The artifact type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>EcsImage: an ECS image artifact.</para>
        /// </description></item>
        /// <item><description><para>AcrImage: a container image artifact.</para>
        /// </description></item>
        /// <item><description><para>File: an Object Storage Service (OSS) file artifact.</para>
        /// </description></item>
        /// <item><description><para>Script: a script artifact.</para>
        /// </description></item>
        /// <item><description><para>HelmChart: a Helm chart artifact.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EcsImage</para>
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>Ensures the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>The artifact name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redhat8_5 image</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2jfvb7b****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The regions where the image can be distributed.</para>
        /// </summary>
        [NameInMap("SupportRegionIds")]
        [Validation(Required=false)]
        public List<string> SupportRegionIds { get; set; }

        /// <summary>
        /// <para>The custom tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateArtifactShrinkRequestTag> Tag { get; set; }
        public class CreateArtifactShrinkRequestTag : TeaModel {
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

        /// <summary>
        /// <para>The name of the artifact version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
