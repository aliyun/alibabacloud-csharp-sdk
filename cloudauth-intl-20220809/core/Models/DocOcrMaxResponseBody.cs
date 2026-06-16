// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DocOcrMaxResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DocOcrMaxResponseBodyResult Result { get; set; }
        public class DocOcrMaxResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The card and certificate recognition result. This parameter is returned only when the API response is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;docType&quot;: &quot;PPTW01&quot;,
            ///   &quot;ocrIdInfo&quot;: {
            ///     &quot;passportNo&quot;: &quot;36*******&quot;,
            ///     &quot;expiryDate&quot;: &quot;2032/02/10&quot;,
            ///     &quot;placeOfBirth&quot;: &quot;TAIWAN&quot;,
            ///     &quot;surname&quot;: &quot;CHEN&quot;,
            ///     &quot;givenname&quot;: &quot;LIN-CHUN&quot;,
            ///     &quot;countryCode&quot;: &quot;TWN&quot;,
            ///     &quot;sex&quot;: &quot;F&quot;,
            ///     &quot;personalNo&quot;: &quot;S22********&quot;,
            ///     &quot;issueDate&quot;: &quot;2022/02/10&quot;,
            ///     &quot;birthDate&quot;: &quot;1988/10/04&quot;
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("ExtIdInfo")]
            [Validation(Required=false)]
            public string ExtIdInfo { get; set; }

            /// <summary>
            /// <para>Indicates whether the authentication is passed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Y: passed.</description></item>
            /// <item><description>N: not passed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>The sub-result code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The authentication ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hk573be80f944d95ac812e0*******a8</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
