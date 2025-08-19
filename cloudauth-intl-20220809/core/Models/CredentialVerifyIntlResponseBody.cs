// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 for success, others for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message.</para>
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
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF039795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CredentialVerifyIntlResponseBodyResultObject ResultObject { get; set; }
        public class CredentialVerifyIntlResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Other information in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///  &quot;sameBackgroundDetail&quot;: {
            ///  // 相似背景对于的原始图请求RequestId
            ///  &quot;originalRequestId&quot;: &quot;130A2C10-B9EE-4D84-88E3-5384FF03****&quot;;
            ///  // 相似背景对于的原始图请求商户ID 
            ///  &quot;originalMerchantId&quot;: &quot;xxxxxxxx&quot; 
            ///  }
            /// }</para>
            /// </summary>
            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public string MaterialInfo { get; set; }

            /// <summary>
            /// <para>Risk result:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Low risk</description></item>
            /// <item><description><b>1</b>: High risk</description></item>
            /// <item><description><b>2</b>: Suspicious</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>Risk score map</para>
            /// </summary>
            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            /// <summary>
            /// <para>Risk tags, separated by commas (,). Includes:</para>
            /// <list type="bullet">
            /// <item><description>PS: Image manipulation (Photoshop)</description></item>
            /// <item><description>SCREEN_PHOTO: Screen recapture</description></item>
            /// <item><description>SCREENSHOT: Screenshot</description></item>
            /// <item><description>ORIGINAL_PHOTO: Not original image</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PS</para>
            /// </summary>
            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

        }

    }

}
