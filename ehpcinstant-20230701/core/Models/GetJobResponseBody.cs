// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The job details.</para>
        /// </summary>
        [NameInMap("JobInfo")]
        [Validation(Required=false)]
        public GetJobResponseBodyJobInfo JobInfo { get; set; }
        public class GetJobResponseBodyJobInfo : TeaModel {
            /// <summary>
            /// <para>The application additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;xxx\&quot;: \&quot;xxxxx\&quot;}</para>
            /// </summary>
            [NameInMap("AppExtraInfo")]
            [Validation(Required=false)]
            public string AppExtraInfo { get; set; }

            /// <summary>
            /// <para>The job submission time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-05 20:00:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DependencyPolicy")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoDependencyPolicy DependencyPolicy { get; set; }
            public class GetJobResponseBodyJobInfoDependencyPolicy : TeaModel {
                [NameInMap("JobDependency")]
                [Validation(Required=false)]
                public List<GetJobResponseBodyJobInfoDependencyPolicyJobDependency> JobDependency { get; set; }
                public class GetJobResponseBodyJobInfoDependencyPolicyJobDependency : TeaModel {
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The resource deployment policy.</para>
            /// </summary>
            [NameInMap("DeploymentPolicy")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoDeploymentPolicy DeploymentPolicy { get; set; }
            public class GetJobResponseBodyJobInfoDeploymentPolicy : TeaModel {
                /// <summary>
                /// <para>The resource type. Currently, only Dedicated is supported. You must be added to the whitelist to use this feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dedicated</para>
                /// </summary>
                [NameInMap("AllocationSpec")]
                [Validation(Required=false)]
                public string AllocationSpec { get; set; }

                /// <summary>
                /// <para>The computing power level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>General: general-purpose.</description></item>
                /// <item><description>Performance: performance-optimized.</description></item>
                /// </list>
                /// <para>Default value: General.</para>
                /// 
                /// <b>Example:</b>
                /// <para>General</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The network configuration.</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoDeploymentPolicyNetwork Network { get; set; }
                public class GetJobResponseBodyJobInfoDeploymentPolicyNetwork : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether resources are created in the zone that corresponds to the specified vSwitch.</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: Resources are created in the zone that corresponds to the specified vSwitch.</para>
                    /// </description></item>
                    /// <item><description><para>false: Resources are created in any zone that has available resources.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EnableENIMapping")]
                    [Validation(Required=false)]
                    public bool? EnableENIMapping { get; set; }

                    /// <summary>
                    /// <para>Indicates whether a public IP address is created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EnableExternalIpAddress")]
                    [Validation(Required=false)]
                    public bool? EnableExternalIpAddress { get; set; }

                    /// <summary>
                    /// <para>The vSwitch array.</para>
                    /// </summary>
                    [NameInMap("Vswitch")]
                    [Validation(Required=false)]
                    public List<string> Vswitch { get; set; }

                }

                /// <summary>
                /// <para>The resource pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testpool</para>
                /// </summary>
                [NameInMap("Pool")]
                [Validation(Required=false)]
                public string Pool { get; set; }

                /// <summary>
                /// <para>The priority.</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The job tag list.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetJobResponseBodyJobInfoDeploymentPolicyTags> Tags { get; set; }
                public class GetJobResponseBodyJobInfoDeploymentPolicyTags : TeaModel {
                    /// <summary>
                    /// <para>The job tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestKey</para>
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <para>The job tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestValue</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

            /// <summary>
            /// <para>The job end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-05 20:01:48</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The job description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Demo</para>
            /// </summary>
            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-xxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("JobScheduler")]
            [Validation(Required=false)]
            public string JobScheduler { get; set; }

            [NameInMap("SecurityPolicy")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoSecurityPolicy SecurityPolicy { get; set; }
            public class GetJobResponseBodyJobInfoSecurityPolicy : TeaModel {
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoSecurityPolicySecurityGroup SecurityGroup { get; set; }
                public class GetJobResponseBodyJobInfoSecurityPolicySecurityGroup : TeaModel {
                    [NameInMap("SecurityGroupIds")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupIds { get; set; }

                }

            }

            /// <summary>
            /// <para>The job start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-05 20:00:48</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The job is queued.</description></item>
            /// <item><description>Initing: The job is being initialized.</description></item>
            /// <item><description>Succeed: The job ran successfully.</description></item>
            /// <item><description>Failed: The job failed.</description></item>
            /// <item><description>Running: The job is running.</description></item>
            /// <item><description>Exception: A scheduling exception occurred.</description></item>
            /// <item><description>Retrying: The job is being retried.</description></item>
            /// <item><description>Expired: The job timed out.</description></item>
            /// <item><description>Deleted: The job has been deleted.</description></item>
            /// <item><description>Suspended: The job is in hibernation.</description></item>
            /// <item><description>Restarting: The job is being restarted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task list. Currently, only one task is supported.</para>
            /// </summary>
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobInfoTasks> Tasks { get; set; }
            public class GetJobResponseBodyJobInfoTasks : TeaModel {
                /// <summary>
                /// <para>The task execution policy.</para>
                /// </summary>
                [NameInMap("ExecutorPolicy")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoTasksExecutorPolicy ExecutorPolicy { get; set; }
                public class GetJobResponseBodyJobInfoTasksExecutorPolicy : TeaModel {
                    /// <summary>
                    /// <para>The array job details.</para>
                    /// </summary>
                    [NameInMap("ArraySpec")]
                    [Validation(Required=false)]
                    public GetJobResponseBodyJobInfoTasksExecutorPolicyArraySpec ArraySpec { get; set; }
                    public class GetJobResponseBodyJobInfoTasksExecutorPolicyArraySpec : TeaModel {
                        /// <summary>
                        /// <para>The end value of the array job index. Valid values: 0 to 4999. The value must be greater than or equal to IndexStart.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9</para>
                        /// </summary>
                        [NameInMap("IndexEnd")]
                        [Validation(Required=false)]
                        public int? IndexEnd { get; set; }

                        /// <summary>
                        /// <para>The start value of the array job index. Valid values: 0 to 4999.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("IndexStart")]
                        [Validation(Required=false)]
                        public int? IndexStart { get; set; }

                        /// <summary>
                        /// <para>The interval of the array job index.</para>
                        /// <remarks>
                        /// <para>If the array job properties are IndexStart=1, IndexEnd=5, and IndexStep=2, the array job contains three subtasks with indexes 1, 3, and 5.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("IndexStep")]
                        [Validation(Required=false)]
                        public int? IndexStep { get; set; }

                    }

                    /// <summary>
                    /// <para>The maximum number of nodes for running the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxCount")]
                    [Validation(Required=false)]
                    public int? MaxCount { get; set; }

                }

                /// <summary>
                /// <para>The task execution status.</para>
                /// </summary>
                [NameInMap("ExecutorStatus")]
                [Validation(Required=false)]
                public List<GetJobResponseBodyJobInfoTasksExecutorStatus> ExecutorStatus { get; set; }
                public class GetJobResponseBodyJobInfoTasksExecutorStatus : TeaModel {
                    /// <summary>
                    /// <para>The subtask ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ArrayId")]
                    [Validation(Required=false)]
                    public int? ArrayId { get; set; }

                    /// <summary>
                    /// <para>The job creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-02-04 13:54:10</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The job end time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-02-04 13:54:10</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The job start time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-02-04 13:54:10</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>The job status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Running</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The status reason description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Creating executor</para>
                    /// </summary>
                    [NameInMap("StatusReason")]
                    [Validation(Required=false)]
                    public string StatusReason { get; set; }

                }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task0</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The task specification details.</para>
                /// </summary>
                [NameInMap("TaskSpec")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoTasksTaskSpec TaskSpec { get; set; }
                public class GetJobResponseBodyJobInfoTasksTaskSpec : TeaModel {
                    /// <summary>
                    /// <para>The resource information.</para>
                    /// </summary>
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public GetJobResponseBodyJobInfoTasksTaskSpecResource Resource { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecResource : TeaModel {
                        /// <summary>
                        /// <para>The number of CPUs used to run the job.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Cores")]
                        [Validation(Required=false)]
                        public float? Cores { get; set; }

                        /// <summary>
                        /// <para>The cloud disk array.</para>
                        /// </summary>
                        [NameInMap("Disks")]
                        [Validation(Required=false)]
                        public List<GetJobResponseBodyJobInfoTasksTaskSpecResourceDisks> Disks { get; set; }
                        public class GetJobResponseBodyJobInfoTasksTaskSpecResourceDisks : TeaModel {
                            /// <summary>
                            /// <para>The cloud disk size.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public int? Size { get; set; }

                            /// <summary>
                            /// <para>The cloud disk type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>System: system cloud disk.</description></item>
                            /// <item><description>Data: data cloud disk.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>System</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        [NameInMap("EnableHT")]
                        [Validation(Required=false)]
                        public bool? EnableHT { get; set; }

                        [NameInMap("HostNamePrefix")]
                        [Validation(Required=false)]
                        public string HostNamePrefix { get; set; }

                        [NameInMap("InstanceTypes")]
                        [Validation(Required=false)]
                        public List<string> InstanceTypes { get; set; }

                        /// <summary>
                        /// <para>The total amount of memory resources. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public int? Memory { get; set; }

                    }

                    [NameInMap("RetryPolicy")]
                    [Validation(Required=false)]
                    public GetJobResponseBodyJobInfoTasksTaskSpecRetryPolicy RetryPolicy { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecRetryPolicy : TeaModel {
                        [NameInMap("ExitCodeActions")]
                        [Validation(Required=false)]
                        public List<GetJobResponseBodyJobInfoTasksTaskSpecRetryPolicyExitCodeActions> ExitCodeActions { get; set; }
                        public class GetJobResponseBodyJobInfoTasksTaskSpecRetryPolicyExitCodeActions : TeaModel {
                            [NameInMap("Action")]
                            [Validation(Required=false)]
                            public string Action { get; set; }

                            [NameInMap("ExitCode")]
                            [Validation(Required=false)]
                            public long? ExitCode { get; set; }

                        }

                        [NameInMap("RetryCount")]
                        [Validation(Required=false)]
                        public int? RetryCount { get; set; }

                    }

                    /// <summary>
                    /// <para>The task execution configuration.</para>
                    /// </summary>
                    [NameInMap("TaskExecutor")]
                    [Validation(Required=false)]
                    public List<GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutor> TaskExecutor { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutor : TeaModel {
                        /// <summary>
                        /// <para>The ECS instance configuration.</para>
                        /// </summary>
                        [NameInMap("VM")]
                        [Validation(Required=false)]
                        public GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutorVM VM { get; set; }
                        public class GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutorVM : TeaModel {
                            /// <summary>
                            /// <para>The image ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>m-xxxx</para>
                            /// </summary>
                            [NameInMap("Image")]
                            [Validation(Required=false)]
                            public string Image { get; set; }

                            /// <summary>
                            /// <para>The pre-processing script. The script must be Base64-encoded.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ZWNobyAiMTIzNCIgPiBgZGF0ZSArJXNg</para>
                            /// </summary>
                            [NameInMap("PrologScript")]
                            [Validation(Required=false)]
                            public string PrologScript { get; set; }

                            /// <summary>
                            /// <para>The job execution script. The script must be Base64-encoded.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ZWNobyAiMTIzNCIgPiBgZGF0ZSArJXNg</para>
                            /// </summary>
                            [NameInMap("Script")]
                            [Validation(Required=false)]
                            public string Script { get; set; }

                        }

                    }

                    [NameInMap("VolumeMount")]
                    [Validation(Required=false)]
                    public List<GetJobResponseBodyJobInfoTasksTaskSpecVolumeMount> VolumeMount { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecVolumeMount : TeaModel {
                        [NameInMap("MountOptions")]
                        [Validation(Required=false)]
                        public string MountOptions { get; set; }

                        [NameInMap("MountPath")]
                        [Validation(Required=false)]
                        public string MountPath { get; set; }

                        [NameInMap("VolumeDriver")]
                        [Validation(Required=false)]
                        public string VolumeDriver { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the job is a long-running job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TaskSustainable")]
                [Validation(Required=false)]
                public bool? TaskSustainable { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
