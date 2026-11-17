// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceDuplicationCheckIntlRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically register the face to the specified face library if no duplicate face is found during the search. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Register.</description></item>
        /// <item><description>1: Do not register. This is the default value.</description></item>
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
        /// <item><description>N: Do not return. This is the default value.</description></item>
        /// <item><description>Y: Return. The result is located in Result.ExtFaceInfo.FaceAttributeInfo.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("FaceAttributeCheck")]
        [Validation(Required=false)]
        public string FaceAttributeCheck { get; set; }

        /// <summary>
        /// <para>The codes of the face libraries created by the customer in the console. A maximum of 10 face libraries can be queried at the same time. Separate multiple face library codes with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1232344，23444</para>
        /// </summary>
        [NameInMap("FaceGroupCodes")]
        [Validation(Required=false)]
        public string FaceGroupCodes { get; set; }

        /// <summary>
        /// <para>The face quality check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("FaceQualityCheck")]
        [Validation(Required=false)]
        public string FaceQualityCheck { get; set; }

        /// <summary>
        /// <para>The code of the face library for face registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceRegisterGroupCode")]
        [Validation(Required=false)]
        public string FaceRegisterGroupCode { get; set; }

        /// <summary>
        /// <para>The face matching threshold. <warning>Reserved field. Not enabled yet.</warning></para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("FaceVerifyThreshold")]
        [Validation(Required=false)]
        public string FaceVerifyThreshold { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable passive liveness detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Disable.</description></item>
        /// <item><description>1: Enable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier used for subsequent troubleshooting. The value supports a combination of up to 32 letters and digits. Make sure that the value is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35****</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID or other identifier that can identify a specific user, such as a mobile phone number or email address. Desensitize the value of this field in advance, such as by hashing the value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FACE_IDU_MIN</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Specifies the number of faces to return when multiple faces exceed the matching threshold. Default value: 1. Maximum value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnFaces")]
        [Validation(Required=false)]
        public string ReturnFaces { get; set; }

        /// <summary>
        /// <para>Specifies the type of face data to save. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Face image. This is the default value.</description></item>
        /// <item><description>1: Face feature.
        /// <warning>Reserved field. Not enabled yet.</warning></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SaveFacePicture")]
        [Validation(Required=false)]
        public string SaveFacePicture { get; set; }

        /// <summary>
        /// <para>The custom authentication scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The Base64-encoded portrait photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("SourceFacePicture")]
        [Validation(Required=false)]
        public string SourceFacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the portrait image. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face1.jpeg</para>
        /// </summary>
        [NameInMap("SourceFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The Base64-encoded portrait photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the portrait image. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face2.jpeg</para>
        /// </summary>
        [NameInMap("TargetFacePictureUrl")]
        [Validation(Required=false)]
        public string TargetFacePictureUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the original face with the current face if the MerchantUserId already exists during automatic registration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: Overwrite.</description></item>
        /// <item><description>N: Do not overwrite and return that the UserId already exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("UpdateFaceIfUserExists")]
        [Validation(Required=false)]
        public string UpdateFaceIfUserExists { get; set; }

        /// <summary>
        /// <para>The authentication type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Retrieve pattern<list type="bullet">
        /// <item><description>Feature: The system receives a face library and a user face image (sourceFacePicture), and automatically retrieves from the face library to check whether the specified face image (sourceFacePicture) already exists. Passive liveness detection can be enabled for the face image (sourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: Scenarios where a real person needs to create an account and duplicate registration is not allowed.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>1 (default): Authenticate pattern<list type="bullet">
        /// <item><description>Feature: The system receives a specified face image (sourceFacePicture) and a retained face image (TargetFacePicture), and automatically authenticates whether the faces match. Passive liveness detection can be enabled for the specified face image (sourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: Scenarios where it is required to authenticate whether the operation is performed by the user when modifying logon or account information.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>2: Comprehensive pattern<list type="bullet">
        /// <item><description>Feature: The system receives a face library, a specified face image (sourceFacePicture), and a retained face image (TargetFacePicture) at the same time, and automatically retrieves from the face library to check whether the specified face image (sourceFacePicture) exists and authenticates whether it matches the retained face. Passive liveness detection can be enabled for the specified face image (sourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: Scenarios where it is required to authenticate that the user is a new user and the operation is performed by the user.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VerifyModel")]
        [Validation(Required=false)]
        public string VerifyModel { get; set; }

    }

}
