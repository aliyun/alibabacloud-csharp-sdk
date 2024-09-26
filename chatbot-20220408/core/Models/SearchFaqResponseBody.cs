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
            /// <b>Example:</b>
            /// <para>30000055639</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-04-02T03:09:30Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18453</para>
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public int? EffectStatus { get; set; }

            [NameInMap("HitSimilarTitles")]
            [Validation(Required=false)]
            public List<string> HitSimilarTitles { get; set; }

            [NameInMap("HitSolutions")]
            [Validation(Required=false)]
            public List<string> HitSolutions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30002145804</para>
            /// </summary>
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-04-02T03:09:30Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18453</para>
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public long? ModifyUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

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
        /// <para>E45491D5-7E0A-42C6-9B21-91D1066B1475</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1075</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
