// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetPipelineRunResponseBody : TeaModel {
        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 流水线运行实例
        /// </summary>
        [NameInMap("pipelineRun")]
        [Validation(Required=false)]
        public GetPipelineRunResponseBodyPipelineRun PipelineRun { get; set; }
        public class GetPipelineRunResponseBodyPipelineRun : TeaModel {
            [NameInMap("creatorAccountId")]
            [Validation(Required=false)]
            public string CreatorAccountId { get; set; }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }
            [NameInMap("pipelineRunId")]
            [Validation(Required=false)]
            public long? PipelineRunId { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public int? TriggerMode { get; set; }
            [NameInMap("stageGroup")]
            [Validation(Required=false)]
            public List<string> StageGroup { get; set; }
            [NameInMap("sources")]
            [Validation(Required=false)]
            public List<GetPipelineRunResponseBodyPipelineRunSources> Sources { get; set; }
            public class GetPipelineRunResponseBodyPipelineRunSources : TeaModel {
                public string Sign { get; set; }
                public string Type { get; set; }
                public GetPipelineRunResponseBodyPipelineRunSourcesData Data { get; set; }
                public class GetPipelineRunResponseBodyPipelineRunSourcesData : TeaModel {
                    /// <summary>
                    /// 分支
                    /// </summary>
                    [NameInMap("branch")]
                    [Validation(Required=false)]
                    public string Branch { get; set; }

                    /// <summary>
                    /// 提交信息 json数据
                    /// </summary>
                    [NameInMap("commint")]
                    [Validation(Required=false)]
                    public string Commint { get; set; }

                    /// <summary>
                    /// 代码库地址
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                }
            }
            [NameInMap("stages")]
            [Validation(Required=false)]
            public List<GetPipelineRunResponseBodyPipelineRunStages> Stages { get; set; }
            public class GetPipelineRunResponseBodyPipelineRunStages : TeaModel {
                public string Name { get; set; }
                public GetPipelineRunResponseBodyPipelineRunStagesStageInfo StageInfo { get; set; }
                public class GetPipelineRunResponseBodyPipelineRunStagesStageInfo : TeaModel {
                    /// <summary>
                    /// 结束时间
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// 开始时间
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// 阶段名称
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 状态
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// 任务
                    /// </summary>
                    [NameInMap("jobs")]
                    [Validation(Required=false)]
                    public List<GetPipelineRunResponseBodyPipelineRunStagesStageInfoJobs> Jobs { get; set; }
                    public class GetPipelineRunResponseBodyPipelineRunStagesStageInfoJobs : TeaModel {
                        /// <summary>
                        /// 结束时间
                        /// </summary>
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        /// <summary>
                        /// 任务Id
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// 任务名称
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// 触发参数
                        /// </summary>
                        [NameInMap("params")]
                        [Validation(Required=false)]
                        public string Params { get; set; }

                        /// <summary>
                        /// 状态
                        /// </summary>
                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// 开始时间
                        /// </summary>
                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                    }

                }
            }
        };

        /// <summary>
        /// true 接口调用成功，false 接口调用失败
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public bool? ErrorCode { get; set; }

    }

}
