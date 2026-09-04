// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetJobTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-20 11:09:59</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The template configuration.</para>
        /// </summary>
        [NameInMap("JobTemplateConfig")]
        [Validation(Required=false)]
        public GetJobTemplateResponseBodyJobTemplateConfig JobTemplateConfig { get; set; }
        public class GetJobTemplateResponseBodyJobTemplateConfig : TeaModel {
            /// <summary>
            /// <para>The resource deployment policy.</para>
            /// </summary>
            [NameInMap("DeploymentPolicy")]
            [Validation(Required=false)]
            public GetJobTemplateResponseBodyJobTemplateConfigDeploymentPolicy DeploymentPolicy { get; set; }
            public class GetJobTemplateResponseBodyJobTemplateConfigDeploymentPolicy : TeaModel {
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
                /// <para>The computing power level. This parameter is valid only when the resource type is Economy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>General: General-purpose.</description></item>
                /// <item><description>Performance: Performance.</description></item>
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
                public GetJobTemplateResponseBodyJobTemplateConfigDeploymentPolicyNetwork Network { get; set; }
                public class GetJobTemplateResponseBodyJobTemplateConfigDeploymentPolicyNetwork : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether a public IP address is created for the job. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EnableExternalIpAddress")]
                    [Validation(Required=false)]
                    public bool? EnableExternalIpAddress { get; set; }

                    /// <summary>
                    /// <para>The vSwitch array.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-xxxx</para>
                    /// </summary>
                    [NameInMap("Vswitch")]
                    [Validation(Required=false)]
                    public List<string> Vswitch { get; set; }

                }

                /// <summary>
                /// <para>The job resource pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-pool</para>
                /// </summary>
                [NameInMap("Pool")]
                [Validation(Required=false)]
                public string Pool { get; set; }

                /// <summary>
                /// <para>The job priority. A larger value indicates a higher scheduling priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The job tag information.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetJobTemplateResponseBodyJobTemplateConfigDeploymentPolicyTags> Tags { get; set; }
                public class GetJobTemplateResponseBodyJobTemplateConfigDeploymentPolicyTags : TeaModel {
                    /// <summary>
                    /// <para>The job tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TestKey</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The job tag value.</para>
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
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-job</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The job scheduler type.</para>
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
            public GetJobTemplateResponseBodyJobTemplateConfigSecurityPolicy SecurityPolicy { get; set; }
            public class GetJobTemplateResponseBodyJobTemplateConfigSecurityPolicy : TeaModel {
                /// <summary>
                /// <para>The security group.</para>
                /// </summary>
                [NameInMap("SecurityGroup")]
                [Validation(Required=false)]
                public GetJobTemplateResponseBodyJobTemplateConfigSecurityPolicySecurityGroup SecurityGroup { get; set; }
                public class GetJobTemplateResponseBodyJobTemplateConfigSecurityPolicySecurityGroup : TeaModel {
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
            /// <para>The task list.</para>
            /// </summary>
            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetJobTemplateResponseBodyJobTemplateConfigTasks> Tasks { get; set; }
            public class GetJobTemplateResponseBodyJobTemplateConfigTasks : TeaModel {
                /// <summary>
                /// <para>The task execution policy.</para>
                /// </summary>
                [NameInMap("ExecutorPolicy")]
                [Validation(Required=false)]
                public GetJobTemplateResponseBodyJobTemplateConfigTasksExecutorPolicy ExecutorPolicy { get; set; }
                public class GetJobTemplateResponseBodyJobTemplateConfigTasksExecutorPolicy : TeaModel {
                    /// <summary>
                    /// <para>The array job details.</para>
                    /// </summary>
                    [NameInMap("ArraySpec")]
                    [Validation(Required=false)]
                    public GetJobTemplateResponseBodyJobTemplateConfigTasksExecutorPolicyArraySpec ArraySpec { get; set; }
                    public class GetJobTemplateResponseBodyJobTemplateConfigTasksExecutorPolicyArraySpec : TeaModel {
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
                public GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpec TaskSpec { get; set; }
                public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpec : TeaModel {
                    /// <summary>
                    /// <para>The runtime environment resource information.</para>
                    /// </summary>
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecResource Resource { get; set; }
                    public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecResource : TeaModel {
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
                        public List<GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecResourceDisks> Disks { get; set; }
                        public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecResourceDisks : TeaModel {
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
                        /// <para>Indicates whether hyper-threading is enabled in the runtime environment.</para>
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
                    public GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecRetryPolicy RetryPolicy { get; set; }
                    public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecRetryPolicy : TeaModel {
                        /// <summary>
                        /// <para>The retry rules.</para>
                        /// </summary>
                        [NameInMap("ExitCodeActions")]
                        [Validation(Required=false)]
                        public List<GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecRetryPolicyExitCodeActions> ExitCodeActions { get; set; }
                        public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecRetryPolicyExitCodeActions : TeaModel {
                            /// <summary>
                            /// <para>The next action for the task. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>Retry: retries the task.</description></item>
                            /// <item><description>Exit: exits the task.</description></item>
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
                    public List<GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecTaskExecutor> TaskExecutor { get; set; }
                    public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecTaskExecutor : TeaModel {
                        /// <summary>
                        /// <para>The container environment configuration.</para>
                        /// </summary>
                        [NameInMap("Container")]
                        [Validation(Required=false)]
                        public GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecTaskExecutorContainer Container { get; set; }
                        public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecTaskExecutorContainer : TeaModel {
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
                            public List<GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecTaskExecutorContainerEnvironmentVars> EnvironmentVars { get; set; }
                            public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecTaskExecutorContainerEnvironmentVars : TeaModel {
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
                            /// <para>The container image.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/ehpc/hpl:latest</para>
                            /// </summary>
                            [NameInMap("Image")]
                            [Validation(Required=false)]
                            public string Image { get; set; }

                            /// <summary>
                            /// <para>The list of self-managed image registry mount parameters. The parameters are in key-value format and passed as JSON.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
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
                        /// <para>The virtual machine (VM) environment configuration.</para>
                        /// </summary>
                        [NameInMap("VM")]
                        [Validation(Required=false)]
                        public GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecTaskExecutorVM VM { get; set; }
                        public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecTaskExecutorVM : TeaModel {
                            /// <summary>
                            /// <para>The VM application ID.</para>
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
                            /// <para>The login password for the VM environment.</para>
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
                    /// <para>The list of data volumes mounted to the task. A maximum of 10 volumes are supported.</para>
                    /// </summary>
                    [NameInMap("VolumeMount")]
                    [Validation(Required=false)]
                    public List<GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecVolumeMount> VolumeMount { get; set; }
                    public class GetJobTemplateResponseBodyJobTemplateConfigTasksTaskSpecVolumeMount : TeaModel {
                        /// <summary>
                        /// <para>The list of data volume mount parameters. The parameters are in key-value format and passed as JSON.</para>
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
                        /// <para>Indicates whether the data volume is read-only.</para>
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
                /// <item><description>false: The job is a batch processing job.</description></item>
                /// </list>
                /// <para>Default value: false.</para>
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
        /// <para>The template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Demo</para>
        /// </summary>
        [NameInMap("JobTemplateDescription")]
        [Validation(Required=false)]
        public string JobTemplateDescription { get; set; }

        /// <summary>
        /// <para>The ID of the job template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jt-xxxx</para>
        /// </summary>
        [NameInMap("JobTemplateId")]
        [Validation(Required=false)]
        public string JobTemplateId { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-template</para>
        /// </summary>
        [NameInMap("JobTemplateName")]
        [Validation(Required=false)]
        public string JobTemplateName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The job template status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Working</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-20 11:09:59</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
