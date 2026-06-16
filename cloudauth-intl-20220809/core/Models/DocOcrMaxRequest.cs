// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DocOcrMaxRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable authoritative data source verification to enhance document anti-forgery capabilities.</para>
        /// <list type="bullet">
        /// <item><description><para><b>T</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>F</b>: disabled (default).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>Applicable document types</b>: China resident identity card (CHN01001) and Chinese mainland driver\&quot;s license (CHN02001).</description></item>
        /// <item><description><b>Data transmission statement</b>: Enabling this parameter indicates your consent to transmit the user\&quot;s name and document number to an authoritative data source in the Chinese mainland for consistency verification.</description></item>
        /// <item><description><b>Performance impact</b>: After this feature is enabled, the API response time increases by approximately 1 to 2 seconds. Adjust the timeout settings accordingly.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        /// <summary>
        /// <para>The expected page to recognize. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>01 (default): the portrait side of the document.</para>
        /// </description></item>
        /// <item><description><para>02: the back side of the document.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("DocPage")]
        [Validation(Required=false)]
        public string DocPage { get; set; }

        /// <summary>
        /// <para>The document type.</para>
        /// <list type="bullet">
        /// <item><description>Format: country code + document type abbreviation + page (optional).</description></item>
        /// </list>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description>OcrModel = 0: DocType is required. Specify the document type. The existing logic remains unchanged.</description></item>
        /// <item><description>OcrModel = 1 or 2: DocType must be left empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CNSSC01</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image of the card or certificate.</para>
        /// <para>If you use IdOcrPictureBase64 to pass in the document image, check the image size and do not pass in an excessively large image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The URL of the card or certificate image. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***********.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</para>
        /// </summary>
        [NameInMap("IdOcrPictureUrl")]
        [Validation(Required=false)]
        public string IdOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the document anti-forgery feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>T: enabled.</para>
        /// </description></item>
        /// <item><description><para>F (default): disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
        /// <para>The custom OCR quality detection threshold mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: system default.</description></item>
        /// <item><description>1: strict mode.</description></item>
        /// <item><description>2: loose mode.</description></item>
        /// <item><description>3 (default): quality detection disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier, which is used for subsequent troubleshooting.</para>
        /// <para>The value can contain up to 32 characters, including letters and digits. Make sure the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c******</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID or another identifier that can identify a specific user, such as a phone number or email address.</para>
        /// <para>We strongly recommend that you desensitize the value of this field in advance, for example, by hashing the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>The OCR recognition mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: general document recognition mode (default).</para>
        /// </description></item>
        /// <item><description><para>1: automatic document classification mode.</para>
        /// </description></item>
        /// <item><description><para>2: automatic document classification + general recognition mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrModel")]
        [Validation(Required=false)]
        public string OcrModel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable OCR key field standardization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no (default). </description></item>
        /// <item><description>1: yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrValueStandard")]
        [Validation(Required=false)]
        public string OcrValueStandard { get; set; }

        /// <summary>
        /// <para>The product solution to use.</para>
        /// <para>Set this parameter to ID_OCR_MAX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_OCR_MAX</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Warning: This field is deprecated.</warning>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>已废弃</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The custom authentication scenario ID. You can use this scenario ID to query related records in the console.</para>
        /// <para>The value can contain up to 10 characters, including letters, digits, and underscores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para><warning>This field is deprecated.</warning>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>已废弃</para>
        /// </summary>
        [NameInMap("Spoof")]
        [Validation(Required=false)]
        public string Spoof { get; set; }

    }

}
