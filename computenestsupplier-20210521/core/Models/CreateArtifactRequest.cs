// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateArtifactRequest : TeaModel {
        /// <summary>
        /// <para>The content used to build the artifact. This parameter is used for managed artifact builds.</para>
        /// </summary>
        [NameInMap("ArtifactBuildProperty")]
        [Validation(Required=false)]
        public CreateArtifactRequestArtifactBuildProperty ArtifactBuildProperty { get; set; }
        public class CreateArtifactRequestArtifactBuildProperty : TeaModel {
            /// <summary>
            /// <para>The build arguments.</para>
            /// <remarks>
            /// <para>This parameter can be set only when ArtifactBuildType is set to Dockerfile.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("BuildArgs")]
            [Validation(Required=false)]
            public List<CreateArtifactRequestArtifactBuildPropertyBuildArgs> BuildArgs { get; set; }
            public class CreateArtifactRequestArtifactBuildPropertyBuildArgs : TeaModel {
                /// <summary>
                /// <para>The name of the build argument.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENV</para>
                /// </summary>
                [NameInMap("ArgumentName")]
                [Validation(Required=false)]
                public string ArgumentName { get; set; }

                /// <summary>
                /// <para>The value of the build argument.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx:latest</para>
                /// </summary>
                [NameInMap("ArgumentValue")]
                [Validation(Required=false)]
                public string ArgumentValue { get; set; }

            }

            /// <summary>
            /// <para>The code repository address.</para>
            /// <remarks>
            /// <para>This parameter can be set only when ArtifactBuildType is set to Dockerfile or Buildpacks.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CodeRepo")]
            [Validation(Required=false)]
            public CreateArtifactRequestArtifactBuildPropertyCodeRepo CodeRepo { get; set; }
            public class CreateArtifactRequestArtifactBuildPropertyCodeRepo : TeaModel {
                /// <summary>
                /// <para>The name of the code repository branch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("Branch")]
                [Validation(Required=false)]
                public string Branch { get; set; }

                /// <summary>
                /// <para>The endpoint. This parameter is required for a private GitLab deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://121.40.25.0">http://121.40.25.0</a></para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The organization ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>455231</para>
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// <para>The owner of the code repository.</para>
                /// <remarks>
                /// <para>This parameter is required only when the code repository is a private repository.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun-computenest</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The platform where the code repository is located. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>github</para>
                /// </description></item>
                /// <item><description><para>gitee</para>
                /// </description></item>
                /// <item><description><para>gitlab</para>
                /// </description></item>
                /// <item><description><para>codeup</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>github</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The repository ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>103</para>
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public long? RepoId { get; set; }

                /// <summary>
                /// <para>The repository name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun-computenest/quickstart-Lobexxx</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

            }

            /// <summary>
            /// <para>The content of the command.</para>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is an ECS image artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>echo &quot;start run command&quot;</para>
            /// </summary>
            [NameInMap("CommandContent")]
            [Validation(Required=false)]
            public string CommandContent { get; set; }

            /// <summary>
            /// <para>The command type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RunBatScript: The command is a BAT script that runs on a Windows instance.</para>
            /// </description></item>
            /// <item><description><para>RunPowerShellScript: The command is a PowerShell script that runs on a Windows instance.</para>
            /// </description></item>
            /// <item><description><para>RunShellScript: The command is a shell script that runs on a Linux instance.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is an ECS image artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RunShellScript</para>
            /// </summary>
            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            /// <summary>
            /// <para>The relative address of the Dockerfile file in the code repository.</para>
            /// <para>Default value: Dockerfile.</para>
            /// <remarks>
            /// <para>This parameter can be set only when ArtifactBuildType is set to Dockerfile.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>./file/Dockerfile</para>
            /// </summary>
            [NameInMap("DockerfilePath")]
            [Validation(Required=false)]
            public string DockerfilePath { get; set; }

            /// <summary>
            /// <para>Specifies whether to use a GPU-accelerated instance. By default, a CPU-powered instance is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableGpu")]
            [Validation(Required=false)]
            public bool? EnableGpu { get; set; }

            /// <summary>
            /// <para>The ID of the region where the source image is located.</para>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is an ECS image artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The pull address of the source container image.</para>
            /// <para>Used for docker pull ${SourceContainerImage}.</para>
            /// <remarks>
            /// <para>This parameter can be set only when ArtifactBuildType is set to ContainerImage.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pytorch/pytorch:2.5.1-cuda12.4-cudnn9-devel</para>
            /// </summary>
            [NameInMap("SourceContainerImage")]
            [Validation(Required=false)]
            public string SourceContainerImage { get; set; }

            /// <summary>
            /// <para>The source image ID. The following types are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>Image ID: The ID of the ECS image.</para>
            /// </description></item>
            /// <item><description><para>OOS public parameter name: The image ID is automatically obtained based on the name of the Operation Orchestration Service (OOS) public parameter.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is an ECS image artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Image ID: m-t4nhenrdc38pe4*****
            /// ubuntu_22_04_x64_20G_alibase_20240926.vhd
            /// OOS public parameter name: aliyun/services/computenest/images/aliyun_3_2104_python_3_11</para>
            /// </summary>
            [NameInMap("SourceImageId")]
            [Validation(Required=false)]
            public string SourceImageId { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

        }

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
        public CreateArtifactRequestArtifactProperty ArtifactProperty { get; set; }
        public class CreateArtifactRequestArtifactProperty : TeaModel {
            /// <summary>
            /// <para>The commodity code of the product in Alibaba Cloud Marketplace.</para>
            /// <para>Obtain the commodity code in the <a href="https://market.console.aliyun.com/?spm=a2c4g.11186623.0.0.599d6787eMBBxu#/apiTools?_k=d7j8gk">Alibaba Cloud Marketplace console</a>.</para>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is an image artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cmjj00****</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The version of the product in Alibaba Cloud Marketplace.</para>
            /// <para>View the product version on the <a href="https://market.aliyun.com/?spm=5176.24779694.0.0.b2144d22sksKM5">Alibaba Cloud Marketplace</a> page.</para>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is an image artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>V1.0</para>
            /// </summary>
            [NameInMap("CommodityVersion")]
            [Validation(Required=false)]
            public string CommodityVersion { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// <para>After you specify a region ID, call the <a href="https://help.aliyun.com/document_detail/2679797.html">DescribeImages</a> operation to view the available image IDs in the specified region.</para>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is an image artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>m-uf645fnsef9dsxmw****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The region of the image.</para>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is an image artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the image repository.</para>
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2539919.html">ListAcrImageRepositories</a> operation to obtain the image repository ID.</para>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is a container image artifact or a Helm chart artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>crr-d8o1nponyc2t****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is a container image artifact or a Helm chart artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>wordpress</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The type of the repository. Valid values: Public and Private.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>The version of the image in the image repository.</para>
            /// <para>Call the <a href="https://help.aliyun.com/document_detail/2539920.html">ListAcrImageTags</a> operation to obtain the version of the image in the image repository.</para>
            /// <remarks>
            /// <para>This parameter can be set only when the artifact is a container image artifact or a Helm chart artifact.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The URL of the file artifact.</para>
            /// <para>Upload a file and obtain its URL in the <a href="https://oss.console.aliyun.com/bucket">Object Storage Service console</a>.</para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

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
        public List<CreateArtifactRequestTag> Tag { get; set; }
        public class CreateArtifactRequestTag : TeaModel {
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
