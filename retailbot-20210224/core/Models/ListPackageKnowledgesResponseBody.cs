// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListPackageKnowledgesResponseBody : TeaModel {
        /// <summary>
        /// 返回code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 知识集合
        /// </summary>
        [NameInMap("Knowledges")]
        [Validation(Required=false)]
        public List<ListPackageKnowledgesResponseBodyKnowledges> Knowledges { get; set; }
        public class ListPackageKnowledgesResponseBodyKnowledges : TeaModel {
            /// <summary>
            /// 创建时间格式：yyyy-MM-dd HH:mm:ss
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 创建用户id
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            /// <summary>
            /// 知识描述
            /// </summary>
            [NameInMap("KnowledgeDescription")]
            [Validation(Required=false)]
            public string KnowledgeDescription { get; set; }

            /// <summary>
            /// 知识id
            /// </summary>
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }

            /// <summary>
            /// "online":在用，"disabled":禁用
            /// </summary>
            [NameInMap("KnowledgeStatus")]
            [Validation(Required=false)]
            public string KnowledgeStatus { get; set; }

            /// <summary>
            /// 知识标题
            /// </summary>
            [NameInMap("KnowledgeTitle")]
            [Validation(Required=false)]
            public string KnowledgeTitle { get; set; }

            /// <summary>
            /// 修改时间格式：yyyy-MM-dd HH:mm:ss
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// 修改用户id
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public string ModifyUserId { get; set; }

            /// <summary>
            /// 场景key
            /// </summary>
            [NameInMap("SceneKey")]
            [Validation(Required=false)]
            public string SceneKey { get; set; }

            /// <summary>
            /// 场景问法
            /// </summary>
            [NameInMap("SimilarQuestions")]
            [Validation(Required=false)]
            public List<ListPackageKnowledgesResponseBodyKnowledgesSimilarQuestions> SimilarQuestions { get; set; }
            public class ListPackageKnowledgesResponseBodyKnowledgesSimilarQuestions : TeaModel {
                /// <summary>
                /// 创建时间格式：yyyy-MM-dd HH:mm:ss
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 创建用户id
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public string CreateUserId { get; set; }

                /// <summary>
                /// 修改时间格式：yyyy-MM-dd HH:mm:ss
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// 修改用户id
                /// </summary>
                [NameInMap("ModifyUserId")]
                [Validation(Required=false)]
                public string ModifyUserId { get; set; }

                /// <summary>
                /// "positive":正向，"negative":负向
                /// </summary>
                [NameInMap("SimilarQuestionEffectType")]
                [Validation(Required=false)]
                public string SimilarQuestionEffectType { get; set; }

                /// <summary>
                /// 问法id
                /// </summary>
                [NameInMap("SimilarQuestionId")]
                [Validation(Required=false)]
                public long? SimilarQuestionId { get; set; }

                /// <summary>
                /// 示例问法标题
                /// </summary>
                [NameInMap("SimilarQuestionTitle")]
                [Validation(Required=false)]
                public string SimilarQuestionTitle { get; set; }

                /// <summary>
                /// "similar":场景正负例句，"sample":场景示例问法，"keyword":场景关键词
                /// </summary>
                [NameInMap("SimilarQuestionType")]
                [Validation(Required=false)]
                public string SimilarQuestionType { get; set; }

            }

            /// <summary>
            /// 答案
            /// </summary>
            [NameInMap("Solutions")]
            [Validation(Required=false)]
            public List<ListPackageKnowledgesResponseBodyKnowledgesSolutions> Solutions { get; set; }
            public class ListPackageKnowledgesResponseBodyKnowledgesSolutions : TeaModel {
                /// <summary>
                /// 约束
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<ListPackageKnowledgesResponseBodyKnowledgesSolutionsConditions> Conditions { get; set; }
                public class ListPackageKnowledgesResponseBodyKnowledgesSolutionsConditions : TeaModel {
                    /// <summary>
                    /// 约束类型
                    /// </summary>
                    [NameInMap("ConditionType")]
                    [Validation(Required=false)]
                    public string ConditionType { get; set; }

                    /// <summary>
                    /// 约束值
                    /// </summary>
                    [NameInMap("ConditionValue")]
                    [Validation(Required=false)]
                    public string ConditionValue { get; set; }

                    /// <summary>
                    /// 知识id
                    /// </summary>
                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public long? KnowledgeId { get; set; }

                    /// <summary>
                    /// 答案id
                    /// </summary>
                    [NameInMap("SolutionId")]
                    [Validation(Required=false)]
                    public long? SolutionId { get; set; }

                }

                /// <summary>
                /// 答案扩展文本
                /// </summary>
                [NameInMap("ExtraContent")]
                [Validation(Required=false)]
                public string ExtraContent { get; set; }

                /// <summary>
                /// 知识id
                /// </summary>
                [NameInMap("KnowledgeId")]
                [Validation(Required=false)]
                public long? KnowledgeId { get; set; }

                /// <summary>
                /// 答案文本
                /// </summary>
                [NameInMap("SolutionContent")]
                [Validation(Required=false)]
                public string SolutionContent { get; set; }

                /// <summary>
                /// 答案id
                /// </summary>
                [NameInMap("SolutionId")]
                [Validation(Required=false)]
                public long? SolutionId { get; set; }

                /// <summary>
                /// 答案来源
                /// </summary>
                [NameInMap("SolutionSource")]
                [Validation(Required=false)]
                public string SolutionSource { get; set; }

                /// <summary>
                /// 答案类型
                /// </summary>
                [NameInMap("SolutionType")]
                [Validation(Required=false)]
                public string SolutionType { get; set; }

            }

        }

        /// <summary>
        /// 返回信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功标示
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
