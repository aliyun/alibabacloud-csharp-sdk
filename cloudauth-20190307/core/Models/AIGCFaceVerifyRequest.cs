// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class AIGCFaceVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded photo.</para>
        /// <remarks>
        /// <para>You can use one of the following methods to pass in the image: FaceContrastPicture, FaceContrastPictureUrl, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FaceContrastPicture")]
        [Validation(Required=false)]
        public string FaceContrastPicture { get; set; }

        /// <summary>
        /// <para>The URL of the face image. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// <remarks>
        /// <para>You can use one of the following methods to pass in the image: FaceContrastPicture, FaceContrastPictureUrl, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("FaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string FaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <para>The name of the authorized OSS bucket.</para>
        /// <remarks>
        /// <para>You can use one of the following methods to pass in the image: FaceContrastPicture, FaceContrastPictureUrl, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-xxxxx</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The file name in the authorized OSS bucket.</para>
        /// <remarks>
        /// <para>You can use one of the following methods to pass in the image: FaceContrastPicture, FaceContrastPictureUrl, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>verify/xxxxx/xxxxxx.jpeg</para>
        /// </summary>
        [NameInMap("OssObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        /// <summary>
        /// <para>The custom business unique identifier on the client side, used for subsequent troubleshooting. The value can contain up to 32 characters, including letters and digits. Make sure the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>The product plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LR_FR_AIGC</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the verification scenario. This ID is automatically generated after you create a verification scenario in the console. For more information about how to create a verification scenario, refer to Add a verification scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000xxxx</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

    }

}
