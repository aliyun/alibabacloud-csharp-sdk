// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetPipelineRunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("pipelineRun")]
        [Validation(Required=false)]
        public GetPipelineRunResponseBodyPipelineRun PipelineRun { get; set; }
        public class GetPipelineRunResponseBodyPipelineRun : TeaModel {
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
            public List<GetPipelineRunResponseBodyPipelineRunSources> Sources { get; set; }
            public class GetPipelineRunResponseBodyPipelineRunSources : TeaModel {
                [NameInMap("data")]
                [Validation(Required=false)]
                public GetPipelineRunResponseBodyPipelineRunSourcesData Data { get; set; }
                public class GetPipelineRunResponseBodyPipelineRunSourcesData : TeaModel {
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
                    [NameInMap("commint")]
                    [Validation(Required=false)]
                    public string Commint { get; set; }

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
            public List<GetPipelineRunResponseBodyPipelineRunStages> Stages { get; set; }
            public class GetPipelineRunResponseBodyPipelineRunStages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Java构建</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("stageInfo")]
                [Validation(Required=false)]
                public GetPipelineRunResponseBodyPipelineRunStagesStageInfo StageInfo { get; set; }
                public class GetPipelineRunResponseBodyPipelineRunStagesStageInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1586863220000</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("jobs")]
                    [Validation(Required=false)]
                    public List<GetPipelineRunResponseBodyPipelineRunStagesStageInfoJobs> Jobs { get; set; }
                    public class GetPipelineRunResponseBodyPipelineRunStagesStageInfoJobs : TeaModel {
                        [NameInMap("actions")]
                        [Validation(Required=false)]
                        public List<GetPipelineRunResponseBodyPipelineRunStagesStageInfoJobsActions> Actions { get; set; }
                        public class GetPipelineRunResponseBodyPipelineRunStagesStageInfoJobsActions : TeaModel {
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
                            public Dictionary<string, object> Params { get; set; }

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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>java构建</para>
                        /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Java构建</para>
                    /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
