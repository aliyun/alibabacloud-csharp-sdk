// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class GeneralRephotographyDetectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The recapture detection result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GeneralRephotographyDetectionResponseBodyData Data { get; set; }
        public class GeneralRephotographyDetectionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business result. This is an empty object if the call fails.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public GeneralRephotographyDetectionResponseBodyDataResult Result { get; set; }
            public class GeneralRephotographyDetectionResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>Indicates whether the image is recaptured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public bool? IsFake { get; set; }

                /// <summary>
                /// <para>Fixed to general.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The usage information. The value is <c>{&quot;ProcessingCount&quot;:1}</c> if the call is successful, or an empty object if the call fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProcessingCount&quot;:1}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The response message or failure description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70CBEFDF-BB17-1EB3-8A21-569F3124738F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
