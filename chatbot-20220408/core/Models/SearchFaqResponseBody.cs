// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchFaqResponseBody : TeaModel {
        /// <summary>
        /// <para>The knowledge search results.</para>
        /// </summary>
        [NameInMap("FaqHits")]
        [Validation(Required=false)]
        public List<SearchFaqResponseBodyFaqHits> FaqHits { get; set; }
        public class SearchFaqResponseBodyFaqHits : TeaModel {
            /// <summary>
            /// <para>The category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000055639</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>The creation time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-02T03:09:30Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18453</para>
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }

            /// <summary>
            /// <para>The name of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>The effective status of the knowledge, calculated based on StartDate and EndDate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>20: Active.</description></item>
            /// <item><description>21: Expired.</description></item>
            /// <item><description>22: Pending.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public int? EffectStatus { get; set; }

            /// <summary>
            /// <para>The list of hit similar questions.</para>
            /// </summary>
            [NameInMap("HitSimilarTitles")]
            [Validation(Required=false)]
            public List<string> HitSimilarTitles { get; set; }

            /// <summary>
            /// <para>The list of hit solutions.</para>
            /// </summary>
            [NameInMap("HitSolutions")]
            [Validation(Required=false)]
            public List<string> HitSolutions { get; set; }

            /// <summary>
            /// <para>The knowledge ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30002145804</para>
            /// </summary>
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }

            /// <summary>
            /// <para>The modification time in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-02T03:09:30Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18453</para>
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public long? ModifyUserId { get; set; }

            /// <summary>
            /// <para>The name of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// <para>The knowledge status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>-1: deleted and unpublished.</description></item>
            /// <item><description>1: unpublished.</description></item>
            /// <item><description>2: published.</description></item>
            /// <item><description>3: updated and unpublished.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E45491D5-7E0A-42C6-9B21-91D1066B1475</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1075</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
