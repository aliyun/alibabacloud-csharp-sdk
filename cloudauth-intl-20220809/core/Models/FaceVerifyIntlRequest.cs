// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>Required when ProductCode is set to FACE_IDU_MIN.</para>
        /// <para>Specifies whether to automatically register the face to the specified face library when no duplicate face is found during retrieval. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: automatic registration.</description></item>
        /// <item><description>1: no registration. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRegistration")]
        [Validation(Required=false)]
        public string AutoRegistration { get; set; }

        /// <summary>
        /// <para>Required when ProductCode is set to FACE_IDU_MIN.</para>
        /// <para>The face library codes created by the customer through the console. A maximum of 10 face libraries can be queried at the same time. Separate multiple face library codes with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1232344，23444</para>
        /// </summary>
        [NameInMap("FaceGroupCodes")]
        [Validation(Required=false)]
        public string FaceGroupCodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to check the quality of the face image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: enabled.</description></item>
        /// <item><description>N: disabled. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("FaceQualityCheck")]
        [Validation(Required=false)]
        public string FaceQualityCheck { get; set; }

        /// <summary>
        /// <para>Required when ProductCode is set to FACE_IDU_MIN.</para>
        /// <para>The face library for registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceRegisterGroupCode")]
        [Validation(Required=false)]
        public string FaceRegisterGroupCode { get; set; }

        /// <summary>
        /// <para>A custom unique business identifier used for subsequent troubleshooting. The value supports a combination of letters and numbers up to 32 characters in length. Make sure the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35****</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>A custom user ID or other identifier that can identify a specific user, such as a phone number or email address. We strongly recommend that you desensitize the value of this field in advance, for example, by hashing the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>The product code. Valid values: FACE_VERIFY_MIN and FACE_IDU_MIN.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_VERIFY_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Required when ProductCode is set to FACE_IDU_MIN.</para>
        /// <para>Specifies the number of faces to return when multiple faces exist above the matching threshold. You can use this parameter to customize the number of returned faces.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 1.</description></item>
        /// <item><description>Maximum value: 5.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnFaces")]
        [Validation(Required=false)]
        public string ReturnFaces { get; set; }

        /// <summary>
        /// <para>The Base64-encoded portrait image.</para>
        /// <remarks>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass in the image, check the image size and do not pass in an excessively large image.</description></item>
        /// <item><description>Specify one of the following parameters: SourceFacePicture, SourceFacePictureUrl, or SourceFacePictureFile.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("SourceFacePicture")]
        [Validation(Required=false)]
        public string SourceFacePicture { get; set; }

        /// <summary>
        /// <para>The file stream of the face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("SourceFacePictureFile")]
        [Validation(Required=false)]
        public string SourceFacePictureFile { get; set; }

        /// <summary>
        /// <para>The publicly accessible HTTPS URL of the portrait image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face1.jpeg</para>
        /// </summary>
        [NameInMap("SourceFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The Base64-encoded reference face image.</para>
        /// <remarks>
        /// <para><b>Note</b></para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass in the image, check the image size and do not pass in an excessively large image.</description></item>
        /// <item><description>Specify one of the following parameters: TargetFacePicture, TargetFacePictureUrl, or TargetFacePictureFile.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

        /// <summary>
        /// <para>The file stream of the reference face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("TargetFacePictureFile")]
        [Validation(Required=false)]
        public string TargetFacePictureFile { get; set; }

        /// <summary>
        /// <para>The HTTPS URL of the reference face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face2.jpeg</para>
        /// </summary>
        [NameInMap("TargetFacePictureUrl")]
        [Validation(Required=false)]
        public string TargetFacePictureUrl { get; set; }

        /// <summary>
        /// <para>Required when ProductCode is set to FACE_IDU_MIN.
        /// The verification type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: retrieval pattern.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Feature: Pass in a face library and a user face image (sourceFacePicture). The system automatically retrieves whether the specified face image (sourceFacePicture) already exists in the face library. Passive liveness detection can be enabled for the face image (sourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: real-person account creation where duplicate registration is not allowed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>1 (default): authentication pattern.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Feature: Pass in a specified face image (sourceFacePicture) and a reference face image (TargetFacePicture). The system automatically authenticates whether the faces match. Passive liveness detection can be enabled for the specified face image (sourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: authenticating the identity of the user when modifying logon credentials or account information.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>2: comprehensive pattern.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Feature: Pass in a face library, a specified face image (sourceFacePicture), and a reference face image (TargetFacePicture). The system automatically retrieves whether the specified face image (sourceFacePicture) exists in the face library, authenticates whether it matches the reference face, and supports enabling passive liveness detection for the specified face image (sourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: verifying that the user is new and creating an account in person.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VerifyModel")]
        [Validation(Required=false)]
        public string VerifyModel { get; set; }

    }

}
