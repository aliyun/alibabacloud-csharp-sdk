// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DeepfakeDetectRequest : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded face image.</para>
        /// <remarks>
        /// <para>Specify either FaceUrl or FaceBase64.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FaceBase64")]
        [Validation(Required=false)]
        public string FaceBase64 { get; set; }

        /// <summary>
        /// <para>The input type of the face material. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IMAGE (default): face image</description></item>
        /// <item><description>VIDEO: face video</description></item>
        /// </list>
        /// <remarks>
        /// <para>Video processing takes longer. Set the timeout to more than 3 seconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("FaceInputType")]
        [Validation(Required=false)]
        public string FaceInputType { get; set; }

        /// <summary>
        /// <para>The URL of the face image.</para>
        /// <remarks>
        /// <para>Specify either FaceUrl or FaceBase64.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("FaceUrl")]
        [Validation(Required=false)]
        public string FaceUrl { get; set; }

        /// <summary>
        /// <para>The unique identifier of the merchant request. The value is a 32-character alphanumeric string. The first few characters consist of a custom merchant abbreviation, the middle part can contain a time segment, and the last part can use a random or incremental sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c******</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

    }

}
