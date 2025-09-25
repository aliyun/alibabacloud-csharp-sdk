// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ContrastFaceVerifyAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>Real name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>ID number</para>
        /// 
        /// <b>Example:</b>
        /// <para>330103xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CertNo")]
        [Validation(Required=false)]
        public string CertNo { get; set; }

        /// <summary>
        /// <para>Type of identification. Currently, only IDENTITY_CARD is supported and must be provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDENTITY_CARD</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The CertifyId of a previously passed real-person authentication, with the photo taken during that authentication used as the comparison photo. </para>
        /// <remarks>
        /// <para>Among the four ways to input images (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, OSS), choose one to provide.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0bfa7c493f850e5178b9f8613634c9xx</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>Allow face image cropping:</para>
        /// <list type="bullet">
        /// <item><description><b>T</b> – Cropping is allowed.</description></item>
        /// <item><description><b>F</b> (default) – Cropping is not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>Risk Identification - Device Token</para>
        /// 
        /// <b>Example:</b>
        /// <para>McozS1ZWRcRZStlERcZZo_QOytx5jcgZoZJEoRLOxxxxxxx</para>
        /// </summary>
        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// <para>Encryption type. Leave it empty if no encryption is required.</para>
        /// <para>If you enable encrypted transmission, you must specify the encryption algorithm; currently, only the SM2 (Chinese national standard) algorithm is supported.</para>
        /// <para>When an encryption algorithm is specified, encrypt both <b>CertName</b> and <b>CertNo</b> and submit the resulting ciphertext. For more details on parameter encryption, see the <a href="https://help.aliyun.com/zh/id-verification/financial-grade-id-verification/description-of-parameter-encryption?spm=a2c4g.11186623.0.0.49541a8554cELI#task-2229332">Parameter Encryption documentation</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SM2</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>Local video file.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("FaceContrastFile")]
        [Validation(Required=false)]
        public Stream FaceContrastFileObject { get; set; }

        /// <summary>
        /// <para>Base64 encoded photo</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FaceContrastPicture")]
        [Validation(Required=false)]
        public string FaceContrastPicture { get; set; }

        /// <summary>
        /// <para>OSS photo URL, currently only supports authorized OSS photo URLs.</para>
        /// <remarks>
        /// <para>Among the four ways to input images (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, OSS), choose one to input.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("FaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string FaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <para>User IP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114.xxx.xxx.xxx</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>User\&quot;s phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>130xxxxxxxx</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>Liveness detection type. Possible values:</para>
        /// <para>• <b>NO_LIVENESS</b> – Liveness detection is disabled.</para>
        /// <para>• <b>FRONT_CAMERA_LIVENESS</b> (default) – Liveness detection on face images captured with the mobile device’s front camera.</para>
        /// <para>• <b>REAR_CAMERA_LIVENESS</b> – Liveness detection on face images captured in other scenarios (e.g., via the rear camera).</para>
        /// 
        /// <b>Example:</b>
        /// <para>FRONT_CAMERA_LIVENESS</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Authorized OSS space Bucket name. In the methods of passing images, including FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS, choose one to pass in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-xxxxx</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>Filename of the authorized OSS space.</para>
        /// <remarks>
        /// <para>Among the four ways to input images (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, OSS), choose one to input.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>verify/xxxxx/xxxxxx.jpeg</para>
        /// </summary>
        [NameInMap("OssObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        /// <summary>
        /// <para>A unique identifier for the merchant\&quot;s request. It is a 32-character alphanumeric combination. The first few characters are a custom abbreviation defined by the merchant, followed by a period, and the latter part can be a random or incrementing sequence.</para>
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
        /// <para>Authentication scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000006</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>Custom user ID defined by the customer\&quot;s business.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
