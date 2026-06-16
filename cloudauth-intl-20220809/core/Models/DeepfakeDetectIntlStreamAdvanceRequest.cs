// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeepfakeDetectIntlStreamAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded face image. For videos, we recommend that you use the stream method for transmission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FaceBase64")]
        [Validation(Required=false)]
        public string FaceBase64 { get; set; }

        /// <summary>
        /// <para>The image input stream.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("FaceFile")]
        [Validation(Required=false)]
        public Stream FaceFileObject { get; set; }

        /// <summary>
        /// <para>The type of facial material input:</para>
        /// <list type="bullet">
        /// <item><description>IMAGE (default): Face image</description></item>
        /// <item><description>VIDEO: Face video</description></item>
        /// </list>
        /// <para>Note
        /// Video processing takes a long time. We recommend that you set the timeout period to more than 3 seconds.</para>
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
        /// <para>The unique identifier of the merchant request. The value is an alphanumeric string with a length of 32 characters.</para>
        /// <para>The first few characters consist of a custom abbreviation defined by the merchant, the middle part can contain a timestamp, and the last part can use a random or incremental sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The product solution to integrate.
        /// Valid value: FACE_DEEPFAKE</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_DEEPFAKE</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>A custom verification scenario ID that you define. This ID is used to query related records in the console.</para>
        /// <para>The value is a combination of letters, digits, or underscores (_) with a maximum length of 10 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****123</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}
