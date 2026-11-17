// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialRecognitionIntlV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates that the request is successful. Other values indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>7F971622-38C0-5F56-B2EC-315367979B4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CredentialRecognitionIntlV2ResponseBodyResult Result { get; set; }
        public class CredentialRecognitionIntlV2ResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The recognized key information in JSON format.</para>
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
            /// <para>The result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>200: OCR extraction is successful and all rule checks are passed</description></item>
            /// <item><description>204: verification results are inconsistent. OCR extraction is successful, but some fields in CheckRuleConfig fail the check (N)</description></item>
            /// <item><description>211: quality does not meet the requirements. Quality detection fails when idQuality is set to Y. This feature is not available in the current version</description></item>
            /// <item><description>212: anti-counterfeiting check fails. fraudCheck is triggered and anti-counterfeiting verification fails</description></item>
            /// <item><description>213: no text is extracted or the credential type check fails</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            /// <summary>
            /// <para>The extraction result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>S: success.</description></item>
            /// <item><description>F: failure.</description></item>
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
