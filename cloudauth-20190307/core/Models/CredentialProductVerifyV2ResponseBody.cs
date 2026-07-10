// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialProductVerifyV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130A2C10-B9EE-4D84-88E3-5384FF039795</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result object.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CredentialProductVerifyV2ResponseBodyResultObject ResultObject { get; set; }
        public class CredentialProductVerifyV2ResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The additional information in JSON format.</para>
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
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: low risk</description></item>
            /// <item><description>1: high risk</description></item>
            /// <item><description>2: suspicious.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The risk score map.</para>
            /// </summary>
            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            /// <summary>
            /// <para>The risk labels. Multiple labels are separated by commas. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PS: image manipulation</description></item>
            /// <item><description>LOW_QUALITY_PRODUCT: low quality (low clarity)</description></item>
            /// <item><description>SAME_BACKGROUND: similar image.</description></item>
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
