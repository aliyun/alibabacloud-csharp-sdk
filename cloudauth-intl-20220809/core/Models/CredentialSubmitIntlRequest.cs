// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialSubmitIntlRequest : TeaModel {
        /// <summary>
        /// <para>The field validation rule configuration in JSON string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;address_rule&quot;: &quot;Includes Address Hangzhou***&quot;,
        ///     &quot;name_rule&quot;: &quot;Includes Name Zhang*&quot;,
        ///     &quot;date_of_issue_rule&quot;: &quot;Whthin 2026.05.20&quot;
        /// }</para>
        /// </summary>
        [NameInMap("CheckRuleConfig")]
        [Validation(Required=false)]
        public string CheckRuleConfig { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image. If you use this method to submit a photo, check the photo size and do not submit an excessively large photo.</para>
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
        /// <para>The credential type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>02: vehicle registration certificate</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
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
        /// <para>false</para>
        /// </summary>
        [NameInMap("FraudCheck")]
        [Validation(Required=false)]
        public string FraudCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable quality detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: Enabled.</description></item>
        /// <item><description>N: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdQuality")]
        [Validation(Required=false)]
        public string IdQuality { get; set; }

        /// <summary>
        /// <para>The merchant-defined unique business identifier, used for subsequent troubleshooting. The value can be a combination of letters and numbers with a maximum length of 32 characters. Ensure that the value is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The extraction type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0201: Thailand vehicle registration certificate</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0201</para>
        /// </summary>
        [NameInMap("OcrArea")]
        [Validation(Required=false)]
        public string OcrArea { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable translation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Disabled.</description></item>
        /// <item><description>1: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OcrTranslation")]
        [Validation(Required=false)]
        public string OcrTranslation { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable OCR result standardization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Disabled.</description></item>
        /// <item><description>1: Enabled.</description></item>
        /// </list>
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

        /// <summary>
        /// <para>The custom authentication scenario ID. You can use this ID to query related records in the console. The value can be a combination of letters, numbers, or underscores with a maximum length of 10 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****123</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}
