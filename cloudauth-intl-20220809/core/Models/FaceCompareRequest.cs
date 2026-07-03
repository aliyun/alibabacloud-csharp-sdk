// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceCompareRequest : TeaModel {
        /// <summary>
        /// <para>Whether to enable quality detection for the input face image&gt;Danger: Deprecated</para>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("FacePictureQualityCheck")]
        [Validation(Required=false)]
        public string FacePictureQualityCheck { get; set; }

        /// <summary>
        /// <para>Face quality check</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("FaceQualityCheck")]
        [Validation(Required=false)]
        public string FaceQualityCheck { get; set; }

        /// <summary>
        /// <para>A unique business identifier customized by the merchant, used for subsequent troubleshooting. Supports a combination of letters and numbers with a maximum length of 32 characters. Ensure it is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Base64-encoded face photo.</para>
        /// <para>Note</para>
        /// <list type="bullet">
        /// <item><description>If you choose this method to pass in the photo, check the photo size and do not pass in an oversized photo.</description></item>
        /// <item><description>Either SourceFacePicture or SourceFacePictureUrl must be specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("SourceFacePicture")]
        [Validation(Required=false)]
        public string SourceFacePicture { get; set; }

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
        /// <para>Base64-encoded reference photo.</para>
        /// <para>Note</para>
        /// <list type="bullet">
        /// <item><description>If you choose this method to pass in the photo, check the photo size and do not pass in an oversized photo.</description></item>
        /// <item><description>Either TargetFacePicture or TargetFacePictureUrl must be specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

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
