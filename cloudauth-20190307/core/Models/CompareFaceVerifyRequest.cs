// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFaceVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether cropping is allowed. Default value: F.</para>
        /// <list type="bullet">
        /// <item><description>T: detection is required.</description></item>
        /// <item><description>F: detection is required. (Default: F).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The unique identifier of the merchant request.</para>
        /// <para>The value is a 32-character alphanumeric string. The first few characters are a custom abbreviation defined by the merchant, the middle part can be a time segment, and the last part can be a random or incremental sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>Fixed value: PV_FC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PV_FC</para>
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
        /// <para>The CertifyId from a previous successful ID Verification. The photo captured during that verification is used as the face comparison photo.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0bfa7c493f850e5178b9f8613634c9xx</para>
        /// </summary>
        [NameInMap("SourceCertifyId")]
        [Validation(Required=false)]
        public string SourceCertifyId { get; set; }

        /// <summary>
        /// <para>The Base64-encoded photo.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("SourceFaceContrastPicture")]
        [Validation(Required=false)]
        public string SourceFaceContrastPicture { get; set; }

        /// <summary>
        /// <para>The OSS photo URL. Only authorized OSS photo URLs are supported.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("SourceFaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string SourceFaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <para>The bucket name of the authorized OSS space.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-xxxxx</para>
        /// </summary>
        [NameInMap("SourceOssBucketName")]
        [Validation(Required=false)]
        public string SourceOssBucketName { get; set; }

        /// <summary>
        /// <para>The file name in the authorized OSS space.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>verify/xxxxx/xxxxxx.jpeg</para>
        /// </summary>
        [NameInMap("SourceOssObjectName")]
        [Validation(Required=false)]
        public string SourceOssObjectName { get; set; }

        /// <summary>
        /// <para>The CertifyId from a previous successful ID Verification. The photo captured during that verification is used as the face comparison photo.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0bfa7c493f850e5178b9f8613634c9xx</para>
        /// </summary>
        [NameInMap("TargetCertifyId")]
        [Validation(Required=false)]
        public string TargetCertifyId { get; set; }

        /// <summary>
        /// <para>The Base64-encoded reference photo.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("TargetFaceContrastPicture")]
        [Validation(Required=false)]
        public string TargetFaceContrastPicture { get; set; }

        /// <summary>
        /// <para>The OSS URL of the reference photo. Only authorized OSS photo URLs are supported.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("TargetFaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string TargetFaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <para>The bucket name of the authorized OSS space.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-xxxxx</para>
        /// </summary>
        [NameInMap("TargetOssBucketName")]
        [Validation(Required=false)]
        public string TargetOssBucketName { get; set; }

        /// <summary>
        /// <para>The file name in the authorized OSS space.</para>
        /// <remarks>
        /// <para>You can use one of the following four methods to submit a reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS. Select one method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>verify/xxxxx/xxxxxx.jpeg</para>
        /// </summary>
        [NameInMap("TargetOssObjectName")]
        [Validation(Required=false)]
        public string TargetOssObjectName { get; set; }

    }

}
