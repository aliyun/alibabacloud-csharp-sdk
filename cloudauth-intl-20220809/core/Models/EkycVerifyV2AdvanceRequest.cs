// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class EkycVerifyV2AdvanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable authoritative identity verification. Currently, this feature is applicable only to second-generation ID cards of mainland China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        /// <summary>
        /// <para>Specifies whether cropping is allowed. Not allowed by default. Valid values: T and F.</para>
        /// <list type="bullet">
        /// <item><description>T: Cropping is allowed.</description></item>
        /// <item><description>F: Cropping is not allowed. (Default: F)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The real name of the user. When Authorize=\&quot;T\&quot; and the document type is a mainland China ID card, at least one of the following groups must be provided: document key information (DocName, DocNo) or document image (IdOcrPictureBase64/URL). Note: Supports combinations of Chinese characters with a length of at least 1 character. Special characters are not supported, except for the middle dot (·) used in ethnic minority names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张**</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The document number of the user. When Authorize=\&quot;T\&quot; and the document type is a mainland China ID card, at least one of the following groups must be provided: document key information (DocName, DocNo) or document image (IdOcrPictureBase64/URL). Note: Supports a combination of letters and digits with a length of 18 characters.</para>
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
        /// <para>The Base64-encoded face image.</para>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass the face image, check the photo size and do not pass an overly large photo.</description></item>
        /// <item><description>You can only specify one of FacePictureBase64, FacePictureUrl, and FacePictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        /// <summary>
        /// <para>The file stream of the face photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("FacePictureFile")]
        [Validation(Required=false)]
        public Stream FacePictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the face photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        [NameInMap("FaceQualityCheck")]
        [Validation(Required=false)]
        public string FaceQualityCheck { get; set; }

        /// <summary>
        /// <para>The Base64-encoded document image. Note:</para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass the document image, check the photo size and do not pass an overly large photo.</description></item>
        /// <item><description>You can only specify one of IdOcrPictureBase64, IdOcrPictureUrl, and IdOcrPictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The file stream of the front side of the document image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("IdOcrPictureFile")]
        [Validation(Required=false)]
        public Stream IdOcrPictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the front side of the document image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("IdOcrPictureUrl")]
        [Validation(Required=false)]
        public string IdOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>The custom OCR quality detection threshold mode:</para>
        /// <list type="bullet">
        /// <item><description>0: System default.</description></item>
        /// <item><description>1: Strict mode.</description></item>
        /// <item><description>2: Lenient mode.</description></item>
        /// <item><description>3 (Default): Quality detection is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>A unique business identifier customized by the merchant, used for subsequent troubleshooting. Supports a combination of letters and digits with a length of 32 characters. Ensure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>A custom user ID or other identifier that can identify a specific user, such as a phone number or email address. We strongly recommend that you desensitize the value of this field in advance, for example, by hashing the value.</para>
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
