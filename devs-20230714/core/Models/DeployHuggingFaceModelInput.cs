// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class DeployHuggingFaceModelInput : TeaModel {
        [NameInMap("accountID")]
        [Validation(Required=false)]
        public string AccountID { get; set; }

        [NameInMap("concurrencyConfig")]
        [Validation(Required=false)]
        public DeployHuggingFaceModelInputConcurrencyConfig ConcurrencyConfig { get; set; }
        public class DeployHuggingFaceModelInputConcurrencyConfig : TeaModel {
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
        public DeployHuggingFaceModelInputGpuConfig GpuConfig { get; set; }
        public class DeployHuggingFaceModelInputGpuConfig : TeaModel {
            [NameInMap("gpuMemorySize")]
            [Validation(Required=false)]
            public int? GpuMemorySize { get; set; }

            [NameInMap("gpuType")]
            [Validation(Required=false)]
            public string GpuType { get; set; }

        }

        [NameInMap("httpTrigger")]
        [Validation(Required=false)]
        public DeployHuggingFaceModelInputHttpTrigger HttpTrigger { get; set; }
        public class DeployHuggingFaceModelInputHttpTrigger : TeaModel {
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

            [NameInMap("triggerConfig")]
            [Validation(Required=false)]
            public DeployHuggingFaceModelInputHttpTriggerTriggerConfig TriggerConfig { get; set; }
            public class DeployHuggingFaceModelInputHttpTriggerTriggerConfig : TeaModel {
                [NameInMap("authType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

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
        public DeployHuggingFaceModelInputLogConfig LogConfig { get; set; }
        public class DeployHuggingFaceModelInputLogConfig : TeaModel {
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
        public DeployHuggingFaceModelInputModelConfig ModelConfig { get; set; }
        public class DeployHuggingFaceModelInputModelConfig : TeaModel {
            [NameInMap("fmkHuggingFaceConfig")]
            [Validation(Required=false)]
            public DeployHuggingFaceModelInputModelConfigFmkHuggingFaceConfig FmkHuggingFaceConfig { get; set; }
            public class DeployHuggingFaceModelInputModelConfigFmkHuggingFaceConfig : TeaModel {
                [NameInMap("framework")]
                [Validation(Required=false)]
                public string Framework { get; set; }

                [NameInMap("task")]
                [Validation(Required=false)]
                public string Task { get; set; }

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

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public DeployHuggingFaceModelInputNasConfig NasConfig { get; set; }
        public class DeployHuggingFaceModelInputNasConfig : TeaModel {
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
        public DeployHuggingFaceModelInputProvisionConfig ProvisionConfig { get; set; }
        public class DeployHuggingFaceModelInputProvisionConfig : TeaModel {
            [NameInMap("alwaysAllocateGPU")]
            [Validation(Required=false)]
            public bool? AlwaysAllocateGPU { get; set; }

            [NameInMap("scheduledActions")]
            [Validation(Required=false)]
            public List<DeployHuggingFaceModelInputProvisionConfigScheduledActions> ScheduledActions { get; set; }
            public class DeployHuggingFaceModelInputProvisionConfigScheduledActions : TeaModel {
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
        public DeployHuggingFaceModelInputVpcConfig VpcConfig { get; set; }
        public class DeployHuggingFaceModelInputVpcConfig : TeaModel {
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
