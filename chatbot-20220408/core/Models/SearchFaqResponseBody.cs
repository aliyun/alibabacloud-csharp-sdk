// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchFaqResponseBody : TeaModel {
        [NameInMap("FaqHits")]
        [Validation(Required=false)]
        public List<SearchFaqResponseBodyFaqHits> FaqHits { get; set; }
        public class SearchFaqResponseBodyFaqHits : TeaModel {
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
            /// 创建人ID
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }

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
            /// 命中的相似问
            /// </summary>
            [NameInMap("HitSimilarTitles")]
            [Validation(Required=false)]
            public List<string> HitSimilarTitles { get; set; }

            /// <summary>
            /// 命中的答案
            /// </summary>
            [NameInMap("HitSolutions")]
            [Validation(Required=false)]
            public List<string> HitSolutions { get; set; }

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
            /// 修改人ID
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public long? ModifyUserId { get; set; }

            /// <summary>
            /// 修改人
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

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

        /// <summary>
        /// 页码 默认1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页数量，默认10，最大500
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
