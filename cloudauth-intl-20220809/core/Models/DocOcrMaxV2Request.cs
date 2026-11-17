// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DocOcrMaxV2Request : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable authoritative data source verification to enhance the ID document anti-counterfeiting capability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>T</b>: enabled.</description></item>
        /// <item><description><b>F</b>: disabled (default).</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>Applicable ID document types</b>: Chinese resident identity card (CHN01001) and Chinese mainland driver\&quot;s license (CHN02001).</description></item>
        /// <item><description><b>Data transmission statement</b>: Enabling this parameter indicates that you agree to transmit the user\&quot;s name and ID document number to an authoritative data source in the Chinese mainland for consistency verification.</description></item>
        /// <item><description><b>Performance impact</b>: After this parameter is enabled, the API response time increases by about 1 to 2 seconds. Adjust the timeout settings accordingly.</description></item>
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
        /// <para>The page to be recognized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>01: the portrait side of the ID document (default).</description></item>
        /// <item><description>02: the back side of the ID document.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("DocPage")]
        [Validation(Required=false)]
        public string DocPage { get; set; }

        /// <summary>
        /// <para>The type of the ID document.</para>
        /// <list type="bullet">
        /// <item><description>Format: country code + ID document type abbreviation + page (optional).</description></item>
        /// </list>
        /// <para>Note</para>
        /// <list type="bullet">
        /// <item><description>If OcrModel is set to 0, DocType is required and specifies the ID document type. The existing logic remains unchanged.</description></item>
        /// <item><description>If OcrModel is set to 1 or 2, DocType must be left empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CHN01001</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image of the ID document. If you use the IdOcrPictureBase64 parameter to pass the Base64-encoded photo of the ID document, check the photo size and do not upload excessively large photos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The file stream of the ID document image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("IdOcrPictureFile")]
        [Validation(Required=false)]
        public string IdOcrPictureFile { get; set; }

        /// <summary>
        /// <para>The URL of the ID document image. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***********.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</para>
        /// </summary>
        [NameInMap("IdOcrPictureUrl")]
        [Validation(Required=false)]
        public string IdOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the ID document anti-counterfeiting feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: enabled.</description></item>
        /// <item><description>F: disabled (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
        /// <para>The custom threshold mode for OCR quality detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: system default.</description></item>
        /// <item><description>1: strict mode.</description></item>
        /// <item><description>2: loose mode.</description></item>
        /// <item><description>3: disable quality detection (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier on the merchant side, which is used for subsequent troubleshooting. The value can be up to 32 characters in length and can contain letters and digits. Make sure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID or other identifier that can identify a specific user, such as a mobile phone number or an email address. Desensitize the value of this field in advance, for example, by hashing the value.</para>
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
        /// <item><description>0: general ID document recognition mode (default).</description></item>
        /// <item><description>1: automatic ID document classification mode.</description></item>
        /// <item><description>2: automatic ID document classification and general recognition mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrModel")]
        [Validation(Required=false)]
        public string OcrModel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable standardization for key OCR fields. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disabled (default).</description></item>
        /// <item><description>1: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrValueStandard")]
        [Validation(Required=false)]
        public string OcrValueStandard { get; set; }

        /// <summary>
        /// <para>The product solution to access. Valid value: ID_OCR_MAX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_OCR_MAX</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The custom authentication scene ID, which is used to query related records by entering this scene ID in the console later. The value can be up to 10 characters in length and can contain letters, digits, and underscores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}
