// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListDSEntityValueResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of entity values.</para>
        /// </summary>
        [NameInMap("EntityValues")]
        [Validation(Required=false)]
        public List<ListDSEntityValueResponseBodyEntityValues> EntityValues { get; set; }
        public class ListDSEntityValueResponseBodyEntityValues : TeaModel {
            /// <summary>
            /// <para>The content of the entity value, which can be a standard value or a regular expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>书类型</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The creation time of the entity value in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34313785463</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            /// <summary>
            /// <para>The ID of the entity value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3467858234534534532</para>
            /// </summary>
            [NameInMap("EntityValueId")]
            [Validation(Required=false)]
            public long? EntityValueId { get; set; }

            /// <summary>
            /// <para>The last modification time of the entity value in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-12T16:00:01Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>A list of synonyms for the entity value.</para>
            /// </summary>
            [NameInMap("Synonyms")]
            [Validation(Required=false)]
            public List<string> Synonyms { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n3fg34gbfj8adf2gj923</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of matching entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
