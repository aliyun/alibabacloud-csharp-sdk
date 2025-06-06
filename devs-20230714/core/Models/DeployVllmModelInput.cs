// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class DeployVllmModelInput : TeaModel {
        [NameInMap("accountID")]
        [Validation(Required=false)]
        public string AccountID { get; set; }

        [NameInMap("concurrencyConfig")]
        [Validation(Required=false)]
        public DeployVllmModelInputConcurrencyConfig ConcurrencyConfig { get; set; }
        public class DeployVllmModelInputConcurrencyConfig : TeaModel {
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
        public DeployVllmModelInputGpuConfig GpuConfig { get; set; }
        public class DeployVllmModelInputGpuConfig : TeaModel {
            [NameInMap("gpuMemorySize")]
            [Validation(Required=false)]
            public int? GpuMemorySize { get; set; }

            [NameInMap("gpuType")]
            [Validation(Required=false)]
            public string GpuType { get; set; }

        }

        [NameInMap("httpTrigger")]
        [Validation(Required=false)]
        public DeployVllmModelInputHttpTrigger HttpTrigger { get; set; }
        public class DeployVllmModelInputHttpTrigger : TeaModel {
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

            [NameInMap("triggerConfig")]
            [Validation(Required=false)]
            public DeployVllmModelInputHttpTriggerTriggerConfig TriggerConfig { get; set; }
            public class DeployVllmModelInputHttpTriggerTriggerConfig : TeaModel {
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
        public DeployVllmModelInputLogConfig LogConfig { get; set; }
        public class DeployVllmModelInputLogConfig : TeaModel {
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
        public DeployVllmModelInputModelConfig ModelConfig { get; set; }
        public class DeployVllmModelInputModelConfig : TeaModel {
            [NameInMap("fmkVllmConfig")]
            [Validation(Required=false)]
            public DeployVllmModelInputModelConfigFmkVllmConfig FmkVllmConfig { get; set; }
            public class DeployVllmModelInputModelConfigFmkVllmConfig : TeaModel {
                [NameInMap("apiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                [NameInMap("blockSize")]
                [Validation(Required=false)]
                public int? BlockSize { get; set; }

                [NameInMap("chatTemplate")]
                [Validation(Required=false)]
                public string ChatTemplate { get; set; }

                [NameInMap("dtype")]
                [Validation(Required=false)]
                public string Dtype { get; set; }

                [NameInMap("fullTextPostfix")]
                [Validation(Required=false)]
                public string FullTextPostfix { get; set; }

                [NameInMap("gpuMemoryUtilization")]
                [Validation(Required=false)]
                public float? GpuMemoryUtilization { get; set; }

                [NameInMap("loadFormat")]
                [Validation(Required=false)]
                public string LoadFormat { get; set; }

                [NameInMap("maxModelLen")]
                [Validation(Required=false)]
                public int? MaxModelLen { get; set; }

                [NameInMap("maxParallelLoadingWorkers")]
                [Validation(Required=false)]
                public int? MaxParallelLoadingWorkers { get; set; }

                [NameInMap("quantization")]
                [Validation(Required=false)]
                public string Quantization { get; set; }

                [NameInMap("servedModelName")]
                [Validation(Required=false)]
                public string ServedModelName { get; set; }

                [NameInMap("swapSpace")]
                [Validation(Required=false)]
                public int? SwapSpace { get; set; }

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
        public DeployVllmModelInputNasConfig NasConfig { get; set; }
        public class DeployVllmModelInputNasConfig : TeaModel {
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<DeployVllmModelInputNasConfigMountPoints> MountPoints { get; set; }
            public class DeployVllmModelInputNasConfigMountPoints : TeaModel {
                [NameInMap("enableTLS")]
                [Validation(Required=false)]
                public bool? EnableTLS { get; set; }

                [NameInMap("mountDir")]
                [Validation(Required=false)]
                public string MountDir { get; set; }

                [NameInMap("serverAddr")]
                [Validation(Required=false)]
                public string ServerAddr { get; set; }

            }

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
        public DeployVllmModelInputProvisionConfig ProvisionConfig { get; set; }
        public class DeployVllmModelInputProvisionConfig : TeaModel {
            [NameInMap("alwaysAllocateGPU")]
            [Validation(Required=false)]
            public bool? AlwaysAllocateGPU { get; set; }

            [NameInMap("scheduledActions")]
            [Validation(Required=false)]
            public List<DeployVllmModelInputProvisionConfigScheduledActions> ScheduledActions { get; set; }
            public class DeployVllmModelInputProvisionConfigScheduledActions : TeaModel {
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
        public DeployVllmModelInputVpcConfig VpcConfig { get; set; }
        public class DeployVllmModelInputVpcConfig : TeaModel {
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
