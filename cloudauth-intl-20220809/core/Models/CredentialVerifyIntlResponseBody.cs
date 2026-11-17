// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialVerifyIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success, and other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF039795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CredentialVerifyIntlResponseBodyResultObject ResultObject { get; set; }
        public class CredentialVerifyIntlResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The additional information in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///  &quot;sameBackgroundDetail&quot;: {
            ///  // The request ID of the original image request corresponding to the similar background
            ///  &quot;originalRequestId&quot;: &quot;130A2C10-B9EE-4D84-88E3-5384FF03****&quot;;
            ///  // The merchant ID of the original image request corresponding to the similar background 
            ///  &quot;originalMerchantId&quot;: &quot;xxxxxxxx&quot; 
            ///  }
            /// }</para>
            /// </summary>
            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public string MaterialInfo { get; set; }

            /// <summary>
            /// <para>The risk result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: low risk</description></item>
            /// <item><description><b>1</b>: high risk</description></item>
            /// <item><description><b>2</b>: suspicious</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The map of risk scores.</para>
            /// </summary>
            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            /// <summary>
            /// <para>The risk tags. Multiple tags are separated by commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PS: The image is edited by using Photoshop.</description></item>
            /// <item><description>SCREEN_PHOTO: The image is a photo of a screen.</description></item>
            /// <item><description>SCREENSHOT: The image is a screenshot.</description></item>
            /// <item><description>ORIGINAL_PHOTO: The image is not an original image.</description></item>
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
