// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialProductVerifyV2ResponseBody : TeaModel {
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
        /// <para>Result object.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CredentialProductVerifyV2ResponseBodyResultObject ResultObject { get; set; }
        public class CredentialProductVerifyV2ResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Additional information in JSON format.</para>
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
            /// <list type="bullet">
            /// <item><description>0: Low risk</description></item>
            /// <item><description>1: High risk</description></item>
            /// <item><description>2: Suspicious</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>Map of risk scores.</para>
            /// </summary>
            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            /// <summary>
            /// <para>Risk tags, separated by commas, including:</para>
            /// <list type="bullet">
            /// <item><description>PS: Image has been photoshopped</description></item>
            /// <item><description>LOW_QUALITY_PRODUCT: Low quality (low clarity)</description></item>
            /// <item><description>SAME_BACKGROUND: Similar background</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PS,LOW_QUALITY_PRODUCT</para>
            /// </summary>
            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

        }

    }

}
