// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class EkycVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable identity verification against the official database:</para>
        /// <list type="bullet">
        /// <item><description><para><b>T</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>F</b>: Disable. (Default)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This feature is currently available only for second-generation resident ID cards of the Chinese mainland.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        /// <summary>
        /// <para>Specifies whether to crop the face image:</para>
        /// <list type="bullet">
        /// <item><description><para><b>T</b>: Allows cropping.</para>
        /// </description></item>
        /// <item><description><para><b>F</b>: Disallows cropping. (Default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The user\&quot;s real name.</para>
        /// <remarks>
        /// <para>If Authorize is set to T and the certificate type is Chinese mainland resident ID card, you must enter at least one of the following groups of information:</para>
        /// <list type="bullet">
        /// <item><description>DocName and DocNo.</description></item>
        /// <item><description>IdOcrPictureBase64 or IdOcrPictureUrl.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The user\&quot;s certificate number.</para>
        /// <remarks>
        /// <para>If Authorize is set to <b>T</b> and the certificate type is Chinese mainland resident ID card, you must enter at least one of the following groups of information:</para>
        /// <list type="bullet">
        /// <item><description>DocName and DocNo.</description></item>
        /// <item><description>IdOcrPictureBase64 or IdOcrPictureUrl.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>410***************</para>
        /// </summary>
        [NameInMap("DocNo")]
        [Validation(Required=false)]
        public string DocNo { get; set; }

        /// <summary>
        /// <para>The certificate type, which is uniquely identified by an 8-digit number. For more information, see <a href="https://www.alibabacloud.com/help/en/ekyc/latest/im1u641gyesiqmbg?spm=a2c63.p38356.0.i18#Hu5TG">Certificate types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000001</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        /// <summary>
        /// <para>The URL of the portrait image. The URL must be an HTTP or HTTPS link accessible over the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        [NameInMap("IdOcrPictureBase64")]
        [Validation(Required=false)]
        public string IdOcrPictureBase64 { get; set; }

        /// <summary>
        /// <para>The URL of the certificate image. The URL must be an HTTP or HTTPS link accessible over the Internet.</para>
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
        /// <item><description><para><b>0</b>: Standard mode</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Strict mode</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Loose mode</para>
        /// </description></item>
        /// <item><description><para><b>3</b> (default): Disables quality detection</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>A unique business identifier that you customize. It is used to locate and troubleshoot issues. The identifier can be up to 32 characters in length and can contain letters and digits. Make sure that the identifier is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>A custom user ID or another identifier that can identify a specific user, such as a mobile number or an email address. Desensitize the value of this field in advance, for example, by hashing the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>The product solution to integrate. Set the value to <b>eKYC_MIN</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eKYC_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
