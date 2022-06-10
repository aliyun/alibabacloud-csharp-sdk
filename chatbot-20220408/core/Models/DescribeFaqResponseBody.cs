// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeFaqResponseBody : TeaModel {
        /// <summary>
        /// 类目ID
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// 创建时间（UTC时间）
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// 知识生效状态,根据StartDate, EndDate计算出来: 20-生效中, 21-已失效, 22-待生效
        /// </summary>
        [NameInMap("EffectStatus")]
        [Validation(Required=false)]
        public int? EffectStatus { get; set; }

        /// <summary>
        /// 失效时间（UTC时间）
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 知识ID
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// 修改时间（UTC时间）
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// 关联问列表
        /// </summary>
        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<DescribeFaqResponseBodyOutlines> Outlines { get; set; }
        public class DescribeFaqResponseBodyOutlines : TeaModel {
            /// <summary>
            /// 关联知识ID
            /// </summary>
            [NameInMap("ConnQuestionId")]
            [Validation(Required=false)]
            public long? ConnQuestionId { get; set; }

            /// <summary>
            /// 创建时间(UTC 时间)
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 修改时间(UTC 时间)
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// 关联关系ID
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            /// <summary>
            /// 关联知识标题
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 相似问列表
        /// </summary>
        [NameInMap("SimQuestions")]
        [Validation(Required=false)]
        public List<DescribeFaqResponseBodySimQuestions> SimQuestions { get; set; }
        public class DescribeFaqResponseBodySimQuestions : TeaModel {
            /// <summary>
            /// 创建时间(UTC 时间)
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 修改时间(UTC 时间)
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// 相似问ID
            /// </summary>
            [NameInMap("SimQuestionId")]
            [Validation(Required=false)]
            public long? SimQuestionId { get; set; }

            /// <summary>
            /// 相似问标题
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 答案列表
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public List<DescribeFaqResponseBodySolutions> Solutions { get; set; }
        public class DescribeFaqResponseBodySolutions : TeaModel {
            /// <summary>
            /// 答案内容
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 答案类型(0纯文本，1富文本）
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            /// <summary>
            /// 创建时间(UTC 时间)
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 修改时间(UTC 时间)
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// 视角code列表
            /// </summary>
            [NameInMap("PerspectiveCodes")]
            [Validation(Required=false)]
            public List<string> PerspectiveCodes { get; set; }

            /// <summary>
            /// 答案纯文本内容
            /// </summary>
            [NameInMap("PlainText")]
            [Validation(Required=false)]
            public string PlainText { get; set; }

            /// <summary>
            /// 答案ID
            /// </summary>
            [NameInMap("SolutionId")]
            [Validation(Required=false)]
            public long? SolutionId { get; set; }

        }

        /// <summary>
        /// 生效时间（UTC时间）
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 知识状态: -1-已删除未发布, 1-未发布, 2-已发布, 3-已更新未发布
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
