// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResultResponseBodyData Data { get; set; }
        public class GetResultResponseBodyData : TeaModel {
            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public List<GetResultResponseBodyDataResultInfo> ResultInfo { get; set; }
            public class GetResultResponseBodyDataResultInfo : TeaModel {
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public GetResultResponseBodyDataResultInfoAgent Agent { get; set; }
                public class GetResultResponseBodyDataResultInfoAgent : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SkillGroup")]
                    [Validation(Required=false)]
                    public string SkillGroup { get; set; }

                }

                [NameInMap("AsrResult")]
                [Validation(Required=false)]
                public GetResultResponseBodyDataResultInfoAsrResult AsrResult { get; set; }
                public class GetResultResponseBodyDataResultInfoAsrResult : TeaModel {
                    [NameInMap("AsrResult")]
                    [Validation(Required=false)]
                    public List<GetResultResponseBodyDataResultInfoAsrResultAsrResult> AsrResult { get; set; }
                    public class GetResultResponseBodyDataResultInfoAsrResultAsrResult : TeaModel {
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }

                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }

                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                }

                [NameInMap("AssignmentTime")]
                [Validation(Required=false)]
                public string AssignmentTime { get; set; }

                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimeLong")]
                [Validation(Required=false)]
                public string CreateTimeLong { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("HitResult")]
                [Validation(Required=false)]
                public GetResultResponseBodyDataResultInfoHitResult HitResult { get; set; }
                public class GetResultResponseBodyDataResultInfoHitResult : TeaModel {
                    [NameInMap("HitResult")]
                    [Validation(Required=false)]
                    public List<GetResultResponseBodyDataResultInfoHitResultHitResult> HitResult { get; set; }
                    public class GetResultResponseBodyDataResultInfoHitResultHitResult : TeaModel {
                        [NameInMap("Conditions")]
                        [Validation(Required=false)]
                        public GetResultResponseBodyDataResultInfoHitResultHitResultConditions Conditions { get; set; }
                        public class GetResultResponseBodyDataResultInfoHitResultHitResultConditions : TeaModel {
                            [NameInMap("Conditions")]
                            [Validation(Required=false)]
                            public List<GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditions> Conditions { get; set; }
                            public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditions : TeaModel {
                                /// <summary>
                                /// 检测范围
                                /// </summary>
                                [NameInMap("Check_range")]
                                [Validation(Required=false)]
                                public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRange CheckRange { get; set; }
                                public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRange : TeaModel {
                                    /// <summary>
                                    /// false: 相对位置; 会结合anchor以及角色来决定句子位置
                                    /// </summary>
                                    [NameInMap("Absolute")]
                                    [Validation(Required=false)]
                                    public bool? Absolute { get; set; }

                                    /// <summary>
                                    /// true: 每句话都必须满足条件；
                                    /// </summary>
                                    [NameInMap("AllSentencesSatisfy")]
                                    [Validation(Required=false)]
                                    public bool? AllSentencesSatisfy { get; set; }

                                    /// <summary>
                                    /// 前置后置条件
                                    /// </summary>
                                    [NameInMap("Anchor")]
                                    [Validation(Required=false)]
                                    public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeAnchor Anchor { get; set; }
                                    public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeAnchor : TeaModel {
                                        /// <summary>
                                        /// 条件ID
                                        /// </summary>
                                        [NameInMap("Cid")]
                                        [Validation(Required=false)]
                                        public string Cid { get; set; }

                                        /// <summary>
                                        /// 命中次数
                                        /// </summary>
                                        [NameInMap("Hit_time")]
                                        [Validation(Required=false)]
                                        public int? HitTime { get; set; }

                                        /// <summary>
                                        /// 位置
                                        /// </summary>
                                        [NameInMap("Location")]
                                        [Validation(Required=false)]
                                        public string Location { get; set; }

                                    }

                                    /// <summary>
                                    /// 相对范围
                                    /// </summary>
                                    [NameInMap("Range")]
                                    [Validation(Required=false)]
                                    public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeRange Range { get; set; }
                                    public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeRange : TeaModel {
                                        /// <summary>
                                        /// 对话开始索引
                                        /// </summary>
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public int? From { get; set; }

                                        /// <summary>
                                        /// 对话结束索引
                                        /// </summary>
                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public int? To { get; set; }

                                    }

                                    /// <summary>
                                    /// 对应 RoleType.type
                                    /// </summary>
                                    [NameInMap("Role")]
                                    [Validation(Required=false)]
                                    public string Role { get; set; }

                                    /// <summary>
                                    /// 对应 RoleType.id
                                    /// </summary>
                                    [NameInMap("RoleId")]
                                    [Validation(Required=false)]
                                    public int? RoleId { get; set; }

                                    [NameInMap("TimeRange")]
                                    [Validation(Required=false)]
                                    public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeTimeRange TimeRange { get; set; }
                                    public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeTimeRange : TeaModel {
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public long? From { get; set; }

                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public long? To { get; set; }

                                    }

                                }

                                /// <summary>
                                /// 条件id，可能是db中的主键，也可能是转换成的a, b, c
                                /// </summary>
                                [NameInMap("Cid")]
                                [Validation(Required=false)]
                                public string Cid { get; set; }

                                /// <summary>
                                /// 排除
                                /// </summary>
                                [NameInMap("Exclusion")]
                                [Validation(Required=false)]
                                public int? Exclusion { get; set; }

                                /// <summary>
                                /// 在db中的主键
                                /// </summary>
                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public long? Id { get; set; }

                                /// <summary>
                                /// Lambda表达式：例如:a&&b
                                /// </summary>
                                [NameInMap("Lambda")]
                                [Validation(Required=false)]
                                public string Lambda { get; set; }

                                /// <summary>
                                /// 算子列表
                                /// </summary>
                                [NameInMap("Operators")]
                                [Validation(Required=false)]
                                public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperators Operators { get; set; }
                                public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperators : TeaModel {
                                    [NameInMap("Operator")]
                                    [Validation(Required=false)]
                                    public List<GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperator> Operator { get; set; }
                                    public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperator : TeaModel {
                                        /// <summary>
                                        /// 主键id
                                        /// </summary>
                                        [NameInMap("Id")]
                                        [Validation(Required=false)]
                                        public long? Id { get; set; }

                                        /// <summary>
                                        /// 算子名
                                        /// </summary>
                                        [NameInMap("Name")]
                                        [Validation(Required=false)]
                                        public string Name { get; set; }

                                        /// <summary>
                                        /// 可能是主键id，也可能是前端生成的id
                                        /// </summary>
                                        [NameInMap("Oid")]
                                        [Validation(Required=false)]
                                        public string Oid { get; set; }

                                        /// <summary>
                                        /// 算子参数
                                        /// </summary>
                                        [NameInMap("Param")]
                                        [Validation(Required=false)]
                                        public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParam Param { get; set; }
                                        public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParam : TeaModel {
                                            /// <summary>
                                            /// 语速检测，是否计算整个对话平均语速，默认false
                                            /// </summary>
                                            [NameInMap("Average")]
                                            [Validation(Required=false)]
                                            public bool? Average { get; set; }

                                            /// <summary>
                                            /// 时长算子，时长计算开始类型，录音开始，还是某句对话开始
                                            /// </summary>
                                            [NameInMap("BeginType")]
                                            [Validation(Required=false)]
                                            public string BeginType { get; set; }

                                            /// <summary>
                                            /// 区分大小写
                                            /// </summary>
                                            [NameInMap("Case_sensitive")]
                                            [Validation(Required=false)]
                                            public bool? CaseSensitive { get; set; }

                                            /// <summary>
                                            /// 静音检测：要不要检测第一句话
                                            /// </summary>
                                            [NameInMap("CheckFirstSentence")]
                                            [Validation(Required=false)]
                                            public bool? CheckFirstSentence { get; set; }

                                            /// <summary>
                                            /// 检测方式，1 相邻句能量波动 2 最大能量跨度 默认1
                                            /// </summary>
                                            [NameInMap("CheckType")]
                                            [Validation(Required=false)]
                                            public int? CheckType { get; set; }

                                            /// <summary>
                                            /// 大于，还是小于，gt/lt
                                            /// </summary>
                                            [NameInMap("CompareOperator")]
                                            [Validation(Required=false)]
                                            public string CompareOperator { get; set; }

                                            /// <summary>
                                            /// 是否单句话匹配；
                                            /// </summary>
                                            [NameInMap("ContextChatMatch")]
                                            [Validation(Required=false)]
                                            public bool? ContextChatMatch { get; set; }

                                            /// <summary>
                                            /// 抢话算子 延时时长
                                            /// </summary>
                                            [NameInMap("DelayTime")]
                                            [Validation(Required=false)]
                                            public int? DelayTime { get; set; }

                                            /// <summary>
                                            /// 时长算子，时长计算结束类型，录音结束，还是某句对话结束
                                            /// </summary>
                                            [NameInMap("EndType")]
                                            [Validation(Required=false)]
                                            public string EndType { get; set; }

                                            /// <summary>
                                            /// 上下文重复算子：排除掉某些对话
                                            /// </summary>
                                            [NameInMap("Excludes")]
                                            [Validation(Required=false)]
                                            public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamExcludes Excludes { get; set; }
                                            public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamExcludes : TeaModel {
                                                [NameInMap("Exclude")]
                                                [Validation(Required=false)]
                                                public List<string> Exclude { get; set; }

                                            }

                                            /// <summary>
                                            /// 流程节点前置条件参数
                                            /// </summary>
                                            [NameInMap("FlowNodePrerequisiteParam")]
                                            [Validation(Required=false)]
                                            public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamFlowNodePrerequisiteParam FlowNodePrerequisiteParam { get; set; }
                                            public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamFlowNodePrerequisiteParam : TeaModel {
                                                /// <summary>
                                                /// 节点id
                                                /// </summary>
                                                [NameInMap("NodeId")]
                                                [Validation(Required=false)]
                                                public long? NodeId { get; set; }

                                                /// <summary>
                                                /// 节点匹配状态。
                                                /// </summary>
                                                [NameInMap("NodeMatchStatus")]
                                                [Validation(Required=false)]
                                                public int? NodeMatchStatus { get; set; }

                                                /// <summary>
                                                /// 冗余的节点名称
                                                /// </summary>
                                                [NameInMap("NodeName")]
                                                [Validation(Required=false)]
                                                public string NodeName { get; set; }

                                            }

                                            /// <summary>
                                            /// 上下文重复算子：检测当前句的前from句是否有重复；0表示前面的所有句
                                            /// </summary>
                                            [NameInMap("From")]
                                            [Validation(Required=false)]
                                            public int? From { get; set; }

                                            /// <summary>
                                            /// from_end
                                            /// </summary>
                                            [NameInMap("From_end")]
                                            [Validation(Required=false)]
                                            public bool? FromEnd { get; set; }

                                            /// <summary>
                                            /// 上下文重复算子：重复几次
                                            /// </summary>
                                            [NameInMap("Hit_time")]
                                            [Validation(Required=false)]
                                            public int? HitTime { get; set; }

                                            /// <summary>
                                            /// 生效句子， true单个句子，false多个句子
                                            /// </summary>
                                            [NameInMap("In_sentence")]
                                            [Validation(Required=false)]
                                            public bool? InSentence { get; set; }

                                            /// <summary>
                                            /// 意图模型检查参数
                                            /// </summary>
                                            [NameInMap("IntentModelCheckParm")]
                                            [Validation(Required=false)]
                                            public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamIntentModelCheckParm IntentModelCheckParm { get; set; }
                                            public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamIntentModelCheckParm : TeaModel {
                                                /// <summary>
                                                /// 引用的意图模型
                                                /// </summary>
                                                [NameInMap("Intents")]
                                                [Validation(Required=false)]
                                                public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamIntentModelCheckParmIntents Intents { get; set; }
                                                public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamIntentModelCheckParmIntents : TeaModel {
                                                    [NameInMap("Intent")]
                                                    [Validation(Required=false)]
                                                    public List<GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamIntentModelCheckParmIntentsIntent> Intent { get; set; }
                                                    public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamIntentModelCheckParmIntentsIntent : TeaModel {
                                                        /// <summary>
                                                        /// 意图模型ID
                                                        /// </summary>
                                                        [NameInMap("Id")]
                                                        [Validation(Required=false)]
                                                        public long? Id { get; set; }

                                                        /// <summary>
                                                        /// 意图模型名称
                                                        /// </summary>
                                                        [NameInMap("Name")]
                                                        [Validation(Required=false)]
                                                        public string Name { get; set; }

                                                    }

                                                }

                                                /// <summary>
                                                /// 模型应用的场景 AGENT:客户场景、CUSTOMER:客服场景 (CUSTOMER: 客户场景, AGENT: 坐席场景)
                                                /// </summary>
                                                [NameInMap("ModelScene")]
                                                [Validation(Required=false)]
                                                public string ModelScene { get; set; }

                                            }

                                            /// <summary>
                                            /// interval代表区间范围开始
                                            /// </summary>
                                            [NameInMap("Interval")]
                                            [Validation(Required=false)]
                                            public int? Interval { get; set; }

                                            /// <summary>
                                            /// intervalEnd 代表区间范围结束
                                            /// </summary>
                                            [NameInMap("IntervalEnd")]
                                            [Validation(Required=false)]
                                            public int? IntervalEnd { get; set; }

                                            /// <summary>
                                            /// 关键字扩展
                                            /// </summary>
                                            [NameInMap("KeywordExtension")]
                                            [Validation(Required=false)]
                                            public int? KeywordExtension { get; set; }

                                            /// <summary>
                                            /// 匹配到的关键字数量
                                            /// </summary>
                                            [NameInMap("KeywordMatchSize")]
                                            [Validation(Required=false)]
                                            public int? KeywordMatchSize { get; set; }

                                            /// <summary>
                                            /// 关键词
                                            /// </summary>
                                            [NameInMap("Keywords")]
                                            [Validation(Required=false)]
                                            public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamKeywords Keywords { get; set; }
                                            public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamKeywords : TeaModel {
                                                [NameInMap("Keyword")]
                                                [Validation(Required=false)]
                                                public List<string> Keyword { get; set; }

                                            }

                                            /// <summary>
                                            /// 能量值变化，默认3, 1~9
                                            /// </summary>
                                            [NameInMap("MaxEmotionChangeValue")]
                                            [Validation(Required=false)]
                                            public int? MaxEmotionChangeValue { get; set; }

                                            /// <summary>
                                            /// 句子中最少字数，小于此字数的句子不检查
                                            /// </summary>
                                            [NameInMap("MinWordSize")]
                                            [Validation(Required=false)]
                                            public int? MinWordSize { get; set; }

                                            /// <summary>
                                            /// true表示取不同角色相邻的两句话，false表示取不同角色的第一句话比较响应时间（默认）
                                            /// </summary>
                                            [NameInMap("Near_dialogue")]
                                            [Validation(Required=false)]
                                            public bool? NearDialogue { get; set; }

                                            /// <summary>
                                            /// 排除的正则表达式
                                            /// </summary>
                                            [NameInMap("NotRegex")]
                                            [Validation(Required=false)]
                                            public string NotRegex { get; set; }

                                            /// <summary>
                                            /// 语句
                                            /// </summary>
                                            [NameInMap("Phrase")]
                                            [Validation(Required=false)]
                                            public string Phrase { get; set; }

                                            /// <summary>
                                            /// 正则表达式
                                            /// </summary>
                                            [NameInMap("Regex")]
                                            [Validation(Required=false)]
                                            public string Regex { get; set; }

                                            /// <summary>
                                            /// target
                                            /// </summary>
                                            [NameInMap("Target")]
                                            [Validation(Required=false)]
                                            public int? Target { get; set; }

                                            /// <summary>
                                            /// 阈值
                                            /// </summary>
                                            [NameInMap("Threshold")]
                                            [Validation(Required=false)]
                                            public float? Threshold { get; set; }

                                        }

                                        /// <summary>
                                        /// 算子类别
                                        /// </summary>
                                        [NameInMap("Type")]
                                        [Validation(Required=false)]
                                        public string Type { get; set; }

                                    }

                                }

                                /// <summary>
                                /// 条件所属的规则id
                                /// </summary>
                                [NameInMap("Rid")]
                                [Validation(Required=false)]
                                public string Rid { get; set; }

                            }

                        }

                        [NameInMap("Hits")]
                        [Validation(Required=false)]
                        public GetResultResponseBodyDataResultInfoHitResultHitResultHits Hits { get; set; }
                        public class GetResultResponseBodyDataResultInfoHitResultHitResultHits : TeaModel {
                            [NameInMap("Hit")]
                            [Validation(Required=false)]
                            public List<GetResultResponseBodyDataResultInfoHitResultHitResultHitsHit> Hit { get; set; }
                            public class GetResultResponseBodyDataResultInfoHitResultHitResultHitsHit : TeaModel {
                                [NameInMap("Cid")]
                                [Validation(Required=false)]
                                public GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitCid Cid { get; set; }
                                public class GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitCid : TeaModel {
                                    [NameInMap("Cid")]
                                    [Validation(Required=false)]
                                    public List<string> Cid { get; set; }

                                }

                                [NameInMap("KeyWords")]
                                [Validation(Required=false)]
                                public GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitKeyWords KeyWords { get; set; }
                                public class GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitKeyWords : TeaModel {
                                    [NameInMap("KeyWord")]
                                    [Validation(Required=false)]
                                    public List<GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitKeyWordsKeyWord> KeyWord { get; set; }
                                    public class GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitKeyWordsKeyWord : TeaModel {
                                        [NameInMap("Cid")]
                                        [Validation(Required=false)]
                                        public string Cid { get; set; }

                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public int? From { get; set; }

                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public int? To { get; set; }

                                        [NameInMap("Val")]
                                        [Validation(Required=false)]
                                        public string Val { get; set; }

                                    }

                                }

                                [NameInMap("Phrase")]
                                [Validation(Required=false)]
                                public GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitPhrase Phrase { get; set; }
                                public class GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitPhrase : TeaModel {
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

                                    [NameInMap("Words")]
                                    [Validation(Required=false)]
                                    public string Words { get; set; }

                                }

                            }

                        }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("ReviewResult")]
                        [Validation(Required=false)]
                        public int? ReviewResult { get; set; }

                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public string Rid { get; set; }

                        [NameInMap("SchemeId")]
                        [Validation(Required=false)]
                        public long? SchemeId { get; set; }

                        [NameInMap("SchemeVersion")]
                        [Validation(Required=false)]
                        public long? SchemeVersion { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("HitScore")]
                [Validation(Required=false)]
                public GetResultResponseBodyDataResultInfoHitScore HitScore { get; set; }
                public class GetResultResponseBodyDataResultInfoHitScore : TeaModel {
                    [NameInMap("HitScore")]
                    [Validation(Required=false)]
                    public List<GetResultResponseBodyDataResultInfoHitScoreHitScore> HitScore { get; set; }
                    public class GetResultResponseBodyDataResultInfoHitScoreHitScore : TeaModel {
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                        [NameInMap("ScoreId")]
                        [Validation(Required=false)]
                        public string ScoreId { get; set; }

                        [NameInMap("ScoreName")]
                        [Validation(Required=false)]
                        public string ScoreName { get; set; }

                        [NameInMap("ScoreNumber")]
                        [Validation(Required=false)]
                        public string ScoreNumber { get; set; }

                    }

                }

                [NameInMap("LastDataId")]
                [Validation(Required=false)]
                public string LastDataId { get; set; }

                [NameInMap("Recording")]
                [Validation(Required=false)]
                public GetResultResponseBodyDataResultInfoRecording Recording { get; set; }
                public class GetResultResponseBodyDataResultInfoRecording : TeaModel {
                    [NameInMap("Business")]
                    [Validation(Required=false)]
                    public string Business { get; set; }

                    [NameInMap("CallId")]
                    [Validation(Required=false)]
                    public string CallId { get; set; }

                    [NameInMap("CallTime")]
                    [Validation(Required=false)]
                    public string CallTime { get; set; }

                    [NameInMap("CallType")]
                    [Validation(Required=false)]
                    public int? CallType { get; set; }

                    [NameInMap("Callee")]
                    [Validation(Required=false)]
                    public string Callee { get; set; }

                    [NameInMap("Caller")]
                    [Validation(Required=false)]
                    public string Caller { get; set; }

                    [NameInMap("DataSetName")]
                    [Validation(Required=false)]
                    public string DataSetName { get; set; }

                    [NameInMap("DialogueSize")]
                    [Validation(Required=false)]
                    public int? DialogueSize { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("PrimaryId")]
                    [Validation(Required=false)]
                    public string PrimaryId { get; set; }

                    [NameInMap("Remark1")]
                    [Validation(Required=false)]
                    public string Remark1 { get; set; }

                    [NameInMap("Remark10")]
                    [Validation(Required=false)]
                    public string Remark10 { get; set; }

                    [NameInMap("Remark11")]
                    [Validation(Required=false)]
                    public string Remark11 { get; set; }

                    [NameInMap("Remark12")]
                    [Validation(Required=false)]
                    public string Remark12 { get; set; }

                    [NameInMap("Remark13")]
                    [Validation(Required=false)]
                    public string Remark13 { get; set; }

                    [NameInMap("Remark2")]
                    [Validation(Required=false)]
                    public string Remark2 { get; set; }

                    [NameInMap("Remark3")]
                    [Validation(Required=false)]
                    public string Remark3 { get; set; }

                    [NameInMap("Remark4")]
                    [Validation(Required=false)]
                    public string Remark4 { get; set; }

                    [NameInMap("Remark5")]
                    [Validation(Required=false)]
                    public long? Remark5 { get; set; }

                    [NameInMap("Remark6")]
                    [Validation(Required=false)]
                    public string Remark6 { get; set; }

                    [NameInMap("Remark7")]
                    [Validation(Required=false)]
                    public string Remark7 { get; set; }

                    [NameInMap("Remark8")]
                    [Validation(Required=false)]
                    public string Remark8 { get; set; }

                    [NameInMap("Remark9")]
                    [Validation(Required=false)]
                    public string Remark9 { get; set; }

                    [NameInMap("TaskConfigId")]
                    [Validation(Required=false)]
                    public long? TaskConfigId { get; set; }

                    [NameInMap("TaskConfigName")]
                    [Validation(Required=false)]
                    public string TaskConfigName { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("Resolver")]
                [Validation(Required=false)]
                public string Resolver { get; set; }

                [NameInMap("ReviewHistoryList")]
                [Validation(Required=false)]
                public GetResultResponseBodyDataResultInfoReviewHistoryList ReviewHistoryList { get; set; }
                public class GetResultResponseBodyDataResultInfoReviewHistoryList : TeaModel {
                    [NameInMap("ReviewHistory")]
                    [Validation(Required=false)]
                    public List<GetResultResponseBodyDataResultInfoReviewHistoryListReviewHistory> ReviewHistory { get; set; }
                    public class GetResultResponseBodyDataResultInfoReviewHistoryListReviewHistory : TeaModel {
                        [NameInMap("Comments")]
                        [Validation(Required=false)]
                        public string Comments { get; set; }

                        [NameInMap("ComplainResult")]
                        [Validation(Required=false)]
                        public int? ComplainResult { get; set; }

                        [NameInMap("OldScore")]
                        [Validation(Required=false)]
                        public int? OldScore { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public long? Operator { get; set; }

                        [NameInMap("OperatorName")]
                        [Validation(Required=false)]
                        public string OperatorName { get; set; }

                        [NameInMap("ReviewManagerType")]
                        [Validation(Required=false)]
                        public string ReviewManagerType { get; set; }

                        [NameInMap("ReviewResult")]
                        [Validation(Required=false)]
                        public int? ReviewResult { get; set; }

                        [NameInMap("ReviewRightRule")]
                        [Validation(Required=false)]
                        public GetResultResponseBodyDataResultInfoReviewHistoryListReviewHistoryReviewRightRule ReviewRightRule { get; set; }
                        public class GetResultResponseBodyDataResultInfoReviewHistoryListReviewHistoryReviewRightRule : TeaModel {
                            [NameInMap("Rid")]
                            [Validation(Required=false)]
                            public long? Rid { get; set; }

                            [NameInMap("RuleName")]
                            [Validation(Required=false)]
                            public string RuleName { get; set; }

                        }

                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public int? Score { get; set; }

                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("TimeStr")]
                        [Validation(Required=false)]
                        public string TimeStr { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                }

                [NameInMap("ReviewResult")]
                [Validation(Required=false)]
                public int? ReviewResult { get; set; }

                [NameInMap("ReviewStatus")]
                [Validation(Required=false)]
                public int? ReviewStatus { get; set; }

                [NameInMap("ReviewTime")]
                [Validation(Required=false)]
                public string ReviewTime { get; set; }

                [NameInMap("ReviewTimeLong")]
                [Validation(Required=false)]
                public string ReviewTimeLong { get; set; }

                [NameInMap("ReviewType")]
                [Validation(Required=false)]
                public int? ReviewType { get; set; }

                [NameInMap("ReviewTypeIdList")]
                [Validation(Required=false)]
                public GetResultResponseBodyDataResultInfoReviewTypeIdList ReviewTypeIdList { get; set; }
                public class GetResultResponseBodyDataResultInfoReviewTypeIdList : TeaModel {
                    [NameInMap("ReviewTypeIdList")]
                    [Validation(Required=false)]
                    public List<GetResultResponseBodyDataResultInfoReviewTypeIdListReviewTypeIdList> ReviewTypeIdList { get; set; }
                    public class GetResultResponseBodyDataResultInfoReviewTypeIdListReviewTypeIdList : TeaModel {
                        [NameInMap("ReviewKeyIdList")]
                        [Validation(Required=false)]
                        public GetResultResponseBodyDataResultInfoReviewTypeIdListReviewTypeIdListReviewKeyIdList ReviewKeyIdList { get; set; }
                        public class GetResultResponseBodyDataResultInfoReviewTypeIdListReviewTypeIdListReviewKeyIdList : TeaModel {
                            [NameInMap("ReviewKeyIdList")]
                            [Validation(Required=false)]
                            public List<long?> ReviewKeyIdList { get; set; }

                        }

                        [NameInMap("ReviewTypeId")]
                        [Validation(Required=false)]
                        public long? ReviewTypeId { get; set; }

                    }

                }

                [NameInMap("Reviewer")]
                [Validation(Required=false)]
                public string Reviewer { get; set; }

                [NameInMap("SchemeIdList")]
                [Validation(Required=false)]
                public GetResultResponseBodyDataResultInfoSchemeIdList SchemeIdList { get; set; }
                public class GetResultResponseBodyDataResultInfoSchemeIdList : TeaModel {
                    [NameInMap("SchemeIdList")]
                    [Validation(Required=false)]
                    public List<long?> SchemeIdList { get; set; }

                }

                [NameInMap("SchemeNameList")]
                [Validation(Required=false)]
                public GetResultResponseBodyDataResultInfoSchemeNameList SchemeNameList { get; set; }
                public class GetResultResponseBodyDataResultInfoSchemeNameList : TeaModel {
                    [NameInMap("SchemeNameList")]
                    [Validation(Required=false)]
                    public List<string> SchemeNameList { get; set; }

                }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
