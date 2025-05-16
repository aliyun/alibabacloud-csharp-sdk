// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteHundredThousandWhysDialogueResponseBody : TeaModel {
        [NameInMap("choices")]
        [Validation(Required=false)]
        public List<ExecuteHundredThousandWhysDialogueResponseBodyChoices> Choices { get; set; }
        public class ExecuteHundredThousandWhysDialogueResponseBodyChoices : TeaModel {
            [NameInMap("delta")]
            [Validation(Required=false)]
            public ExecuteHundredThousandWhysDialogueResponseBodyChoicesDelta Delta { get; set; }
            public class ExecuteHundredThousandWhysDialogueResponseBodyChoicesDelta : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>assistant</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("finish_reason")]
            [Validation(Required=false)]
            public string FinishReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBFA232A-1176-50E6-95AE-50F7A62A28AD</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
