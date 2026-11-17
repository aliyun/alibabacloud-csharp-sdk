// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class EkycVerifyV2AdvanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable authoritative identity verification. This feature applies only to second-generation ID cards in mainland China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow cropping. Default value: F. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: Allowed.</description></item>
        /// <item><description>F: Not allowed (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The real name of the user. If Authorize is set to T and the document type is a mainland China ID card, you must provide at least one of the following: key document information (DocName and DocNo) or document images (IdOcrPictureBase64 or URL). Note: The value must contain one or more Chinese characters and no special characters, except for the middle dot (·) used in ethnic minority names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang**</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The document number of the user. If Authorize is set to T and the document type is a mainland China ID card, you must provide at least one of the following: key document information (DocName and DocNo) or document images (IdOcrPictureBase64 or URL). Note: The value must be an 18-character combination of letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>410***************</para>
        /// </summary>
        [NameInMap("DocNo")]
        [Validation(Required=false)]
        public string DocNo { get; set; }

        /// <summary>
        /// <para>The document type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000001</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>The Base64-encoded facial image. Notes:</para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass the facial image, check the image size and do not upload oversized images.</description></item>
        /// <item><description>Specify only one of FacePictureBase64, FacePictureUrl, and FacePictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        /// <summary>
        /// <para>The file stream of the facial image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("FacePictureFile")]
        [Validation(Required=false)]
        public Stream FacePictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the facial image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable facial quality check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("FaceQualityCheck")]
        [Validation(Required=false)]
        public string FaceQualityCheck { get; set; }

        /// <summary>
        /// <para>The Base64-encoded image of the document. Notes:</para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass the document image, check the image size and do not upload oversized images.</description></item>
        /// <item><description>Specify only one of IdOcrPictureBase64, IdOcrPictureUrl, and IdOcrPictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The file stream of the front image of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("IdOcrPictureFile")]
        [Validation(Required=false)]
        public Stream IdOcrPictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the front image of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("IdOcrPictureUrl")]
        [Validation(Required=false)]
        public string IdOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable document anti-spoofing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
        /// <para>The custom OCR quality check threshold mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: System default.</description></item>
        /// <item><description>1: Strict mode.</description></item>
        /// <item><description>2: Loose mode.</description></item>
        /// <item><description>3: Quality check disabled (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier on the merchant side, used for subsequent troubleshooting. The value must be a unique combination of up to 32 letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID or other identifier that identifies a specific user, such as a mobile phone number or email address. Desensitize the value of this field in advance, such as by hashing the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eKYC_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
