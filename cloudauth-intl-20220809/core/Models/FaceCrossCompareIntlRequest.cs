// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceCrossCompareIntlRequest : TeaModel {
        /// <summary>
        /// <para>The comparison mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: chain comparison (default). A:B and B:C.</description></item>
        /// <item><description>1: circular comparison. A:B, B:C, and C:A.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CompareModel")]
        [Validation(Required=false)]
        public string CompareModel { get; set; }

        /// <summary>
        /// <para>The face matching threshold. This parameter is reserved by the system and does not support custom values.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("FaceVerifyThreshold")]
        [Validation(Required=false)]
        public string FaceVerifyThreshold { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier, used for subsequent troubleshooting. The value is a combination of letters and digits with a length of 32 characters. Ensure that the value is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35****</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The product solution to use. Valid values:
        /// FACE_CROSS_COMPARE.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_CROSS_COMPARE</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The custom business scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The Base64-encoded face photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("SourceAFacePicture")]
        [Validation(Required=false)]
        public string SourceAFacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the face photo. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxx.com/1.jpg">https://www.xxx.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("SourceAFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceAFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The Base64-encoded face photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("SourceBFacePicture")]
        [Validation(Required=false)]
        public string SourceBFacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the face photo. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxx.com/1.jpg">https://www.xxx.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("SourceBFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceBFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The Base64-encoded face photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("SourceCFacePicture")]
        [Validation(Required=false)]
        public string SourceCFacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the face photo. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxx.com/1.jpg">https://www.xxx.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("SourceCFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceCFacePictureUrl { get; set; }

    }

}
