// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class EkycVerifyV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message</para>
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
        /// <para>Return Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public EkycVerifyV2ResponseBodyResult Result { get; set; }
        public class EkycVerifyV2ResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Face detection result information</para>
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
            /// <para>Certificate Classification Result. Returned only when the API response Succeeded.</para>
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
            /// <para>Indicates whether the verification passed. The value is Y if passed, or N if Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>Sub-result code</para>
            /// 
            /// <b>Example:</b>
            /// <para>205</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The unique id of the request</para>
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
