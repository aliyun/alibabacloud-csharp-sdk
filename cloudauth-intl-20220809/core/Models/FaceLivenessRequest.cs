// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceLivenessRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to crop the facial image. The default value is F.</para>
        /// <list type="bullet">
        /// <item><description><para><b>T</b>: allows cropping.</para>
        /// </description></item>
        /// <item><description><para><b>F</b>: Forbidden</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

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

        /// <summary>
        /// <para>Specifies whether to return the facial image quality score. The default value is F.</para>
        /// <list type="bullet">
        /// <item><description><para><b>T</b>: returns the score.</para>
        /// </description></item>
        /// <item><description><para><b>F</b>: does not return the score.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("FaceQuality")]
        [Validation(Required=false)]
        public string FaceQuality { get; set; }

        /// <summary>
        /// <para>A custom unique business identifier. You can use this identifier to track and troubleshoot issues. The identifier can be up to 32 characters in length and can contain letters and digits. Make sure the identifier is unique.</para>
        /// <remarks>
        /// <para>Alibaba Cloud servers do not check the uniqueness of this value. For better tracking, ensure this value is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>A  custom user ID or another identifier for a specific user, such as a mobile number or email address. For security, desensitize this value in advance, for example, by hashing it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable occlusion detection. The default value is F.</para>
        /// <list type="bullet">
        /// <item><description><para><b>T</b>: enables the feature.</para>
        /// </description></item>
        /// <item><description><para><b>F</b>: disables the feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Occlusion")]
        [Validation(Required=false)]
        public string Occlusion { get; set; }

        /// <summary>
        /// <para>The product solution to use. Set the value to <b>FACE_LIVENESS_MIN</b> to use the passive liveness detection API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_LIVENESS_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
