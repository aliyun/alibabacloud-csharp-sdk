// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class RecognizeMessageResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 问答返回结果
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeMessageResponseBodyData Data { get; set; }
        public class RecognizeMessageResponseBodyData : TeaModel {
            [NameInMap("Knowledges")]
            [Validation(Required=false)]
            public List<RecognizeMessageResponseBodyDataKnowledges> Knowledges { get; set; }
            public class RecognizeMessageResponseBodyDataKnowledges : TeaModel {
                public long? KnowledgeId { get; set; }
                public string KnowledgeTitle { get; set; }
                public string SceneKey { get; set; }
                public List<RecognizeMessageResponseBodyDataKnowledgesSolutions> Solutions { get; set; }
                public class RecognizeMessageResponseBodyDataKnowledgesSolutions : TeaModel {
                    public List<RecognizeMessageResponseBodyDataKnowledgesSolutionsConditions> Conditions { get; set; }
                    public class RecognizeMessageResponseBodyDataKnowledgesSolutionsConditions : TeaModel {
                        public string ConditionType { get; set; }
                        public string ConditionValue { get; set; }
                    }
                    public string ExtraContent { get; set; }
                    public long? KnowledgeId { get; set; }
                    public string SolutionContent { get; set; }
                    public long? SolutionId { get; set; }
                    public string SolutionSource { get; set; }
                    public string SolutionType { get; set; }
                    public List<RecognizeMessageResponseBodyDataKnowledgesSolutionsSolutionVariables> SolutionVariables { get; set; }
                    public class RecognizeMessageResponseBodyDataKnowledgesSolutionsSolutionVariables : TeaModel {
                        public string VariableName { get; set; }
                        public string VariableType { get; set; }
                    }
                }
            }
            [NameInMap("OutputMessages")]
            [Validation(Required=false)]
            public List<RecognizeMessageResponseBodyDataOutputMessages> OutputMessages { get; set; }
            public class RecognizeMessageResponseBodyDataOutputMessages : TeaModel {
                public Dictionary<string, string> OutputContent { get; set; }
                public string OutputContentType { get; set; }
            }
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public RecognizeMessageResponseBodyDataScene Scene { get; set; }
            public class RecognizeMessageResponseBodyDataScene : TeaModel {
                /// <summary>
                /// 情绪识别
                /// </summary>
                [NameInMap("EmotionTag")]
                [Validation(Required=false)]
                public string EmotionTag { get; set; }

                /// <summary>
                /// 定位场景使用的商品id
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// 定位场景使用的订单id
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// 场景识别
                /// </summary>
                [NameInMap("SceneDTOs")]
                [Validation(Required=false)]
                public List<RecognizeMessageResponseBodyDataSceneSceneDTOs> SceneDTOs { get; set; }
                public class RecognizeMessageResponseBodyDataSceneSceneDTOs : TeaModel {
                    /// <summary>
                    /// 场景key
                    /// </summary>
                    [NameInMap("SceneKey")]
                    [Validation(Required=false)]
                    public string SceneKey { get; set; }

                    /// <summary>
                    /// 场景来源
                    /// </summary>
                    [NameInMap("SceneSource")]
                    [Validation(Required=false)]
                    public string SceneSource { get; set; }

                }

                /// <summary>
                /// 语义完整性识别
                /// </summary>
                [NameInMap("SemanticComplete")]
                [Validation(Required=false)]
                public string SemanticComplete { get; set; }

            }
            [NameInMap("UnitSlots")]
            [Validation(Required=false)]
            public RecognizeMessageResponseBodyDataUnitSlots UnitSlots { get; set; }
            public class RecognizeMessageResponseBodyDataUnitSlots : TeaModel {
                [NameInMap("UnitSpans")]
                [Validation(Required=false)]
                public List<RecognizeMessageResponseBodyDataUnitSlotsUnitSpans> UnitSpans { get; set; }
                public class RecognizeMessageResponseBodyDataUnitSlotsUnitSpans : TeaModel {
                    /// <summary>
                    /// 槽位名称
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// 槽位结束下标
                    /// </summary>
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                    /// <summary>
                    /// 槽位值
                    /// </summary>
                    [NameInMap("NumericSlotValue")]
                    [Validation(Required=false)]
                    public RecognizeMessageResponseBodyDataUnitSlotsUnitSpansNumericSlotValue NumericSlotValue { get; set; }
                    public class RecognizeMessageResponseBodyDataUnitSlotsUnitSpansNumericSlotValue : TeaModel {
                        [NameInMap("Num")]
                        [Validation(Required=false)]
                        public double? Num { get; set; }
                        [NameInMap("Unit")]
                        [Validation(Required=false)]
                        public RecognizeMessageResponseBodyDataUnitSlotsUnitSpansNumericSlotValueUnit Unit { get; set; }
                        public class RecognizeMessageResponseBodyDataUnitSlotsUnitSpansNumericSlotValueUnit : TeaModel {
                            /// <summary>
                            /// 单位唯一标识
                            /// </summary>
                            [NameInMap("UnitKey")]
                            [Validation(Required=false)]
                            public string UnitKey { get; set; }

                            /// <summary>
                            /// 单位中文名
                            /// </summary>
                            [NameInMap("UnitName")]
                            [Validation(Required=false)]
                            public string UnitName { get; set; }

                        }
                    };

                    /// <summary>
                    /// 槽位分值
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                    /// <summary>
                    /// 槽位key
                    /// </summary>
                    [NameInMap("SlotKey")]
                    [Validation(Required=false)]
                    public string SlotKey { get; set; }

                    /// <summary>
                    /// 槽位值
                    /// </summary>
                    [NameInMap("SlotValue")]
                    [Validation(Required=false)]
                    public string SlotValue { get; set; }

                    /// <summary>
                    /// 槽位来源
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// 槽位起始下标
                    /// </summary>
                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public int? Start { get; set; }

                }

            }
            [NameInMap("extOutput")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtOutput { get; set; }
        };

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
