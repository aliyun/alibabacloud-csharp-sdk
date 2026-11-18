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
            /// <para>The additional application information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;xxx\&quot;: \&quot;xxxxx\&quot;}</para>
            /// </summary>
            [NameInMap("AppExtraInfo")]
            [Validation(Required=false)]
            public string AppExtraInfo { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted. The example uses the YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-05 20:00:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The dependency policy.</para>
            /// </summary>
            [NameInMap("DependencyPolicy")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoDependencyPolicy DependencyPolicy { get; set; }
            public class GetJobResponseBodyJobInfoDependencyPolicy : TeaModel {
                /// <summary>
                /// <para>The job dependencies. A maximum of 10 dependencies are supported.</para>
                /// </summary>
                [NameInMap("JobDependency")]
                [Validation(Required=false)]
                public List<GetJobResponseBodyJobInfoDependencyPolicyJobDependency> JobDependency { get; set; }
                public class GetJobResponseBodyJobInfoDependencyPolicyJobDependency : TeaModel {
                    /// <summary>
                    /// <para>The job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>job-bjxxxxxxxxxxxx</para>
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public string JobId { get; set; }

                    /// <summary>
                    /// <para>The dependency type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>AfterSucceeded: All subtasks of the dependent job or array job run successfully (the exit code is 0).</description></item>
                    /// <item><description>AfterFailed: Any subtask of the dependent job or array job fails (the exit code is not 0).</description></item>
                    /// <item><description>AfterAny: The dependent job finishes running, regardless of success or failure.</description></item>
                    /// <item><description>AfterCorresponding: The corresponding subtask of the dependent array job runs successfully (the exit code is 0).</description></item>
                    /// </list>
                    /// <para>Default value: AfterSucceeded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AfterSucceeded</para>
                    /// </summary>
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
                /// <item><description>General: General-purpose.</description></item>
                /// <item><description>Performance: Performance-optimized.</description></item>
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
                /// <para>The network configuration information.</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoDeploymentPolicyNetwork Network { get; set; }
                public class GetJobResponseBodyJobInfoDeploymentPolicyNetwork : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether the resource is created in the zone corresponding to the specified vSwitch parameter. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: The resource is created in the zone corresponding to the specified vSwitch parameter.</para>
                    /// </description></item>
                    /// <item><description><para>false: The resource is created in any zone with available resources.</para>
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
                    /// <para>Specifies whether to create a public IP address.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The list of job tags.</para>
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
            /// <para>The time when the job ended. The example uses the YYYY-MM-DD HH:mm:ss format.</para>
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

            /// <summary>
            /// <para>The security policy.</para>
            /// </summary>
            [NameInMap("SecurityPolicy")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoSecurityPolicy SecurityPolicy { get; set; }
            public class GetJobResponseBodyJobInfoSecurityPolicy : TeaModel {
                /// <summary>
                /// <para>The security group.</para>
                /// </summary>
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoSecurityPolicySecurityGroup SecurityGroup { get; set; }
                public class GetJobResponseBodyJobInfoSecurityPolicySecurityGroup : TeaModel {
                    /// <summary>
                    /// <para>The security group ID array.</para>
                    /// </summary>
                    [NameInMap("SecurityGroupIds")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupIds { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the job started. The example uses the YYYY-MM-DD HH:mm:ss format.</para>
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
            /// <item><description>Failed: The job failed to run.</description></item>
            /// <item><description>Running: The job is running.</description></item>
            /// <item><description>Exception: A scheduling exception occurred.</description></item>
            /// <item><description>Retrying: The job is being retried.</description></item>
            /// <item><description>Expired: The job timed out.</description></item>
            /// <item><description>Deleted: The job is deleted.</description></item>
            /// <item><description>Suspended: The job is hibernated.</description></item>
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
                        /// <para>The end value of the array job index. Valid values: 0 to 4999. The value must be greater than or equal to the value of IndexStart.</para>
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
                        /// <para>The step size of the array job index.</para>
                        /// <remarks>
                        /// <para>If the array job attributes are IndexStart=1, IndexEnd=5, and IndexStep=2, the array job contains three subtasks with indexes 1, 3, and 5.</para>
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
                    /// <para>The maximum number of nodes for job execution.</para>
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
                    /// <para>The sub-job ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ArrayId")]
                    [Validation(Required=false)]
                    public int? ArrayId { get; set; }

                    /// <summary>
                    /// <para>The time when the job was created. The example uses the YYYY-MM-DD HH:mm:ss format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-02-04 13:54:10</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The time when the job ended. The example uses the YYYY-MM-DD HH:mm:ss format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-02-04 13:54:10</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The time when the job started. The example uses the YYYY-MM-DD HH:mm:ss format.</para>
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
                    /// <para>The description of the status reason.</para>
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
                            /// <item><description>System: System cloud disk.</description></item>
                            /// <item><description>Data: Data cloud disk.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>System</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>Specifies whether to enable hyper-threading for the runtime environment. Default value: true.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("EnableHT")]
                        [Validation(Required=false)]
                        public bool? EnableHT { get; set; }

                        /// <summary>
                        /// <para>The hostname prefix of the runtime environment. The limits are as follows:</para>
                        /// <list type="bullet">
                        /// <item><description>A period (.) and a hyphen (-) cannot be used as the first or last character, and cannot be used consecutively.</description></item>
                        /// <item><description>Windows environment: The length cannot exceed 10 characters. Periods (.) are not supported, and the name cannot contain only digits. Uppercase and lowercase letters, digits, and hyphens (-) are allowed.</description></item>
                        /// <item><description>Linux environment: The length cannot exceed 32 characters. Multiple periods (.) are supported. The string between periods is considered a segment, and each segment can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>compute</para>
                        /// </summary>
                        [NameInMap("HostNamePrefix")]
                        [Validation(Required=false)]
                        public string HostNamePrefix { get; set; }

                        /// <summary>
                        /// <para>The instance types of the runtime environment. A maximum of 5 instance types are supported.</para>
                        /// </summary>
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

                    /// <summary>
                    /// <para>The task retry policy.</para>
                    /// </summary>
                    [NameInMap("RetryPolicy")]
                    [Validation(Required=false)]
                    public GetJobResponseBodyJobInfoTasksTaskSpecRetryPolicy RetryPolicy { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecRetryPolicy : TeaModel {
                        /// <summary>
                        /// <para>The retry rules. A maximum of 10 rules are supported.</para>
                        /// </summary>
                        [NameInMap("ExitCodeActions")]
                        [Validation(Required=false)]
                        public List<GetJobResponseBodyJobInfoTasksTaskSpecRetryPolicyExitCodeActions> ExitCodeActions { get; set; }
                        public class GetJobResponseBodyJobInfoTasksTaskSpecRetryPolicyExitCodeActions : TeaModel {
                            /// <summary>
                            /// <para>The next action for the task. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><para>Retry: The job starts a new retry when a specific exit code is matched.</para>
                            /// </description></item>
                            /// <item><description><para>Exit: The job exits when a specific exit code is matched.</para>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Exit</para>
                            /// </summary>
                            [NameInMap("Action")]
                            [Validation(Required=false)]
                            public string Action { get; set; }

                            /// <summary>
                            /// <para>The task exit code, which is used together with Action to form a job retry rule. Valid values: 0 to 255.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("ExitCode")]
                            [Validation(Required=false)]
                            public long? ExitCode { get; set; }

                        }

                        /// <summary>
                        /// <para>The number of retries. Valid values: 1 to 10. Default value: 3.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
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
                        /// <para>The ECS instance used.</para>
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
                            /// <para>The pre-processing script. Base64 encoding is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ZWNobyAiMTIzNCIgPiBgZGF0ZSArJXNg</para>
                            /// </summary>
                            [NameInMap("PrologScript")]
                            [Validation(Required=false)]
                            public string PrologScript { get; set; }

                            /// <summary>
                            /// <para>The script used to run the job. Base64 encoding is required.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ZWNobyAiMTIzNCIgPiBgZGF0ZSArJXNg</para>
                            /// </summary>
                            [NameInMap("Script")]
                            [Validation(Required=false)]
                            public string Script { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The list of data volumes mounted to the task. A maximum of 10 data volumes are supported.</para>
                    /// </summary>
                    [NameInMap("VolumeMount")]
                    [Validation(Required=false)]
                    public List<GetJobResponseBodyJobInfoTasksTaskSpecVolumeMount> VolumeMount { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecVolumeMount : TeaModel {
                        /// <summary>
                        /// <para>The list of mount parameters for the data volume. The parameters are key-value pairs in JSON format.</para>
                        /// <list type="bullet">
                        /// <item><description><para>Format for mounting a NAS file system: {&quot;server&quot;:&quot;xxxxx-xxxxx.cn-heyuan.nas.aliyuncs.com&quot;,&quot;vers&quot;:&quot;3&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;options&quot;:&quot;nolock,tcp,noresvport&quot;}</para>
                        /// <remarks>
                        /// <para>server specifies the mount target address of the NAS file system. path specifies the subdirectory under the NAS path, which must start with / and must already exist. vers specifies the NFS protocol version used to mount the NAS file system. Use v3. options specifies the custom parameters used when mounting the NAS file system, in the format of &quot;xxx,xxx,xxx&quot;.</para>
                        /// </remarks>
                        /// </description></item>
                        /// <item><description><para>Format for mounting an OSS bucket: {&quot;bucket&quot;:&quot;xxxxx&quot;, &quot;url&quot;:&quot;oss-cn-heyuan-internal.aliyuncs.com&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;akId&quot;:&quot;xxxxx&quot;,&quot;akSecret&quot;:&quot;xxxxx&quot;}</para>
                        /// <remarks>
                        /// <para>bucket specifies the name of the OSS bucket. url specifies the endpoint of the OSS bucket. You can log on to the OSS console and obtain the endpoint on the Overview page of the bucket. path specifies the directory structure relative to the root directory of the bucket when mounting. The default value is /, and the directory must already exist. akId specifies the AccessKey ID used for direct authorization with an AccessKey pair. akSecret specifies the AccessKey secret used for direct authorization with an AccessKey pair.</para>
                        /// </remarks>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;bucket&quot;:&quot;demo-bucket&quot;,&quot;otherOpts&quot;:&quot;-o allow_other&quot;,&quot;url&quot;:&quot;oss-cn-hangzhou.aliyuncs.com&quot;}</para>
                        /// </summary>
                        [NameInMap("MountOptions")]
                        [Validation(Required=false)]
                        public string MountOptions { get; set; }

                        /// <summary>
                        /// <para>The directory where the data volume is mounted to the task.</para>
                        /// <remarks>
                        /// <para>The content in the mount directory will be directly overwritten by the content of the volume. Use this parameter with caution.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/cromwell_inputs/1234abcd</para>
                        /// </summary>
                        [NameInMap("MountPath")]
                        [Validation(Required=false)]
                        public string MountPath { get; set; }

                        /// <summary>
                        /// <para>The supported data volume types. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>alicloud/nas: Mount a NAS file system.</description></item>
                        /// <item><description>alicloud/oss: Mount an OSS bucket.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>alicloud/nas</para>
                        /// </summary>
                        [NameInMap("VolumeDriver")]
                        [Validation(Required=false)]
                        public string VolumeDriver { get; set; }

                    }

                }

                /// <summary>
                /// <para>Specifies whether the job is a long-running job.</para>
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
