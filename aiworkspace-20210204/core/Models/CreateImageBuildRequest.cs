// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateImageBuildRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLIC</b>: Public.</description></item>
        /// <item><description><b>PRIVATE</b>: Private.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para><b>The build configuration, which specifies the content of the Dockerfile to be built.</b></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BuildConfig")]
        [Validation(Required=false)]
        public CreateImageBuildRequestBuildConfig BuildConfig { get; set; }
        public class CreateImageBuildRequestBuildConfig : TeaModel {
            /// <summary>
            /// <para>The build type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PackageInstallation</b>: Installs software packages based on a specified image.</description></item>
            /// <item><description><b>CustomDockerfile</b>: Uses a custom Dockerfile.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PackageInstallation</para>
            /// </summary>
            [NameInMap("BuildType")]
            [Validation(Required=false)]
            public string BuildType { get; set; }

            /// <summary>
            /// <para>The list of data sources.</para>
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<CreateImageBuildRequestBuildConfigDataSources> DataSources { get; set; }
            public class CreateImageBuildRequestBuildConfigDataSources : TeaModel {
                /// <summary>
                /// <para>The ID of the dataset in the workspace. Example: d-************zbs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-************zbs</para>
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public string DataSourceId { get; set; }

                /// <summary>
                /// <para>The dataset version. If you specify this parameter, you must also specify DataSourceId. Example: v1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("DataSourceVersion")]
                [Validation(Required=false)]
                public string DataSourceVersion { get; set; }

                /// <summary>
                /// <para>The read and write permissions. Valid values: RW (default) and RO.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RO</para>
                /// </summary>
                [NameInMap("MountAccess")]
                [Validation(Required=false)]
                public string MountAccess { get; set; }

                /// <summary>
                /// <para>The mount path. Example: /mnt/data/.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/data/</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The mount property for the custom dataset. Only OSS is supported. Example: {&quot;fs.oss.download.thread.concurrency&quot;:&quot;10&quot;}.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;fs.oss.download.thread.concurrency&quot;:&quot;10&quot;}</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// <para>The storage path, including the endpoint. This parameter is mutually exclusive with DataSourceId. Example: OSS storage path oss://{bucket-name}.oss-{region}-internal.aliyuncs.com/{subPath}/.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://{bucket-name}.oss-{region}-internal.aliyuncs.com/{subPath}/</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>The content of the Dockerfile to be built.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FROM ubuntu:18:04
            /// RUN pip3 install numpy==1.19.5</para>
            /// </summary>
            [NameInMap("Dockerfile")]
            [Validation(Required=false)]
            public string Dockerfile { get; set; }

            /// <summary>
            /// <para>The Dockerfile path, which is a relative path to the mounted context path. Example: docker/Dockerfile. If the mount path is /mnt/data/, the file is located at /mnt/data/docker/Dockerfile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docker/Dockerfile</para>
            /// </summary>
            [NameInMap("DockerfilePath")]
            [Validation(Required=false)]
            public string DockerfilePath { get; set; }

            /// <summary>
            /// <para>The authentication information for private image repositories. You can specify the authentication information for an ACR image repository that does not belong to the current user. Format: {&quot;user_registry_domain&quot;:{&quot;Auth&quot;:&quot;base64 encoded auth&quot;}}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;user-test-registry-vpc.cn-wulanchabu.cr.aliyuncs.com&quot;: {
            ///     &quot;Auth&quot;: &quot;dXNlcjp0ZXN0&quot;
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("RegistryAuths")]
            [Validation(Required=false)]
            public Dictionary<string, object> RegistryAuths { get; set; }

        }

        /// <summary>
        /// <para>The image metadata.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public CreateImageBuildRequestImage Image { get; set; }
        public class CreateImageBuildRequestImage : TeaModel {
            /// <summary>
            /// <para>The image description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Build test image</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The image labels.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateImageBuildRequestImageLabels> Labels { get; set; }
            public class CreateImageBuildRequestImageLabels : TeaModel {
                /// <summary>
                /// <para>The key of the image label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the image label.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The image name. The naming rules are as follows:</para>
            /// <list type="bullet">
            /// <item><description>The name must be 1 to 50 characters in length.</description></item>
            /// <item><description>The name can contain lowercase letters, digits, and hyphens (-), and must start with a letter.</description></item>
            /// <item><description>The name must be unique within the same workspace.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-v1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The image URI.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-test-registry-vpc.cn-wulanchabu.cr.aliyuncs.com/pai-test/pai-test:test-v1</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <para>The name of the image build task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>build-my-image</para>
        /// </summary>
        [NameInMap("ImageBuildJobName")]
        [Validation(Required=false)]
        public string ImageBuildJobName { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the existing image version in the image repository.</para>
        /// </summary>
        [NameInMap("OverwriteImageTag")]
        [Validation(Required=false)]
        public bool? OverwriteImageTag { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resources used to run the task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public CreateImageBuildRequestResource Resource { get; set; }
        public class CreateImageBuildRequestResource : TeaModel {
            /// <summary>
            /// <para>The pay-as-you-go resource specifications. This parameter is required when you use a public resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c6.large</para>
            /// </summary>
            [NameInMap("EcsSpec")]
            [Validation(Required=false)]
            public string EcsSpec { get; set; }

            /// <summary>
            /// <para>The resource configuration. This parameter is required when you use subscription resources and must be left empty when you use a public resource group.</para>
            /// </summary>
            [NameInMap("ResourceConfig")]
            [Validation(Required=false)]
            public CreateImageBuildRequestResourceResourceConfig ResourceConfig { get; set; }
            public class CreateImageBuildRequestResourceResourceConfig : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }

                /// <summary>
                /// <para>The memory capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8Gi</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

            }

            /// <summary>
            /// <para>The resource quota ID. This parameter applies only to subscription resources and must not be specified when you use pay-as-you-go resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quotaadzoqup693z</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The subscription resource type. Only Lingjun resources are supported. This parameter is required when you use subscription resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Lingjun</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para><b>The target registry configuration.</b></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TargetRegistry")]
        [Validation(Required=false)]
        public CreateImageBuildRequestTargetRegistry TargetRegistry { get; set; }
        public class CreateImageBuildRequestTargetRegistry : TeaModel {
            /// <summary>
            /// <para>The registry instance ID. This parameter is required when you use Container Registry (ACR) as the image service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-**abcd</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The registry type. Only Container Registry Enterprise Edition is supported as the target registry.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AcrEnterprise</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The user VPC information. This parameter is required when you use a public resource group.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateImageBuildRequestUserVpc UserVpc { get; set; }
        public class CreateImageBuildRequestUserVpc : TeaModel {
            /// <summary>
            /// <para>The default routing of the network interface controller (NIC). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>eth1: Uses the user\&quot;s elastic network interfaces (ENIs) to access external networks through a private NAT gateway. For the configuration method, refer to <a href="https://www.alibabacloud.com/help/en/pai/user-guide/configure-a-dsw-instance-to-access-the-internet-through-a-private-nat-gateway">Configure a DSW instance to access the Internet through a private NAT gateway</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eth1</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            /// <summary>
            /// <para>The extended CIDR blocks.</para>
            /// <list type="bullet">
            /// <item><description>If the vSwitch ID is empty, this parameter is optional and the system automatically retrieves all CIDR blocks under the VPC.</description></item>
            /// <item><description>If the vSwitch ID is not empty, this parameter is required. We recommend that you specify all CIDR blocks under the VPC.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExtendedCidrs")]
            [Validation(Required=false)]
            public List<string> ExtendedCidrs { get; set; }

            /// <summary>
            /// <para>The security group ID. This parameter is required when you specify the VPC configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-abcdef**</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vs-abcdef**</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID. When the build task accesses a user\&quot;s Container Registry Enterprise Edition instance, you must specify a VPC that is added to the access control list of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-abcdef**</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
