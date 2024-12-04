// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>28240****15643</para>
                    /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10000</para>
                        /// </summary>
                        [NameInMap("Begin")]
                        [Validation(Required=false)]
                        public long? Begin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("EmotionValue")]
                        [Validation(Required=false)]
                        public int? EmotionValue { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public long? End { get; set; }

                        [NameInMap("Identity")]
                        [Validation(Required=false)]
                        public string Identity { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("SpeechRate")]
                        [Validation(Required=false)]
                        public int? SpeechRate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Words")]
                        [Validation(Required=false)]
                        public string Words { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-02T14:37Z</para>
                /// </summary>
                [NameInMap("AssignmentTime")]
                [Validation(Required=false)]
                public string AssignmentTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-07-24T19:31Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1602743090</para>
                /// </summary>
                [NameInMap("CreateTimeLong")]
                [Validation(Required=false)]
                public string CreateTimeLong { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
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
                                /// <para>检测范围</para>
                                /// </summary>
                                [NameInMap("Check_range")]
                                [Validation(Required=false)]
                                public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRange CheckRange { get; set; }
                                public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRange : TeaModel {
                                    /// <summary>
                                    /// <para>false: 相对位置; 会结合anchor以及角色来决定句子位置</para>
                                    /// </summary>
                                    [NameInMap("Absolute")]
                                    [Validation(Required=false)]
                                    public bool? Absolute { get; set; }

                                    /// <summary>
                                    /// <para>true: 每句话都必须满足条件；</para>
                                    /// </summary>
                                    [NameInMap("AllSentencesSatisfy")]
                                    [Validation(Required=false)]
                                    public bool? AllSentencesSatisfy { get; set; }

                                    /// <summary>
                                    /// <para>前置后置条件</para>
                                    /// </summary>
                                    [NameInMap("Anchor")]
                                    [Validation(Required=false)]
                                    public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeAnchor Anchor { get; set; }
                                    public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeAnchor : TeaModel {
                                        /// <summary>
                                        /// <para>条件ID</para>
                                        /// </summary>
                                        [NameInMap("Cid")]
                                        [Validation(Required=false)]
                                        public string Cid { get; set; }

                                        /// <summary>
                                        /// <para>命中次数</para>
                                        /// </summary>
                                        [NameInMap("Hit_time")]
                                        [Validation(Required=false)]
                                        public int? HitTime { get; set; }

                                        /// <summary>
                                        /// <para>位置</para>
                                        /// </summary>
                                        [NameInMap("Location")]
                                        [Validation(Required=false)]
                                        public string Location { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>相对范围</para>
                                    /// </summary>
                                    [NameInMap("Range")]
                                    [Validation(Required=false)]
                                    public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeRange Range { get; set; }
                                    public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsCheckRangeRange : TeaModel {
                                        /// <summary>
                                        /// <para>对话开始索引</para>
                                        /// </summary>
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public int? From { get; set; }

                                        /// <summary>
                                        /// <para>对话结束索引</para>
                                        /// </summary>
                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public int? To { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>对应 RoleType.type</para>
                                    /// </summary>
                                    [NameInMap("Role")]
                                    [Validation(Required=false)]
                                    public string Role { get; set; }

                                    /// <summary>
                                    /// <para>对应 RoleType.id</para>
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
                                /// <para>条件id，可能是db中的主键，也可能是转换成的a, b, c</para>
                                /// </summary>
                                [NameInMap("Cid")]
                                [Validation(Required=false)]
                                public string Cid { get; set; }

                                /// <summary>
                                /// <para>排除</para>
                                /// </summary>
                                [NameInMap("Exclusion")]
                                [Validation(Required=false)]
                                public int? Exclusion { get; set; }

                                /// <summary>
                                /// <para>在db中的主键</para>
                                /// </summary>
                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public long? Id { get; set; }

                                /// <summary>
                                /// <para>Lambda表达式：例如:a&amp;&amp;b</para>
                                /// </summary>
                                [NameInMap("Lambda")]
                                [Validation(Required=false)]
                                public string Lambda { get; set; }

                                /// <summary>
                                /// <para>算子列表</para>
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
                                        /// <para>主键id</para>
                                        /// </summary>
                                        [NameInMap("Id")]
                                        [Validation(Required=false)]
                                        public long? Id { get; set; }

                                        /// <summary>
                                        /// <para>算子名</para>
                                        /// </summary>
                                        [NameInMap("Name")]
                                        [Validation(Required=false)]
                                        public string Name { get; set; }

                                        /// <summary>
                                        /// <para>可能是主键id，也可能是前端生成的id</para>
                                        /// </summary>
                                        [NameInMap("Oid")]
                                        [Validation(Required=false)]
                                        public string Oid { get; set; }

                                        /// <summary>
                                        /// <para>算子参数</para>
                                        /// </summary>
                                        [NameInMap("Param")]
                                        [Validation(Required=false)]
                                        public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParam Param { get; set; }
                                        public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParam : TeaModel {
                                            /// <summary>
                                            /// <para>语速检测，是否计算整个对话平均语速，默认false</para>
                                            /// </summary>
                                            [NameInMap("Average")]
                                            [Validation(Required=false)]
                                            public bool? Average { get; set; }

                                            /// <summary>
                                            /// <para>时长算子，时长计算开始类型，录音开始，还是某句对话开始</para>
                                            /// </summary>
                                            [NameInMap("BeginType")]
                                            [Validation(Required=false)]
                                            public string BeginType { get; set; }

                                            /// <summary>
                                            /// <para>区分大小写</para>
                                            /// </summary>
                                            [NameInMap("Case_sensitive")]
                                            [Validation(Required=false)]
                                            public bool? CaseSensitive { get; set; }

                                            /// <summary>
                                            /// <para>静音检测：要不要检测第一句话</para>
                                            /// </summary>
                                            [NameInMap("CheckFirstSentence")]
                                            [Validation(Required=false)]
                                            public bool? CheckFirstSentence { get; set; }

                                            /// <summary>
                                            /// <para>检测方式，1 相邻句能量波动 2 最大能量跨度 默认1</para>
                                            /// </summary>
                                            [NameInMap("CheckType")]
                                            [Validation(Required=false)]
                                            public int? CheckType { get; set; }

                                            /// <summary>
                                            /// <para>大于，还是小于，gt/lt</para>
                                            /// </summary>
                                            [NameInMap("CompareOperator")]
                                            [Validation(Required=false)]
                                            public string CompareOperator { get; set; }

                                            /// <summary>
                                            /// <para>是否单句话匹配；</para>
                                            /// </summary>
                                            [NameInMap("ContextChatMatch")]
                                            [Validation(Required=false)]
                                            public bool? ContextChatMatch { get; set; }

                                            /// <summary>
                                            /// <para>抢话算子 延时时长</para>
                                            /// </summary>
                                            [NameInMap("DelayTime")]
                                            [Validation(Required=false)]
                                            public int? DelayTime { get; set; }

                                            /// <summary>
                                            /// <para>时长算子，时长计算结束类型，录音结束，还是某句对话结束</para>
                                            /// </summary>
                                            [NameInMap("EndType")]
                                            [Validation(Required=false)]
                                            public string EndType { get; set; }

                                            /// <summary>
                                            /// <para>上下文重复算子：排除掉某些对话</para>
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
                                            /// <para>流程节点前置条件参数</para>
                                            /// </summary>
                                            [NameInMap("FlowNodePrerequisiteParam")]
                                            [Validation(Required=false)]
                                            public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamFlowNodePrerequisiteParam FlowNodePrerequisiteParam { get; set; }
                                            public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamFlowNodePrerequisiteParam : TeaModel {
                                                /// <summary>
                                                /// <para>节点id</para>
                                                /// </summary>
                                                [NameInMap("NodeId")]
                                                [Validation(Required=false)]
                                                public long? NodeId { get; set; }

                                                /// <summary>
                                                /// <para>节点匹配状态。</para>
                                                /// </summary>
                                                [NameInMap("NodeMatchStatus")]
                                                [Validation(Required=false)]
                                                public int? NodeMatchStatus { get; set; }

                                                /// <summary>
                                                /// <para>冗余的节点名称</para>
                                                /// </summary>
                                                [NameInMap("NodeName")]
                                                [Validation(Required=false)]
                                                public string NodeName { get; set; }

                                            }

                                            /// <summary>
                                            /// <para>上下文重复算子：检测当前句的前from句是否有重复；0表示前面的所有句</para>
                                            /// </summary>
                                            [NameInMap("From")]
                                            [Validation(Required=false)]
                                            public int? From { get; set; }

                                            /// <summary>
                                            /// <para>from_end</para>
                                            /// </summary>
                                            [NameInMap("From_end")]
                                            [Validation(Required=false)]
                                            public bool? FromEnd { get; set; }

                                            /// <summary>
                                            /// <para>上下文重复算子：重复几次</para>
                                            /// </summary>
                                            [NameInMap("Hit_time")]
                                            [Validation(Required=false)]
                                            public int? HitTime { get; set; }

                                            /// <summary>
                                            /// <para>生效句子， true单个句子，false多个句子</para>
                                            /// </summary>
                                            [NameInMap("In_sentence")]
                                            [Validation(Required=false)]
                                            public bool? InSentence { get; set; }

                                            /// <summary>
                                            /// <para>意图模型检查参数</para>
                                            /// </summary>
                                            [NameInMap("IntentModelCheckParm")]
                                            [Validation(Required=false)]
                                            public GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamIntentModelCheckParm IntentModelCheckParm { get; set; }
                                            public class GetResultResponseBodyDataResultInfoHitResultHitResultConditionsConditionsOperatorsOperatorParamIntentModelCheckParm : TeaModel {
                                                /// <summary>
                                                /// <para>引用的意图模型</para>
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
                                                        /// <para>意图模型ID</para>
                                                        /// </summary>
                                                        [NameInMap("Id")]
                                                        [Validation(Required=false)]
                                                        public long? Id { get; set; }

                                                        /// <summary>
                                                        /// <para>意图模型名称</para>
                                                        /// </summary>
                                                        [NameInMap("Name")]
                                                        [Validation(Required=false)]
                                                        public string Name { get; set; }

                                                    }

                                                }

                                                /// <summary>
                                                /// <para>模型应用的场景 AGENT:客户场景、CUSTOMER:客服场景 (CUSTOMER: 客户场景, AGENT: 坐席场景)</para>
                                                /// </summary>
                                                [NameInMap("ModelScene")]
                                                [Validation(Required=false)]
                                                public string ModelScene { get; set; }

                                            }

                                            /// <summary>
                                            /// <para>interval代表区间范围开始</para>
                                            /// </summary>
                                            [NameInMap("Interval")]
                                            [Validation(Required=false)]
                                            public int? Interval { get; set; }

                                            /// <summary>
                                            /// <para>intervalEnd 代表区间范围结束</para>
                                            /// </summary>
                                            [NameInMap("IntervalEnd")]
                                            [Validation(Required=false)]
                                            public int? IntervalEnd { get; set; }

                                            /// <summary>
                                            /// <para>关键字扩展</para>
                                            /// </summary>
                                            [NameInMap("KeywordExtension")]
                                            [Validation(Required=false)]
                                            public int? KeywordExtension { get; set; }

                                            /// <summary>
                                            /// <para>匹配到的关键字数量</para>
                                            /// </summary>
                                            [NameInMap("KeywordMatchSize")]
                                            [Validation(Required=false)]
                                            public int? KeywordMatchSize { get; set; }

                                            /// <summary>
                                            /// <para>关键词</para>
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
                                            /// <para>能量值变化，默认3, 1~9</para>
                                            /// </summary>
                                            [NameInMap("MaxEmotionChangeValue")]
                                            [Validation(Required=false)]
                                            public int? MaxEmotionChangeValue { get; set; }

                                            /// <summary>
                                            /// <para>句子中最少字数，小于此字数的句子不检查</para>
                                            /// </summary>
                                            [NameInMap("MinWordSize")]
                                            [Validation(Required=false)]
                                            public int? MinWordSize { get; set; }

                                            /// <summary>
                                            /// <para>true表示取不同角色相邻的两句话，false表示取不同角色的第一句话比较响应时间（默认）</para>
                                            /// </summary>
                                            [NameInMap("Near_dialogue")]
                                            [Validation(Required=false)]
                                            public bool? NearDialogue { get; set; }

                                            /// <summary>
                                            /// <para>排除的正则表达式</para>
                                            /// </summary>
                                            [NameInMap("NotRegex")]
                                            [Validation(Required=false)]
                                            public string NotRegex { get; set; }

                                            /// <summary>
                                            /// <para>语句</para>
                                            /// </summary>
                                            [NameInMap("Phrase")]
                                            [Validation(Required=false)]
                                            public string Phrase { get; set; }

                                            /// <summary>
                                            /// <para>正则表达式</para>
                                            /// </summary>
                                            [NameInMap("Regex")]
                                            [Validation(Required=false)]
                                            public string Regex { get; set; }

                                            /// <summary>
                                            /// <para>target</para>
                                            /// </summary>
                                            [NameInMap("Target")]
                                            [Validation(Required=false)]
                                            public int? Target { get; set; }

                                            /// <summary>
                                            /// <para>阈值</para>
                                            /// </summary>
                                            [NameInMap("Threshold")]
                                            [Validation(Required=false)]
                                            public float? Threshold { get; set; }

                                        }

                                        /// <summary>
                                        /// <para>算子类别</para>
                                        /// </summary>
                                        [NameInMap("Type")]
                                        [Validation(Required=false)]
                                        public string Type { get; set; }

                                    }

                                }

                                /// <summary>
                                /// <para>条件所属的规则id</para>
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
                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>xxxx</para>
                                        /// </summary>
                                        [NameInMap("Cid")]
                                        [Validation(Required=false)]
                                        public string Cid { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>1</para>
                                        /// </summary>
                                        [NameInMap("From")]
                                        [Validation(Required=false)]
                                        public int? From { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>2</para>
                                        /// </summary>
                                        [NameInMap("To")]
                                        [Validation(Required=false)]
                                        public int? To { get; set; }

                                        /// <summary>
                                        /// <b>Example:</b>
                                        /// <para>test</para>
                                        /// </summary>
                                        [NameInMap("Val")]
                                        [Validation(Required=false)]
                                        public string Val { get; set; }

                                    }

                                }

                                [NameInMap("Phrase")]
                                [Validation(Required=false)]
                                public GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitPhrase Phrase { get; set; }
                                public class GetResultResponseBodyDataResultInfoHitResultHitResultHitsHitPhrase : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>300</para>
                                    /// </summary>
                                    [NameInMap("Begin")]
                                    [Validation(Required=false)]
                                    public long? Begin { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>0</para>
                                    /// </summary>
                                    [NameInMap("EmotionValue")]
                                    [Validation(Required=false)]
                                    public int? EmotionValue { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>300</para>
                                    /// </summary>
                                    [NameInMap("End")]
                                    [Validation(Required=false)]
                                    public int? End { get; set; }

                                    [NameInMap("Role")]
                                    [Validation(Required=false)]
                                    public string Role { get; set; }

                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>xxx</para>
                                    /// </summary>
                                    [NameInMap("Words")]
                                    [Validation(Required=false)]
                                    public string Words { get; set; }

                                }

                            }

                        }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ReviewResult")]
                        [Validation(Required=false)]
                        public int? ReviewResult { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1276</para>
                        /// </summary>
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public string Rid { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123xx</para>
                        /// </summary>
                        [NameInMap("SchemeId")]
                        [Validation(Required=false)]
                        public long? SchemeId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>11xx</para>
                        /// </summary>
                        [NameInMap("SchemeVersion")]
                        [Validation(Required=false)]
                        public long? SchemeVersion { get; set; }

                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public int? Score { get; set; }

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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("RuleId")]
                        [Validation(Required=false)]
                        public string RuleId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123456</para>
                        /// </summary>
                        [NameInMap("ScoreId")]
                        [Validation(Required=false)]
                        public string ScoreId { get; set; }

                        [NameInMap("ScoreName")]
                        [Validation(Required=false)]
                        public string ScoreName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>-20</para>
                        /// </summary>
                        [NameInMap("ScoreNumber")]
                        [Validation(Required=false)]
                        public string ScoreNumber { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4498420@a_z@93EAADF1-01D3-44BD-8AC9-F57F447EFCE8_1614*****</para>
                /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXXX</para>
                    /// </summary>
                    [NameInMap("CallId")]
                    [Validation(Required=false)]
                    public string CallId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1563967699000</para>
                    /// </summary>
                    [NameInMap("CallTime")]
                    [Validation(Required=false)]
                    public string CallTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CallType")]
                    [Validation(Required=false)]
                    public int? CallType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1888888****</para>
                    /// </summary>
                    [NameInMap("Callee")]
                    [Validation(Required=false)]
                    public string Callee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0108888****</para>
                    /// </summary>
                    [NameInMap("Caller")]
                    [Validation(Required=false)]
                    public string Caller { get; set; }

                    [NameInMap("CustomerName")]
                    [Validation(Required=false)]
                    public string CustomerName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXXX</para>
                    /// </summary>
                    [NameInMap("DataSetName")]
                    [Validation(Required=false)]
                    public string DataSetName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>32</para>
                    /// </summary>
                    [NameInMap("DialogueSize")]
                    [Validation(Required=false)]
                    public int? DialogueSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXXXX</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123456.mkv</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3437500</para>
                    /// </summary>
                    [NameInMap("PrimaryId")]
                    [Validation(Required=false)]
                    public string PrimaryId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark1")]
                    [Validation(Required=false)]
                    public string Remark1 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark10")]
                    [Validation(Required=false)]
                    public string Remark10 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark11")]
                    [Validation(Required=false)]
                    public string Remark11 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark12")]
                    [Validation(Required=false)]
                    public string Remark12 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark13")]
                    [Validation(Required=false)]
                    public string Remark13 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark2")]
                    [Validation(Required=false)]
                    public string Remark2 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark3")]
                    [Validation(Required=false)]
                    public string Remark3 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark4")]
                    [Validation(Required=false)]
                    public string Remark4 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1232</para>
                    /// </summary>
                    [NameInMap("Remark5")]
                    [Validation(Required=false)]
                    public long? Remark5 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark6")]
                    [Validation(Required=false)]
                    public string Remark6 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark7")]
                    [Validation(Required=false)]
                    public string Remark7 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark8")]
                    [Validation(Required=false)]
                    public string Remark8 { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("Remark9")]
                    [Validation(Required=false)]
                    public string Remark9 { get; set; }

                    [NameInMap("TaskConfigId")]
                    [Validation(Required=false)]
                    public long? TaskConfigId { get; set; }

                    [NameInMap("TaskConfigName")]
                    [Validation(Required=false)]
                    public string TaskConfigName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://aliyun.com/audio.wav">http://aliyun.com/audio.wav</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
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
                            [NameInMap("ReviewRightRule")]
                            [Validation(Required=false)]
                            public List<GetResultResponseBodyDataResultInfoReviewHistoryListReviewHistoryReviewRightRuleReviewRightRule> ReviewRightRule { get; set; }
                            public class GetResultResponseBodyDataResultInfoReviewHistoryListReviewHistoryReviewRightRuleReviewRightRule : TeaModel {
                                [NameInMap("rid")]
                                [Validation(Required=false)]
                                public long? Rid { get; set; }

                                [NameInMap("ruleName")]
                                [Validation(Required=false)]
                                public string RuleName { get; set; }

                            }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReviewResult")]
                [Validation(Required=false)]
                public int? ReviewResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReviewStatus")]
                [Validation(Required=false)]
                public int? ReviewStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-07-24T19:31Z</para>
                /// </summary>
                [NameInMap("ReviewTime")]
                [Validation(Required=false)]
                public string ReviewTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1602743090</para>
                /// </summary>
                [NameInMap("ReviewTimeLong")]
                [Validation(Required=false)]
                public string ReviewTimeLong { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A6BEC8D-9A5B-4BE5-8432-4F635E***</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("Vid")]
                [Validation(Required=false)]
                public string Vid { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3CEA0495-341B-4482-9AD9-8191EF4***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
