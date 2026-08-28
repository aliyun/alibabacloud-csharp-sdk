// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class EkycVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable authoritative identity verification. Currently, this applies only to second-generation ID cards in mainland China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        /// <summary>
        /// <para>Specifies whether cropping is allowed. By default, cropping is not allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: Detection is required.</description></item>
        /// <item><description>F: Detection is required. (Default value: F)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The real name of the user. When Authorize=\&quot;T\&quot; and the document type is a mainland China ID card, either the key document information (DocName, DocNo) or the document image (IdOcrPictureBase64/URL) must be provided.
        /// Note: Supports a combination of Chinese characters with a minimum length of one character. No special characters are allowed, except for the middle dot (·) used in ethnic minority names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang**</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The document number of the user. When Authorize=\&quot;T\&quot; and the document type is a mainland China ID card, either the key document information (DocName, DocNo) or the document image (IdOcrPictureBase64/URL) must be provided.
        /// Note: Supports a combination of letters and numbers with a length of 18 characters.</para>
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
        /// <item><description>If you choose this method to pass in the face image, check the photo size and do not pass in an excessively large photo.</description></item>
        /// <item><description>Specify either FacePictureBase64 or FacePictureUrl.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        /// <summary>
        /// <para>The URL of the face photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable face quality detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("FaceQualityCheck")]
        [Validation(Required=false)]
        public string FaceQualityCheck { get; set; }

        /// <summary>
        /// <para>The Base64-encoded document image.
        /// Note:</para>
        /// <list type="bullet">
        /// <item><description>If you choose this method to pass in the document image, check the photo size and do not pass in an excessively large photo.</description></item>
        /// <item><description>Specify either IdOcrPictureBase64 or IdOcrPictureUrl.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

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
        /// <para>Specifies whether to enable document anti-spoofing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
        /// <para>The custom OCR quality detection threshold mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: system default</description></item>
        /// <item><description>1: strict mode</description></item>
        /// <item><description>2: loose mode</description></item>
        /// <item><description>3 (default): disable quality detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>A custom business unique identifier defined by the merchant, used for subsequent issue tracking and troubleshooting. Supports a combination of letters and numbers up to 32 characters in length. Ensure that this value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>A custom user ID or other identifier that can identify a specific user, such as a phone number or email address. We strongly recommend that you desensitize this field value in advance, for example, by hashing the value.</para>
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
