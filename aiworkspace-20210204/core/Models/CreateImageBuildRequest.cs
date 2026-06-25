// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateImageBuildRequest : TeaModel {
        /// <summary>
        /// <para>An idempotence token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The visibility of the image.</para>
        /// <list type="bullet">
        /// <item><description><para><b>PUBLIC</b>: The image is public.</para>
        /// </description></item>
        /// <item><description><para><b>PRIVATE</b>: The image is private.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para><b>The build configuration. Specify the content of the Dockerfile to be built.</b></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BuildConfig")]
        [Validation(Required=false)]
        public CreateImageBuildRequestBuildConfig BuildConfig { get; set; }
        public class CreateImageBuildRequestBuildConfig : TeaModel {
            /// <summary>
            /// <para>The build type. The following types are supported:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PackageInstallation</b>: Installs software packages based on a specified image.</para>
            /// </description></item>
            /// <item><description><para><b>CustomDockerfile</b>: Builds an image based on a custom Dockerfile.</para>
            /// </description></item>
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
            /// <para>The content of the Dockerfile to be built.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FROM ubuntu:18:04
            /// RUN pip3 install numpy==1.19.5</para>
            /// </summary>
            [NameInMap("Dockerfile")]
            [Validation(Required=false)]
            public string Dockerfile { get; set; }

            /// <summary>
            /// <para>The authentication information for the private image repository. You can specify the authentication information for an ACR image repository that does not belong to you. The format is \<c>{&quot;user_registry_domain&quot;:{&quot;Auth&quot;:&quot;base64 encoded auth&quot;}}\\</c>.</para>
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
        /// <para>The metadata of the image.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public CreateImageBuildRequestImage Image { get; set; }
        public class CreateImageBuildRequestImage : TeaModel {
            /// <summary>
            /// <para>The description of the image.</para>
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
            /// <para>The name of the image. The name must meet the following requirements:</para>
            /// <list type="bullet">
            /// <item><description><para>The name must be 1 to 50 characters in length.</para>
            /// </description></item>
            /// <item><description><para>The name can contain lowercase letters, digits, and hyphens (-). It must start with a letter.</para>
            /// </description></item>
            /// <item><description><para>The name must be unique within the same workspace.</para>
            /// </description></item>
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
            /// <para>The image URL.</para>
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
        /// <para>Specifies whether to overwrite an existing image version in the image repository.</para>
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
            /// <para>The instance type of the pay-as-you-go resource. This parameter is required when you use the public resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c6.large</para>
            /// </summary>
            [NameInMap("EcsSpec")]
            [Validation(Required=false)]
            public string EcsSpec { get; set; }

            /// <summary>
            /// <para>The resource configuration. Specify this parameter when you use subscription resources. Leave it empty when you use the public resource group.</para>
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
                /// <para>The memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8Gi</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

            }

            /// <summary>
            /// <para>The resource quota ID. This parameter applies only to subscription resources. Do not set this parameter for pay-as-you-go resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quotaadzoqup693z</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the subscription resource. Currently, only Lingjun resources are supported. Specify this parameter when you use subscription resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Lingjun</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para><b>The configuration of the target image repository.</b></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TargetRegistry")]
        [Validation(Required=false)]
        public CreateImageBuildRequestTargetRegistry TargetRegistry { get; set; }
        public class CreateImageBuildRequestTargetRegistry : TeaModel {
            /// <summary>
            /// <para>The ID of the image repository instance. This parameter is required when you use ACR as the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-**abcd</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of the target image repository. Only ACR Enterprise Edition is supported.</para>
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
        /// <para>The information about the user\&quot;s virtual private cloud (VPC). This parameter is required when you use the public resource group.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateImageBuildRequestUserVpc UserVpc { get; set; }
        public class CreateImageBuildRequestUserVpc : TeaModel {
            /// <summary>
            /// <para>The default route.</para>
            /// <list type="bullet">
            /// <item><description>eth1: Indicates that the user\&quot;s elastic network interface (ENI) is used to access the external network through a private gateway. For more information, see <a href="https://help.aliyun.com/zh/pai/user-guide/configure-a-dsw-instance-to-access-the-internet-through-a-private-nat-gateway?spm=a2c4g.11186623.0.0.3b3965f6SZWm85">Configure a Distribution Switch (DSW) instance to access the Internet through a private NAT gateway</a>.</description></item>
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
            /// <item><description><para>If you do not specify a vSwitch ID, you can leave this parameter empty. The system automatically obtains all CIDR blocks of the VPC.</para>
            /// </description></item>
            /// <item><description><para>If you specify a vSwitch ID, you must specify this parameter. For best results, include all CIDR blocks of the VPC.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExtendedCidrs")]
            [Validation(Required=false)]
            public List<string> ExtendedCidrs { get; set; }

            /// <summary>
            /// <para>The security group ID. This parameter is required when you configure a VPC.</para>
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
            /// <para>The VPC ID. If the build task needs to access your ACR Enterprise Edition instance, specify a VPC that is in the access control list of the instance.</para>
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
