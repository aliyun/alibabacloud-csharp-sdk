// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CompareFaceVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Whether cropping is allowed. Default is not allowed, T/F.</para>
        /// <list type="bullet">
        /// <item><description>T: Indicates that cropping is required</description></item>
        /// <item><description>F: Indicates that cropping is not required (default F)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>A unique identifier for the merchant\&quot;s request. The value is a 32-character alphanumeric combination, where the first few characters are a custom abbreviation defined by the merchant, followed by a period, and the latter part can be a random or incrementing sequence.</para>
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
        /// <para>Authentication scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000006</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>The CertifyId of a previously successful real-person verification, where the photo taken during that verification is used as the face comparison photo.</para>
        /// <remarks>
        /// <para>Among the four ways to input facial photos (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, OSS), choose one to provide.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0bfa7c493f850e5178b9f8613634c9xx</para>
        /// </summary>
        [NameInMap("SourceCertifyId")]
        [Validation(Required=false)]
        public string SourceCertifyId { get; set; }

        /// <summary>
        /// <para>Base64 encoding of the photo.</para>
        /// <remarks>
        /// <para>Choose one of the four ways to input a face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("SourceFaceContrastPicture")]
        [Validation(Required=false)]
        public string SourceFaceContrastPicture { get; set; }

        /// <summary>
        /// <para>OSS photo URL, currently only supports authorized OSS photo URLs.</para>
        /// <remarks>
        /// <para>Four ways to input face photos: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS. Choose one of them to input.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("SourceFaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string SourceFaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <para>Name of the authorized OSS bucket.</para>
        /// <remarks>
        /// <para>Choose one of the four ways to input face photos: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-xxxxx</para>
        /// </summary>
        [NameInMap("SourceOssBucketName")]
        [Validation(Required=false)]
        public string SourceOssBucketName { get; set; }

        /// <summary>
        /// <para>Filename of the authorized OSS space.</para>
        /// <remarks>
        /// <para>Choose one of the four ways to input face photos: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>verify/xxxxx/xxxxxx.jpeg</para>
        /// </summary>
        [NameInMap("SourceOssObjectName")]
        [Validation(Required=false)]
        public string SourceOssObjectName { get; set; }

        /// <summary>
        /// <para>CertifyId from a previously successful real-person authentication, where the photo taken during the authentication is used for face comparison.</para>
        /// <remarks>
        /// <para>Choose one of the four methods to provide the reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0bfa7c493f850e5178b9f8613634c9xx</para>
        /// </summary>
        [NameInMap("TargetCertifyId")]
        [Validation(Required=false)]
        public string TargetCertifyId { get; set; }

        /// <summary>
        /// <para>Base64 encoding of the reference photo.</para>
        /// <remarks>
        /// <para>Choose one of the four methods to provide the reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("TargetFaceContrastPicture")]
        [Validation(Required=false)]
        public string TargetFaceContrastPicture { get; set; }

        /// <summary>
        /// <para>OSS address of the reference photo. Currently, only authorized OSS addresses are supported.</para>
        /// <remarks>
        /// <para>Choose one of the four methods to provide the reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("TargetFaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string TargetFaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <para>Name of the authorized OSS bucket.</para>
        /// <remarks>
        /// <para>Choose one of the four methods to provide the reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-xxxxx</para>
        /// </summary>
        [NameInMap("TargetOssBucketName")]
        [Validation(Required=false)]
        public string TargetOssBucketName { get; set; }

        /// <summary>
        /// <para>File name in the authorized OSS space.</para>
        /// <remarks>
        /// <para>Choose one of the four methods to provide the reference face photo: FaceContrastPicture, FaceContrastPictureUrl, CertifyId, or OSS.</para>
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
