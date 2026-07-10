// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ContrastFaceVerifyAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The real name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The certificate number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330103xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>The certificate type.
        /// Currently only ID cards are supported. You must set this parameter to IDENTITY_CARD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDENTITY_CARD</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The CertifyId from a previous successful ID Verification. The photo from that verification is used as the comparison photo.</para>
        /// <remarks>
        /// <para>Among the four methods of passing in images (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS), select only one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0bfa7c493f850e5178b9f8613634c9xx</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow cropping of the face image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>T: Allowed.</para>
        /// </description></item>
        /// <item><description><para>F (default): Not allowed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The device token for risk identification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>McozS1ZWRcRZStlERcZZo_QOytx5jcgZoZJEoRLOxxxxxxx</para>
        /// </summary>
        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// <para>The encryption type. An empty value indicates no encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SM2</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>The local video file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("FaceContrastFile")]
        [Validation(Required=false)]
        public Stream FaceContrastFileObject { get; set; }

        /// <summary>
        /// <para>The Base64-encoded photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FaceContrastPicture")]
        [Validation(Required=false)]
        public string FaceContrastPicture { get; set; }

        /// <summary>
        /// <para>The OSS photo URL. Currently only authorized OSS photo URLs are supported.</para>
        /// <remarks>
        /// <para>Among the four methods of passing in images (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS), select only one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("FaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string FaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <para>The IP address of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114.xxx.xxx.xxx</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130xxxxxxxx</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The liveness detection type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FRONT_CAMERA_LIVENESS</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The bucket name of the authorized OSS space.</para>
        /// <remarks>
        /// <para>Among the four methods of passing in images (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS), select only one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-xxxxx</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The file name in the authorized OSS space.</para>
        /// <remarks>
        /// <para>Among the four methods of passing in images (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS), select only one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>verify/xxxxx/xxxxxx.jpeg</para>
        /// </summary>
        [NameInMap("OssObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the merchant request.
        /// The value is a 32-character alphanumeric string. The first few characters are a custom abbreviation defined by the merchant, the middle part can be a time segment, and the last part can be a random or incremental sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>Fixed value: ID_MIN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The verification scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000006</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>The custom user ID defined by the business.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
