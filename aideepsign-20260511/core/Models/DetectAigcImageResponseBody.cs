// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class DetectAigcImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of AIGC detection result labels.</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public List<DetectAigcImageResponseBodyBody> Body { get; set; }
        public class DetectAigcImageResponseBodyBody : TeaModel {
            /// <summary>
            /// <para>The confidence level. Value range: 0 to 1. A higher value indicates a higher probability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.51</para>
            /// </summary>
            [NameInMap("Confidence")]
            [Validation(Required=false)]
            public string Confidence { get; set; }

            /// <summary>
            /// <para>The detection label. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ai_generated</c>: AI-generated.</description></item>
            /// <item><description><c>non_ai_generated</c>: Not AI-generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ai_generated</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

        }

        /// <summary>
        /// <para>The business error code. The value <c>OK</c> is returned if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value <c>200</c> is returned if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The additional information. The value <c>success</c> is returned if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
