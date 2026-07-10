// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class LivenessFaceVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The unique identity of the ID Verification request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91707dc296d469ad38e4c5efa6a0f24b</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow trim of the face image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>T: Trim is allowed.</para>
        /// </description></item>
        /// <item><description><para>F (default): Trim is not allowed.</para>
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
        /// <para>The device token, which is used for risk identification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>McozS1ZWRcRZStlERcZZo_QOytx5jcgZoZJEoRLOxxxxxxx</para>
        /// </summary>
        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// <para>The Base64 encoding of the photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FaceContrastPicture")]
        [Validation(Required=false)]
        public string FaceContrastPicture { get; set; }

        /// <summary>
        /// <para>The URL of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ware.cdeledu.com/upfile/uploadPic/2025/03/21/dd62fbb9c966433ab0ba9a7252816b30.jpg">https://ware.cdeledu.com/upfile/uploadPic/2025/03/21/dd62fbb9c966433ab0ba9a7252816b30.jpg</a></para>
        /// </summary>
        [NameInMap("FaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string FaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <para>The IP address of the user network.</para>
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
        /// <para>The liveness detection parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FRONT_CAMERA_LIVENESS</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The bucket name of the authorization-granted OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-aliyun-cloudauth-1494517779820665</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The file name in the authorization-granted OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>facedetect/17483113370916034.jpg</para>
        /// </summary>
        [NameInMap("OssObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        /// <summary>
        /// <para>The custom business unique identity on the client side, which is used for subsequent troubleshooting. The value can contain up to 32 alphanumeric characters. Make sure the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>Fixed value: LR_FR_MIN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LR_FR_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the authentication scenario. This ID is automatically generated after you create an authentication scenario in the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000****</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>The custom user ID (up to 100 characters). Make sure the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
