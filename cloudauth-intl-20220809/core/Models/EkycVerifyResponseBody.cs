// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class EkycVerifyResponseBody : TeaModel {
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
        /// <para>4EB356FE-BB6A-5DCC-B4C5-E8051787EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public EkycVerifyResponseBodyResult Result { get; set; }
        public class EkycVerifyResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The face verification result information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            /// &quot;faceAttack&quot;: &quot;N&quot;,
            /// &quot;faceComparisonScore&quot;: 52.57,
            /// &quot;facePassed&quot;: &quot;N&quot;,
            /// &quot;authorityComparisonScore&quot;: 80.39
            /// }</para>
            /// </summary>
            [NameInMap("ExtFaceInfo")]
            [Validation(Required=false)]
            public string ExtFaceInfo { get; set; }

            /// <summary>
            /// <para>The document recognition result. This parameter is returned only when the API response is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///  &quot;ocrIdInfo&quot;: {
            ///  &quot;firstName&quot;: &quot;<b>龙&quot;,
            ///  &quot;lastName&quot;: &quot;</b>&quot;,
            ///  &quot;countryCode&quot;: &quot;CHN&quot;,
            ///  &quot;docType&quot;: &quot;01560001&quot;,
            ///  &quot;dateOfBirth&quot;: &quot;2002-08-04&quot;,
            ///  &quot;idNumber&quot;: &quot;410************19&quot;
            ///  },
            ///  &quot;ocrIdPassed&quot;: &quot;N&quot;,
            ///  &quot;spoofInfo&quot;: {
            ///  &quot;spoofResult&quot;: &quot;Y&quot;,
            ///  }
            /// }</para>
            /// </summary>
            [NameInMap("ExtIdInfo")]
            [Validation(Required=false)]
            public string ExtIdInfo { get; set; }

            /// <summary>
            /// <para>Indicates whether the verification is passed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>T: Passed.</description></item>
            /// <item><description>F: Not passed.</description></item>
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
            /// <para>205</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The unique identifier of the verification request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4ab0b***cbde97</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
