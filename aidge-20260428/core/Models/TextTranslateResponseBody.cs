// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextTranslateResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value &quot;success&quot; is returned for a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The translation result data, which contains the translation list and usage information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TextTranslateResponseBodyData Data { get; set; }
        public class TextTranslateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of translation results. Each element corresponds to a translation result for an entry in the input text list.</para>
            /// </summary>
            [NameInMap("Translations")]
            [Validation(Required=false)]
            public List<TextTranslateResponseBodyDataTranslations> Translations { get; set; }
            public class TextTranslateResponseBodyDataTranslations : TeaModel {
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
                /// <para>The automatically detected source language code.</para>
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
            /// <para>The usage information, including the number of input characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;InputCharacterCount&quot;:5}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. The value &quot;Success&quot; is returned for a successful call. For a failed call, a specific error message is returned, such as &quot;The parameters contain sensitive information. Try other input.&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>922E43BB-EE0E-1A29-B143-BB91BB3EA6AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
