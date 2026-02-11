// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// <para>Dependency policy.</para>
        /// </summary>
        [NameInMap("DependencyPolicy")]
        [Validation(Required=false)]
        public CreateJobRequestDependencyPolicy DependencyPolicy { get; set; }
        public class CreateJobRequestDependencyPolicy : TeaModel {
            /// <summary>
            /// <para>The job dependency. A maximum of 10 groups.</para>
            /// </summary>
            [NameInMap("JobDependency")]
            [Validation(Required=false)]
            public List<CreateJobRequestDependencyPolicyJobDependency> JobDependency { get; set; }
            public class CreateJobRequestDependencyPolicyJobDependency : TeaModel {
                /// <summary>
                /// <para>The ID of the job.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-bjxxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The type of the dependency. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AfterSucceeded: <b>All subtasks</b> of the dependent job or array job succeed. The exit code is 0.</description></item>
                /// <item><description>AfterFailed: <b>All subtasks</b> of the dependent job or array job fail. The exit code is not 0.</description></item>
                /// <item><description>AfterAny: The dependent job completes (succeeds or fails).</description></item>
                /// <item><description>AfterCorresponding: The subtask corresponding to the dependent array job succeeds. The exit code is 0.</description></item>
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
            /// <para>The resource type,</para>
            /// <list type="bullet">
            /// <item><description>Standard</description></item>
            /// <item><description>Dedicated: You must enable a whitelist for use.</description></item>
            /// <item><description>Economic: You must enable a whitelist for use.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Dedicated</para>
            /// </summary>
            [NameInMap("AllocationSpec")]
            [Validation(Required=false)]
            public string AllocationSpec { get; set; }

            /// <summary>
            /// <para>The computing power level. This value is valid only when the resource type is Economic. The following disk categories are supported:</para>
            /// <list type="bullet">
            /// <item><description>General</description></item>
            /// <item><description>Performance</description></item>
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
                /// <para>Whether the job creates a public IP address.</para>
                /// <list type="bullet">
                /// <item><description>true: creates a public IP address.</description></item>
                /// <item><description>false: does not create a public IP address.</description></item>
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
                /// <para>The VSwitch array.</para>
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
            /// <para>The priorities of the jobs. A larger value indicates a higher job scheduling priority. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The tag information of the job. A maximum of 20 groups.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateJobRequestDeploymentPolicyTag> Tag { get; set; }
            public class CreateJobRequestDeploymentPolicyTag : TeaModel {
                /// <summary>
                /// <para>The key of the job tag. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the job tag. You can specify empty strings as tag values. The tag value can be up to 128 characters in length and cannot contain http:// or https://.</para>
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
        /// <para>The job name. The name must be 2 to 64 characters in length and can contain letters, digits, and Chinese characters. It can contain hyphens (-) and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testjob</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The type of the job scheduler.</para>
        /// <list type="bullet">
        /// <item><description>HPC</description></item>
        /// <item><description>K8S</description></item>
        /// </list>
        /// <para>Default value: HPC</para>
        /// 
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
        public CreateJobRequestSecurityPolicy SecurityPolicy { get; set; }
        public class CreateJobRequestSecurityPolicy : TeaModel {
            /// <summary>
            /// <para>The security group ID.</para>
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
                /// <para>The details of the array job. The index value of the sub-job is passed to the running environment through environment variables to support user business program reference. Environment variables include:</para>
                /// <list type="bullet">
                /// <item><description>EHPC_JOB_NAME: the name of the job. This parameter corresponds to the JobName parameter.</description></item>
                /// <item><description>EHPC_JOB_ID: The ID of the job.</description></item>
                /// <item><description>EHPC_TASK_NAME: the name of the task. This parameter corresponds to the TaskName parameter.</description></item>
                /// <item><description>EHPC_EXECUTOR_ID: The ID of the execution unit.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_ID: the sub-job index value.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_COUNT: the total number of sub-jobs.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_MAX: the maximum sub-job index, which corresponds to the IndexStart parameter.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_MIN: the minimum value of the sub-job index, which corresponds to the IndexEnd parameter.</description></item>
                /// <item><description>EHPC_ARRAY_TASK_STEP: the index step size of the sub-job, which corresponds to the IndexStep parameter.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ArraySpec")]
                [Validation(Required=false)]
                public CreateJobRequestTasksExecutorPolicyArraySpec ArraySpec { get; set; }
                public class CreateJobRequestTasksExecutorPolicyArraySpec : TeaModel {
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
                    /// <para>The starting value of the array job index. Valid values: 0 to 4999.</para>
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
                    /// <para>If the array job property is IndexStart=1,IndexEnd=5, and IndexStep=2, the array job contains three sub-jobs. The index values of the sub-jobs are 1,3, and 5. You can access the sub-jobs by using environment variables.</para>
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
                /// <para>The maximum number of nodes to run the job.</para>
                /// <remarks>
                /// <para>Follow the calculation formula: <c>MaxCount = (IndexEnd - IndexStart) / IndexStep +1</c></para>
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
            /// <para>The job name. It must be 2 to 32 characters in length and can contain letters, digits, and Chinese characters. It can contain hyphens (-) and underscores (_).</para>
            /// 
            /// <b>Example:</b>
            /// <para>task0</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The details of the task specification.</para>
            /// </summary>
            [NameInMap("TaskSpec")]
            [Validation(Required=false)]
            public CreateJobRequestTasksTaskSpec TaskSpec { get; set; }
            public class CreateJobRequestTasksTaskSpec : TeaModel {
                /// <summary>
                /// <para>The resource information of the running environment.</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public CreateJobRequestTasksTaskSpecResource Resource { get; set; }
                public class CreateJobRequestTasksTaskSpecResource : TeaModel {
                    /// <summary>
                    /// <para>The number of CPUs in the running environment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public float? Cores { get; set; }

                    /// <summary>
                    /// <para>The array of the disks.</para>
                    /// </summary>
                    [NameInMap("Disks")]
                    [Validation(Required=false)]
                    public List<CreateJobRequestTasksTaskSpecResourceDisks> Disks { get; set; }
                    public class CreateJobRequestTasksTaskSpecResourceDisks : TeaModel {
                        /// <summary>
                        /// <para>The size of the disk. Unit: GiB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>40</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        /// <summary>
                        /// <para>The type of the disk. Currently, only System is supported, which indicates the system disk.</para>
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

                    /// <summary>
                    /// <para>The instance type of the running environment. A maximum of 5 groups.</para>
                    /// </summary>
                    [NameInMap("InstanceTypes")]
                    [Validation(Required=false)]
                    public List<string> InstanceTypes { get; set; }

                    /// <summary>
                    /// <para>The memory size of the running environment. Unit: GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public float? Memory { get; set; }

                }

                /// <summary>
                /// <para>Task retry policy.</para>
                /// </summary>
                [NameInMap("RetryPolicy")]
                [Validation(Required=false)]
                public CreateJobRequestTasksTaskSpecRetryPolicy RetryPolicy { get; set; }
                public class CreateJobRequestTasksTaskSpecRetryPolicy : TeaModel {
                    /// <summary>
                    /// <para>The retry rule. A maximum of 10 groups.</para>
                    /// </summary>
                    [NameInMap("ExitCodeActions")]
                    [Validation(Required=false)]
                    public List<CreateJobRequestTasksTaskSpecRetryPolicyExitCodeActions> ExitCodeActions { get; set; }
                    public class CreateJobRequestTasksTaskSpecRetryPolicyExitCodeActions : TeaModel {
                        /// <summary>
                        /// <para>The next step behavior of the task.</para>
                        /// <list type="bullet">
                        /// <item><description>Retry: The job starts a retry when a specific exit code is hit.</description></item>
                        /// <item><description>Exit: The job exits when a specific exit code is hit.</description></item>
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
                        /// <para>The task exit code, which is used together with the action to form a job retry rule. Valid values: 0 to 255.</para>
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
                    /// <para>The maximum number of retries. Valid values: 1 to 10. Default value: 3.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("RetryCount")]
                    [Validation(Required=false)]
                    public int? RetryCount { get; set; }

                }

                /// <summary>
                /// <para>The task execution configurations.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("TaskExecutor")]
                [Validation(Required=false)]
                public List<CreateJobRequestTasksTaskSpecTaskExecutor> TaskExecutor { get; set; }
                public class CreateJobRequestTasksTaskSpecTaskExecutor : TeaModel {
                    /// <summary>
                    /// <para>Use the container environment.</para>
                    /// </summary>
                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public CreateJobRequestTasksTaskSpecTaskExecutorContainer Container { get; set; }
                    public class CreateJobRequestTasksTaskSpecTaskExecutorContainer : TeaModel {
                        /// <summary>
                        /// <para>The application ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ci-vm-32k6LXAi3cOG</para>
                        /// </summary>
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>The startup argument of the init container. A maximum of 10 groups.</para>
                        /// </summary>
                        [NameInMap("Arg")]
                        [Validation(Required=false)]
                        public List<string> Arg { get; set; }

                        /// <summary>
                        /// <para>The container startup commands. You can specify up to 20 commands. Each command can be up to 256 characters in length.</para>
                        /// <remarks>
                        /// </remarks>
                        /// <list type="bullet">
                        /// <item><description><para>If the start command contains spaces (for example, <c>sleep 60s</c> ), the input JSON format parameter is <c>[&quot;sleep&quot;, &quot;60s&quot;]</c>.</para>
                        /// </description></item>
                        /// <item><description><para>If the startup command is complex, the parameter format may be a combination of <c>Command: [&quot;/bin/bash&quot;]</c> and <c>Arg:[&quot;-c&quot;, &quot;&lt;customized command&gt;&quot;]</c>. The <c>&lt;customized command&gt;</c> is a user-defined combination of commands and can contain characters such as spaces.</para>
                        /// </description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public List<string> Command { get; set; }

                        /// <summary>
                        /// <para>The environment variables of the container. A maximum of 20 groups.</para>
                        /// </summary>
                        [NameInMap("EnvironmentVars")]
                        [Validation(Required=false)]
                        public List<CreateJobRequestTasksTaskSpecTaskExecutorContainerEnvironmentVars> EnvironmentVars { get; set; }
                        public class CreateJobRequestTasksTaskSpecTaskExecutorContainerEnvironmentVars : TeaModel {
                            /// <summary>
                            /// <para>The name of the environment variable for the container. It can be 1 to 128 characters in length. Format requirement: [0-9a-zA-Z], and underscores, cannot start with a number.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>PATH</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The value of the environment variable for the container. The value must be 0 to 256 bits in length.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/usr/local/bin</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The image of the container.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/ehpc/hpl:latest</para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        [NameInMap("ImageRegistryOptions")]
                        [Validation(Required=false)]
                        public string ImageRegistryOptions { get; set; }

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
                    /// <para>Use a virtual machine environment.</para>
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
                        /// <para>The ID of the image.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>m-xxxx</para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        /// <summary>
                        /// <para>The logon password of the virtual machine environment. The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported:</para>
                        /// <para>()\`~!@#$%^&amp;\*-_+=|{}[]:;\&quot;&lt;&gt;,.?/ In Windows, the password cannot contain a forward slash (/) as the first character.</para>
                        /// <remarks>
                        /// <para>We recommend that you use HTTPS to send requests if you specify Password to avoid password leakage.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EHPC@1234</para>
                        /// </summary>
                        [NameInMap("Password")]
                        [Validation(Required=false)]
                        public string Password { get; set; }

                        /// <summary>
                        /// <para>The pre-processing script. Base64 encoding is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
                        /// </summary>
                        [NameInMap("PrologScript")]
                        [Validation(Required=false)]
                        public string PrologScript { get; set; }

                        /// <summary>
                        /// <para>The running-job script. Base64 encoding is required.</para>
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
                /// <para>The list of data volumes mounted to the task. A maximum of 10 groups.</para>
                /// </summary>
                [NameInMap("VolumeMount")]
                [Validation(Required=false)]
                public List<CreateJobRequestTasksTaskSpecVolumeMount> VolumeMount { get; set; }
                public class CreateJobRequestTasksTaskSpecVolumeMount : TeaModel {
                    /// <summary>
                    /// <para>The list of data volume mount parameters. Each option is a key-value pair in a JSON string.</para>
                    /// <list type="bullet">
                    /// <item><description>Format for mounting a NAS file system:{&quot;server&quot;:&quot;xxxxx-xxxxx.cn-heyuan.nas.aliyuncs.com&quot;,&quot;vers&quot;:&quot;3&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;options&quot;:&quot;nolock,tcp,noresvport&quot;}</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>server indicates the address of the mount point of the NAS file system. path indicates the subdirectory of the NAS file system. The subdirectory must start with a (/) and must already exist. vers indicates the version number of the NFS protocol used to mount the file system. We recommend that you use v3. options indicates the custom parameters in the format of &quot;xxx,xxx,xxx&quot;.</para>
                    /// </remarks>
                    /// <list type="bullet">
                    /// <item><description>OSS mount format:{&quot;bucket&quot;:&quot;xxxxx&quot;, &quot;url&quot;:&quot;oss-cn-heyuan-internal.aliyuncs.com&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;akId&quot;:&quot;xxxxx&quot;,&quot;akSecret&quot;:&quot;xxxxx&quot;}</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>bucket indicates the name of the OSS bucket. url indicates the endpoint of the OSS bucket. You can log on to the OSS console and obtain the endpoint on the Overview page of the destination bucket. path indicates the directory structure of the root file of the bucket. The default value is /, which requires that the directory already exists. akId indicates the AccessKey ID. akSecret indicates the AccessKey secret.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;server&quot;:&quot;xxxxx-xxxxx.cn-heyuan.nas.aliyuncs.com&quot;,&quot;vers&quot;:&quot;3&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;options&quot;:&quot;nolock,tcp,noresvport&quot;}</para>
                    /// </summary>
                    [NameInMap("MountOptions")]
                    [Validation(Required=false)]
                    public string MountOptions { get; set; }

                    /// <summary>
                    /// <para>The directory where the task mounts the data volume.</para>
                    /// <remarks>
                    /// <para>The content of the mounted directory is overwritten by the content of the volume. Exercise caution when you use the directory.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/mnt</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the volume is read-only. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <para>Currently supported data volume types.</para>
                    /// <list type="bullet">
                    /// <item><description>alicloud/nas: mounts NAS.</description></item>
                    /// <item><description>alicloud/oss: mounts OSS.</description></item>
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
            /// <para>Indicate whether the job is a long-running job.</para>
            /// <list type="bullet">
            /// <item><description>true: background service the job.</description></item>
            /// <item><description>false: batch jobs.</description></item>
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
