// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceLivenessV2AdvanceRequest : TeaModel {
        [NameInMap("FaceAttributeCheck")]
        [Validation(Required=false)]
        public string FaceAttributeCheck { get; set; }

        /// <summary>
        /// <para>The Base64-encoded face image.</para>
        /// <remarks>
        /// <para><b>Note</b></para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass in the image, check the image size and do not pass in an excessively large image.</description></item>
        /// <item><description>Specify one of the following parameters: FacePictureBase64, FacePictureUrl, or FacePictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        /// <summary>
        /// <para>The file stream of the face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("FacePictureFile")]
        [Validation(Required=false)]
        public Stream FacePictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the face image. The URL must be a publicly accessible HTTPS URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***</para>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the quality of the face image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: enabled.</description></item>
        /// <item><description>N: disabled. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("FaceQualityCheck")]
        [Validation(Required=false)]
        public string FaceQualityCheck { get; set; }

        /// <summary>
        /// <para>The merchant-defined unique business ID for subsequent troubleshooting. The value can be a combination of letters and digits with a maximum length of 32 characters. Make sure the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID or another identifier that can identify a specific user, such as a phone number or email address. We strongly recommend that you desensitize the value of this field in advance, for example, by hashing the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>The product plan to use. Valid values: FACE_LIVENESS_MIN_PRO and FACE_LIVENESS_MIN.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_LIVENESS_MIN_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
