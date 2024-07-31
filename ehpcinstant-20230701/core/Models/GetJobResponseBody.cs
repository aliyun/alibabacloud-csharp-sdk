// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetJobResponseBody : TeaModel {
        [NameInMap("JobInfo")]
        [Validation(Required=false)]
        public GetJobResponseBodyJobInfo JobInfo { get; set; }
        public class GetJobResponseBodyJobInfo : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeploymentPolicy")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoDeploymentPolicy DeploymentPolicy { get; set; }
            public class GetJobResponseBodyJobInfoDeploymentPolicy : TeaModel {
                [NameInMap("AllocationSpec")]
                [Validation(Required=false)]
                public string AllocationSpec { get; set; }

                [NameInMap("Network")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoDeploymentPolicyNetwork Network { get; set; }
                public class GetJobResponseBodyJobInfoDeploymentPolicyNetwork : TeaModel {
                    [NameInMap("Vswitch")]
                    [Validation(Required=false)]
                    public List<string> Vswitch { get; set; }

                }

            }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("JobScheduler")]
            [Validation(Required=false)]
            public string JobScheduler { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tasks")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobInfoTasks> Tasks { get; set; }
            public class GetJobResponseBodyJobInfoTasks : TeaModel {
                [NameInMap("ExecutorPolicy")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoTasksExecutorPolicy ExecutorPolicy { get; set; }
                public class GetJobResponseBodyJobInfoTasksExecutorPolicy : TeaModel {
                    [NameInMap("ArraySpec")]
                    [Validation(Required=false)]
                    public GetJobResponseBodyJobInfoTasksExecutorPolicyArraySpec ArraySpec { get; set; }
                    public class GetJobResponseBodyJobInfoTasksExecutorPolicyArraySpec : TeaModel {
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

                [NameInMap("ExecutorStatus")]
                [Validation(Required=false)]
                public List<GetJobResponseBodyJobInfoTasksExecutorStatus> ExecutorStatus { get; set; }
                public class GetJobResponseBodyJobInfoTasksExecutorStatus : TeaModel {
                    [NameInMap("ArrayId")]
                    [Validation(Required=false)]
                    public int? ArrayId { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StatusReason")]
                    [Validation(Required=false)]
                    public string StatusReason { get; set; }

                }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TaskSpec")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoTasksTaskSpec TaskSpec { get; set; }
                public class GetJobResponseBodyJobInfoTasksTaskSpec : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public GetJobResponseBodyJobInfoTasksTaskSpecResource Resource { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecResource : TeaModel {
                        [NameInMap("Cores")]
                        [Validation(Required=false)]
                        public float? Cores { get; set; }

                        [NameInMap("Disks")]
                        [Validation(Required=false)]
                        public List<GetJobResponseBodyJobInfoTasksTaskSpecResourceDisks> Disks { get; set; }
                        public class GetJobResponseBodyJobInfoTasksTaskSpecResourceDisks : TeaModel {
                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public int? Size { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public int? Memory { get; set; }

                    }

                    [NameInMap("TaskExecutor")]
                    [Validation(Required=false)]
                    public List<GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutor> TaskExecutor { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutor : TeaModel {
                        [NameInMap("VM")]
                        [Validation(Required=false)]
                        public GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutorVM VM { get; set; }
                        public class GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutorVM : TeaModel {
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

                }

                [NameInMap("TaskSustainable")]
                [Validation(Required=false)]
                public bool? TaskSustainable { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
