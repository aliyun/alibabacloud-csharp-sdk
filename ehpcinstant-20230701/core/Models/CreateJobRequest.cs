// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// <para>The dependency policy.</para>
        /// </summary>
        [NameInMap("DependencyPolicy")]
        [Validation(Required=false)]
        public CreateJobRequestDependencyPolicy DependencyPolicy { get; set; }
        public class CreateJobRequestDependencyPolicy : TeaModel {
            /// <summary>
            /// <para>The job dependencies. A maximum of 10 dependencies are supported.</para>
            /// </summary>
            [NameInMap("JobDependency")]
            [Validation(Required=false)]
            public List<CreateJobRequestDependencyPolicyJobDependency> JobDependency { get; set; }
            public class CreateJobRequestDependencyPolicyJobDependency : TeaModel {
                /// <summary>
                /// <para>The job ID.</para>
                /// <para>This parameter is required.</para>
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
                /// <item><description>AfterSucceeded: All child jobs of the dependent job or array job run successfully (the exit code is 0).</description></item>
                /// <item><description>AfterFailed: Any child job of the dependent job or array job fails (the exit code is not 0).</description></item>
                /// <item><description>AfterAny: The dependent job finishes running, regardless of success or failure.</description></item>
                /// <item><description>AfterCorresponding: The corresponding child job of the dependent array job runs successfully (the exit code is 0).</description></item>
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
        public CreateJobRequestDeploymentPolicy DeploymentPolicy { get; set; }
        public class CreateJobRequestDeploymentPolicy : TeaModel {
            /// <summary>
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: standard.</description></item>
            /// <item><description>Dedicated: dedicated. You must be added to the whitelist to use this type.</description></item>
            /// <item><description>Economic: economic. You must be added to the whitelist to use this type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Dedicated</para>
            /// </summary>
            [NameInMap("AllocationSpec")]
            [Validation(Required=false)]
            public string AllocationSpec { get; set; }

            /// <summary>
            /// <para>The computing power level. This parameter is valid only when the resource type is economy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>General: general-purpose.</description></item>
            /// <item><description>Performance: compute-optimized.</description></item>
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
            public CreateJobRequestDeploymentPolicyNetwork Network { get; set; }
            public class CreateJobRequestDeploymentPolicyNetwork : TeaModel {
                /// <summary>
                /// <para>Specifies whether resource scheduling is restricted to the specified vSwitch. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableENIMapping")]
                [Validation(Required=false)]
                public bool? EnableENIMapping { get; set; }

                /// <summary>
                /// <para>Specifies whether to create a public IP address for the job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: A public IP address is created.</description></item>
                /// <item><description>false: No public IP address is created.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
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
            /// <para>The resource pool of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>compute</para>
            /// </summary>
            [NameInMap("Pool")]
            [Validation(Required=false)]
            public string Pool { get; set; }

            /// <summary>
            /// <para>The priority of the job. A larger value indicates a higher scheduling priority. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The tag information of the job. A maximum of 20 tags are supported.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateJobRequestDeploymentPolicyTag> Tag { get; set; }
            public class CreateJobRequestDeploymentPolicyTag : TeaModel {
                /// <summary>
                /// <para>The tag key. If this parameter is specified, it cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. If this parameter is specified, it can be an empty string. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
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
        /// <para>The job description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Demo</para>
        /// </summary>
        [NameInMap("JobDescription")]
        [Validation(Required=false)]
        public string JobDescription { get; set; }

        /// <summary>
        /// <para>The job name. The name must be 2 to 64 characters in length and can contain Chinese characters, English letters, and digits. It can also contain hyphens (-) and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testjob</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("JobScheduler")]
        [Validation(Required=false)]
        public string JobScheduler { get; set; }

        /// <summary>
        /// <para>The job template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jt-xxxx</para>
        /// </summary>
        [NameInMap("JobTemplateId")]
        [Validation(Required=false)]
        public string JobTemplateId { get; set; }

        /// <summary>
        /// <para>The security policy.</para>
        /// </summary>
        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public CreateJobRequestSecurityPolicy SecurityPolicy { get; set; }
        public class CreateJobRequestSecurityPolicy : TeaModel {
            /// <summary>
            /// <para>The security group.</para>
            /// </summary>
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public CreateJobRequestSecurityPolicySecurityGroup SecurityGroup { get; set; }
            public class CreateJobRequestSecurityPolicySecurityGroup : TeaModel {
                /// <summary>
                /// <para>The array of security group IDs.</para>
                /// </summary>
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIds { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of tasks. Only one task is supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<CreateJobRequestTasks> Tasks { get; set; }
        public class CreateJobRequestTasks : TeaModel {
            /// <summary>
            /// <para>The task execution policy.</para>
            /// </summary>
            [NameInMap("ExecutorPolicy")]
            [Validation(Required=false)]
            public CreateJobRequestTasksExecutorPolicy ExecutorPolicy { get; set; }
            public class CreateJobRequestTasksExecutorPolicy : TeaModel {
                /// <summary>
                /// <para>The array job details. The index values of sub-jobs are passed to the runtime environment through environment variables and can be referenced by user business programs. The environment variables include:</para>
                /// <list type="bullet">
                /// <item><description>EHPC_JOB_NAME: the job name, which corresponds to the JobName parameter.</description></item>
                /// <item><description>EHPC_JOB_ID: the job ID.</description></item>
                /// <item><description>EHPC_TASK_NAME: the task name, which corresponds to the TaskName parameter.</description></item>
                /// <item><description>EHPC_EXECUTOR_ID: the executor ID.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_ID: the index value of the sub-job.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_COUNT: the total number of sub-jobs.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_MAX: the maximum index value of the sub-job, which corresponds to the IndexStart parameter.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_MIN: the minimum index value of the sub-job, which corresponds to the IndexEnd parameter.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_STEP: the index step of the sub-job, which corresponds to the IndexStep parameter.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ArraySpec")]
                [Validation(Required=false)]
                public CreateJobRequestTasksExecutorPolicyArraySpec ArraySpec { get; set; }
                public class CreateJobRequestTasksExecutorPolicyArraySpec : TeaModel {
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
                    /// <para>The step of the array job index.</para>
                    /// <remarks>
                    /// <para>If the array job attributes are IndexStart=1, IndexEnd=5, and IndexStep=2, the array job contains three sub-jobs with index values of 1, 3, and 5. User business programs can access these values through environment variables.</para>
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
                /// <para>The maximum number of nodes for the job execution.</para>
                /// <remarks>
                /// <para>The value must follow the formula: <c>MaxCount = (IndexEnd - IndexStart) / IndexStep + 1</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxCount")]
                [Validation(Required=false)]
                public int? MaxCount { get; set; }

            }

            /// <summary>
            /// <para>The task name. The name must be 2 to 32 characters in length and can contain Chinese characters, English letters, and digits. It can also contain hyphens (-) and underscores (_).</para>
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
            public CreateJobRequestTasksTaskSpec TaskSpec { get; set; }
            public class CreateJobRequestTasksTaskSpec : TeaModel {
                /// <summary>
                /// <para>The resource information of the runtime environment.</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public CreateJobRequestTasksTaskSpecResource Resource { get; set; }
                public class CreateJobRequestTasksTaskSpecResource : TeaModel {
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
                    public List<CreateJobRequestTasksTaskSpecResourceDisks> Disks { get; set; }
                    public class CreateJobRequestTasksTaskSpecResourceDisks : TeaModel {
                        /// <summary>
                        /// <para>The size of the cloud disk. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>40</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        /// <summary>
                        /// <para>The cloud disk type. Only System is supported, which indicates a system cloud disk.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>System</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies whether to enable hyper-threading in the runtime environment. Default value: true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("EnableHT")]
                    [Validation(Required=false)]
                    public bool? EnableHT { get; set; }

                    /// <summary>
                    /// <para>The hostname prefix of the runtime environment. Limits:</para>
                    /// <list type="bullet">
                    /// <item><description>The prefix cannot start or end with a period (.) or a hyphen (-), and cannot contain consecutive periods (.) or hyphens (-).</description></item>
                    /// <item><description>Windows environment: The prefix can be up to 10 characters in length and cannot contain periods (.). It cannot contain only digits. It can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
                    /// <item><description>Linux environment: The prefix can be up to 32 characters in length and can contain multiple periods (.). The string between two periods is a segment, and each segment can contain uppercase and lowercase letters, digits, and hyphens (-).</description></item>
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
                public CreateJobRequestTasksTaskSpecRetryPolicy RetryPolicy { get; set; }
                public class CreateJobRequestTasksTaskSpecRetryPolicy : TeaModel {
                    /// <summary>
                    /// <para>The retry rules. A maximum of 10 retry rules are supported.</para>
                    /// </summary>
                    [NameInMap("ExitCodeActions")]
                    [Validation(Required=false)]
                    public List<CreateJobRequestTasksTaskSpecRetryPolicyExitCodeActions> ExitCodeActions { get; set; }
                    public class CreateJobRequestTasksTaskSpecRetryPolicyExitCodeActions : TeaModel {
                        /// <summary>
                        /// <para>The next action of the task. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para>Retry: The job starts a new retry when the specified exit code is matched.</para>
                        /// </description></item>
                        /// <item><description><para>Exit: The job exits when the specified exit code is matched.</para>
                        /// </description></item>
                        /// </list>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Retry</para>
                        /// </summary>
                        [NameInMap("Action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        /// <summary>
                        /// <para>The task exit code, which is used together with Action to form the job retry rule. Valid values: 0 to 255.</para>
                        /// <para>This parameter is required.</para>
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
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("RetryCount")]
                    [Validation(Required=false)]
                    public int? RetryCount { get; set; }

                }

                /// <summary>
                /// <para>The task execution configuration.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("TaskExecutor")]
                [Validation(Required=false)]
                public List<CreateJobRequestTasksTaskSpecTaskExecutor> TaskExecutor { get; set; }
                public class CreateJobRequestTasksTaskSpecTaskExecutor : TeaModel {
                    /// <summary>
                    /// <para>The container environment.</para>
                    /// </summary>
                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public CreateJobRequestTasksTaskSpecTaskExecutorContainer Container { get; set; }
                    public class CreateJobRequestTasksTaskSpecTaskExecutorContainer : TeaModel {
                        /// <summary>
                        /// <para>The ID of the container application.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ci-vm-32k6LXAi3cOG</para>
                        /// </summary>
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>The arguments for the container startup command. A maximum of 10 arguments are supported.</para>
                        /// </summary>
                        [NameInMap("Arg")]
                        [Validation(Required=false)]
                        public List<string> Arg { get; set; }

                        /// <summary>
                        /// <para>The list of container startup commands. A maximum of 20 commands are supported, and each command can be up to 256 characters in length.    </para>
                        /// <remarks>
                        /// <ol>
                        /// <item><description>If a startup command contains spaces (for example, <c>sleep 60s</c>), pass the parameter in JSON format as <c>[&quot;sleep&quot;, &quot;60s&quot;]</c>.</description></item>
                        /// <item><description>If the startup command is complex, you can combine <c>Command: [&quot;/bin/bash&quot;]</c> and <c>Arg:[&quot;-c&quot;, &quot;&lt;customized command&gt;&quot;]</c>. <c>&lt;customized command&gt;</c> is a custom command combination defined by the user and can contain spaces and other characters.</description></item>
                        /// </ol>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public List<string> Command { get; set; }

                        /// <summary>
                        /// <para>The environment variables of the container. A maximum of 20 environment variables are supported.</para>
                        /// </summary>
                        [NameInMap("EnvironmentVars")]
                        [Validation(Required=false)]
                        public List<CreateJobRequestTasksTaskSpecTaskExecutorContainerEnvironmentVars> EnvironmentVars { get; set; }
                        public class CreateJobRequestTasksTaskSpecTaskExecutorContainerEnvironmentVars : TeaModel {
                            /// <summary>
                            /// <para>The name of the environment variable. The name must be 1 to 128 characters in length and can contain letters, digits, and underscores (_). It cannot start with a digit.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>PATH</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The value of the environment variable. The value can be 0 to 256 characters in length.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/usr/local/bin</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>Specifies the GPU driver version.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tesla=535</para>
                        /// </summary>
                        [NameInMap("GpuDriverVersion")]
                        [Validation(Required=false)]
                        public string GpuDriverVersion { get; set; }

                        /// <summary>
                        /// <para>The container image.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/ehpc/hpl:latest</para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        /// <summary>
                        /// <para>The list of mount parameters for the self-managed image registry. The parameters are passed in JSON format as key-value pairs.</para>
                        /// <list type="bullet">
                        /// <item><description>Sample format: {&quot;ImageRegistryType&quot;:&quot;https&quot;,&quot;ImageRegistryServer&quot;:&quot;xxx&quot;,&quot;ImageRegistryUserName&quot;:&quot;xxx&quot;,&quot;ImageRegistryPassword&quot;:&quot;xxx&quot;}</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;ImageRegistryType&quot;:&quot;https&quot;,&quot;ImageRegistryServer&quot;:&quot;xxx&quot;,&quot;ImageRegistryUserName&quot;:&quot;xxx&quot;,&quot;ImageRegistryPassword&quot;:&quot;xxx&quot;}</para>
                        /// </summary>
                        [NameInMap("ImageRegistryOptions")]
                        [Validation(Required=false)]
                        public string ImageRegistryOptions { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to run the container in privileged mode. Default value: false.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Privileged")]
                        [Validation(Required=false)]
                        public bool? Privileged { get; set; }

                        /// <summary>
                        /// <para>The working directory of the container.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>/usr/local/</para>
                        /// </summary>
                        [NameInMap("WorkingDir")]
                        [Validation(Required=false)]
                        public string WorkingDir { get; set; }

                    }

                    /// <summary>
                    /// <para>The virtual machine environment.</para>
                    /// </summary>
                    [NameInMap("VM")]
                    [Validation(Required=false)]
                    public CreateJobRequestTasksTaskSpecTaskExecutorVM VM { get; set; }
                    public class CreateJobRequestTasksTaskSpecTaskExecutorVM : TeaModel {
                        /// <summary>
                        /// <para>The ID of the virtual machine application.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ci-vm-9jc58Pm5Leky</para>
                        /// </summary>
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>The environment variables of the virtual machine.</para>
                        /// </summary>
                        [NameInMap("EnvironmentVars")]
                        [Validation(Required=false)]
                        public List<CreateJobRequestTasksTaskSpecTaskExecutorVMEnvironmentVars> EnvironmentVars { get; set; }
                        public class CreateJobRequestTasksTaskSpecTaskExecutorVMEnvironmentVars : TeaModel {
                            /// <summary>
                            /// <para>The name of the environment variable.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>PATH</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The value of the environment variable.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/usr/local/bin</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The image ID.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>m-xxxx</para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        /// <summary>
                        /// <para>The logon password for the virtual machine environment. The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include:</para>
                        /// <para>()`~!@#$%^&amp;*-_+=|{}[]:;\&quot;&lt;&gt;,.?/
                        /// The password for a Windows environment cannot start with a forward slash (/).</para>
                        /// <remarks>
                        /// <para>If you specify the Password parameter, use HTTPS to send the request to prevent password leaks.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EHPC@1234</para>
                        /// </summary>
                        [NameInMap("Password")]
                        [Validation(Required=false)]
                        public string Password { get; set; }

                        /// <summary>
                        /// <para>The pre-processing script. The script must be Base64-encoded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
                        /// </summary>
                        [NameInMap("PrologScript")]
                        [Validation(Required=false)]
                        public string PrologScript { get; set; }

                        /// <summary>
                        /// <para>The job execution script. The script must be Base64-encoded.</para>
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
                public List<CreateJobRequestTasksTaskSpecVolumeMount> VolumeMount { get; set; }
                public class CreateJobRequestTasksTaskSpecVolumeMount : TeaModel {
                    /// <summary>
                    /// <para>The list of mount parameters for the data volume. The parameters are passed in JSON format as key-value pairs.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Sample format for mounting a NAS file system: {&quot;server&quot;:&quot;xxxxx-xxxxx.cn-heyuan.nas.aliyuncs.com&quot;,&quot;vers&quot;:&quot;3&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;options&quot;:&quot;nolock,tcp,noresvport&quot;}</para>
                    /// <remarks>
                    /// <para>server indicates the mount target address of the NAS file system. path indicates the subdirectory under the NAS path, which must start with a forward slash (/) and already exist. vers indicates the NFS protocol version used to mount the NAS file system. We recommend that you use v3. options indicates the custom parameters for mounting the NAS file system, in the format of &quot;xxx,xxx,xxx&quot;.</para>
                    /// </remarks>
                    /// </description></item>
                    /// <item><description><para>Sample format for mounting an OSS bucket: {&quot;bucket&quot;:&quot;xxxxx&quot;, &quot;url&quot;:&quot;oss-cn-heyuan-internal.aliyuncs.com&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;akId&quot;:&quot;xxxxx&quot;,&quot;akSecret&quot;:&quot;xxxxx&quot;}</para>
                    /// <remarks>
                    /// <para>bucket indicates the name of the OSS bucket. url indicates the endpoint of the OSS bucket. You can log on to the OSS console and obtain the endpoint on the Overview page of the bucket. path indicates the directory structure relative to the root directory of the bucket when the volume is mounted. The default value is /, and the directory must already exist. akId indicates the AccessKey ID used for direct authorization. akSecret indicates the AccessKey secret used for direct authorization.</para>
                    /// </remarks>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;server&quot;:&quot;xxxxx-xxxxx.cn-heyuan.nas.aliyuncs.com&quot;,&quot;vers&quot;:&quot;3&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;options&quot;:&quot;nolock,tcp,noresvport&quot;}</para>
                    /// </summary>
                    [NameInMap("MountOptions")]
                    [Validation(Required=false)]
                    public string MountOptions { get; set; }

                    /// <summary>
                    /// <para>The directory to which the data volume is mounted.</para>
                    /// <remarks>
                    /// <para>The content in the mount directory is directly overwritten by the content of the volume. Proceed with caution.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mnt</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the data volume is read-only. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <para>The type of the data volume. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>alicloud/nas: mounts a NAS file system.</description></item>
                    /// <item><description>alicloud/oss: mounts an OSS bucket.</description></item>
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
            /// <para>Specifies whether the job runs for a long time. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The job is a background service job.</description></item>
            /// <item><description>false: The job is a batch job.</description></item>
            /// </list>
            /// <para>Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TaskSustainable")]
            [Validation(Required=false)]
            public bool? TaskSustainable { get; set; }

        }

    }

}
