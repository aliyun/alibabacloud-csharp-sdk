// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateArtifactRequest : TeaModel {
        /// <summary>
        /// <para>The build properties of the artifact, utilized for hosting and building the deployment package.</para>
        /// </summary>
        [NameInMap("ArtifactBuildProperty")]
        [Validation(Required=false)]
        public UpdateArtifactRequestArtifactBuildProperty ArtifactBuildProperty { get; set; }
        public class UpdateArtifactRequestArtifactBuildProperty : TeaModel {
            /// <summary>
            /// <para>The build arguments used during the image build process.</para>
            /// <remarks>
            /// <para> This parameter is available only if the ArtifactBuildType is Dockerfile type.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("BuildArgs")]
            [Validation(Required=false)]
            public List<UpdateArtifactRequestArtifactBuildPropertyBuildArgs> BuildArgs { get; set; }
            public class UpdateArtifactRequestArtifactBuildPropertyBuildArgs : TeaModel {
                /// <summary>
                /// <para>The name of a specific build argument.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENV</para>
                /// </summary>
                [NameInMap("ArgumentName")]
                [Validation(Required=false)]
                public string ArgumentName { get; set; }

                /// <summary>
                /// <para>The value of a specific build argument.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx:latest</para>
                /// </summary>
                [NameInMap("ArgumentValue")]
                [Validation(Required=false)]
                public string ArgumentValue { get; set; }

            }

            /// <summary>
            /// <para>The address of the code repository.</para>
            /// <remarks>
            /// <para> This parameter is available only if the ArtifactBuildType is Dockerfile or Buildpacks type.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CodeRepo")]
            [Validation(Required=false)]
            public UpdateArtifactRequestArtifactBuildPropertyCodeRepo CodeRepo { get; set; }
            public class UpdateArtifactRequestArtifactBuildPropertyCodeRepo : TeaModel {
                /// <summary>
                /// <para>The name of the branch in the code repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>main</para>
                /// </summary>
                [NameInMap("Branch")]
                [Validation(Required=false)]
                public string Branch { get; set; }

                /// <summary>
                /// <para>The owner of the code repository.</para>
                /// <remarks>
                /// <para> This parameter is available only if the git repository is private.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun-computenest</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The platform where the code repository is hosted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>github</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The name of the repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun-computenest/quickstart-Lobexxx</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

            }

            /// <summary>
            /// <para>The command content.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a ecs image type.</para>
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
            /// <item><description>RunBatScript: batch command, applicable to Windows instances.</description></item>
            /// <item><description>RunPowerShellScript: PowerShell command, applicable to Windows instances.</description></item>
            /// <item><description>RunShellScript: shell command, applicable to Linux instances.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a ecs image type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RunShellScript</para>
            /// </summary>
            [NameInMap("CommandType")]
            [Validation(Required=false)]
            public string CommandType { get; set; }

            /// <summary>
            /// <para>The relative path to the Dockerfile within the code repository.</para>
            /// <remarks>
            /// <para> This parameter is available only if the ArtifactBuildType is Dockerfile type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>./file/Dockerfile</para>
            /// </summary>
            [NameInMap("DockerfilePath")]
            [Validation(Required=false)]
            public string DockerfilePath { get; set; }

            /// <summary>
            /// <para>The region ID where the source mirror image is located.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a ecs image type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The pull location of the source container image. This is used for the command docker pull ${SourceContainerImage}.</para>
            /// <remarks>
            /// <para> This parameter is available only if the ArtifactBuildType is ContainerImage type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pytorch/pytorch:2.5.1-cuda12.4-cudnn9-devel</para>
            /// </summary>
            [NameInMap("SourceContainerImage")]
            [Validation(Required=false)]
            public string SourceContainerImage { get; set; }

            /// <summary>
            /// <para>The source image id. Supported Types:</para>
            /// <list type="bullet">
            /// <item><description><para>Image ID: Pass the Image ID of the Ecs image directly.</para>
            /// </description></item>
            /// <item><description><para>OOS Common Parameter Name: Obtain the corresponding Image ID automatically by using the OOS common parameter name.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a ecs image type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Image ID：m-t4nhenrdc38pe4*****
            /// ubuntu_22_04_x64_20G_alibase_20240926.vhd
            /// OOS Common Parameter Name：aliyun/services/computenest/images/aliyun_3_2104_python_3_11</para>
            /// </summary>
            [NameInMap("SourceImageId")]
            [Validation(Required=false)]
            public string SourceImageId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the deployment package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>artifact-eea08d1e2d3a43aexxxx</para>
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// <para>The properties of the deployment package.</para>
        /// </summary>
        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public UpdateArtifactRequestArtifactProperty ArtifactProperty { get; set; }
        public class UpdateArtifactRequestArtifactProperty : TeaModel {
            /// <summary>
            /// <para>The commodity code of the service in Alibaba Cloud Marketplace.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is an image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cmjj00xxxx</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The commodity version of the service in Alibaba Cloud Marketplace.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is an image.</para>
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
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is an image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>m-0xij191j9cuev6ucxxxx</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is an image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry  repository.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a container image or of the Helm chart type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>crr-yy4g68uhi39ttkm8</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The name of the Container Registry repository.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a container image or of the Helm chart type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>volcanosh/vc-webhook-manager</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The type of the repository.Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Public</c>: a public repository.</description></item>
            /// <item><description><c>Private</c>: a private repository.<remarks>
            /// <para> This parameter is available only if the deployment package is a container image or of the Helm chart type.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>The version tag of the image repository.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a container image or of the Helm chart type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The URL of the deployment package object.</para>
            /// <remarks>
            /// <para>Note This parameter is available only if the deployment package is an file.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1309208528xxxxxx/template/2e1ce8fc-xxxx-481c-9e8e-789ba9db487d.json">https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1309208528xxxxxx/template/2e1ce8fc-xxxx-481c-9e8e-789ba9db487d.json</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

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
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Permission fields are applicable to container image artifact and Helm Chart artifact. They can only change from Automatic to Public. Options:</para>
        /// <para>Public</para>
        /// <para>Automatic</para>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("PermissionType")]
        [Validation(Required=false)]
        public string PermissionType { get; set; }

        /// <summary>
        /// <para>The IDs of the regions that support the deployment package.</para>
        /// </summary>
        [NameInMap("SupportRegionIds")]
        [Validation(Required=false)]
        public List<string> SupportRegionIds { get; set; }

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

}
