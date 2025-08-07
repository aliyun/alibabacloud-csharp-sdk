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
            [NameInMap("AppExtraInfo")]
            [Validation(Required=false)]
            public string AppExtraInfo { get; set; }

            /// <summary>
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

            [NameInMap("DeploymentPolicy")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoDeploymentPolicy DeploymentPolicy { get; set; }
            public class GetJobResponseBodyJobInfoDeploymentPolicy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Dedicated</para>
                /// </summary>
                [NameInMap("AllocationSpec")]
                [Validation(Required=false)]
                public string AllocationSpec { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Network")]
                [Validation(Required=false)]
                public GetJobResponseBodyJobInfoDeploymentPolicyNetwork Network { get; set; }
                public class GetJobResponseBodyJobInfoDeploymentPolicyNetwork : TeaModel {
                    [NameInMap("EnableENIMapping")]
                    [Validation(Required=false)]
                    public bool? EnableENIMapping { get; set; }

                    [NameInMap("EnableExternalIpAddress")]
                    [Validation(Required=false)]
                    public bool? EnableExternalIpAddress { get; set; }

                    [NameInMap("Vswitch")]
                    [Validation(Required=false)]
                    public List<string> Vswitch { get; set; }

                }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetJobResponseBodyJobInfoDeploymentPolicyTags> Tags { get; set; }
                public class GetJobResponseBodyJobInfoDeploymentPolicyTags : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-05 20:01:48</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Demo</para>
            /// </summary>
            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-xxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>2024-03-05 20:00:48</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeed</para>
            /// </summary>
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
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxCount")]
                    [Validation(Required=false)]
                    public int? MaxCount { get; set; }

                }

                [NameInMap("ExecutorStatus")]
                [Validation(Required=false)]
                public List<GetJobResponseBodyJobInfoTasksExecutorStatus> ExecutorStatus { get; set; }
                public class GetJobResponseBodyJobInfoTasksExecutorStatus : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ArrayId")]
                    [Validation(Required=false)]
                    public int? ArrayId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-02-04 13:54:10</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-02-04 13:54:10</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-02-04 13:54:10</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Running</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Creating executor</para>
                    /// </summary>
                    [NameInMap("StatusReason")]
                    [Validation(Required=false)]
                    public string StatusReason { get; set; }

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
                public GetJobResponseBodyJobInfoTasksTaskSpec TaskSpec { get; set; }
                public class GetJobResponseBodyJobInfoTasksTaskSpec : TeaModel {
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public GetJobResponseBodyJobInfoTasksTaskSpecResource Resource { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecResource : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Cores")]
                        [Validation(Required=false)]
                        public float? Cores { get; set; }

                        [NameInMap("Disks")]
                        [Validation(Required=false)]
                        public List<GetJobResponseBodyJobInfoTasksTaskSpecResourceDisks> Disks { get; set; }
                        public class GetJobResponseBodyJobInfoTasksTaskSpecResourceDisks : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>100</para>
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

                        [NameInMap("InstanceTypes")]
                        [Validation(Required=false)]
                        public List<string> InstanceTypes { get; set; }

                        /// <summary>
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

                    [NameInMap("TaskExecutor")]
                    [Validation(Required=false)]
                    public List<GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutor> TaskExecutor { get; set; }
                    public class GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutor : TeaModel {
                        [NameInMap("VM")]
                        [Validation(Required=false)]
                        public GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutorVM VM { get; set; }
                        public class GetJobResponseBodyJobInfoTasksTaskSpecTaskExecutorVM : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>m-xxxx</para>
                            /// </summary>
                            [NameInMap("Image")]
                            [Validation(Required=false)]
                            public string Image { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>ZWNobyAiMTIzNCIgPiBgZGF0ZSArJXNg</para>
                            /// </summary>
                            [NameInMap("PrologScript")]
                            [Validation(Required=false)]
                            public string PrologScript { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>ZWNobyAiMTIzNCIgPiBgZGF0ZSArJXNg</para>
                            /// </summary>
                            [NameInMap("Script")]
                            [Validation(Required=false)]
                            public string Script { get; set; }

                        }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
