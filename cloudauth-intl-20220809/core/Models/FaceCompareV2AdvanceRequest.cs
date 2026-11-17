// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceCompareV2AdvanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable quality check for the input face image.</para>
        /// <remarks>
        /// <para>Danger: <b>[Deprecated]</b></danger></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("FacePictureQualityCheck")]
        [Validation(Required=false)]
        public string FacePictureQualityCheck { get; set; }

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
        /// <para>The custom unique business identifier on the merchant side, which is used for subsequent troubleshooting. It supports a combination of letters and digits, with a maximum length of 32 characters. Ensure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The Base64-encoded portrait photo.</para>
        /// <para>Note</para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass the face image, check the image size and do not pass oversized images.</description></item>
        /// <item><description>Specify only one of the following parameters: SourceFacePicture, SourceFacePictureUrl, and SourceFacePictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("SourceFacePicture")]
        [Validation(Required=false)]
        public string SourceFacePicture { get; set; }

        /// <summary>
        /// <para>The file stream of the face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("SourceFacePictureFile")]
        [Validation(Required=false)]
        public Stream SourceFacePictureFileObject { get; set; }

        /// <summary>
        /// <para>The HTTPS or HTTP URL of the face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face1.jpeg</para>
        /// </summary>
        [NameInMap("SourceFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The Base64-encoded reference photo.</para>
        /// <para>Note</para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass the reference photo, check the photo size and do not pass oversized photos.</description></item>
        /// <item><description>Specify only one of the following parameters: TargetFacePicture, TargetFacePictureUrl, and TargetFacePictureFile.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

        /// <summary>
        /// <para>The file stream of the reference face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("TargetFacePictureFile")]
        [Validation(Required=false)]
        public Stream TargetFacePictureFileObject { get; set; }

        /// <summary>
        /// <para>The HTTPS or HTTP URL of the reference face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face2.jpeg</para>
        /// </summary>
        [NameInMap("TargetFacePictureUrl")]
        [Validation(Required=false)]
        public string TargetFacePictureUrl { get; set; }

    }

}
