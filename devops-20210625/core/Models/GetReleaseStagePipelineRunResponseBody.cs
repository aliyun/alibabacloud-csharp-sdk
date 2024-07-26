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
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }

            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }

            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }

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
                    [NameInMap("branch")]
                    [Validation(Required=false)]
                    public string Branch { get; set; }

                    [NameInMap("commit")]
                    [Validation(Required=false)]
                    public string Commit { get; set; }

                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                }

                [NameInMap("sign")]
                [Validation(Required=false)]
                public string Sign { get; set; }

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
                            [NameInMap("disable")]
                            [Validation(Required=false)]
                            public bool? Disable { get; set; }

                            [NameInMap("params")]
                            [Validation(Required=false)]
                            public object Params { get; set; }

                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public string Params { get; set; }

                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public int? TriggerMode { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

    }

}
