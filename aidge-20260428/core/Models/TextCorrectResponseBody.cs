// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextCorrectResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code. Returns &quot;success&quot; during normal calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Intelligent error correction result data.</para>
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
            /// <para>Usage information, including the number of input characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;InputCharacterCount&quot;:9}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>Error message. Returns &quot;Success&quot; during normal calls. Returns specific error information during exceptions, such as &quot;The parameters contain sensitive information. Please try a different input.&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, used to identify a unique request call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32882AD0-50D1-1D90-A221-3987325EC03E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful. true indicates success, false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
