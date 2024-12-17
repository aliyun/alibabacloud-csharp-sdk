// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateArtifactShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The build properties of the artifact, utilized for hosting and building the deployment package.</para>
        /// </summary>
        [NameInMap("ArtifactBuildProperty")]
        [Validation(Required=false)]
        public string ArtifactBuildPropertyShrink { get; set; }

        /// <summary>
        /// <para>The type of the artifact build task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>EcsImage: Build ECS (Elastic Container Service) image.</para>
        /// </description></item>
        /// <item><description><para>Dockerfile: Build container image based on Dockerfile.</para>
        /// </description></item>
        /// <item><description><para>Buildpacks: Build container image based on Buildpacks.</para>
        /// </description></item>
        /// <item><description><para>ContainerImage: Rebuild container image by renaming an existing container image.</para>
        /// </description></item>
        /// </list>
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
        /// </summary>
        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public string ArtifactPropertyShrink { get; set; }

        /// <summary>
        /// <para>The type of the deployment package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EcsImage: Elastic Compute Service (ECS) image.</description></item>
        /// <item><description>AcrImage: container image.</description></item>
        /// <item><description>File: Object Storage Service (OSS) object.</description></item>
        /// <item><description>Script: script.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>The name of the deployment package.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>rg-aekzkt5buxxxxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The supported regions.</para>
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
        /// <para>The version name of the deployment package.</para>
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
