// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSimQuestionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>15CD94CC-CBEB-4189-806C-A132D1F45D51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SimQuestions")]
        [Validation(Required=false)]
        public List<ListSimQuestionResponseBodySimQuestions> SimQuestions { get; set; }
        public class ListSimQuestionResponseBodySimQuestions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-30T02:08:33Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-13T03:49:28Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30001979424</para>
            /// </summary>
            [NameInMap("SimQuestionId")]
            [Validation(Required=false)]
            public long? SimQuestionId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
