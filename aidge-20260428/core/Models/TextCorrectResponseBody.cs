// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextCorrectResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. &quot;success&quot; is returned for successful calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The intelligent correction result data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TextCorrectResponseBodyData Data { get; set; }
        public class TextCorrectResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The corrected text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Empfehlung</para>
            /// </summary>
            [NameInMap("CorrectedText")]
            [Validation(Required=false)]
            public string CorrectedText { get; set; }

            /// <summary>
            /// <para>The usage information, including the number of input characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;InputCharacterCount&quot;:9}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. &quot;Success&quot; is returned for successful calls. For failed calls, a specific error message is returned, such as &quot;The parameter contains sensitive information. Please try another input.&quot;</para>
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
        /// <para>32882AD0-50D1-1D90-A221-3987325EC03E</para>
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
