// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSolutionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5B29DB5E-251D-5A73-84B5-A12DF795F231</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of solutions.</para>
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public List<ListSolutionResponseBodySolutions> Solutions { get; set; }
        public class ListSolutionResponseBodySolutions : TeaModel {
            /// <summary>
            /// <para>The content of the solution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>答案内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The type of the solution content. Valid values: <c>0</c> (plain text) and <c>1</c> (rich text).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            /// <summary>
            /// <para>The time when the solution was created, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-29T03:55:04Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the solution was last modified, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-29T06:23:53Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>A list of perspective codes.</para>
            /// </summary>
            [NameInMap("PerspectiveCodes")]
            [Validation(Required=false)]
            public List<string> PerspectiveCodes { get; set; }

            /// <summary>
            /// <para>The content of the solution in plain text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>答案内容</para>
            /// </summary>
            [NameInMap("PlainText")]
            [Validation(Required=false)]
            public string PlainText { get; set; }

            /// <summary>
            /// <para>The solution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>496</para>
            /// </summary>
            [NameInMap("SolutionId")]
            [Validation(Required=false)]
            public long? SolutionId { get; set; }

            /// <summary>
            /// <para>A list of tag IDs.</para>
            /// </summary>
            [NameInMap("TagIdList")]
            [Validation(Required=false)]
            public List<long?> TagIdList { get; set; }

        }

    }

}
