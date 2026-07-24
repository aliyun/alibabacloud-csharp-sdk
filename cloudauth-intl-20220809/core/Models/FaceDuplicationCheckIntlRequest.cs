// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class FaceDuplicationCheckIntlRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically register the face in the specified face library when no duplicate face is found during the search. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: automatic registration</description></item>
        /// <item><description>1: no registration (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRegistration")]
        [Validation(Required=false)]
        public string AutoRegistration { get; set; }

        [NameInMap("FaceAttributeCheck")]
        [Validation(Required=false)]
        public string FaceAttributeCheck { get; set; }

        /// <summary>
        /// <para>The face library codes created through the console. A maximum of 10 face libraries can be queried at the same time. Separate multiple face library codes with commas (,).</para>
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
        /// <para>The face library for registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceRegisterGroupCode")]
        [Validation(Required=false)]
        public string FaceRegisterGroupCode { get; set; }

        /// <summary>
        /// <para>The face matching threshold. &gt;Warning: This is a reserved field and is not currently enabled.</warning></para>
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
        /// <item><description>0: disabled</description></item>
        /// <item><description>1: enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier used for subsequent troubleshooting. The value is a combination of letters and digits up to 32 characters in length. Ensure that the value is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c35****</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>The custom user ID or another identifier that can identify a specific user, such as a phone number or email address. We strongly recommend that you desensitize this field value in advance, for example, by hashing the value.</para>
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
        /// <para>The number of faces to return when multiple faces above the matching threshold are found. You can use this parameter to customize the number of returned faces.</para>
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
        /// <para>The type of face data to save. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: face image (default)</description></item>
        /// <item><description>1: feature<remarks>
        /// <para>Warning: This is a reserved field and is not currently enabled.</warning></para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SaveFacePicture")]
        [Validation(Required=false)]
        public string SaveFacePicture { get; set; }

        /// <summary>
        /// <para>The custom verification scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The Base64-encoded face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("SourceFacePicture")]
        [Validation(Required=false)]
        public string SourceFacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the face image. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face1.jpeg</para>
        /// </summary>
        [NameInMap("SourceFacePictureUrl")]
        [Validation(Required=false)]
        public string SourceFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The Base64-encoded face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

        /// <summary>
        /// <para>The URL of the face image. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***face2.jpeg</para>
        /// </summary>
        [NameInMap("TargetFacePictureUrl")]
        [Validation(Required=false)]
        public string TargetFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The verification type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: retrieve pattern</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Feature: Submits a face library and a user face image (sourceFacePicture). The system automatically retrieves the face library to determine whether the specified face image (sourceFacePicture) already exists. Passive liveness detection can be enabled for the face image (sourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: Real-person create an account where duplicate registration is not allowed.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>1 (default): authenticate pattern</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Feature: Submits a specified face image (sourceFacePicture) and a stored face image (TargetFacePicture). The system automatically authenticates whether the two faces match. Passive liveness detection can be enabled for the specified face image (sourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: Authenticating the identity of the operator when modifying logon credentials or account information.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>2: comprehensive pattern</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Feature: Submits a face library, a specified face image (sourceFacePicture), and a stored face image (TargetFacePicture). The system automatically retrieves the face library to determine whether the specified face image (sourceFacePicture) exists, authenticates whether it matches the stored face, and supports passive liveness detection for the specified face image (sourceFacePicture).</description></item>
        /// <item><description>Recommended scenario: Verifying that the user is new and the operation is performed by the user in person.</description></item>
        /// </list>
        /// </remarks>
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
