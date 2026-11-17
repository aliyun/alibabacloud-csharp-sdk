// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeepfakeDetectIntlStreamRequest : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded string of the face image. For videos, pass the data as a stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FaceBase64")]
        [Validation(Required=false)]
        public string FaceBase64 { get; set; }

        /// <summary>
        /// <para>The input stream of the image.</para>
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
        /// <para>The input type of the face material. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMAGE: face image. This is the default value.</description></item>
        /// <item><description>VIDEO: face video.</description></item>
        /// </list>
        /// <para>Note: Video processing takes a long time. Set the timeout period to a value greater than 3 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("FaceInputType")]
        [Validation(Required=false)]
        public string FaceInputType { get; set; }

        /// <summary>
        /// <para>The URL of the face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("FaceUrl")]
        [Validation(Required=false)]
        public string FaceUrl { get; set; }

        /// <summary>
        /// <para>The unique identifier of the merchant request. The value is a 32-character alphanumeric string. The first few characters consist of a custom merchant abbreviation, the middle part can contain a time period, and the latter part can be a random or incremental sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The product solution to be integrated. Valid values: FACE_DEEPFAKE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_DEEPFAKE</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The custom authentication scenario ID, which is used to query related records by entering this scenario ID in the console. The value must be 10 characters in length and can contain letters, digits, and underscores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****123</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}
