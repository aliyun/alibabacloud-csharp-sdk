// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateImageBuildRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>镜像构建的可见性，可能值： - PUBLIC：当前工作空间所有成员都可以操作。 - PRIVATE：只有创建者可以操作。</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>构建配置，指定待构建的 Dockerfile 文件内容。</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BuildConfig")]
        [Validation(Required=false)]
        public CreateImageBuildRequestBuildConfig BuildConfig { get; set; }
        public class CreateImageBuildRequestBuildConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PackageInstallation</para>
            /// </summary>
            [NameInMap("BuildType")]
            [Validation(Required=false)]
            public string BuildType { get; set; }

            /// <summary>
            /// <para>Dockerfile文件内容</para>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public CreateImageBuildRequestImage Image { get; set; }
        public class CreateImageBuildRequestImage : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateImageBuildRequestImageLabels> Labels { get; set; }
            public class CreateImageBuildRequestImageLabels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-v1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>build-my-image</para>
        /// </summary>
        [NameInMap("ImageBuildJobName")]
        [Validation(Required=false)]
        public string ImageBuildJobName { get; set; }

        /// <summary>
        /// <para>是否覆盖更新 ACR 镜像仓库中已存在的镜像 tag。</para>
        /// </summary>
        [NameInMap("OverwriteImageTag")]
        [Validation(Required=false)]
        public bool? OverwriteImageTag { get; set; }

        /// <summary>
        /// <para>代表region的资源属性字段</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>构建任务运行资源</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public CreateImageBuildRequestResource Resource { get; set; }
        public class CreateImageBuildRequestResource : TeaModel {
            /// <summary>
            /// <para>后付费资源规格</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c6.large</para>
            /// </summary>
            [NameInMap("EcsSpec")]
            [Validation(Required=false)]
            public string EcsSpec { get; set; }

            [NameInMap("ResourceConfig")]
            [Validation(Required=false)]
            public CreateImageBuildRequestResourceResourceConfig ResourceConfig { get; set; }
            public class CreateImageBuildRequestResourceResourceConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8Gi</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>quotaadzoqup693z</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Lingjun</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TargetRegistry")]
        [Validation(Required=false)]
        public CreateImageBuildRequestTargetRegistry TargetRegistry { get; set; }
        public class CreateImageBuildRequestTargetRegistry : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cri-**abcd</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
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
        /// <para>用户专有网络信息。使用企业版 ACR 实例时，此参数必填，指定在用户 ACR 实例的访问控制里已添加的专有网络。</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateImageBuildRequestUserVpc UserVpc { get; set; }
        public class CreateImageBuildRequestUserVpc : TeaModel {
            /// <summary>
            /// <para>默认路由网卡出口</para>
            /// 
            /// <b>Example:</b>
            /// <para>eth1</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            /// <summary>
            /// <para>扩展网段</para>
            /// </summary>
            [NameInMap("ExtendedCidrs")]
            [Validation(Required=false)]
            public List<string> ExtendedCidrs { get; set; }

            /// <summary>
            /// <para>安全组 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-abcdef**</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>交换机 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vs-abcdef**</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>专有网络 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-abcdef**</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>镜像构建所属的工作空间ID。</para>
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
