// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class CreateJobTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the template.</para>
        /// </summary>
        [NameInMap("JobTemplateConfig")]
        [Validation(Required=false)]
        public CreateJobTemplateRequestJobTemplateConfig JobTemplateConfig { get; set; }
        public class CreateJobTemplateRequestJobTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The resource deployment policy.</para>
            /// </summary>
            [NameInMap("DeploymentPolicy")]
            [Validation(Required=false)]
            public CreateJobTemplateRequestJobTemplateConfigDeploymentPolicy DeploymentPolicy { get; set; }
            public class CreateJobTemplateRequestJobTemplateConfigDeploymentPolicy : TeaModel {
                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dedicated</para>
                /// </summary>
                [NameInMap("AllocationSpec")]
                [Validation(Required=false)]
                public string AllocationSpec { get; set; }

                /// <summary>
                /// <para>The computing power level. This parameter takes effect only when the resource type is economy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>General: general-purpose.</description></item>
                /// <item><description>Performance: compute-optimized instance.</description></item>
                /// </list>
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
                public CreateJobTemplateRequestJobTemplateConfigDeploymentPolicyNetwork Network { get; set; }
                public class CreateJobTemplateRequestJobTemplateConfigDeploymentPolicyNetwork : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to create a public IP address for the job. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EnableExternalIpAddress")]
                    [Validation(Required=false)]
                    public bool? EnableExternalIpAddress { get; set; }

                    /// <summary>
                    /// <para>The array of vSwitches.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-xxxx</para>
                    /// </summary>
                    [NameInMap("Vswitch")]
                    [Validation(Required=false)]
                    public List<string> Vswitch { get; set; }

                }

                /// <summary>
                /// <para>The resource pool for the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-pool</para>
                /// </summary>
                [NameInMap("Pool")]
                [Validation(Required=false)]
                public string Pool { get; set; }

                /// <summary>
                /// <para>The priority of the job. A larger value indicates a higher scheduling priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The tag information of the job.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<CreateJobTemplateRequestJobTemplateConfigDeploymentPolicyTags> Tags { get; set; }
                public class CreateJobTemplateRequestJobTemplateConfigDeploymentPolicyTags : TeaModel {
                    /// <summary>
                    /// <para>The key of the job tag.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestKey</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the job tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestValue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The description of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Demo</para>
            /// </summary>
            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-job</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HPC</para>
            /// </summary>
            [NameInMap("JobScheduler")]
            [Validation(Required=false)]
            public string JobScheduler { get; set; }

            /// <summary>
            /// <para>The security policy.</para>
            /// </summary>
            [NameInMap("SecurityPolicy")]
            [Validation(Required=false)]
            public CreateJobTemplateRequestJobTemplateConfigSecurityPolicy SecurityPolicy { get; set; }
            public class CreateJobTemplateRequestJobTemplateConfigSecurityPolicy : TeaModel {
                /// <summary>
                /// <para>The security group.</para>
                /// </summary>
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public CreateJobTemplateRequestJobTemplateConfigSecurityPolicySecurityGroup SecurityGroup { get; set; }
                public class CreateJobTemplateRequestJobTemplateConfigSecurityPolicySecurityGroup : TeaModel {
                    /// <summary>
                    /// <para>The array of security group IDs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-xxxx</para>
                    /// </summary>
                    [NameInMap("SecurityGroupIds")]
                    [Validation(Required=false)]
                    public List<string> SecurityGroupIds { get; set; }

                }

            }

            /// <summary>
            /// <para>The task list. A maximum of 5 tasks are supported.</para>
            /// </summary>
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<CreateJobTemplateRequestJobTemplateConfigTasks> Tasks { get; set; }
            public class CreateJobTemplateRequestJobTemplateConfigTasks : TeaModel {
                /// <summary>
                /// <para>The task execution policy.</para>
                /// </summary>
                [NameInMap("ExecutorPolicy")]
                [Validation(Required=false)]
                public CreateJobTemplateRequestJobTemplateConfigTasksExecutorPolicy ExecutorPolicy { get; set; }
                public class CreateJobTemplateRequestJobTemplateConfigTasksExecutorPolicy : TeaModel {
                    /// <summary>
                    /// <para>The array job details.</para>
                    /// </summary>
                    [NameInMap("ArraySpec")]
                    [Validation(Required=false)]
                    public CreateJobTemplateRequestJobTemplateConfigTasksExecutorPolicyArraySpec ArraySpec { get; set; }
                    public class CreateJobTemplateRequestJobTemplateConfigTasksExecutorPolicyArraySpec : TeaModel {
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
                        /// <para>The step size of the array job index.</para>
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MaxCount")]
                    [Validation(Required=false)]
                    public int? MaxCount { get; set; }

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
                public CreateJobTemplateRequestJobTemplateConfigTasksTaskSpec TaskSpec { get; set; }
                public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpec : TeaModel {
                    /// <summary>
                    /// <para>The runtime environment resource information.</para>
                    /// </summary>
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecResource Resource { get; set; }
                    public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecResource : TeaModel {
                        /// <summary>
                        /// <para>The number of CPUs in the runtime environment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Cores")]
                        [Validation(Required=false)]
                        public float? Cores { get; set; }

                        /// <summary>
                        /// <para>The cloud disk array.</para>
                        /// </summary>
                        [NameInMap("Disks")]
                        [Validation(Required=false)]
                        public List<CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecResourceDisks> Disks { get; set; }
                        public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecResourceDisks : TeaModel {
                            /// <summary>
                            /// <para>The cloud disk size. Unit: GiB.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>40</para>
                            /// </summary>
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public int? Size { get; set; }

                            /// <summary>
                            /// <para>The cloud disk type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>System</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <para>Specifies whether hyper-threading is enabled in the runtime environment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("EnableHT")]
                        [Validation(Required=false)]
                        public bool? EnableHT { get; set; }

                        /// <summary>
                        /// <para>The hostname prefix of the runtime environment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>compute</para>
                        /// </summary>
                        [NameInMap("HostNamePrefix")]
                        [Validation(Required=false)]
                        public string HostNamePrefix { get; set; }

                        /// <summary>
                        /// <para>The instance types of the runtime environment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ecs.c7a.8xlarge</para>
                        /// </summary>
                        [NameInMap("InstanceTypes")]
                        [Validation(Required=false)]
                        public List<string> InstanceTypes { get; set; }

                        /// <summary>
                        /// <para>The memory size of the runtime environment. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public float? Memory { get; set; }

                    }

                    /// <summary>
                    /// <para>The task retry policy.</para>
                    /// </summary>
                    [NameInMap("RetryPolicy")]
                    [Validation(Required=false)]
                    public CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecRetryPolicy RetryPolicy { get; set; }
                    public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecRetryPolicy : TeaModel {
                        /// <summary>
                        /// <para>The retry rules.</para>
                        /// </summary>
                        [NameInMap("ExitCodeActions")]
                        [Validation(Required=false)]
                        public List<CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecRetryPolicyExitCodeActions> ExitCodeActions { get; set; }
                        public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecRetryPolicyExitCodeActions : TeaModel {
                            /// <summary>
                            /// <para>The next action for the task. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>Retry: Retry the task.</description></item>
                            /// <item><description>Exit: Exit the task.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Retry</para>
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
                        /// <para>The number of retries.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
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
                    public List<CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecTaskExecutor> TaskExecutor { get; set; }
                    public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecTaskExecutor : TeaModel {
                        /// <summary>
                        /// <para>The container environment configuration.</para>
                        /// </summary>
                        [NameInMap("Container")]
                        [Validation(Required=false)]
                        public CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecTaskExecutorContainer Container { get; set; }
                        public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecTaskExecutorContainer : TeaModel {
                            /// <summary>
                            /// <para>The container application ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ci-vm-32k6LXAi3cOG</para>
                            /// </summary>
                            [NameInMap("AppId")]
                            [Validation(Required=false)]
                            public string AppId { get; set; }

                            /// <summary>
                            /// <para>The arguments for the container startup command.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>60s</para>
                            /// </summary>
                            [NameInMap("Arg")]
                            [Validation(Required=false)]
                            public List<string> Arg { get; set; }

                            /// <summary>
                            /// <para>The list of container startup commands.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>sleep</para>
                            /// </summary>
                            [NameInMap("Command")]
                            [Validation(Required=false)]
                            public List<string> Command { get; set; }

                            /// <summary>
                            /// <para>The environment variables of the container.</para>
                            /// </summary>
                            [NameInMap("EnvironmentVars")]
                            [Validation(Required=false)]
                            public List<CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecTaskExecutorContainerEnvironmentVars> EnvironmentVars { get; set; }
                            public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecTaskExecutorContainerEnvironmentVars : TeaModel {
                                /// <summary>
                                /// <para>The environment variable name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>PATH</para>
                                /// </summary>
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// <para>The environment variable value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>/usr/local/bin</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                            /// <summary>
                            /// <para>The container image.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/ehpc/hpl:latest</para>
                            /// </summary>
                            [NameInMap("Image")]
                            [Validation(Required=false)]
                            public string Image { get; set; }

                            /// <summary>
                            /// <para>The mount parameter list for the self-managed image repository. The parameters are in key-value format and passed as JSON.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
                            [NameInMap("ImageRegistryOptions")]
                            [Validation(Required=false)]
                            public string ImageRegistryOptions { get; set; }

                            /// <summary>
                            /// <para>The container working directory.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/usr/local/</para>
                            /// </summary>
                            [NameInMap("WorkingDir")]
                            [Validation(Required=false)]
                            public string WorkingDir { get; set; }

                        }

                        /// <summary>
                        /// <para>The virtual machine environment configuration.</para>
                        /// </summary>
                        [NameInMap("VM")]
                        [Validation(Required=false)]
                        public CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecTaskExecutorVM VM { get; set; }
                        public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecTaskExecutorVM : TeaModel {
                            /// <summary>
                            /// <para>The virtual machine application ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ci-vm-9jc58Pm5Leky</para>
                            /// </summary>
                            [NameInMap("AppId")]
                            [Validation(Required=false)]
                            public string AppId { get; set; }

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
                            /// <para>The logon password for the virtual machine environment.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>EHPC@1234</para>
                            /// </summary>
                            [NameInMap("Password")]
                            [Validation(Required=false)]
                            public string Password { get; set; }

                            /// <summary>
                            /// <para>The prolog script. The script must be Base64-encoded.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
                            /// </summary>
                            [NameInMap("PrologScript")]
                            [Validation(Required=false)]
                            public string PrologScript { get; set; }

                            /// <summary>
                            /// <para>The job script. The script must be Base64-encoded.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
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
                    public List<CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecVolumeMount> VolumeMount { get; set; }
                    public class CreateJobTemplateRequestJobTemplateConfigTasksTaskSpecVolumeMount : TeaModel {
                        /// <summary>
                        /// <para>The list of data volume mount options. The options are in key-value format and passed as JSON.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;server&quot;:&quot;xxxxx-xxxxx.cn-heyuan.nas.aliyuncs.com&quot;,&quot;vers&quot;:&quot;3&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;options&quot;:&quot;nolock,tcp,noresvport&quot;}</para>
                        /// </summary>
                        [NameInMap("MountOptions")]
                        [Validation(Required=false)]
                        public string MountOptions { get; set; }

                        /// <summary>
                        /// <para>The directory where the data volume is mounted to the task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/mnt</para>
                        /// </summary>
                        [NameInMap("MountPath")]
                        [Validation(Required=false)]
                        public string MountPath { get; set; }

                        /// <summary>
                        /// <para>Specifies whether the data volume is read-only.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("ReadOnly")]
                        [Validation(Required=false)]
                        public bool? ReadOnly { get; set; }

                        /// <summary>
                        /// <para>The currently supported data volume type.</para>
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
                /// <para>Specifies whether the job is long-running. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The job is a background service job.</description></item>
                /// <item><description>false: The job is a batch job.
                /// Default value: false.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("TaskSustainable")]
                [Validation(Required=false)]
                public bool? TaskSustainable { get; set; }

            }

        }

        /// <summary>
        /// <para>The description of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Demo</para>
        /// </summary>
        [NameInMap("JobTemplateDescription")]
        [Validation(Required=false)]
        public string JobTemplateDescription { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-template</para>
        /// </summary>
        [NameInMap("JobTemplateName")]
        [Validation(Required=false)]
        public string JobTemplateName { get; set; }

    }

}
