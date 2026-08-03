// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachDebugResultResponseBody : TeaModel {
        [NameInMap("aliyunSubId")]
        [Validation(Required=false)]
        public string AliyunSubId { get; set; }

        [NameInMap("dataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public long? DataType { get; set; }

        [NameInMap("dialogueList")]
        [Validation(Required=false)]
        public List<GetAICoachDebugResultResponseBodyDialogueList> DialogueList { get; set; }
        public class GetAICoachDebugResultResponseBodyDialogueList : TeaModel {
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scriptDebugId")]
        [Validation(Required=false)]
        public string ScriptDebugId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("taskReport")]
        [Validation(Required=false)]
        public GetAICoachDebugResultResponseBodyTaskReport TaskReport { get; set; }
        public class GetAICoachDebugResultResponseBodyTaskReport : TeaModel {
            [NameInMap("deductionRule")]
            [Validation(Required=false)]
            public GetAICoachDebugResultResponseBodyTaskReportDeductionRule DeductionRule { get; set; }
            public class GetAICoachDebugResultResponseBodyTaskReportDeductionRule : TeaModel {
                [NameInMap("hit")]
                [Validation(Required=false)]
                public bool? Hit { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("reason")]
                [Validation(Required=false)]
                public List<string> Reason { get; set; }

            }

            [NameInMap("expressiveness")]
            [Validation(Required=false)]
            public GetAICoachDebugResultResponseBodyTaskReportExpressiveness Expressiveness { get; set; }
            public class GetAICoachDebugResultResponseBodyTaskReportExpressiveness : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("reason")]
                [Validation(Required=false)]
                public List<string> Reason { get; set; }

                [NameInMap("scoreRounds")]
                [Validation(Required=false)]
                public int? ScoreRounds { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("totalRounds")]
                [Validation(Required=false)]
                public int? TotalRounds { get; set; }

            }

            [NameInMap("point")]
            [Validation(Required=false)]
            public GetAICoachDebugResultResponseBodyTaskReportPoint Point { get; set; }
            public class GetAICoachDebugResultResponseBodyTaskReportPoint : TeaModel {
                [NameInMap("answerList")]
                [Validation(Required=false)]
                public List<GetAICoachDebugResultResponseBodyTaskReportPointAnswerList> AnswerList { get; set; }
                public class GetAICoachDebugResultResponseBodyTaskReportPointAnswerList : TeaModel {
                    [NameInMap("reason")]
                    [Validation(Required=false)]
                    public List<string> Reason { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
