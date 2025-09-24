// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class EkycVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The <a href="https://www.alibabacloud.com/help/en/ekyc/latest/im1u641gyesiqmbg?spm=a2c63.p38356.0.i18#GiGmf">response code</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A detailed description of the response code.</para>
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
        /// <para>Result object</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public EkycVerifyResponseBodyResult Result { get; set; }
        public class EkycVerifyResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Information about the face liveness verification result. For the JSON format, see the example on the right. For more information, see <a href="https://www.alibabacloud.com/help/en/ekyc/latest/im1u641gyesiqmbg?spm=a2c63.p38356.0.i18#JJ40j">ExtFaceInfo</a>.</para>
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
            /// <para>Information about the certificate detection result.</para>
            /// <para>For the JSON format, see the example on the right. For more information, see <a href="https://www.alibabacloud.com/help/en/ekyc/latest/im1u641gyesiqmbg?spm=a2c63.p38356.0.i18#iWOBY">ExtIdInfo</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;ocrIdInfo&quot;: {
            ///     &quot;expiryDate&quot;: &quot;&quot;,
            ///     &quot;originOfIssue&quot;: &quot;Exit and Entry Administration of the Ministry of Public Security&quot;,
            ///     &quot;englishName&quot;: &quot;LI SI&quot;,
            ///     &quot;sex&quot;: &quot;Male&quot;,
            ///     &quot;name&quot;: &quot;Li Si&quot;,
            ///     &quot;idNumber&quot;: &quot;H11111112&quot;,
            ///     &quot;issueDate&quot;: &quot;2013-01-02&quot;,
            ///     &quot;birthDate&quot;: &quot;1990-02-21&quot;
            ///   },
            ///   &quot;ocrIdPassed&quot;: &quot;N&quot;,
            ///   &quot;spoofInfo&quot;: {
            ///     &quot;spoofResult&quot;: &quot;Y&quot;,
            ///     &quot;spoofType&quot;: [
            ///       &quot;SCREEN_REMARK&quot;
            ///     ]
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("ExtIdInfo")]
            [Validation(Required=false)]
            public string ExtIdInfo { get; set; }

            /// <summary>
            /// <para>The final authentication result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Y</b>: The authentication is passed.</para>
            /// </description></item>
            /// <item><description><para><b>N</b>: The authentication fails.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <para>A description of the authentication result. For more information, see <a href="https://www.alibabacloud.com/help/en/ekyc/latest/im1u641gyesiqmbg?spm=a2c63.p38356.0.i18#HCGLb">Error codes for ResultObject.SubCode</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>205</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The transaction ID.</para>
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
