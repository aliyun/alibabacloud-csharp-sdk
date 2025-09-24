// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceCompareRequest : TeaModel {
        /// <summary>
        /// <para>是否开启传入人脸图片质量检测</para>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("FacePictureQualityCheck")]
        [Validation(Required=false)]
        public string FacePictureQualityCheck { get; set; }

        /// <summary>
        /// <para>A custom unique business ID used for troubleshooting. It can be a combination of up to 32 letters and digits. Make sure that the ID is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        [NameInMap("SourceFacePicture")]
        [Validation(Required=false)]
        public string SourceFacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the portrait photo. The URL must be an HTTP or HTTPS link accessible over the Internet.</para>
        /// <remarks>
        /// <para>You must specify either SourceFacePicture or SourceFacePictureUrl.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face1.jpeg</para>
        /// </summary>
        [NameInMap("SourceFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceFacePictureUrl { get; set; }

        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the base portrait photo. The URL must be an HTTP or HTTPS link accessible over the Internet.</para>
        /// <remarks>
        /// <para>You must specify either TargetFacePicture or TargetFacePictureUrl.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face2.jpeg</para>
        /// </summary>
        [NameInMap("TargetFacePictureUrl")]
        [Validation(Required=false)]
        public string TargetFacePictureUrl { get; set; }

    }

}
