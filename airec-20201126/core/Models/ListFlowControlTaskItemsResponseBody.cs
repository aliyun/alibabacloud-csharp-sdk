// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListFlowControlTaskItemsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFlowControlTaskItemsResponseBodyResult Result { get; set; }
        public class ListFlowControlTaskItemsResponseBodyResult : TeaModel {
            [NameInMap("detail")]
            [Validation(Required=false)]
            public List<ListFlowControlTaskItemsResponseBodyResultDetail> Detail { get; set; }
            public class ListFlowControlTaskItemsResponseBodyResultDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12_34</para>
                /// </summary>
                [NameInMap("categoryPath")]
                [Validation(Required=false)]
                public string CategoryPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>news</para>
                /// </summary>
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1612687809</para>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1662346558</para>
                /// </summary>
                [NameInMap("lastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1661931487</para>
                /// </summary>
                [NameInMap("pubTime")]
                [Validation(Required=false)]
                public string PubTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("validCount")]
            [Validation(Required=false)]
            public string ValidCount { get; set; }

        }

    }

}
