// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class LanguageDetectResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates a successful call. For other response codes, refer to the error code information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The language detection result data, which includes the detected language and usage information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public LanguageDetectResponseBodyData Data { get; set; }
        public class LanguageDetectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The code of the detected language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("DetectedLanguage")]
            [Validation(Required=false)]
            public string DetectedLanguage { get; set; }

            /// <summary>
            /// <para>The usage information, which includes the number of input characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;InputCharacterCount&quot;:4}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. &quot;Success&quot; is returned for normal calls. For exceptions, a specific error message is returned, such as &quot;The parameter contains sensitive information. Try another input.&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to uniquely identify a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42542C6C-F2A4-1B2B-8EFF-130C8FD06F54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
