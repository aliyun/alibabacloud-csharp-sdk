// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialSubmitIntlRequest : TeaModel {
        /// <summary>
        /// <para>The field validation rule configuration, which is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;address_rule&quot;: &quot;Includes Adrress Hangzhou***&quot;,
        ///     &quot;name_rule&quot;: &quot;Includes Name  Zhang*&quot;,
        ///     &quot;date_of_issue_rule&quot;: &quot;Whthin 2026.05.20&quot;
        /// }</para>
        /// </summary>
        [NameInMap("CheckRuleConfig")]
        [Validation(Required=false)]
        public string CheckRuleConfig { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image. If you choose this method to upload the image, check the image size and do not upload an excessively large image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("CredentialOcrPictureBase64")]
        [Validation(Required=false)]
        public string CredentialOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The image URL, which must be a publicly accessible HTTP or HTTPS link.</para>
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
        /// <item><description>02: Vehicle registration certificate.</description></item>
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
        /// <para>The material input type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IMAGE: Image. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>PDF: PDF format.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("FileInputType")]
        [Validation(Required=false)]
        public string FileInputType { get; set; }

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
        /// <para>Specifies whether to enable quality detection. Valid values: Y: Enabled. N: Disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdQuality")]
        [Validation(Required=false)]
        public string IdQuality { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier on the merchant side, which is used for subsequent troubleshooting. The identifier can be up to 32 characters in length and can contain letters and digits. Make sure that the identifier is unique.</para>
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
        /// <item><description>0201: Thailand vehicle registration certificate.</description></item>
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
        /// <para>Specifies whether to enable translation. Valid values: 0: Disabled. 1: Enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OcrTranslation")]
        [Validation(Required=false)]
        public string OcrTranslation { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable OCR result standardization. Valid values: 0: Disabled. 1: Enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OcrValueStandard")]
        [Validation(Required=false)]
        public string OcrValueStandard { get; set; }

        /// <summary>
        /// <para>The product solution to be integrated. Valid value: CREDENTIAL_RECOGNITION.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREDENTIAL_RECOGNITION</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The custom authentication scene ID, which is used to query related records in the console. The ID can be up to 10 characters in length and can contain letters, digits, and underscores (_).</para>
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
