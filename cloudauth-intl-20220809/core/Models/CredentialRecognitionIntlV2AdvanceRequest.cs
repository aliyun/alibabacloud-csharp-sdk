// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CredentialRecognitionIntlV2AdvanceRequest : TeaModel {
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
        /// <para>The Base64-encoded image. If you choose to pass the photo by using IdOcrPictureBase64, check the photo size and do not pass excessively large photos.</para>
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
        /// <para>The image URL. The URL must be a publicly accessible HTTP or HTTPS link.</para>
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
        /// <item><description>01: transaction receipt, including electronic bills for utilities and credit cards</description></item>
        /// <item><description>02: vehicle registration certificate</description></item>
        /// <item><description>03: transfer transaction record</description></item>
        /// <item><description>04: proof of address (POA)</description></item>
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
        /// <para>The material input type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMAGE: image</description></item>
        /// <item><description>PDF: PDF format
        /// Default value: IMAGE.</description></item>
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
        /// <item><description>true: enables tampering detection.</description></item>
        /// <item><description>false: disables tampering detection.</description></item>
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
        /// <item><description>Y: enables quality detection.</description></item>
        /// <item><description>N: disables quality detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdQuality")]
        [Validation(Required=false)]
        public string IdQuality { get; set; }

        /// <summary>
        /// <para>The extraction type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0101: electronic bill address and name module, which extracts the address and name module through intelligent analysis</description></item>
        /// <item><description>0201: Thailand vehicle registration certificate</description></item>
        /// <item><description>0301: transfer transaction record amount information</description></item>
        /// <item><description>0401: POA credential extraction information</description></item>
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
        /// <para>Specifies whether to enable translation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disables translation.</description></item>
        /// <item><description>1: enables translation.</description></item>
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
        /// <item><description>0: disables OCR result standardization.</description></item>
        /// <item><description>1: enables OCR result standardization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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

    }

}
