// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class PrepaidTextTranslateResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Returns &quot;success&quot; for normal calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The translation result data, including the translation list and usage information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PrepaidTextTranslateResponseBodyData Data { get; set; }
        public class PrepaidTextTranslateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The translation result list. Each element corresponds to a translation result for an entry in the input text list.</para>
            /// </summary>
            [NameInMap("Translations")]
            [Validation(Required=false)]
            public List<PrepaidTextTranslateResponseBodyDataTranslations> Translations { get; set; }
            public class PrepaidTextTranslateResponseBodyDataTranslations : TeaModel {
                /// <summary>
                /// <para>The character count of the source text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("Characters")]
                [Validation(Required=false)]
                public long? Characters { get; set; }

                /// <summary>
                /// <para>The automatically detected source language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>en</para>
                /// </summary>
                [NameInMap("DetectedLanguage")]
                [Validation(Required=false)]
                public string DetectedLanguage { get; set; }

                /// <summary>
                /// <para>The translated text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好世界</para>
                /// </summary>
                [NameInMap("TranslatedText")]
                [Validation(Required=false)]
                public string TranslatedText { get; set; }

            }

            /// <summary>
            /// <para>The usage information, including the input character count.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. Returns &quot;Success&quot; for normal calls. Returns specific error information for exceptions, such as &quot;The parameters contain sensitive information. Try other input.&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, used to identify a unique request call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. true indicates success. false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
