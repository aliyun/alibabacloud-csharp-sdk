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
            [NameInMap("AllocationSpec")]
            [Validation(Required=false)]
            public string AllocationSpec { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public CreateJobRequestDeploymentPolicyNetwork Network { get; set; }
            public class CreateJobRequestDeploymentPolicyNetwork : TeaModel {
                [NameInMap("Vswitch")]
                [Validation(Required=false)]
                public List<string> Vswitch { get; set; }

            }

        }

        [NameInMap("JobDescription")]
        [Validation(Required=false)]
        public string JobDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("JobScheduler")]
        [Validation(Required=false)]
        public string JobScheduler { get; set; }

        /// <summary>
        /// This parameter is required.
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
                    [NameInMap("IndexEnd")]
                    [Validation(Required=false)]
                    public int? IndexEnd { get; set; }

                    [NameInMap("IndexStart")]
                    [Validation(Required=false)]
                    public int? IndexStart { get; set; }

                    [NameInMap("IndexStep")]
                    [Validation(Required=false)]
                    public int? IndexStep { get; set; }

                }

                [NameInMap("MaxCount")]
                [Validation(Required=false)]
                public int? MaxCount { get; set; }

            }

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
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public float? Cores { get; set; }

                    [NameInMap("Disks")]
                    [Validation(Required=false)]
                    public List<CreateJobRequestTasksTaskSpecResourceDisks> Disks { get; set; }
                    public class CreateJobRequestTasksTaskSpecResourceDisks : TeaModel {
                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public int? Size { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public float? Memory { get; set; }

                }

                /// <summary>
                /// This parameter is required.
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
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

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
                        /// This parameter is required.
                        /// </summary>
                        [NameInMap("Image")]
                        [Validation(Required=false)]
                        public string Image { get; set; }

                        [NameInMap("PrologScript")]
                        [Validation(Required=false)]
                        public string PrologScript { get; set; }

                        [NameInMap("Script")]
                        [Validation(Required=false)]
                        public string Script { get; set; }

                    }

                }

                [NameInMap("VolumeMount")]
                [Validation(Required=false)]
                public List<CreateJobRequestTasksTaskSpecVolumeMount> VolumeMount { get; set; }
                public class CreateJobRequestTasksTaskSpecVolumeMount : TeaModel {
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

            [NameInMap("TaskSustainable")]
            [Validation(Required=false)]
            public bool? TaskSustainable { get; set; }

        }

    }

}
