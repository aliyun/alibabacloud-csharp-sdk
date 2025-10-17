// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeepfakeDetectIntlStreamRequest : TeaModel {
        /// <summary>
        /// <para>Enter the Base64 encoded format of the face image; for video formats, it is recommended to input via stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FaceBase64")]
        [Validation(Required=false)]
        public string FaceBase64 { get; set; }

        /// <summary>
        /// <para>Image input stream.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("FaceFile")]
        [Validation(Required=false)]
        public string FaceFile { get; set; }

        /// <summary>
        /// <para>Face material input type:</para>
        /// <list type="bullet">
        /// <item><description>IMAGE (default): Face image</description></item>
        /// <item><description>VIDEO: Face video</description></item>
        /// </list>
        /// <para>Note: Video processing takes longer, it is recommended to set the timeout &gt; 3S.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("FaceInputType")]
        [Validation(Required=false)]
        public string FaceInputType { get; set; }

        /// <summary>
        /// <para>Enter the URL address of the face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("FaceUrl")]
        [Validation(Required=false)]
        public string FaceUrl { get; set; }

        /// <summary>
        /// <para>A unique identifier for the merchant\&quot;s request, consisting of a 32-character alphanumeric combination.</para>
        /// <para>The first few characters are composed of a custom abbreviation defined by the merchant, the middle part can include a period of time, and the latter part can use a random or incremental sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The product solution to be integrated.
        /// Value: FACE_DEEPFAKE</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_DEEPFAKE</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Your custom authentication scenario ID, used for querying related records by entering this scenario ID in the console later.</para>
        /// <para>Supports a combination of 10 characters, including letters, numbers, or underscores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****123</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}
