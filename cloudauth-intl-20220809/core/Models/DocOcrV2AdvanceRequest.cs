// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DocOcrV2AdvanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the side of the certificate. If this parameter is not specified, the portrait side is used by default.</para>
        /// <list type="bullet">
        /// <item><description><para>OCR_ID_FACE (default): the portrait side</para>
        /// </description></item>
        /// <item><description><para>OCR_ID_NATIONAL_EMBLEM: the national emblem side.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OCR_ID_FACE</para>
        /// </summary>
        [NameInMap("CardSide")]
        [Validation(Required=false)]
        public string CardSide { get; set; }

        /// <summary>
        /// <para>The certificate type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000006</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform face quality detection on the certificate.</para>
        /// <list type="bullet">
        /// <item><description>T: Detection is required.</description></item>
        /// <item><description>F: Detection is not required. (Default: F).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("IdFaceQuality")]
        [Validation(Required=false)]
        public string IdFaceQuality { get; set; }

        /// <summary>
        /// <para>The Base64-encoded card or certificate image.</para>
        /// <para>If you use IdOcrPictureBase64 to pass in the certificate image, check the image size and do not pass in an excessively large image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The file stream of the front side of the certificate image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("IdOcrPictureFile")]
        [Validation(Required=false)]
        public Stream IdOcrPictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the front side of the certificate image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("IdOcrPictureUrl")]
        [Validation(Required=false)]
        public string IdOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>The custom OCR quality detection threshold mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: system default</description></item>
        /// <item><description>1: strict mode</description></item>
        /// <item><description>2: loose mode</description></item>
        /// <item><description>3 (default): quality detection is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>The merchant-defined unique business ID used for subsequent troubleshooting. The value can contain letters and digits with a maximum length of 32 characters. Ensure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dso9322***dsjsd22</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID defined in your business. Ensure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform certificate OCR.</para>
        /// <list type="bullet">
        /// <item><description>T: OCR is required.</description></item>
        /// <item><description>F: OCR is not required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Ocr")]
        [Validation(Required=false)]
        public string Ocr { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>产品方案类型ID_OCR_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable anti-spoofing detection.</para>
        /// <list type="bullet">
        /// <item><description>T: Anti-spoofing is enabled.</description></item>
        /// <item><description>F: Anti-spoofing is disabled.</description></item>
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
