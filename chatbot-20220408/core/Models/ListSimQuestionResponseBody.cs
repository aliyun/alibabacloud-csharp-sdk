// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSimQuestionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15CD94CC-CBEB-4189-806C-A132D1F45D51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of similar questions.</para>
        /// </summary>
        [NameInMap("SimQuestions")]
        [Validation(Required=false)]
        public List<ListSimQuestionResponseBodySimQuestions> SimQuestions { get; set; }
        public class ListSimQuestionResponseBodySimQuestions : TeaModel {
            /// <summary>
            /// <para>The creation time of the similar question, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-30T02:08:33Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The modification time of the similar question, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-13T03:49:28Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The similar question ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30001979424</para>
            /// </summary>
            [NameInMap("SimQuestionId")]
            [Validation(Required=false)]
            public long? SimQuestionId { get; set; }

            /// <summary>
            /// <para>The title of the similar question.</para>
            /// 
            /// <b>Example:</b>
            /// <para>相似问</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
