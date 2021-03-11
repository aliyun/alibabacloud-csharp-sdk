// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResultResponseBodyData Data { get; set; }
        public class GetResultResponseBodyData : TeaModel {
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public List<GetResultResponseBodyDataResultInfo> ResultInfo { get; set; }
            public class GetResultResponseBodyDataResultInfo : TeaModel {
                public int? Status { get; set; }
                public string AssignmentTime { get; set; }
                public string LastDataId { get; set; }
                public string ErrorMessage { get; set; }
                public int? ReviewStatus { get; set; }
                public string CreateTime { get; set; }
                public string Reviewer { get; set; }
                public string TaskName { get; set; }
                public string ReviewTimeLong { get; set; }
                public int? Score { get; set; }
                public int? ReviewResult { get; set; }
                public GetResultResponseBodyDataResultInfoAgent Agent { get; set; }
                public class GetResultResponseBodyDataResultInfoAgent : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SkillGroup")]
                    [Validation(Required=false)]
                    public string SkillGroup { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                }
                public string CreateTimeLong { get; set; }
                public GetResultResponseBodyDataResultInfoAsrResult AsrResult { get; set; }
                public class GetResultResponseBodyDataResultInfoAsrResult : TeaModel {
                    [NameInMap("AsrResult")]
                    [Validation(Required=false)]
                    public List<GetResultResponseBodyDataResultInfoAsrResultAsrResult> AsrResult { get; set; }
                    public class GetResultResponseBodyDataResultInfoAsrResultAsrResult : TeaModel {
                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }

                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                    }

                }
                public string ReviewTime { get; set; }
                public GetResultResponseBodyDataResultInfoHitScore HitScore { get; set; }
                public class GetResultResponseBodyDataResultInfoHitScore : TeaModel {
                    [NameInMap("HitScore")]
                    [Validation(Required=false)]
                    public List<GetResultResponseBodyDataResultInfoHitScoreHitScore> HitScore { get; set; }
                    public class GetResultResponseBodyDataResultInfoHitScoreHitScore : TeaModel {
                        [NameInMap("ScoreName")]
                        [Validation(Required=false)]
                        public string ScoreName { get; set; }

                        [NameInMap("ScoreNumber")]
                        [Validation(Required=false)]
                        public string ScoreNumber { get; set; }

                        [NameInMap("ScoreId")]
                        [Validation(Required=false)]
                        public string ScoreId { get; set; }

                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                    }

                }
                public string Comments { get; set; }
                public GetResultResponseBodyDataResultInfoHitResult HitResult { get; set; }
                public class GetResultResponseBodyDataResultInfoHitResult : TeaModel {
                    [NameInMap("HitResult")]
                    [Validation(Required=false)]
                    public List<GetResultResponseBodyDataResultInfoHitResultHitResult> HitResult { get; set; }
                    public class GetResultResponseBodyDataResultInfoHitResultHitResult : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Hits")]
                        [Validation(Required=false)]
                        public GetResultResponseBodyDataResultInfoHitResultHitResultHits Hits { get; set; }
                        public class GetResultResponseBodyDataResultInfoHitResultHitResultHits : TeaModel {
                            [NameInMap("Hit")]
                            [Validation(Required=false)]
                            public List<GetResultResponseBodyDataResultInfoHitResultHitResultHitsHit> Hit { get; set; }
                            public class GetResultResponseBodyDataResultInfoHitResultHitResultHitsHit : TeaModel {
                                [NameInMap("Words")]
                                [Validation(Required=false)]
                                public string Words { get; set; }

                                [NameInMap("Begin")]
                                [Validation(Required=false)]
                                public long? Begin { get; set; }

                                [NameInMap("EmotionValue")]
                                [Validation(Required=false)]
                                public int? EmotionValue { get; set; }

                                [NameInMap("End")]
                                [Validation(Required=false)]
                                public int? End { get; set; }

                                [NameInMap("Role")]
                                [Validation(Required=false)]
                                public string Role { get; set; }

                            }
                        };

                        [NameInMap("ReviewResult")]
                        [Validation(Required=false)]
                        public int? ReviewResult { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public string Rid { get; set; }

                    }

                }
                public GetResultResponseBodyDataResultInfoRecording Recording { get; set; }
                public class GetResultResponseBodyDataResultInfoRecording : TeaModel {
                    [NameInMap("Remark13")]
                    [Validation(Required=false)]
                    public string Remark13 { get; set; }

                    [NameInMap("Callee")]
                    [Validation(Required=false)]
                    public string Callee { get; set; }

                    [NameInMap("PrimaryId")]
                    [Validation(Required=false)]
                    public string PrimaryId { get; set; }

                    [NameInMap("Remark12")]
                    [Validation(Required=false)]
                    public string Remark12 { get; set; }

                    [NameInMap("Remark1")]
                    [Validation(Required=false)]
                    public string Remark1 { get; set; }

                    [NameInMap("Remark7")]
                    [Validation(Required=false)]
                    public string Remark7 { get; set; }

                    [NameInMap("Remark8")]
                    [Validation(Required=false)]
                    public string Remark8 { get; set; }

                    [NameInMap("Remark2")]
                    [Validation(Required=false)]
                    public string Remark2 { get; set; }

                    [NameInMap("CallId")]
                    [Validation(Required=false)]
                    public string CallId { get; set; }

                    [NameInMap("Remark9")]
                    [Validation(Required=false)]
                    public string Remark9 { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Remark6")]
                    [Validation(Required=false)]
                    public string Remark6 { get; set; }

                    [NameInMap("Remark10")]
                    [Validation(Required=false)]
                    public string Remark10 { get; set; }

                    [NameInMap("Remark3")]
                    [Validation(Required=false)]
                    public string Remark3 { get; set; }

                    [NameInMap("Business")]
                    [Validation(Required=false)]
                    public string Business { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("Remark11")]
                    [Validation(Required=false)]
                    public string Remark11 { get; set; }

                    [NameInMap("Remark4")]
                    [Validation(Required=false)]
                    public string Remark4 { get; set; }

                    [NameInMap("CallType")]
                    [Validation(Required=false)]
                    public int? CallType { get; set; }

                    [NameInMap("Caller")]
                    [Validation(Required=false)]
                    public string Caller { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    [NameInMap("DataSetName")]
                    [Validation(Required=false)]
                    public string DataSetName { get; set; }

                    [NameInMap("Remark5")]
                    [Validation(Required=false)]
                    public long? Remark5 { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("CallTime")]
                    [Validation(Required=false)]
                    public string CallTime { get; set; }

                }
                public string TaskId { get; set; }
                public int? ReviewType { get; set; }
                public string Resolver { get; set; }
            }
        };

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

    }

}
