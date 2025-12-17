// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceCrossCompareIntlRequest : TeaModel {
        /// <summary>
        /// <para>Comparison mode</para>
        /// <list type="bullet">
        /// <item><description>0-Chain comparison (default): A:B and B:C</description></item>
        /// <item><description>1-Circular comparison: A:B and B:C and C:A</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CompareModel")]
        [Validation(Required=false)]
        public string CompareModel { get; set; }

        /// <summary>
        /// <para>Face matching threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("FaceVerifyThreshold")]
        [Validation(Required=false)]
        public string FaceVerifyThreshold { get; set; }

        /// <summary>
        /// <para>A unique business identifier for subsequent troubleshooting. It supports a combination of 32 alphanumeric characters, please ensure its uniqueness.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35****</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Product solution to be integrated. Value: 
        /// FACE_CROSS_COMPARE</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_CROSS_COMPARE</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Custom business scenario ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        [NameInMap("SourceAFacePicture")]
        [Validation(Required=false)]
        public string SourceAFacePicture { get; set; }

        /// <summary>
        /// <para>Portrait image URL, accessible via HTTP or HTTPS on the public network.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxx.com/1.jpg">https://www.xxx.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("SourceAFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceAFacePictureUrl { get; set; }

        [NameInMap("SourceBFacePicture")]
        [Validation(Required=false)]
        public string SourceBFacePicture { get; set; }

        /// <summary>
        /// <para>Portrait image URL, accessible via HTTP or HTTPS on the public network.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxx.com/1.jpg">https://www.xxx.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("SourceBFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceBFacePictureUrl { get; set; }

        [NameInMap("SourceCFacePicture")]
        [Validation(Required=false)]
        public string SourceCFacePicture { get; set; }

        /// <summary>
        /// <para>Portrait image URL, accessible via HTTP or HTTPS on the public network.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxx.com/1.jpg">https://www.xxx.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("SourceCFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceCFacePictureUrl { get; set; }

    }

}
