// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialRecognitionIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response message for the returned information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CredentialRecognitionIntlResponseBodyResult Result { get; set; }
        public class CredentialRecognitionIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Identified key information in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;address&quot;: &quot;&quot;,
            ///   &quot;name&quot;:&quot;&quot;
            /// }</para>
            /// </summary>
            [NameInMap("ExtIdInfo")]
            [Validation(Required=false)]
            public string ExtIdInfo { get; set; }

            /// <summary>
            /// <para>Authentication result description</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>Extraction result. Values:</para>
            /// <list type="bullet">
            /// <item><description>S: Success.</description></item>
            /// <item><description>F: Failure.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public string Success { get; set; }

        }

    }

}
