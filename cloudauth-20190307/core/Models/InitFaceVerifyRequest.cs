// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitFaceVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the SDK enables strict face quality detection:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Y</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>N</b>: Disabled (default).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is enabled, the SDK must integrate the <a href="https://www.alibabacloud.com/help/en/id-verification/financial-grade-id-verification/description-of-sdk-package-clipping">strict face quality detection module</a>. Strict quality detection may reduce the face recognition success rate.</description></item>
        /// <item><description>Only Android SDK 2.3.24 and later versions are supported.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("AppQualityCheck")]
        [Validation(Required=false)]
        public string AppQualityCheck { get; set; }

        /// <summary>
        /// <para>The user authorization ID. Maximum length: 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92d46b9e9e2d703f2897f350d5bd4149</para>
        /// </summary>
        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public string AuthId { get; set; }

        /// <summary>
        /// <para>The date of birth on the certificate.</para>
        /// <para>This field is required when the certificate type <b>CertType</b> is set to <b>PASSPORT</b> and <b>Mode</b> is set to <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1993-10-10</para>
        /// </summary>
        [NameInMap("Birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        /// <summary>
        /// <para>The security token that you generate to prevent duplication and tampering.</para>
        /// <para>If this value is set, the <b>CallbackToken</b> field is displayed in the callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NMjvQanQgplBSaEI0sL86WnQplB</para>
        /// </summary>
        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        /// <summary>
        /// <para>The callback notification URL for the authentication result. The default callback request method is GET, and the callback URL must start with <c>https</c>. After authentication is complete, the platform calls back this URL and automatically appends the <c>certifyId</c> and <c>passed</c> fields. The <c>passed</c> field returns the subcode value. Example: <c>https://www.aliyun.com?callbackToken=1000004826&amp;certifyId=shaxxxx&amp;passed=200.</c></para>
        /// <notice>
        /// 
        /// <list type="bullet">
        /// <item><description>The callback is triggered only when authentication is complete (including both passed and failed). If authentication is abandoned, abnormally breaks, or is not performed, no notification is sent. After receiving the callback notification, you can use the query operation to obtain authentication details if needed.</description></item>
        /// <item><description>The accessibility of the provided URL is verified before the operation is invoked. If the URL cannot be accessed through public network access, error 401 is returned.</description></item>
        /// <item><description>After receiving the callback, your service must return HTTP status code 200. Otherwise, a retry is triggered with two callbacks within 3 seconds.</description></item>
        /// </list>
        /// </notice>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the camera selection feature:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Y</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>N</b>: Disabled (default).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This feature takes effect only for PC integration mode. After it is enabled, users can select a camera for authentication.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("CameraSelection")]
        [Validation(Required=false)]
        public string CameraSelection { get; set; }

        /// <summary>
        /// <para>The real name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Wang Shanshan</para>
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
        /// Currently, only ID cards are supported. Set this parameter to IDENTITY_CARD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IDENTITY_CARD</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Warning: This parameter will be deprecated.</warning></para>
        /// </remarks>
        /// <para>The CertifyId from a previous successful ID Verification session. The photo from that authentication is used as the comparison photo.</para>
        /// <remarks>
        /// <para>Among the four image input methods (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS), select only one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0bfa7c493f850e5178b9f8613634c9xx</para>
        /// </summary>
        [NameInMap("CertifyId")]
        [Validation(Required=false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// <para>The type of the returned <b>CertifyUrl</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>L</b>: Original long URL.</para>
        /// </description></item>
        /// <item><description><para><b>S</b> (default): Short URL.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>L</para>
        /// </summary>
        [NameInMap("CertifyUrlStyle")]
        [Validation(Required=false)]
        public string CertifyUrlStyle { get; set; }

        /// <summary>
        /// <para>The Web SDK device type. Valid values: <b>WEB</b> or <b>H5</b>.</para>
        /// <remarks>
        /// <para>Only Web SDK device types are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WEB</para>
        /// </summary>
        [NameInMap("CertifyUrlType")]
        [Validation(Required=false)]
        public string CertifyUrlType { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow cropping of face images. Cropping is not allowed by default.</para>
        /// <list type="bullet">
        /// <item><description><para>T: Cropping is allowed.</para>
        /// </description></item>
        /// <item><description><para>F: Cropping is not allowed.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the requested image is not captured by a standard liveness detection SDK, allow cropping of face images. After this feature is enabled, the requested image is first cropped and corrected before the request is sent to the service.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable beauty mode: Y/N.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("EnableBeauty")]
        [Validation(Required=false)]
        public string EnableBeauty { get; set; }

        /// <summary>
        /// <para>The encryption algorithm. Currently, only the SM2 national cryptographic algorithm is supported.</para>
        /// <para>After encrypted transmission is enabled, pass in the encrypted CertName and CertNo. For encryption instructions, refer to <a href="https://www.alibabacloud.com/help/en/id-verification/financial-grade-id-verification/description-of-parameter-encryption#task-2229332">Parameter encryption description</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SM2</para>
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>The Base64-encoded photo.</para>
        /// <remarks>
        /// <para>Among the four image input methods (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS), select only one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/9j/4AAQSkZJRgABAQAASxxxxxxx</para>
        /// </summary>
        [NameInMap("FaceContrastPicture")]
        [Validation(Required=false)]
        public string FaceContrastPicture { get; set; }

        /// <summary>
        /// <para>The OSS photo URL. Currently, only authorized OSS photo URLs are supported.</para>
        /// <remarks>
        /// <para>Among the four image input methods (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS), select only one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg">https://cn-shanghai-aliyun-cloudauth-xxxxxx.oss-cn-shanghai.aliyuncs.com/verify/xxxxx/xxxxx.jpeg</a></para>
        /// </summary>
        [NameInMap("FaceContrastPictureUrl")]
        [Validation(Required=false)]
        public string FaceContrastPictureUrl { get; set; }

        /// <summary>
        /// <para>The device assistant tag type. Valid values: <b>DeviceRisk</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Selecting device assistant output incurs additional fees. For more information, refer to <a href="https://www.alibabacloud.com/help/en/id-verification/financial-grade-id-verification/face-guard">Paid value-added services</a>.</description></item>
        /// <item><description>If you do not need device assistant tag output, do not pass this parameter or pass an empty value.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DeviceRisk</para>
        /// </summary>
        [NameInMap("FaceGuardOutput")]
        [Validation(Required=false)]
        public string FaceGuardOutput { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the &quot;I have completed authentication&quot; button on the H5 degradation page after authentication is complete:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Enabled.</description></item>
        /// <item><description><b>N</b> (default): Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("H5DegradeConfirmBtn")]
        [Validation(Required=false)]
        public string H5DegradeConfirmBtn { get; set; }

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
        /// <para>The Metainfo environment parameter, which must be obtained through the client SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;zimVer&quot;:&quot;3.0.0&quot;,&quot;appVersion&quot;: &quot;1&quot;,&quot;bioMetaInfo&quot;: &quot;4.1.0:11501568,0&quot;,&quot;appName&quot;: &quot;com.aliyun.antcloudauth&quot;,&quot;deviceType&quot;: &quot;ios&quot;,&quot;osVersion&quot;: &quot;iOS 10.3.2&quot;,&quot;apdidToken&quot;: &quot;&quot;,&quot;deviceModel&quot;: &quot;iPhone9,1&quot;}</para>
        /// </summary>
        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

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
        /// <para>The method for obtaining passport NFC verification elements:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: User input. The end user manually enters certificate element information using the UI provided by the Alibaba Cloud SDK.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: External parameter input. Certificate element information is passed in externally.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>NFC decoding of passport chip encrypted information requires three passport elements: name, date of birth, and certificate expiration date.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The liveness detection type. Valid values:</para>
        /// <remarks>
        /// <para>The liveness detection type supports only the following values. Custom actions or combinations are not supported.</para>
        /// </remarks>
        /// <para>Note:
        /// The liveness detection type supports only the following values. Custom actions or combinations are not supported.</para>
        /// <list type="bullet">
        /// <item><description><para><b>LIVENESS</b> (default): Blink.</para>
        /// </description></item>
        /// <item><description><para><b>PHOTINUS_LIVENESS</b>: Blink + colorful light.</para>
        /// </description></item>
        /// <item><description><para><b>MULTI_ACTION</b>: Blink + head shake (the order of blink and head shake is random).</para>
        /// </description></item>
        /// <item><description><para><b>MOVE_ACTION</b> (recommended): Move closer/farther + blink.</para>
        /// </description></item>
        /// <item><description><para><b>MOVE_PHOTINUS</b>: Move closer/farther + colorful light.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>The default liveness detection type</b> is supported in the following versions:<list type="bullet">
        /// <item><description>Android SDK 1.2.6 and later</description></item>
        /// <item><description>iOS SDK 1.2.4 and later</description></item>
        /// <item><description>Harmony SDK 1.0.0 and later</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Other types are supported in the latest Android/iOS/Harmony SDK versions. Integrate the latest version.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MOVE_ACTION</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Specifies whether to block authentication when multiple faces are detected on the device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Y</b>: Block. The client prompts the user to redo face recognition.</para>
        /// </description></item>
        /// <item><description><para><b>N</b> (default): Do not block. The largest face in the frame is sent to the server for security detection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("NeedMultiFaceCheck")]
        [Validation(Required=false)]
        public string NeedMultiFaceCheck { get; set; }

        /// <summary>
        /// <para>The bucket name of the authorized OSS space.</para>
        /// <remarks>
        /// <para>Among the four image input methods (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS), select only one.</para>
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
        /// <para>Among the four image input methods (FaceContrastPicture, FaceContrastPictureUrl, CertifyId, and OSS), select only one.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>verify/xxxxx/xxxxxx.jpeg</para>
        /// </summary>
        [NameInMap("OssObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the merchant request.</para>
        /// <para>The value is a 32-character alphanumeric string. The first few characters are a custom abbreviation defined by the merchant, the middle part can use a time segment, and the last part can use a random or incremental sequence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a77f5ac40a5aa5e6ed20c353888</para>
        /// </summary>
        [NameInMap("OuterOrderNo")]
        [Validation(Required=false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// <para>The degradation configuration when WebRTC or WebAssembly incompatibility occurs during mobile H5 authentication.</para>
        /// <list type="bullet">
        /// <item><description><para><b>keep</b>: Degradation is not supported. The system returns directly.</para>
        /// </description></item>
        /// <item><description><para><b>url</b> (default): Degradation is supported. An authentication URL is returned. The user opens or switches to a browser to authenticate using this URL.</para>
        /// </description></item>
        /// <item><description><para><b>video</b>: Degradation is supported. The system camera is used to record a 3-5 second blink video for authentication.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When the degradation mode is Video, the following features become ineffective and product security is reduced. Configure this mode only for security scenarios.</para>
        /// <list type="bullet">
        /// <item><description>The liveness detection type setting does not take effect.</description></item>
        /// <item><description>The VideoEvidence feature is not supported.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("ProcedurePriority")]
        [Validation(Required=false)]
        public string ProcedurePriority { get; set; }

        /// <summary>
        /// <para>A fixed value. This parameter varies depending on the product plan:</para>
        /// <list type="bullet">
        /// <item><description>APP authentication plan: The fixed value is ID_PRO.</description></item>
        /// <item><description>Face liveness verification plan: The fixed value is PV_FV.</description></item>
        /// <item><description>Liveness detection plan: The fixed value is LR_FR.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ID_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rare character mode:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Y</b>: Enabled. An information input box pops up before authentication, requiring the user to enter the rare character name and ID card number and agree to the agreement before starting the authentication process.</para>
        /// </description></item>
        /// <item><description><para><b>N</b>: Disabled (default).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("RarelyCharacters")]
        [Validation(Required=false)]
        public string RarelyCharacters { get; set; }

        /// <summary>
        /// <para>Specifies whether to read the certificate photo:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Y</b>: Read.</para>
        /// </description></item>
        /// <item><description><para><b>N</b>: Do not read.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the certificate face photo is needed in subsequent authentication steps, set this parameter to Y.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("ReadImg")]
        [Validation(Required=false)]
        public string ReadImg { get; set; }

        /// <summary>
        /// <para>The target URL to which the merchant business page redirects.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("ReturnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// <para>The authentication scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000006</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>The elderly-friendly configuration parameter. This parameter takes effect for each authentication request. You can select different parameters for each authentication request based on the business attributes, customer distribution, and operational characteristics of your app. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): Disabled. The current authentication request does not enable elderly-friendly mode.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enabled. The current authentication request enables elderly-friendly mode.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: User choice.</para>
        /// </description></item>
        /// </list>
        /// <para>Allows end users to select the authentication mode. The product guide page provides two authentication entries: &quot;Start Authentication&quot; and &quot;Senior Authentication Mode&quot;. When the user selects &quot;Senior Authentication Mode&quot;, the system enters elderly-friendly mode.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The elderly-friendly parameter takes effect only when the liveness detection type <b>Model</b> is set to <b>LIVENESS</b> or <b>MULTI_ACTION</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SuitableType")]
        [Validation(Required=false)]
        public string SuitableType { get; set; }

        /// <summary>
        /// <para>The UI configuration file URL.</para>
        /// <para>You can view the complete configuration in <a href="https://www.alibabacloud.com/help/en/id-verification/financial-grade-id-verification/web-sdk-ui-custom-configuration-description">Web SDK UI custom configuration</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("UiCustomUrl")]
        [Validation(Required=false)]
        public string UiCustomUrl { get; set; }

        /// <summary>
        /// <para>The custom user ID defined by the business. Keep this value unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The certificate expiration date.</para>
        /// <para>This field is required when the certificate type <b>CertType</b> is set to <b>PASSPORT</b> and <b>Mode</b> is set to <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2039-06-10</para>
        /// </summary>
        [NameInMap("ValidityDate")]
        [Validation(Required=false)]
        public string ValidityDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable video evidence:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled (default).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Because video files are large, the system discards video files to prioritize the transmission of essential authentication images when the network is unstable. Set video as a weak dependency in your business logic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VideoEvidence")]
        [Validation(Required=false)]
        public string VideoEvidence { get; set; }

        /// <summary>
        /// <para>The custom voluntary content. This parameter is required when personalized settings are enabled. The format is a JSON string of a String List.</para>
        /// <list type="bullet">
        /// <item><description><para>For read-aloud scenarios: The content cannot exceed 60 Chinese characters (excluding punctuation), and the List contains only 1 element.</para>
        /// </description></item>
        /// <item><description><para>For Q&amp;A scenarios: A maximum of 3 questions can be set. Each question cannot exceed 30 Chinese characters. Each question is a separate element in the List.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;I, Mr. Wang, agree to the *** agreement.&quot;]</para>
        /// </summary>
        [NameInMap("VoluntaryCustomizedContent")]
        [Validation(Required=false)]
        public string VoluntaryCustomizedContent { get; set; }

    }

}
