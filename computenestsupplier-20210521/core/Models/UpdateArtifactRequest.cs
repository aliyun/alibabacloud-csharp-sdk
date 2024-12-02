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
            [NameInMap("BuildArgs")]
            [Validation(Required=false)]
            public List<UpdateArtifactRequestArtifactBuildPropertyBuildArgs> BuildArgs { get; set; }
            public class UpdateArtifactRequestArtifactBuildPropertyBuildArgs : TeaModel {
                [NameInMap("ArgumentName")]
                [Validation(Required=false)]
                public string ArgumentName { get; set; }

                [NameInMap("ArgumentValue")]
                [Validation(Required=false)]
                public string ArgumentValue { get; set; }

            }

            [NameInMap("CodeRepo")]
            [Validation(Required=false)]
            public UpdateArtifactRequestArtifactBuildPropertyCodeRepo CodeRepo { get; set; }
            public class UpdateArtifactRequestArtifactBuildPropertyCodeRepo : TeaModel {
                [NameInMap("Branch")]
                [Validation(Required=false)]
                public string Branch { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

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
        /// <para>This parameter is required.</para>
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
            /// <para>The metadata of the Object Storage Service (OSS) object.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is an OSS object.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;WorkDir\&quot;:\&quot;/root\&quot;,\&quot;CommandType\&quot;:\&quot;RunShellScript\&quot;,\&quot;Platform\&quot;:\&quot;Linux\&quot;,\&quot;Script\&quot;:\&quot;echo hello\&quot;}</para>
            /// </summary>
            [NameInMap("FileScriptMetadata")]
            [Validation(Required=false)]
            public string FileScriptMetadata { get; set; }

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

            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>The script content of the deployment package.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a script.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ScriptMetadata&quot;:&quot;{\&quot;CommandType\&quot;:\&quot;RunShellScript\&quot;,\&quot;Platform\&quot;:\&quot;Linux\&quot;,\&quot;Script\&quot;:\&quot;ls\&quot;}&quot;}</para>
            /// </summary>
            [NameInMap("ScriptMetadata")]
            [Validation(Required=false)]
            public string ScriptMetadata { get; set; }

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
        /// <para>The description of the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IDs of the regions that support the deployment package.</para>
        /// </summary>
        [NameInMap("SupportRegionIds")]
        [Validation(Required=false)]
        public List<string> SupportRegionIds { get; set; }

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
