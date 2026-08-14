// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class ListTranscriptionPhrasesResponseBody : TeaModel {
        /// <summary>
        /// <para>status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTranscriptionPhrasesResponseBodyData Data { get; set; }
        public class ListTranscriptionPhrasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PHS.Exceed</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The num of the phrase exceeds the upper limit.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Phrase objects.</para>
            /// </summary>
            [NameInMap("Phrases")]
            [Validation(Required=false)]
            public List<ListTranscriptionPhrasesResponseBodyDataPhrases> Phrases { get; set; }
            public class ListTranscriptionPhrasesResponseBodyDataPhrases : TeaModel {
                /// <summary>
                /// <para>Phrase list description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom fruit phrases list</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Phrase list name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fruit_phrase</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Phrase list ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a93b91141c0f422fa114af203f8b****</para>
                /// </summary>
                [NameInMap("PhraseId")]
                [Validation(Required=false)]
                public string PhraseId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the operation was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>status description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>35124E1C-AE99-5D6C-A52E-BD689D8D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
