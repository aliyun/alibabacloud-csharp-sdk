// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageTranslationPlusAsyncResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The response code of the submission call. A value of success indicates a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The submission result of the Image Translation Plus asynchronous task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageTranslationPlusAsyncResponseBodyData Data { get; set; }
        public class ImageTranslationPlusAsyncResponseBodyData : Darabonba.Model {
            /// <summary>
            /// <para>The identifier of the asynchronous task, which is used for result query and notification association. Do not use the example prefix as a business validation rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TID_550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message, such as \&quot;The content contains sensitive data. Try another input.\&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which is used for troubleshooting and Tracing Analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the submission call is successful. This does not mean that the translation is completed. A value of true indicates success, and a value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

