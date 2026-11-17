// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceVerifyIntlAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>Required when ProductCode is set to FACE_IDU_MIN.</para>
        /// <para>Specifies whether to automatically register the face to the specified face library when no duplicate face is retrieved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: automatically register.</description></item>
        /// <item><description>1: do not register. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRegistration")]
        [Validation(Required=false)]
        public string AutoRegistration { get; set; }

        /// <summary>
        /// <para>Specifies whether to return additional face attribute information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>N: do not return. This is the default value.</description></item>
        /// <item><description>Y: return. The result is included in Result.ExtFaceInfo.FaceAttributeInfo.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("FaceAttributeCheck")]
        [Validation(Required=false)]
        public string FaceAttributeCheck { get; set; }

        /// <summary>
        /// <para>Required when ProductCode is set to FACE_IDU_MIN.</para>
        /// <para>The codes of the face libraries created by the customer in the console. You can query up to 10 face libraries at the same time. Separate multiple face library codes with commas.</para>
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
        /// <para>The code of the face library for face registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceRegisterGroupCode")]
        [Validation(Required=false)]
        public string FaceRegisterGroupCode { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier used for subsequent troubleshooting. The value must be a unique combination of up to 32 letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35****</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID or another identifier that can identify a specific user, such as a mobile phone number or email address. Desensitize the value of this field in advance, such as by hashing the value.</para>
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
        /// <para>The custom number of faces to return when multiple faces exceed the matching threshold. Default value: 1. Maximum value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnFaces")]
        [Validation(Required=false)]
        public string ReturnFaces { get; set; }

        /// <summary>
        /// <para>The Base64-encoded portrait photo.</para>
        /// <para>Note</para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass the portrait photo, check the photo size and do not pass oversized photos.</description></item>
        /// <item><description>Specify only one of the following parameters: SourceFacePicture, SourceFacePictureUrl, and SourceFacePictureFile.</description></item>
        /// </list>
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
        public Stream SourceFacePictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the portrait image. The URL must be a publicly accessible HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face1.jpeg</para>
        /// </summary>
        [NameInMap("SourceFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The Base64-encoded reference photo.</para>
        /// <para>Note</para>
        /// <list type="bullet">
        /// <item><description>If you use this method to pass the reference photo, check the photo size and do not pass oversized photos.</description></item>
        /// <item><description>Specify only one of the following parameters: TargetFacePicture, TargetFacePictureUrl, and TargetFacePictureFile.</description></item>
        /// </list>
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
        public Stream TargetFacePictureFileObject { get; set; }

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
        /// <para>Specifies whether to overwrite the existing face with the current face when the MerchantUserId already exists during automatic registration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: overwrite.</description></item>
        /// <item><description>N: do not overwrite and return that the UserId already exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("UpdateFaceIfUserExists")]
        [Validation(Required=false)]
        public string UpdateFaceIfUserExists { get; set; }

        /// <summary>
        /// <para>Required when ProductCode is set to FACE_IDU_MIN.</para>
        /// <para>The verification type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: retrieval mode.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Feature: Passes the face library and the user face image (SourceFacePicture). The system automatically retrieves whether the specified face image (SourceFacePicture) already exists in the face library. Passive liveness detection can be enabled for the face image (SourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: Scenarios where real persons create an account and duplicate registrations are not allowed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>1: verification mode. This is the default value.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Feature: Passes the specified face image (SourceFacePicture) and the reference face image (TargetFacePicture). The system automatically verifies whether the faces match. Passive liveness detection can be enabled for the specified face image (SourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: Scenarios where you need to verify whether the operation is performed by the user in person when modifying logon or account information.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>2: comprehensive mode.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Feature: Passes the face library, the specified face image (SourceFacePicture), and the reference face image (TargetFacePicture) at the same time. The system automatically retrieves whether the specified face image (SourceFacePicture) exists in the face library and whether it matches the reference face. Passive liveness detection can be enabled for the specified face image (SourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: Scenarios where you need to verify that the user is a new user and the operation is performed in person.</description></item>
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
