// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CardOcrResponseBody : TeaModel {
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
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB356FE-BB6A-5DCC-B4C5-E8051787EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CardOcrResponseBodyResult Result { get; set; }
        public class CardOcrResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Document recognition result</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;idFaceQualityScore&quot;: 98.90,
            ///   &quot;ocrIdInfo&quot;: {
            ///     &quot;expiryDate&quot;: &quot;2024-04-20&quot;,
            ///     &quot;placeOfIssue&quot;: &quot;广东&quot;,
            ///     &quot;englishName&quot;: &quot;ZHENGJIAN,YANGBEN&quot;,
            ///     &quot;originOfIssue&quot;: &quot;公安部出入境管理局&quot;,
            ///     &quot;sex&quot;: &quot;女&quot;,
            ///     &quot;name&quot;: &quot;证件样本&quot;,
            ///     &quot;idNumber&quot;: &quot;C00000000&quot;,
            ///     &quot;issueDate&quot;: &quot;2014-04-21&quot;,
            ///     &quot;birthDate&quot;: &quot;1981-08-03&quot;
            ///   },
            ///   &quot;spoofInfo&quot;: {
            ///     &quot;spoofResult&quot;: &quot;N&quot;,
            ///     &quot;spoofType&quot;: [
            ///       &quot;SCREEN_REMARK&quot;
            ///     ]
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("ExtCardInfo")]
            [Validation(Required=false)]
            public string ExtCardInfo { get; set; }

            /// <summary>
            /// <para>Additional result information</para>
            /// 
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("ExtIdInfo")]
            [Validation(Required=false)]
            public string ExtIdInfo { get; set; }

            /// <summary>
            /// <para>Whether the authentication passed.</para>
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
            /// <para>Sub-result code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>Unique identifier for the authentication request</para>
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
