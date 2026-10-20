// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class TextTranslateAsyncResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code of the submission call. Example: success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The submission result of the text translation asynchronous node.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TextTranslateAsyncResponseBodyData Data { get; set; }
        public class TextTranslateAsyncResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the asynchronous task. It is used for result queries and notification association. Do not use the example prefix as a business validation rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TID_550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The invocation message. Example of a successful call: Success. If the call fails, check the actual error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the submission request. It is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the submission call is successful. A successful call does not mean that the translation is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
