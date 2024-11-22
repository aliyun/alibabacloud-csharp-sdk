// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class GetTranscriptionPhrasesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTranscriptionPhrasesResponseBodyData Data { get; set; }
        public class GetTranscriptionPhrasesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Phrases")]
            [Validation(Required=false)]
            public List<GetTranscriptionPhrasesResponseBodyDataPhrases> Phrases { get; set; }
            public class GetTranscriptionPhrasesResponseBodyDataPhrases : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>custom fruit phrases list</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fruit_phrase</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a93b91141c0f422fa114af203f8b****</para>
                /// </summary>
                [NameInMap("PhraseId")]
                [Validation(Required=false)]
                public string PhraseId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;苹果&quot;:3,&quot;西瓜&quot;:3}</para>
                /// </summary>
                [NameInMap("WordWeights")]
                [Validation(Required=false)]
                public string WordWeights { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
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
