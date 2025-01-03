// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetReleaseStagePipelineRunResponseBody : TeaModel {
        [NameInMap("pipelineRun")]
        [Validation(Required=false)]
        public GetReleaseStagePipelineRunResponseBodyPipelineRun PipelineRun { get; set; }
        public class GetReleaseStagePipelineRunResponseBodyPipelineRun : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1586863220000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111111111</para>
            /// </summary>
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11111111111</para>
            /// </summary>
            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pipelineRunId")]
            [Validation(Required=false)]
            public long? PipelineRunId { get; set; }

            [NameInMap("sources")]
            [Validation(Required=false)]
            public List<GetReleaseStagePipelineRunResponseBodyPipelineRunSources> Sources { get; set; }
            public class GetReleaseStagePipelineRunResponseBodyPipelineRunSources : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public GetReleaseStagePipelineRunResponseBodyPipelineRunSourcesData Data { get; set; }
                public class GetReleaseStagePipelineRunResponseBodyPipelineRunSourcesData : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>master</para>
                    /// </summary>
                    [NameInMap("branch")]
                    [Validation(Required=false)]
                    public string Branch { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("commit")]
                    [Validation(Required=false)]
                    public string Commit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://codeup.aliyun.com/a.git">http://codeup.aliyun.com/a.git</a></para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>assaaaaaasasasa</para>
                /// </summary>
                [NameInMap("sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Codeup</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("stageGroup")]
            [Validation(Required=false)]
            public List<List<string>> StageGroup { get; set; }

            [NameInMap("stages")]
            [Validation(Required=false)]
            public List<GetReleaseStagePipelineRunResponseBodyPipelineRunStages> Stages { get; set; }
            public class GetReleaseStagePipelineRunResponseBodyPipelineRunStages : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("stageInfo")]
                [Validation(Required=false)]
                public GetReleaseStagePipelineRunResponseBodyPipelineRunStagesStageInfo StageInfo { get; set; }
                public class GetReleaseStagePipelineRunResponseBodyPipelineRunStagesStageInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1586863220000</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("jobs")]
                    [Validation(Required=false)]
                    public List<GetReleaseStagePipelineRunResponseBodyPipelineRunStagesStageInfoJobs> Jobs { get; set; }
                    public class GetReleaseStagePipelineRunResponseBodyPipelineRunStagesStageInfoJobs : TeaModel {
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<GetReleaseStagePipelineRunResponseBodyPipelineRunStagesStageInfoJobsActions> Actions { get; set; }
                        public class GetReleaseStagePipelineRunResponseBodyPipelineRunStagesStageInfoJobsActions : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("disable")]
                            [Validation(Required=false)]
                            public bool? Disable { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public object Params { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PassPipelineValidate</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1586863220000</para>
                        /// </summary>
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>21212</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public string Params { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1586863220000</para>
                        /// </summary>
                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>RUNNING</para>
                        /// </summary>
                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1586863220000</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RUNNING</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public int? TriggerMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1586863220000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
