// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceLivenessRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow cropping. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: Cropping is allowed.</description></item>
        /// <item><description>F: Cropping is not allowed. Default value: F.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The face attribute check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("FaceAttributeCheck")]
        [Validation(Required=false)]
        public string FaceAttributeCheck { get; set; }

        /// <summary>
        /// <para>The Base64-encoded string of the photo.</para>
        /// <para>Note:</para>
        /// <list type="bullet">
        /// <item><description>If you use the FacePictureBase64 parameter to pass the face photo, check the photo size and do not pass photos that are too large.</description></item>
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
        /// <para>Specifies whether to output the face quality score. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: The detection is required.</description></item>
        /// <item><description>F: The detection is not required. Default value: F.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("FaceQuality")]
        [Validation(Required=false)]
        public string FaceQuality { get; set; }

        /// <summary>
        /// <para>The face quality check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("FaceQualityCheck")]
        [Validation(Required=false)]
        public string FaceQualityCheck { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier on the merchant side, used for subsequent troubleshooting. It supports a combination of letters and digits, with a maximum length of 32 characters. Ensure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The merchant user ID or another identifier used to identify a specific user, such as a phone number or email address. Desensitize the value of the userId field in advance, such as by hashing the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform occlusion detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T: Occlusion detection is required.</description></item>
        /// <item><description>F: Occlusion detection is not required. Default value: F.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Occlusion")]
        [Validation(Required=false)]
        public string Occlusion { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_LIVENESS_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
