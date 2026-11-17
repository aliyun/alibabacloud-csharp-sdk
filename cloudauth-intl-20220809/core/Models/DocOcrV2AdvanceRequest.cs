// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DocOcrV2AdvanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the side of the ID card, which can be the national emblem side or the portrait side. If you do not specify this parameter, the portrait side is used by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OCR_ID_FACE: the portrait side. Default value.</description></item>
        /// <item><description>OCR_ID_NATIONAL_EMBLEM: the national emblem side.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OCR_ID_FACE</para>
        /// </summary>
        [NameInMap("CardSide")]
        [Validation(Required=false)]
        public string CardSide { get; set; }

        /// <summary>
        /// <para>The type of the ID card.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000006</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform face quality check for the ID card. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: Face quality check is performed.</description></item>
        /// <item><description>F: Face quality check is not performed. Default value: F.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("IdFaceQuality")]
        [Validation(Required=false)]
        public string IdFaceQuality { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image of the ID card.</para>
        /// <para>If you choose to pass the ID card photo by using the Base64-encoded image (IdOcrPictureBase64), check the photo size and do not pass oversized photos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The file stream of the front image of the ID card.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("IdOcrPictureFile")]
        [Validation(Required=false)]
        public Stream IdOcrPictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the front image of the ID card.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("IdOcrPictureUrl")]
        [Validation(Required=false)]
        public string IdOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>The custom threshold mode for OCR quality check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: system default.</description></item>
        /// <item><description>1: strict mode.</description></item>
        /// <item><description>2: loose mode.</description></item>
        /// <item><description>3: disables quality check. Default value: 3.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier on the merchant side, which is used for subsequent troubleshooting. It supports a combination of letters and digits, with a maximum length of 32 characters. Make sure that the identifier is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dso9322***dsjsd22</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID in the business. Make sure that the ID is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform OCR on the ID card. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: OCR is performed on the ID card.</description></item>
        /// <item><description>F: OCR is not performed on the ID card.</description></item>
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
        /// <para>Product solution type ID_OCR_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable anti-spoofing check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: Anti-spoofing check is enabled.</description></item>
        /// <item><description>F: Anti-spoofing check is disabled.</description></item>
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
