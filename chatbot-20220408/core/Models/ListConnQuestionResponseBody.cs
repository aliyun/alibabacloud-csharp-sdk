// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListConnQuestionResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of connected questions.</para>
        /// </summary>
        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<ListConnQuestionResponseBodyOutlines> Outlines { get; set; }
        public class ListConnQuestionResponseBodyOutlines : TeaModel {
            /// <summary>
            /// <para>The ID of the connected question.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30001979424</para>
            /// </summary>
            [NameInMap("ConnQuestionId")]
            [Validation(Required=false)]
            public long? ConnQuestionId { get; set; }

            /// <summary>
            /// <para>The creation time, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-25T02:47:18Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The last modification time, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-26T10:18:15Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The relation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>797</para>
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            /// <summary>
            /// <para>The title of the connected question.</para>
            /// 
            /// <b>Example:</b>
            /// <para>关联问</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92B81548-42B9-4B34-924B-4E778AEB412B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
