// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class DeployOllamaModelInput : TeaModel {
        [NameInMap("accountID")]
        [Validation(Required=false)]
        public string AccountID { get; set; }

        [NameInMap("concurrencyConfig")]
        [Validation(Required=false)]
        public DeployOllamaModelInputConcurrencyConfig ConcurrencyConfig { get; set; }
        public class DeployOllamaModelInputConcurrencyConfig : TeaModel {
            [NameInMap("reservedConcurrency")]
            [Validation(Required=false)]
            public int? ReservedConcurrency { get; set; }

        }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("diskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        [NameInMap("envName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, object> EnvironmentVariables { get; set; }

        [NameInMap("gpuConfig")]
        [Validation(Required=false)]
        public DeployOllamaModelInputGpuConfig GpuConfig { get; set; }
        public class DeployOllamaModelInputGpuConfig : TeaModel {
            [NameInMap("gpuMemorySize")]
            [Validation(Required=false)]
            public int? GpuMemorySize { get; set; }

            [NameInMap("gpuType")]
            [Validation(Required=false)]
            public string GpuType { get; set; }

        }

        [NameInMap("httpTrigger")]
        [Validation(Required=false)]
        public DeployOllamaModelInputHttpTrigger HttpTrigger { get; set; }
        public class DeployOllamaModelInputHttpTrigger : TeaModel {
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

            [NameInMap("triggerConfig")]
            [Validation(Required=false)]
            public DeployOllamaModelInputHttpTriggerTriggerConfig TriggerConfig { get; set; }
            public class DeployOllamaModelInputHttpTriggerTriggerConfig : TeaModel {
                [NameInMap("authType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                [NameInMap("disableURLInternet")]
                [Validation(Required=false)]
                public bool? DisableURLInternet { get; set; }

                [NameInMap("dsableURLInternet")]
                [Validation(Required=false)]
                public bool? DsableURLInternet { get; set; }

                [NameInMap("methods")]
                [Validation(Required=false)]
                public List<string> Methods { get; set; }

            }

        }

        [NameInMap("imageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("instanceConcurrency")]
        [Validation(Required=false)]
        public int? InstanceConcurrency { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public DeployOllamaModelInputLogConfig LogConfig { get; set; }
        public class DeployOllamaModelInputLogConfig : TeaModel {
            [NameInMap("enableInstanceMetrics")]
            [Validation(Required=false)]
            public bool? EnableInstanceMetrics { get; set; }

            [NameInMap("enableRequestMetrics")]
            [Validation(Required=false)]
            public bool? EnableRequestMetrics { get; set; }

            [NameInMap("logBeginRule")]
            [Validation(Required=false)]
            public string LogBeginRule { get; set; }

            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

        }

        [NameInMap("memorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("modelConfig")]
        [Validation(Required=false)]
        public DeployOllamaModelInputModelConfig ModelConfig { get; set; }
        public class DeployOllamaModelInputModelConfig : TeaModel {
            [NameInMap("fmkOllamaConfig")]
            [Validation(Required=false)]
            public DeployOllamaModelInputModelConfigFmkOllamaConfig FmkOllamaConfig { get; set; }
            public class DeployOllamaModelInputModelConfigFmkOllamaConfig : TeaModel {
                [NameInMap("minP")]
                [Validation(Required=false)]
                public float? MinP { get; set; }

                [NameInMap("mirostat")]
                [Validation(Required=false)]
                public int? Mirostat { get; set; }

                [NameInMap("mirostatEta")]
                [Validation(Required=false)]
                public float? MirostatEta { get; set; }

                [NameInMap("mirostatTau")]
                [Validation(Required=false)]
                public float? MirostatTau { get; set; }

                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("modelfileAdapter")]
                [Validation(Required=false)]
                public string ModelfileAdapter { get; set; }

                [NameInMap("modelfileAdditionalFromsString")]
                [Validation(Required=false)]
                public string ModelfileAdditionalFromsString { get; set; }

                [NameInMap("modelfileFullTextPostfix")]
                [Validation(Required=false)]
                public string ModelfileFullTextPostfix { get; set; }

                [NameInMap("modelfileParams")]
                [Validation(Required=false)]
                public string ModelfileParams { get; set; }

                [NameInMap("modelfileSystem")]
                [Validation(Required=false)]
                public string ModelfileSystem { get; set; }

                [NameInMap("modelfileTemplate")]
                [Validation(Required=false)]
                public string ModelfileTemplate { get; set; }

                [NameInMap("numCtx")]
                [Validation(Required=false)]
                public int? NumCtx { get; set; }

                [NameInMap("numPredict")]
                [Validation(Required=false)]
                public int? NumPredict { get; set; }

                [NameInMap("quantize")]
                [Validation(Required=false)]
                public string Quantize { get; set; }

                [NameInMap("repeatLastN")]
                [Validation(Required=false)]
                public int? RepeatLastN { get; set; }

                [NameInMap("repeatPenalty")]
                [Validation(Required=false)]
                public float? RepeatPenalty { get; set; }

                [NameInMap("seed")]
                [Validation(Required=false)]
                public int? Seed { get; set; }

                [NameInMap("singleModelFile")]
                [Validation(Required=false)]
                public string SingleModelFile { get; set; }

                [NameInMap("splitedModelStartFile")]
                [Validation(Required=false)]
                public string SplitedModelStartFile { get; set; }

                [NameInMap("stop")]
                [Validation(Required=false)]
                public string Stop { get; set; }

                [NameInMap("stream")]
                [Validation(Required=false)]
                public bool? Stream { get; set; }

                [NameInMap("temperature")]
                [Validation(Required=false)]
                public float? Temperature { get; set; }

                [NameInMap("tfsZ")]
                [Validation(Required=false)]
                public float? TfsZ { get; set; }

                [NameInMap("topK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

                [NameInMap("topP")]
                [Validation(Required=false)]
                public float? TopP { get; set; }

            }

            [NameInMap("framework")]
            [Validation(Required=false)]
            public string Framework { get; set; }

            /// <summary>
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("multiModelConfig")]
            [Validation(Required=false)]
            public List<ModelConfig> MultiModelConfig { get; set; }

            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("srcModelScopeModelID")]
            [Validation(Required=false)]
            public string SrcModelScopeModelID { get; set; }

            [NameInMap("srcModelScopeModelRevision")]
            [Validation(Required=false)]
            public string SrcModelScopeModelRevision { get; set; }

            [NameInMap("srcModelScopeToken")]
            [Validation(Required=false)]
            public string SrcModelScopeToken { get; set; }

            [NameInMap("srcOssBucket")]
            [Validation(Required=false)]
            public string SrcOssBucket { get; set; }

            [NameInMap("srcOssPath")]
            [Validation(Required=false)]
            public string SrcOssPath { get; set; }

            [NameInMap("srcOssRegion")]
            [Validation(Required=false)]
            public string SrcOssRegion { get; set; }

            [NameInMap("syncStrategy")]
            [Validation(Required=false)]
            public string SyncStrategy { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public DeployOllamaModelInputNasConfig NasConfig { get; set; }
        public class DeployOllamaModelInputNasConfig : TeaModel {
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<string> MountPoints { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public int? UserId { get; set; }

        }

        [NameInMap("originalName")]
        [Validation(Required=false)]
        public string OriginalName { get; set; }

        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("provisionConfig")]
        [Validation(Required=false)]
        public DeployOllamaModelInputProvisionConfig ProvisionConfig { get; set; }
        public class DeployOllamaModelInputProvisionConfig : TeaModel {
            [NameInMap("alwaysAllocateGPU")]
            [Validation(Required=false)]
            public bool? AlwaysAllocateGPU { get; set; }

            [NameInMap("scheduledActions")]
            [Validation(Required=false)]
            public List<DeployOllamaModelInputProvisionConfigScheduledActions> ScheduledActions { get; set; }
            public class DeployOllamaModelInputProvisionConfigScheduledActions : TeaModel {
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("scheduleExpression")]
                [Validation(Required=false)]
                public string ScheduleExpression { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("target")]
                [Validation(Required=false)]
                public int? Target { get; set; }

                [NameInMap("timeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            [NameInMap("target")]
            [Validation(Required=false)]
            public int? Target { get; set; }

        }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("reportStatusURL")]
        [Validation(Required=false)]
        public string ReportStatusURL { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

        [NameInMap("vpcConfig")]
        [Validation(Required=false)]
        public DeployOllamaModelInputVpcConfig VpcConfig { get; set; }
        public class DeployOllamaModelInputVpcConfig : TeaModel {
            [NameInMap("securityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("vSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
