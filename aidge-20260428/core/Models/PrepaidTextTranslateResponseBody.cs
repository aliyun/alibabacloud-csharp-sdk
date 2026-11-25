// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class PrepaidTextTranslateResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. success is returned for successful calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The translation result data, which includes the translation list and usage information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PrepaidTextTranslateResponseBodyData Data { get; set; }
        public class PrepaidTextTranslateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of translation results. Each element corresponds to a translation result for an item in the input text list.</para>
            /// </summary>
            [NameInMap("Translations")]
            [Validation(Required=false)]
            public List<PrepaidTextTranslateResponseBodyDataTranslations> Translations { get; set; }
            public class PrepaidTextTranslateResponseBodyDataTranslations : TeaModel {
                /// <summary>
                /// <para>The number of characters in the source text.</para>
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
                /// <para>Hello world</para>
                /// </summary>
                [NameInMap("TranslatedText")]
                [Validation(Required=false)]
                public string TranslatedText { get; set; }

            }

            /// <summary>
            /// <para>The usage information, which includes the number of input characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;InputCharacterCount&quot;:5}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. Success is returned for successful calls. If an exception occurs, a specific error message is returned, such as &quot;The parameter contains sensitive information. Try another input.&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to identify a unique request call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
