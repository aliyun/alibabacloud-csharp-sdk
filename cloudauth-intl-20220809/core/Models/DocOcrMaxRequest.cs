// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DocOcrMaxRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable verification with an authoritative data source to enhance document anti-spoofing capabilities.</para>
        /// <list type="bullet">
        /// <item><description><para><b>T</b>: Enable</para>
        /// </description></item>
        /// <item><description><para><b>F</b>: Disable (default)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>Applicable document types</b>: Chinese resident ID cards (CHN01001) and Chinese mainland driver\&quot;s licenses (CHN02001).</description></item>
        /// <item><description><b>Data transfer declaration</b>: If you enable this parameter, you agree to transfer the user\&quot;s name and certificate number to an authoritative data source in the Chinese mainland for consistency verification.</description></item>
        /// <item><description><b>Performance impact:</b> After you enable this feature, the response time of the API operation increases by 1 to 2 seconds. Adjust the timeout setting.</description></item>
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
        /// <para>Page expected to be recognized</para>
        /// <list type="bullet">
        /// <item><description><para>01 (default): ID portrait.</para>
        /// </description></item>
        /// <item><description><para>02: Back of the certificate</para>
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
        /// <para>Document type.
        /// Format: Country (region) code + document type abbreviation + page (optional)
        /// Note: If provided, it will automatically check if it matches the model recognition result; if empty, the document type will be returned after model recognition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNSSC01</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Document image, base64 encoded binary stream</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>Document image URL</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***********.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</para>
        /// </summary>
        [NameInMap("IdOcrPictureUrl")]
        [Validation(Required=false)]
        public string IdOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>Whether to turn on the certificate anti-counterfeiting function:</para>
        /// <list type="bullet">
        /// <item><description><para>T: open</para>
        /// </description></item>
        /// <item><description><para>F (default): not turned on.</para>
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
        /// <para>Custom OCR quality detection threshold mode:</para>
        /// <list type="bullet">
        /// <item><description>0: System default</description></item>
        /// <item><description>1: Strict mode</description></item>
        /// <item><description>2: Lenient mode</description></item>
        /// <item><description>3 (default): Disable quality detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>A unique business identifier defined by the merchant, used for subsequent problem localization and troubleshooting. It supports a combination of letters and numbers, with a maximum length of 32 characters. Please ensure its uniqueness.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c******</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Your custom user ID or other identifiers that can uniquely identify a specific user, such as a phone number or email address. It is strongly recommended to pre-desensitize the value of this field, for example, by hashing it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>OCR recognition mode.
        /// 0: General document mode.
        /// 1: Custom mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrModel")]
        [Validation(Required=false)]
        public string OcrModel { get; set; }

        /// <summary>
        /// <para>Specifies whether to return additional OCR fields in a standardized format:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: No (default)</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Yes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrValueStandard")]
        [Validation(Required=false)]
        public string OcrValueStandard { get; set; }

        /// <summary>
        /// <para>The product solution to be integrated.</para>
        /// <para>Value: ID_OCR_MAX</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_OCR_MAX</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Prompt (for custom mode)</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxocr识别</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>Custom scene code, used to distinguish business scenarios, a 10-digit number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>Whether to enable document anti-counterfeiting function, default is not enabled.</para>
        /// <list type="bullet">
        /// <item><description>T: Enable document anti-counterfeiting function.</description></item>
        /// <item><description>F: Do not enable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("Spoof")]
        [Validation(Required=false)]
        public string Spoof { get; set; }

    }

}
