// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class Deployment : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("AutoApproval")]
        [Validation(Required=false)]
        public bool? AutoApproval { get; set; }

        [NameInMap("ChatHistoryConfig")]
        [Validation(Required=false)]
        public DeploymentChatHistoryConfig ChatHistoryConfig { get; set; }
        public class DeploymentChatHistoryConfig : TeaModel {
            /// <summary>
            /// <para>连接名称</para>
            /// </summary>
            [NameInMap("ConnectionName")]
            [Validation(Required=false)]
            public string ConnectionName { get; set; }

            /// <summary>
            /// <para>存储类型</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        [NameInMap("ContentModerationConfig")]
        [Validation(Required=false)]
        public DeploymentContentModerationConfig ContentModerationConfig { get; set; }
        public class DeploymentContentModerationConfig : TeaModel {
            /// <summary>
            /// <para>启用输入内容审查</para>
            /// </summary>
            [NameInMap("EnableInputModeration")]
            [Validation(Required=false)]
            public bool? EnableInputModeration { get; set; }

            /// <summary>
            /// <para>启用输出内容审查</para>
            /// </summary>
            [NameInMap("EnableOutputModeration")]
            [Validation(Required=false)]
            public bool? EnableOutputModeration { get; set; }

            /// <summary>
            /// <para>流式输出内容送审缓存大小</para>
            /// </summary>
            [NameInMap("StreamingModerationThreshold")]
            [Validation(Required=false)]
            public int? StreamingModerationThreshold { get; set; }

        }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public DeploymentCredentialConfig CredentialConfig { get; set; }
        public class DeploymentCredentialConfig : TeaModel {
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
            public List<DeploymentCredentialConfigCredentialConfigItems> CredentialConfigItems { get; set; }
            public class DeploymentCredentialConfigCredentialConfigItems : TeaModel {
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
                public List<DeploymentCredentialConfigCredentialConfigItemsRoles> Roles { get; set; }
                public class DeploymentCredentialConfigCredentialConfigItemsRoles : TeaModel {
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
        public List<DeploymentDataSources> DataSources { get; set; }
        public class DeploymentDataSources : TeaModel {
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

        [NameInMap("DeploymentConfig")]
        [Validation(Required=false)]
        public string DeploymentConfig { get; set; }

        [NameInMap("DeploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("DeploymentStages")]
        [Validation(Required=false)]
        public List<DeploymentDeploymentStages> DeploymentStages { get; set; }
        public class DeploymentDeploymentStages : TeaModel {
            /// <summary>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>结束时间</para>
            /// </summary>
            [NameInMap("GmtEndTime")]
            [Validation(Required=false)]
            public string GmtEndTime { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// </summary>
            [NameInMap("GmtStartTime")]
            [Validation(Required=false)]
            public string GmtStartTime { get; set; }

            /// <summary>
            /// <para>阶段</para>
            /// </summary>
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public int? Stage { get; set; }

            /// <summary>
            /// <para>阶段信息</para>
            /// </summary>
            [NameInMap("StageInfo")]
            [Validation(Required=false)]
            public string StageInfo { get; set; }

            /// <summary>
            /// <para>阶段名称</para>
            /// </summary>
            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }

            /// <summary>
            /// <para>阶段状态</para>
            /// </summary>
            [NameInMap("StageStatus")]
            [Validation(Required=false)]
            public string StageStatus { get; set; }

        }

        [NameInMap("DeploymentStatus")]
        [Validation(Required=false)]
        public string DeploymentStatus { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public DeploymentEcsSpec EcsSpec { get; set; }
        public class DeploymentEcsSpec : TeaModel {
            /// <summary>
            /// <para>CPU信息</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public int? CPU { get; set; }

            /// <summary>
            /// <para>竞价资源配置</para>
            /// </summary>
            [NameInMap("ComputingInstanceConfig")]
            [Validation(Required=false)]
            public DeploymentEcsSpecComputingInstanceConfig ComputingInstanceConfig { get; set; }
            public class DeploymentEcsSpecComputingInstanceConfig : TeaModel {
                /// <summary>
                /// <para>机器资源配置</para>
                /// </summary>
                [NameInMap("ComputingInstances")]
                [Validation(Required=false)]
                public List<DeploymentEcsSpecComputingInstanceConfigComputingInstances> ComputingInstances { get; set; }
                public class DeploymentEcsSpecComputingInstanceConfigComputingInstances : TeaModel {
                    /// <summary>
                    /// <para>竞价出价</para>
                    /// </summary>
                    [NameInMap("SpotPriceLimit")]
                    [Validation(Required=false)]
                    public float? SpotPriceLimit { get; set; }

                    /// <summary>
                    /// <para>机型</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>是否启用竞价保留时长</para>
                /// </summary>
                [NameInMap("DisableSpotProtectionPeriod")]
                [Validation(Required=false)]
                public bool? DisableSpotProtectionPeriod { get; set; }

            }

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
            /// <para>是否启用弹性资源池</para>
            /// </summary>
            [NameInMap("ResourceBurstable")]
            [Validation(Required=false)]
            public bool? ResourceBurstable { get; set; }

            /// <summary>
            /// <para>资源组ID</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>共享内存</para>
            /// </summary>
            [NameInMap("SharedMemory")]
            [Validation(Required=false)]
            public int? SharedMemory { get; set; }

        }

        [NameInMap("EnableTrace")]
        [Validation(Required=false)]
        public bool? EnableTrace { get; set; }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<DeploymentEnvs> Envs { get; set; }
        public class DeploymentEnvs : TeaModel {
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

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<DeploymentLabels> Labels { get; set; }
        public class DeploymentLabels : TeaModel {
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

        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceSnapshotId")]
        [Validation(Required=false)]
        public string ResourceSnapshotId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("ServiceGroup")]
        [Validation(Required=false)]
        public string ServiceGroup { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public DeploymentUserVpc UserVpc { get; set; }
        public class DeploymentUserVpc : TeaModel {
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

        [NameInMap("WorkDir")]
        [Validation(Required=false)]
        public string WorkDir { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
