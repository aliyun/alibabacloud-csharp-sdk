// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class EkycVerifyV2Request : TeaModel {
        /// <summary>
        /// <para>Indicates whether to enable authoritative identity verification. This parameter currently applies only to second-generation ID cards issued in the Chinese mainland.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        /// <summary>
        /// <para>Indicates whether clipping is allowed. Clipping is disabled by default (T/F).</para>
        /// <list type="bullet">
        /// <item><description>T: Detection is required.</description></item>
        /// <item><description>F: Detection is required (default is F).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The user\&quot;s real name. When Authorize=\&quot;T\&quot; and the certificate type is a Chinese mainland ID card, you must provide at least one of the following: key certificate information (DocName, DocNo) or certificate image (IdOcrPictureBase64/URL). Note: It supports combinations of one or more Chinese characters, excluding special characters except for the interpunct 【·】 used in ethnic minority names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张**</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The user\&quot;s certificate number. When Authorize=\&quot;T\&quot; and the certificate type is a Chinese mainland ID card, you must provide at least one of the following: key certificate information (DocName, DocNo) or certificate image (IdOcrPictureBase64/URL). Note: It supports a combination of letters and digits with a length of 18 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>410***************</para>
        /// </summary>
        [NameInMap("DocNo")]
        [Validation(Required=false)]
        public string DocNo { get; set; }

        /// <summary>
        /// <para>Certificate type</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000001</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Base64 encoding of the facial image.</para>
        /// <para>Notes:</para>
        /// <list type="bullet">
        /// <item><description>If you choose this method to submit the certificate image, check the image size and avoid uploading excessively large images.</description></item>
        /// <item><description>You must specify exactly one of FacePictureBase64, FacePictureUrl, or FacePictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        /// <summary>
        /// <para>File stream of the facial photo</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("FacePictureFile")]
        [Validation(Required=false)]
        public string FacePictureFile { get; set; }

        /// <summary>
        /// <para>URL of the facial photo</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        /// <summary>
        /// <para>Base64-encoded certificate Image. Notes:</para>
        /// <list type="bullet">
        /// <item><description>If you use this method to submit the certificate image, check the image size and avoid uploading excessively large images.</description></item>
        /// <item><description>You must specify exactly one of IdOcrPictureBase64, IdOcrPictureUrl, or IdOcrPictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>File stream of the front side of the certificate</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("IdOcrPictureFile")]
        [Validation(Required=false)]
        public string IdOcrPictureFile { get; set; }

        /// <summary>
        /// <para>URL of the front side of the certificate</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-cardocr-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("IdOcrPictureUrl")]
        [Validation(Required=false)]
        public string IdOcrPictureUrl { get; set; }

        /// <summary>
        /// <para>Custom OCR quality detection threshold mode:</para>
        /// <list type="bullet">
        /// <item><description>0: System default</description></item>
        /// <item><description>1: Strict mode</description></item>
        /// <item><description>2: Loose mode</description></item>
        /// <item><description>3 (default): Shutdown quality detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>A custom business UUID defined by the merchant, used for subsequent issue tracking and troubleshooting. It supports a combination of letters and digits with a length of 32 characters. Ensure its uniqueness.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Your custom user ID or another identifier that can uniquely identify a specific user, such as a mobile phone number or mailbox address. We strongly recommend pre-masking the value of this field—for example, by applying a hash function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Product code</para>
        /// 
        /// <b>Example:</b>
        /// <para>eKYC_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
