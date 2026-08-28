// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialRecognitionIntlRequest : TeaModel {
        /// <summary>
        /// <para>The field check rule configuration, in JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;address_rule&quot;: &quot;Includes Adrress 杭州市***&quot;,
        ///     &quot;name_rule&quot;: &quot;Includes Name  张*&quot;,
        ///     &quot;date_of_issue_rule&quot;: &quot;Whthin 2026.05.20&quot;
        /// }</para>
        /// </summary>
        [NameInMap("CheckRuleConfig")]
        [Validation(Required=false)]
        public string CheckRuleConfig { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image. If you choose to pass in the image by using IdOcrPictureBase64 (Base64-encoded photo), check the photo size and do not pass in an excessively large photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("CredentialOcrPictureBase64")]
        [Validation(Required=false)]
        public string CredentialOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The URL of the image. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***</para>
        /// </summary>
        [NameInMap("CredentialOcrPictureUrl")]
        [Validation(Required=false)]
        public string CredentialOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>The credential type.</para>
        /// <list type="bullet">
        /// <item><description>Transaction credential: 01 (includes various electronic bill images such as water, electricity, gas, and credit card bills)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable tampering detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FraudCheck")]
        [Validation(Required=false)]
        public string FraudCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable quality detection. Valid values: Y (enabled) and N (disabled).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdQuality")]
        [Validation(Required=false)]
        public string IdQuality { get; set; }

        /// <summary>
        /// <para>The extraction type:</para>
        /// <list type="bullet">
        /// <item><description>0101: Electronic bill address and name module (extracts address and name through intelligent analysis)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0101</para>
        /// </summary>
        [NameInMap("OcrArea")]
        [Validation(Required=false)]
        public string OcrArea { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable translation. Valid values: 0 (disabled) and 1 (enabled).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OcrTranslation")]
        [Validation(Required=false)]
        public string OcrTranslation { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable OCR result standardization. Valid values: 0 (disabled) and 1 (enabled).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OcrValueStandard")]
        [Validation(Required=false)]
        public string OcrValueStandard { get; set; }

        /// <summary>
        /// <para>The product solution to use. Set this to CREDENTIAL_RECOGNITION.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREDENTIAL_RECOGNITION</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
