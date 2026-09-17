// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialRecognitionIntlV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates a successful request. Other values indicate failures.</para>
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
        /// <para>7F971622-38C0-5F56-B2EC-315367979B4F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CredentialRecognitionIntlV2ResponseBodyResult Result { get; set; }
        public class CredentialRecognitionIntlV2ResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The recognized key information, in JSON format.</para>
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
            /// <item><description>200: OCR extraction succeeded and all rule checks passed.</description></item>
            /// <item><description>204: Validation result is inconsistent. OCR extraction succeeded, but some fields in CheckRuleConfig did not pass (N).</description></item>
            /// <item><description>211: Quality does not meet requirements. Quality detection did not pass when idQuality is set to Y (not yet supported in the current version).</description></item>
            /// <item><description>212: Anti-forgery check did not pass. fraudCheck was triggered and anti-forgery verification failed.</description></item>
            /// <item><description>213: No text was extracted, or the credential type check did not pass.</description></item>
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
            /// <item><description>S: Succeeded.</description></item>
            /// <item><description>F: Failed.</description></item>
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
