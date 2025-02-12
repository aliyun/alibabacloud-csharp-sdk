// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class CreateJobRequest : TeaModel {
        [NameInMap("DeploymentPolicy")]
        [Validation(Required=false)]
        public CreateJobRequestDeploymentPolicy DeploymentPolicy { get; set; }
        public class CreateJobRequestDeploymentPolicy : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Dedicated</para>
            /// </summary>
            [NameInMap("AllocationSpec")]
            [Validation(Required=false)]
            public string AllocationSpec { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public CreateJobRequestDeploymentPolicyNetwork Network { get; set; }
            public class CreateJobRequestDeploymentPolicyNetwork : TeaModel {
                [NameInMap("EnableExternalIpAddress")]
                [Validation(Required=false)]
                public bool? EnableExternalIpAddress { get; set; }

                [NameInMap("Vswitch")]
                [Validation(Required=false)]
                public List<string> Vswitch { get; set; }

            }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateJobRequestDeploymentPolicyTag> Tag { get; set; }
            public class CreateJobRequestDeploymentPolicyTag : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Demo</para>
        /// </summary>
        [NameInMap("JobDescription")]
        [Validation(Required=false)]
        public string JobDescription { get; set; }

        /// <summary>
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

        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public CreateJobRequestSecurityPolicy SecurityPolicy { get; set; }
        public class CreateJobRequestSecurityPolicy : TeaModel {
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public CreateJobRequestSecurityPolicySecurityGroup SecurityGroup { get; set; }
            public class CreateJobRequestSecurityPolicySecurityGroup : TeaModel {
                [NameInMap("SecurityGroupIds")]
                [Validation(Required=false)]
                public List<string> SecurityGroupIds { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<CreateJobRequestTasks> Tasks { get; set; }
        public class CreateJobRequestTasks : TeaModel {
            [NameInMap("ExecutorPolicy")]
            [Validation(Required=false)]
            public CreateJobRequestTasksExecutorPolicy ExecutorPolicy { get; set; }
            public class CreateJobRequestTasksExecutorPolicy : TeaModel {
                [NameInMap("ArraySpec")]
                [Validation(Required=false)]
                public CreateJobRequestTasksExecutorPolicyArraySpec ArraySpec { get; set; }
                public class CreateJobRequestTasksExecutorPolicyArraySpec : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("IndexEnd")]
                    [Validation(Required=false)]
                    public int? IndexEnd { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IndexStart")]
                    [Validation(Required=false)]
                    public int? IndexStart { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IndexStep")]
                    [Validation(Required=false)]
                    public int? IndexStep { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxCount")]
                [Validation(Required=false)]
                public int? MaxCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task0</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskSpec")]
            [Validation(Required=false)]
            public CreateJobRequestTasksTaskSpec TaskSpec { get; set; }
            public class CreateJobRequestTasksTaskSpec : TeaModel {
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public CreateJobRequestTasksTaskSpecResource Resource { get; set; }
                public class CreateJobRequestTasksTaskSpecResource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public float? Cores { get; set; }

                    [NameInMap("Disks")]
                    [Validation(Required=false)]
                    public List<CreateJobRequestTasksTaskSpecResourceDisks> Disks { get; set; }
                    public class CreateJobRequestTasksTaskSpecResourceDisks : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>40</para>
                        /// </summary>
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>System</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public float? Memory { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("TaskExecutor")]
                [Validation(Required=false)]
                public List<CreateJobRequestTasksTaskSpecTaskExecutor> TaskExecutor { get; set; }
                public class CreateJobRequestTasksTaskSpecTaskExecutor : TeaModel {
                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public CreateJobRequestTasksTaskSpecTaskExecutorContainer Container { get; set; }
                    public class CreateJobRequestTasksTaskSpecTaskExecutorContainer : TeaModel {
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public List<string> Command { get; set; }

                        [NameInMap("EnvironmentVars")]
                        [Validation(Required=false)]
                        public List<CreateJobRequestTasksTaskSpecTaskExecutorContainerEnvironmentVars> EnvironmentVars { get; set; }
                        public class CreateJobRequestTasksTaskSpecTaskExecutorContainerEnvironmentVars : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PATH</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>/usr/local/bin</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/ehpc/hpl:latest</para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>/usr/local/</para>
                        /// </summary>
                        [NameInMap("WorkingDir")]
                        [Validation(Required=false)]
                        public string WorkingDir { get; set; }

                    }

                    [NameInMap("VM")]
                    [Validation(Required=false)]
                    public CreateJobRequestTasksTaskSpecTaskExecutorVM VM { get; set; }
                    public class CreateJobRequestTasksTaskSpecTaskExecutorVM : TeaModel {
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>m-xxxx</para>
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
                        /// </summary>
                        [NameInMap("PrologScript")]
                        [Validation(Required=false)]
                        public string PrologScript { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
                        /// </summary>
                        [NameInMap("Script")]
                        [Validation(Required=false)]
                        public string Script { get; set; }

                    }

                }

                [NameInMap("VolumeMount")]
                [Validation(Required=false)]
                public List<CreateJobRequestTasksTaskSpecVolumeMount> VolumeMount { get; set; }
                public class CreateJobRequestTasksTaskSpecVolumeMount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;server&quot;:&quot;xxxxx-xxxxx.cn-heyuan.nas.aliyuncs.com&quot;,&quot;vers&quot;:&quot;3&quot;,&quot;path&quot;:&quot;/data&quot;,&quot;options&quot;:&quot;nolock,tcp,noresvport&quot;}</para>
                    /// </summary>
                    [NameInMap("MountOptions")]
                    [Validation(Required=false)]
                    public string MountOptions { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>/mnt</para>
                    /// </summary>
                    [NameInMap("MountPath")]
                    [Validation(Required=false)]
                    public string MountPath { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>alicloud/nas</para>
                    /// </summary>
                    [NameInMap("VolumeDriver")]
                    [Validation(Required=false)]
                    public string VolumeDriver { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TaskSustainable")]
            [Validation(Required=false)]
            public bool? TaskSustainable { get; set; }

        }

    }

}
