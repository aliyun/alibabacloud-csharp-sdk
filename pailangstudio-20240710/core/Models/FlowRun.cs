// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class FlowRun : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("ChildRuns")]
        [Validation(Required=false)]
        public List<FlowRunChildRuns> ChildRuns { get; set; }
        public class FlowRunChildRuns : TeaModel {
            /// <summary>
            /// <para>运行时长</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// <para>应用流运行ID</para>
            /// </summary>
            [NameInMap("FlowRunId")]
            [Validation(Required=false)]
            public string FlowRunId { get; set; }

            /// <summary>
            /// <para>应用流来源</para>
            /// </summary>
            [NameInMap("FlowSource")]
            [Validation(Required=false)]
            public FlowRunChildRunsFlowSource FlowSource { get; set; }
            public class FlowRunChildRunsFlowSource : TeaModel {
                /// <summary>
                /// <para>ID</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>类型</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>创建时间</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>结束时间</para>
            /// </summary>
            [NameInMap("GmtFinishTime")]
            [Validation(Required=false)]
            public string GmtFinishTime { get; set; }

            /// <summary>
            /// <para>修改时间</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>开始时间</para>
            /// </summary>
            [NameInMap("GmtStartTime")]
            [Validation(Required=false)]
            public string GmtStartTime { get; set; }

            /// <summary>
            /// <para>任务信息</para>
            /// </summary>
            [NameInMap("JobInfo")]
            [Validation(Required=false)]
            public FlowRunChildRunsJobInfo JobInfo { get; set; }
            public class FlowRunChildRunsJobInfo : TeaModel {
                /// <summary>
                /// <para>任务ID</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

            /// <summary>
            /// <para>运行模式</para>
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public string RunMode { get; set; }

            /// <summary>
            /// <para>运行名称</para>
            /// </summary>
            [NameInMap("RunName")]
            [Validation(Required=false)]
            public string RunName { get; set; }

            /// <summary>
            /// <para>运行结果</para>
            /// </summary>
            [NameInMap("RunResult")]
            [Validation(Required=false)]
            public string RunResult { get; set; }

            /// <summary>
            /// <para>运行状态</para>
            /// </summary>
            [NameInMap("RunStatus")]
            [Validation(Required=false)]
            public string RunStatus { get; set; }

        }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public FlowRunCredentialConfig CredentialConfig { get; set; }
        public class FlowRunCredentialConfig : TeaModel {
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
            public List<FlowRunCredentialConfigCredentialConfigItems> CredentialConfigItems { get; set; }
            public class FlowRunCredentialConfigCredentialConfigItems : TeaModel {
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
                public List<FlowRunCredentialConfigCredentialConfigItemsRoles> Roles { get; set; }
                public class FlowRunCredentialConfigCredentialConfigItemsRoles : TeaModel {
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

        [NameInMap("DataColumnMapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> DataColumnMapping { get; set; }

        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<FlowRunDataSources> DataSources { get; set; }
        public class FlowRunDataSources : TeaModel {
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

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public FlowRunEcsSpec EcsSpec { get; set; }
        public class FlowRunEcsSpec : TeaModel {
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
        public List<FlowRunEnvs> Envs { get; set; }
        public class FlowRunEnvs : TeaModel {
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

        [NameInMap("EvaluationConfigs")]
        [Validation(Required=false)]
        public List<FlowRunEvaluationConfigs> EvaluationConfigs { get; set; }
        public class FlowRunEvaluationConfigs : TeaModel {
            /// <summary>
            /// <para>映射配置</para>
            /// </summary>
            [NameInMap("DataColumnMapping")]
            [Validation(Required=false)]
            public Dictionary<string, string> DataColumnMapping { get; set; }

            /// <summary>
            /// <para>应用流来源</para>
            /// </summary>
            [NameInMap("FlowSource")]
            [Validation(Required=false)]
            public FlowRunEvaluationConfigsFlowSource FlowSource { get; set; }
            public class FlowRunEvaluationConfigsFlowSource : TeaModel {
                /// <summary>
                /// <para>ID</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>名称</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>类型</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>输入配置</para>
            /// </summary>
            [NameInMap("InputsOverrideConfig")]
            [Validation(Required=false)]
            public string InputsOverrideConfig { get; set; }

        }

        [NameInMap("EvaluationWorkerCount")]
        [Validation(Required=false)]
        public int? EvaluationWorkerCount { get; set; }

        [NameInMap("Exception")]
        [Validation(Required=false)]
        public string Exception { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        [NameInMap("FlowRunId")]
        [Validation(Required=false)]
        public string FlowRunId { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("GmtStartTime")]
        [Validation(Required=false)]
        public string GmtStartTime { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<FlowRunLabels> Labels { get; set; }
        public class FlowRunLabels : TeaModel {
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

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("NodeRunInfos")]
        [Validation(Required=false)]
        public List<FlowRunNodeRunInfos> NodeRunInfos { get; set; }
        public class FlowRunNodeRunInfos : TeaModel {
            /// <summary>
            /// <para>耗时</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>错误信息</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>输入</para>
            /// </summary>
            [NameInMap("Inputs")]
            [Validation(Required=false)]
            public string Inputs { get; set; }

            /// <summary>
            /// <para>节点名称</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>输出</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>节点状态</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>日志信息</para>
            /// </summary>
            [NameInMap("Stdout")]
            [Validation(Required=false)]
            public string Stdout { get; set; }

        }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        [NameInMap("RunName")]
        [Validation(Required=false)]
        public string RunName { get; set; }

        [NameInMap("RunResult")]
        [Validation(Required=false)]
        public string RunResult { get; set; }

        [NameInMap("RunStatus")]
        [Validation(Required=false)]
        public string RunStatus { get; set; }

        [NameInMap("RunTimeout")]
        [Validation(Required=false)]
        public int? RunTimeout { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public FlowRunUserVpc UserVpc { get; set; }
        public class FlowRunUserVpc : TeaModel {
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

        [NameInMap("Variant")]
        [Validation(Required=false)]
        public string Variant { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
