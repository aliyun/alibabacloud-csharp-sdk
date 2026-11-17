// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialSubmitIntlV2AdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The field validation rule configuration. The value is a JSON string.</para>
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
        /// <para>The Base64-encoded image. If you choose this method to upload the photo, check the photo size and do not upload excessively large photos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("CredentialOcrPictureBase64")]
        [Validation(Required=false)]
        public string CredentialOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The image file stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("CredentialOcrPictureFile")]
        [Validation(Required=false)]
        public Stream CredentialOcrPictureFileObject { get; set; }

        /// <summary>
        /// <para>The image URL. The URL must be an HTTP or HTTPS link accessible over the Internet.</para>
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
        /// <item><description>01: transaction credential, including electronic bill images for water, electricity, gas, and credit cards</description></item>
        /// <item><description>02: vehicle registration certificate</description></item>
        /// <item><description>03: transfer transaction record</description></item>
        /// <item><description>04: proof of address (POA)</description></item>
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
        /// <item><description>IMAGE: image (default)</description></item>
        /// <item><description>PDF: PDF format</description></item>
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
        /// <item><description>true: enabled</description></item>
        /// <item><description>false: disabled</description></item>
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
        /// <para>Specifies whether to enable quality detection. Valid values: Y: enabled, N: disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdQuality")]
        [Validation(Required=false)]
        public string IdQuality { get; set; }

        /// <summary>
        /// <para>The unique identifier of the merchant request. The value is a 32-character alphanumeric string. The first few characters consist of a custom merchant abbreviation, the middle part can include a time period, and the latter part can be a random or incremental sequence.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dso932dsjsd22</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The extraction type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0101: electronic bill address and name module, which extracts the address and name module through intelligent analysis</description></item>
        /// <item><description>0201: </description></item>
        /// <item><description>0301: transfer transaction record amount information</description></item>
        /// <item><description>0401: POA credential extraction information</description></item>
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
        /// <para>Specifies whether to enable translation. Valid values: 0: disabled, 1: enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OcrTranslation")]
        [Validation(Required=false)]
        public string OcrTranslation { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable standardization of key fields in OCR recognition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no (default) </description></item>
        /// <item><description>1: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrValueStandard")]
        [Validation(Required=false)]
        public string OcrValueStandard { get; set; }

        /// <summary>
        /// <para>The product solution to be integrated. Valid values: CREDENTIAL_RECOGNITION.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREDENTIAL_RECOGNITION</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The custom authentication scenario ID. This ID is used to query related records in the console. The value can be up to 10 characters in length and can contain letters, digits, and underscores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}
