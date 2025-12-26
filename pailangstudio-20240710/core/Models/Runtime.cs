// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class Runtime : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public RuntimeCredentialConfig CredentialConfig { get; set; }
        public class RuntimeCredentialConfig : TeaModel {
            /// <summary>
            /// <para>AliyunEnvRoleKey</para>
            /// </summary>
            [NameInMap("AliyunEnvRoleKey")]
            [Validation(Required=false)]
            public string AliyunEnvRoleKey { get; set; }

            /// <summary>
            /// <para>Credential配置项列表</para>
            /// </summary>
            [NameInMap("CredentialConfigItems")]
            [Validation(Required=false)]
            public List<RuntimeCredentialConfigCredentialConfigItems> CredentialConfigItems { get; set; }
            public class RuntimeCredentialConfigCredentialConfigItems : TeaModel {
                /// <summary>
                /// <para>Key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>角色列表</para>
                /// </summary>
                [NameInMap("Roles")]
                [Validation(Required=false)]
                public List<RuntimeCredentialConfigCredentialConfigItemsRoles> Roles { get; set; }
                public class RuntimeCredentialConfigCredentialConfigItemsRoles : TeaModel {
                    /// <summary>
                    /// <para>AssumeRoleFor</para>
                    /// </summary>
                    [NameInMap("AssumeRoleFor")]
                    [Validation(Required=false)]
                    public string AssumeRoleFor { get; set; }

                    /// <summary>
                    /// <para>角色名称</para>
                    /// </summary>
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

                    /// <summary>
                    /// <para>角色类型</para>
                    /// </summary>
                    [NameInMap("RoleType")]
                    [Validation(Required=false)]
                    public string RoleType { get; set; }

                }

                /// <summary>
                /// <para>Type</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>是否启用Credential注入</para>
            /// </summary>
            [NameInMap("EnableCredentialInject")]
            [Validation(Required=false)]
            public bool? EnableCredentialInject { get; set; }

        }

        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<RuntimeDataSources> DataSources { get; set; }
        public class RuntimeDataSources : TeaModel {
            /// <summary>
            /// <para>数据集ID</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>挂载路径</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>统一资源识别码</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public RuntimeEcsSpec EcsSpec { get; set; }
        public class RuntimeEcsSpec : TeaModel {
            /// <summary>
            /// <para>CPU信息</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            /// <summary>
            /// <para>额外系统盘</para>
            /// </summary>
            [NameInMap("ExtraEphemeralStorage")]
            [Validation(Required=false)]
            public int? ExtraEphemeralStorage { get; set; }

            /// <summary>
            /// <para>GPU信息</para>
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public int? GPU { get; set; }

            /// <summary>
            /// <para>GPU算力占比</para>
            /// </summary>
            [NameInMap("GPUCorePercentage")]
            [Validation(Required=false)]
            public int? GPUCorePercentage { get; set; }

            /// <summary>
            /// <para>GPU显存</para>
            /// </summary>
            [NameInMap("GPUMemory")]
            [Validation(Required=false)]
            public int? GPUMemory { get; set; }

            /// <summary>
            /// <para>GPU类型</para>
            /// </summary>
            [NameInMap("GPUType")]
            [Validation(Required=false)]
            public string GPUType { get; set; }

            /// <summary>
            /// <para>实例类型</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>内存信息</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>Pod数量</para>
            /// </summary>
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public int? PodCount { get; set; }

            /// <summary>
            /// <para>资源配额ID</para>
            /// </summary>
            [NameInMap("QuotaId")]
            [Validation(Required=false)]
            public string QuotaId { get; set; }

            /// <summary>
            /// <para>资源配额类型</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>共享内存</para>
            /// </summary>
            [NameInMap("SharedMemory")]
            [Validation(Required=false)]
            public int? SharedMemory { get; set; }

        }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<RuntimeEnvs> Envs { get; set; }
        public class RuntimeEnvs : TeaModel {
            /// <summary>
            /// <para>环境键</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>环境值</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("Flows")]
        [Validation(Required=false)]
        public List<RuntimeFlows> Flows { get; set; }
        public class RuntimeFlows : TeaModel {
            /// <summary>
            /// <para>应用流ID</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <para>应用流名称</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

        }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<RuntimeLabels> Labels { get; set; }
        public class RuntimeLabels : TeaModel {
            /// <summary>
            /// <para>标签键</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>标签值</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        [NameInMap("MCPConfig")]
        [Validation(Required=false)]
        public string MCPConfig { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("RunTimeout")]
        [Validation(Required=false)]
        public int? RunTimeout { get; set; }

        [NameInMap("RuntimeId")]
        [Validation(Required=false)]
        public string RuntimeId { get; set; }

        [NameInMap("RuntimeLog")]
        [Validation(Required=false)]
        public string RuntimeLog { get; set; }

        [NameInMap("RuntimeName")]
        [Validation(Required=false)]
        public string RuntimeName { get; set; }

        [NameInMap("RuntimeStatus")]
        [Validation(Required=false)]
        public string RuntimeStatus { get; set; }

        [NameInMap("RuntimeType")]
        [Validation(Required=false)]
        public string RuntimeType { get; set; }

        [NameInMap("SupportSSEStream")]
        [Validation(Required=false)]
        public bool? SupportSSEStream { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public RuntimeUserVpc UserVpc { get; set; }
        public class RuntimeUserVpc : TeaModel {
            /// <summary>
            /// <para>默认路由</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            /// <summary>
            /// <para>扩展网段</para>
            /// </summary>
            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            /// <summary>
            /// <para>安全组ID</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>交换机ID</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("WorkDir")]
        [Validation(Required=false)]
        public string WorkDir { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
