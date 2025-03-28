// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class DeployCustomContainerInput : TeaModel {
        [NameInMap("accountID")]
        [Validation(Required=false)]
        public string AccountID { get; set; }

        [NameInMap("concurrencyConfig")]
        [Validation(Required=false)]
        public DeployCustomContainerInputConcurrencyConfig ConcurrencyConfig { get; set; }
        public class DeployCustomContainerInputConcurrencyConfig : TeaModel {
            [NameInMap("reservedConcurrency")]
            [Validation(Required=false)]
            public int? ReservedConcurrency { get; set; }

        }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        [NameInMap("customContainerConfig")]
        [Validation(Required=false)]
        public DeployCustomContainerInputCustomContainerConfig CustomContainerConfig { get; set; }
        public class DeployCustomContainerInputCustomContainerConfig : TeaModel {
            [NameInMap("command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            [NameInMap("entrypoint")]
            [Validation(Required=false)]
            public List<string> Entrypoint { get; set; }

            [NameInMap("healthCheckConfig")]
            [Validation(Required=false)]
            public DeployCustomContainerInputCustomContainerConfigHealthCheckConfig HealthCheckConfig { get; set; }
            public class DeployCustomContainerInputCustomContainerConfigHealthCheckConfig : TeaModel {
                [NameInMap("failureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                [NameInMap("httpGetUrl")]
                [Validation(Required=false)]
                public string HttpGetUrl { get; set; }

                [NameInMap("initialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                [NameInMap("periodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                [NameInMap("successThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public long? TimeoutSeconds { get; set; }

            }

            [NameInMap("image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            [NameInMap("instanceConcurrency")]
            [Validation(Required=false)]
            public int? InstanceConcurrency { get; set; }

            [NameInMap("instanceLifecycleConfig")]
            [Validation(Required=false)]
            public DeployCustomContainerInputCustomContainerConfigInstanceLifecycleConfig InstanceLifecycleConfig { get; set; }
            public class DeployCustomContainerInputCustomContainerConfigInstanceLifecycleConfig : TeaModel {
                [NameInMap("initializer")]
                [Validation(Required=false)]
                public DeployCustomContainerInputCustomContainerConfigInstanceLifecycleConfigInitializer Initializer { get; set; }
                public class DeployCustomContainerInputCustomContainerConfigInstanceLifecycleConfigInitializer : TeaModel {
                    [NameInMap("handler")]
                    [Validation(Required=false)]
                    public string Handler { get; set; }

                    [NameInMap("timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                [NameInMap("preStop")]
                [Validation(Required=false)]
                public DeployCustomContainerInputCustomContainerConfigInstanceLifecycleConfigPreStop PreStop { get; set; }
                public class DeployCustomContainerInputCustomContainerConfigInstanceLifecycleConfigPreStop : TeaModel {
                    [NameInMap("handler")]
                    [Validation(Required=false)]
                    public string Handler { get; set; }

                    [NameInMap("timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

            }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

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
        public DeployCustomContainerInputGpuConfig GpuConfig { get; set; }
        public class DeployCustomContainerInputGpuConfig : TeaModel {
            [NameInMap("gpuMemorySize")]
            [Validation(Required=false)]
            public long? GpuMemorySize { get; set; }

            [NameInMap("gpuType")]
            [Validation(Required=false)]
            public string GpuType { get; set; }

        }

        [NameInMap("httpTrigger")]
        [Validation(Required=false)]
        public DeployCustomContainerInputHttpTrigger HttpTrigger { get; set; }
        public class DeployCustomContainerInputHttpTrigger : TeaModel {
            [NameInMap("qualifier")]
            [Validation(Required=false)]
            public string Qualifier { get; set; }

            [NameInMap("triggerConfig")]
            [Validation(Required=false)]
            public DeployCustomContainerInputHttpTriggerTriggerConfig TriggerConfig { get; set; }
            public class DeployCustomContainerInputHttpTriggerTriggerConfig : TeaModel {
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

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public DeployCustomContainerInputLogConfig LogConfig { get; set; }
        public class DeployCustomContainerInputLogConfig : TeaModel {
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
        public DeployCustomContainerInputModelConfig ModelConfig { get; set; }
        public class DeployCustomContainerInputModelConfig : TeaModel {
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
        public DeployCustomContainerInputNasConfig NasConfig { get; set; }
        public class DeployCustomContainerInputNasConfig : TeaModel {
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("mountPoints")]
            [Validation(Required=false)]
            public List<string> MountPoints { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("originalName")]
        [Validation(Required=false)]
        public string OriginalName { get; set; }

        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("provisionConfig")]
        [Validation(Required=false)]
        public DeployCustomContainerInputProvisionConfig ProvisionConfig { get; set; }
        public class DeployCustomContainerInputProvisionConfig : TeaModel {
            [NameInMap("alwaysAllocateGPU")]
            [Validation(Required=false)]
            public bool? AlwaysAllocateGPU { get; set; }

            [NameInMap("scheduledActions")]
            [Validation(Required=false)]
            public List<DeployCustomContainerInputProvisionConfigScheduledActions> ScheduledActions { get; set; }
            public class DeployCustomContainerInputProvisionConfigScheduledActions : TeaModel {
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
            public long? Target { get; set; }

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
        public DeployCustomContainerInputVpcConfig VpcConfig { get; set; }
        public class DeployCustomContainerInputVpcConfig : TeaModel {
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
