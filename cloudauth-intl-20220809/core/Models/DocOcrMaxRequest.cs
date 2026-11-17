// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DocOcrMaxRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable authoritative data source verification to enhance the anti-spoofing capability of identity documents. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>T</b>: Enabled.</description></item>
        /// <item><description><b>F</b>: Not enabled (default).<remarks>
        /// <list type="bullet">
        /// <item><description><b>Applicable identity document types</b>: Chinese resident identity card (CHN01001) and Chinese mainland driver\&quot;s license (CHN02001).</description></item>
        /// <item><description><b>Data transmission statement</b>: Enabling this parameter indicates that you agree to transmit the user\&quot;s name and identity document number to an authoritative data source in the Chinese mainland for consistency verification.</description></item>
        /// <item><description><b>Performance impact</b>: After this parameter is enabled, the API response time increases by about 1 to 2 seconds. Adjust the timeout settings accordingly.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        /// <summary>
        /// <para>The page to be recognized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>01: portrait side of the identity document (default)</description></item>
        /// <item><description>02: back side of the identity document</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("DocPage")]
        [Validation(Required=false)]
        public string DocPage { get; set; }

        /// <summary>
        /// <para>The type of the identity document.</para>
        /// <list type="bullet">
        /// <item><description>Format: country code + identity document type abbreviation + page (optional).</description></item>
        /// </list>
        /// <para>Note</para>
        /// <list type="bullet">
        /// <item><description>OcrModel = 0: DocType is required and specifies the identity document type. The existing logic remains unchanged.</description></item>
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
        /// <para>The Base64-encoded image of the identity document. If you choose to pass the identity document image by using the IdOcrPictureBase64 (Base64-encoded image) method, check the image size and do not pass an excessively large image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The URL of the identity document image. The URL must be an HTTP or HTTPS link that is accessible over the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***********.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</para>
        /// </summary>
        [NameInMap("IdOcrPictureUrl")]
        [Validation(Required=false)]
        public string IdOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the identity document anti-spoofing feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: Enabled.</description></item>
        /// <item><description>F: Not enabled (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
        /// <para>The custom OCR quality check threshold mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: system default</description></item>
        /// <item><description>1: strict mode</description></item>
        /// <item><description>2: loose mode</description></item>
        /// <item><description>3: disable quality check (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier, which is used to locate and troubleshoot issues later. The value can be up to 32 characters in length and can contain letters and digits. Make sure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c******</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID or other identifiers that can identify a specific user, such as a mobile phone number or an email address. Desensitize the value of this field in advance, such as by hashing the value.</para>
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
        /// <item><description>0: general identity document recognition mode (default)</description></item>
        /// <item><description>1: automatic identity document classification mode</description></item>
        /// <item><description>2: automatic identity document classification and general recognition mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrModel")]
        [Validation(Required=false)]
        public string OcrModel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the standardization of key fields in OCR recognition. Valid values:</para>
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
        /// <para>The product solution to be integrated. Valid value: ID_OCR_MAX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_OCR_MAX</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>Deprecated</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The custom authentication scene ID, which is used to query related records by entering this scene ID in the console later. The value can be up to 10 characters in length and can contain letters, digits, and underscores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>Deprecated</para>
        /// </summary>
        [NameInMap("Spoof")]
        [Validation(Required=false)]
        public string Spoof { get; set; }

    }

}
