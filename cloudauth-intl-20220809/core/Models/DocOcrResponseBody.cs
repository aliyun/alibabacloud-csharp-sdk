// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DocOcrResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return message.</para>
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
        /// <para>86C40EC3-5940-5F47-995C-BFE90B70E540</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DocOcrResponseBodyResult Result { get; set; }
        public class DocOcrResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The card and certificate recognition result. This parameter is returned only when the API response is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;idFaceQualityScore&quot;: 98.0
            ///   &quot;ocrIdInfo&quot;: {
            ///     &quot;expiryDate&quot;: &quot;&quot;,
            ///     &quot;originOfIssue&quot;: &quot;公安部出入境管理局&quot;,
            ///     &quot;englishName&quot;: &quot;LI SI&quot;,
            ///     &quot;sex&quot;: &quot;男&quot;,
            ///     &quot;name&quot;: &quot;李四&quot;,
            ///     &quot;idNumber&quot;: &quot;H11111112&quot;,
            ///     &quot;issueDate&quot;: &quot;2013-01-02&quot;,
            ///     &quot;birthDate&quot;: &quot;1990-02-21&quot;
            ///   },
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
            /// <para>Indicates whether the authentication is passed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Y: Passed.</description></item>
            /// <item><description>N: Not passed.</description></item>
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
            /// <para>The unique identifier of the authentication request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08573be80f944d95ac812e019e3655a8</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
