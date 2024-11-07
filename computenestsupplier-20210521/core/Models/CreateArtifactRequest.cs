// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateArtifactRequest : TeaModel {
        /// <summary>
        /// <para>The build properties of the artifact, utilized for hosting and building the deployment package.</para>
        /// </summary>
        [NameInMap("ArtifactBuildProperty")]
        [Validation(Required=false)]
        public CreateArtifactRequestArtifactBuildProperty ArtifactBuildProperty { get; set; }
        public class CreateArtifactRequestArtifactBuildProperty : TeaModel {
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
        public CreateArtifactRequestArtifactProperty ArtifactProperty { get; set; }
        public class CreateArtifactRequestArtifactProperty : TeaModel {
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
            /// <para>The script metadata.</para>
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
            /// <para>m-0xij191j9cuev6xxxxxx</para>
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
            /// <para>The ID of the image repository.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a container image or of the Helm chart type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>crr-d8o1nponyc2t1gcg</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// <remarks>
            /// <para> This parameter is available only if the deployment package is a container image or of the Helm chart type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>wordpress</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>The script content.</para>
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
            /// <para>The object URL of the deployment package.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1309208528xxxxxx/template/2e1ce8fc-xxxx-481c-9e8e-789ba9db487d.json">https://service-info-private.oss-cn-hangzhou.aliyuncs.com/1309208528xxxxxx/template/2e1ce8fc-xxxx-481c-9e8e-789ba9db487d.json</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

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
