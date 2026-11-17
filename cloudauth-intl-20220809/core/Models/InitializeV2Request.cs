// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class InitializeV2Request : TeaModel {
        /// <summary>
        /// <para><warning>This feature is not supported by the <b>Web SDK</b>. To use this feature, refer to the App SDK integration guide.</warning></para>
        /// <para>Specifies whether to enable strict face quality detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: Enable. This is the default value.</description></item>
        /// <item><description>N: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("AppQualityCheck")]
        [Validation(Required=false)]
        public string AppQualityCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authoritative identity verification. This feature currently applies only to second-generation ID cards in the Chinese mainland. This parameter is applicable to IDV products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        /// <summary>
        /// <para>The automatic document page classification configuration. This parameter takes effect only when DocType is set to a country or region code. You can specify the pages to collect based on the specific document type code. For documents that are not configured, only the front side is collected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;BRA01001&quot;:&quot;01&quot;,&quot;BRA01002&quot;:&quot;01,02&quot;}</para>
        /// </summary>
        [NameInMap("AutoDocPageConfig")]
        [Validation(Required=false)]
        public string AutoDocPageConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoRegistration")]
        [Validation(Required=false)]
        public string AutoRegistration { get; set; }

        /// <summary>
        /// <para>The security token used for anti-replay and anti-tampering verification. If you specify this parameter, the CallbackToken field is displayed in the callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ca5c68d869344ea8eeb30cdfd544544-6358700</para>
        /// </summary>
        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        /// <summary>
        /// <para>The callback URL for authentication result notifications. The default callback request method is GET, and the callback URL must start with https. After the authentication is completed, the platform calls this URL and automatically appends the transactionId, passed, and subcode fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com?callbackToken=1000004826&transactionId=shaxxxx&passed=Y&subCode=200">https://www.aliyun.com?callbackToken=1000004826&amp;transactionId=shaxxxx&amp;passed=Y&amp;subCode=200</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the adaptive color-changing window border. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Enable.</description></item>
        /// <item><description><b>N</b>: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("ChameleonFrameEnable")]
        [Validation(Required=false)]
        public string ChameleonFrameEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to crop the image. This parameter is applicable to IDV products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The date of birth on the document, in the YYMMDD format (6 digits). This parameter is required when <b>MRTDInput</b> is set to <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900101</para>
        /// </summary>
        [NameInMap("DateOfBirth")]
        [Validation(Required=false)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// <para>The expiration date on the document, in the YYMMDD format (6 digits). This parameter is required when <b>MRTDInput</b> is set to <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>301231</para>
        /// </summary>
        [NameInMap("DateOfExpiry")]
        [Validation(Required=false)]
        public string DateOfExpiry { get; set; }

        /// <summary>
        /// <para>The real name of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang**</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>The document number of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>410***************</para>
        /// </summary>
        [NameInMap("DocNo")]
        [Validation(Required=false)]
        public string DocNo { get; set; }

        /// <summary>
        /// <para>The custom configuration passed by the customer to specify whether to collect more pages.</para>
        /// </summary>
        [NameInMap("DocPageConfig")]
        [Validation(Required=false)]
        public List<string> DocPageConfig { get; set; }

        /// <summary>
        /// <para>The photo capture mode for document collection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>manual: Manual capture.</description></item>
        /// <item><description>auto: Automatic capture. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("DocScanMode")]
        [Validation(Required=false)]
        public string DocScanMode { get; set; }

        /// <summary>
        /// <para>The document type. </para>
        /// <remarks>
        /// <para>For the eKYC_PRO and ID_OCR_MAX editions, see the official documentation: <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/certificate-code-table?spm=a2c63.p38356.help-menu-445633.d_2_8_2_0.279147abwKAWbr">https://www.alibabacloud.com/help/zh/ekyc/latest/certificate-code-table?spm=a2c63.p38356.help-menu-445633.d_2_8_2_0.279147abwKAWbr</a></para>
        /// </remarks>
        /// <remarks>
        /// <para>For the ID_OCR, eKYC, and eYKC_MIN editions, see the document type list in the official documentation: <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/gnhekqy05ni51m4c?spm=a2c63.p38356.help-menu-445633.d_2_3_1_0_0_0.6243244777KoZ7">https://www.alibabacloud.com/help/zh/ekyc/latest/gnhekqy05ni51m4c?spm=a2c63.p38356.help-menu-445633.d_2_3_1_0_0_0.6243244777KoZ7</a></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>00000001</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Specifies whether to store a video as evidence. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>N: No. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>Y: Yes. During the authentication process, a video of the user\&quot;s face scanning process (a 1- to 2-second video file) is collected and returned through the query operation.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Because video files are large, the system discards the video file when the network is unstable to prioritize the transmission of images required for authentication.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("DocVideo")]
        [Validation(Required=false)]
        public string DocVideo { get; set; }

        /// <summary>
        /// <para>The document number. This parameter is required when <b>MRTDInput</b> is set to <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("DocumentNumber")]
        [Validation(Required=false)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// <para>Specifies whether the recognition result page is editable during the document OCR stage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Editable. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EditOcrResult")]
        [Validation(Required=false)]
        public string EditOcrResult { get; set; }

        /// <summary>
        /// <para>The Indonesian email address. This field takes effect only when Authorize is set to T.</para>
        /// <remarks>
        /// <para>Note
        /// This field is required only when the Indonesian data source is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:evxxx@imigxxxxx.go.id">evxxx@imigxxxxx.go.id</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The experience code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9be7b7d0180041219e5ab03ac6dab5fb</para>
        /// </summary>
        [NameInMap("ExperienceCode")]
        [Validation(Required=false)]
        public string ExperienceCode { get; set; }

        /// <summary>
        /// <para>Specifies whether to return additional face attribute information. Valid values: N: Do not return. This is the default value. Y: Return. The result is located in Result.ExtFaceInfo.FaceAttributeInfo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("FaceAttributeCheck")]
        [Validation(Required=false)]
        public string FaceAttributeCheck { get; set; }

        /// <summary>
        /// <para>The face databases for comparison.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceGroupCodes")]
        [Validation(Required=false)]
        public string FaceGroupCodes { get; set; }

        /// <summary>
        /// <para>The Base64-encoded string of the photo. If you choose to pass the face photo by using FacePictureBase64, check the photo size and do not pass an excessively large photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        /// <summary>
        /// <para>The file stream of the face photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("FacePictureFile")]
        [Validation(Required=false)]
        public string FacePictureFile { get; set; }

        /// <summary>
        /// <para>The URL of the face photo. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg">https://digital-face-prod8.oss-cn-hangzhou.aliyuncs.com/1669520556530-expo/default/face/20221127114236530_w3kx2e6t.jpg</a></para>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        /// <summary>
        /// <para>The face database for registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceRegisterGroupCode")]
        [Validation(Required=false)]
        public string FaceRegisterGroupCode { get; set; }

        /// <summary>
        /// <para>The threshold for face verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("FaceVerifyThreshold")]
        [Validation(Required=false)]
        public string FaceVerifyThreshold { get; set; }

        /// <summary>
        /// <para>The quality of the face image. This parameter is applicable to IDV products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdFaceQuality")]
        [Validation(Required=false)]
        public string IdFaceQuality { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable document anti-spoofing detection. This parameter is applicable to IDV products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
        /// <para>The custom threshold mode for OCR quality detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: System default.</description></item>
        /// <item><description>1: Strict mode.</description></item>
        /// <item><description>2: Loose mode.</description></item>
        /// <item><description>3: Disable quality detection. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>The forced centering configuration. Specifies whether to intercept the request when an off-center face is detected on the terminal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: Intercept. The client prompts the user to scan their face again.</description></item>
        /// <item><description>N: Do not intercept. This is the default value. The system extracts the largest face from the face scanning screen and sends it to the server for security detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IsForceFaceCentered")]
        [Validation(Required=false)]
        public string IsForceFaceCentered { get; set; }

        /// <summary>
        /// <para>The language configuration. This parameter is applicable to IDV products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("LanguageConfig")]
        [Validation(Required=false)]
        public string LanguageConfig { get; set; }

        /// <summary>
        /// <para>The input source of the MRTD verification parameter. This parameter is required to decrypt information when NFC reads the document chip information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: User input.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: OCR reading.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: API input.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MRTDInput")]
        [Validation(Required=false)]
        public string MRTDInput { get; set; }

        /// <summary>
        /// <para>The custom unique business identifier on the merchant side, which is used for subsequent troubleshooting. It supports a combination of letters and digits, with a maximum length of 32 characters. Make sure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Your custom user ID or another identifier that can identify a specific user, such as a mobile phone number or an email address. We strongly recommend that you desensitize the value of this field in advance, for example, by hashing the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1221****6543</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>The Metainfo environment parameter, which must be obtained by using the client SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;bioMetaInfo\&quot;:\&quot;4.1.0:2916352,0\&quot;,\&quot;deviceType\&quot;:\&quot;web\&quot;,\&quot;ua\&quot;:\&quot;Mozilla/5.0\&quot;}</para>
        /// </summary>
        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        /// <summary>
        /// <para>The Indonesian phone number. The format must be verified. It must start with +62 followed by 9 to 11 digits. This field takes effect only when Authorize is set to T.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This field is required only when the Indonesian data source is enabled.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>+6281293671234</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The type of liveness detection to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LIVENESS</b>: Liveness detection based on blinking. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>PHOTINUS_LIVENESS</b>: Dual liveness detection based on blinking and photinus.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For supported SDK versions, see <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/sdk-publishing-record?spm=a2c63.p38356.0.i99">SDK release notes</a>.</description></item>
        /// <item><description>Dual liveness detection based on photinus is not supported on PCs.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PHOTINUS_LIVENESS</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Specifies whether to intercept the request when multiple faces are detected on the terminal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Y: Intercept. The client prompts the user to scan their face again.</description></item>
        /// <item><description>N: Do not intercept. This is the default value. The system extracts the largest face from the face scanning screen and sends it to the server for security detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("NeedMultiFaceCheck")]
        [Validation(Required=false)]
        public string NeedMultiFaceCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable OCR. This parameter is applicable to IDV products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("Ocr")]
        [Validation(Required=false)]
        public string Ocr { get; set; }

        /// <summary>
        /// <para>Specifies whether to return additional standardized OCR recognition fields. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No. This is the default value.</description></item>
        /// <item><description>1: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrValueStandard")]
        [Validation(Required=false)]
        public string OcrValueStandard { get; set; }

        /// <summary>
        /// <para>The configuration of the pages to collect. Separate multiple pages with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>01</b>: The portrait side of the document.</para>
        /// </description></item>
        /// <item><description><para><b>01,02</b>: The portrait and back sides of the document.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to 01,02, only Chinese ID cards and Vietnamese ID cards are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("Pages")]
        [Validation(Required=false)]
        public string Pages { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow degraded processing when compatibility issues occur during mobile H5 authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>url</b>: Allow degradation. This is the default value. The page displays the authentication URL, and the user can copy the URL to open it or switch browsers to continue the authentication.</para>
        /// </description></item>
        /// <item><description><para><b>keep</b>: Do not allow degradation. The system directly returns the error cause and ends the authentication process.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This switch is not supported on PCs.</description></item>
        /// <item><description>If the business scenario involves completing authentication in an embedded web page within an app, we recommend that you set this parameter to keep to disable URL degradation.</description></item>
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
        /// <para>The product edition to integrate. </para>
        /// <remarks>
        /// <para>Note: For more information, see the official documentation: <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/product-introduction?spm=a2c63.p38356.0.i1">https://www.alibabacloud.com/help/zh/ekyc/latest/product-introduction?spm=a2c63.p38356.0.i1</a></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eKYC</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The sequence of document and face verification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DOC_FACE: Document verification followed by face verification. This is the default value.</description></item>
        /// <item><description>FACE_DOC: Face verification followed by document verification.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Note: This parameter is required only when ProductCode is set to KYC_GLOBAL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DOC_FACE</para>
        /// </summary>
        [NameInMap("ProductFlow")]
        [Validation(Required=false)]
        public string ProductFlow { get; set; }

        /// <summary>
        /// <para>The number of duplicate faces returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnFaces")]
        [Validation(Required=false)]
        public string ReturnFaces { get; set; }

        /// <summary>
        /// <para>The client-side callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http*****</para>
        /// </summary>
        [NameInMap("ReturnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to save the face photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SaveFacePicture")]
        [Validation(Required=false)]
        public string SaveFacePicture { get; set; }

        /// <summary>
        /// <para>The scene code. This parameter is applicable to IDV products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The pattern that represents different security levels of the authentication flow. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>01: Normal pattern. This is the default value.</description></item>
        /// <item><description>02: safe mode. This is a relatively strict pattern that is active in high-risk scenarios. This parameter is applicable to IDV products.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public string SecurityLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the album upload entry during the document OCR stage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Display. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Do not display.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShowAlbumIcon")]
        [Validation(Required=false)]
        public string ShowAlbumIcon { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the guide page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Display. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Do not display.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShowGuidePage")]
        [Validation(Required=false)]
        public string ShowGuidePage { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the recognition result page during the document OCR stage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Display. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Do not display.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShowOcrResult")]
        [Validation(Required=false)]
        public string ShowOcrResult { get; set; }

        /// <summary>
        /// <para>The custom UI configuration. Convert your custom UI configuration into a JSON string based on the configuration template, and pass it through this operation. For more information, see <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/idv-kyc-custom-skin?spm=a2c63.p38356.0.i60">Customize IDV UI styles</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;guidepage:&quot;: {<b><b>}, 
        ///   &quot;ocrPage&quot;: {</b></b>},
        ///   &quot;ocrResultPage&quot;: [<b><b>],
        ///   &quot;facePage&quot;: {</b></b>},
        /// }</para>
        /// </summary>
        [NameInMap("StyleConfig")]
        [Validation(Required=false)]
        public string StyleConfig { get; set; }

        /// <summary>
        /// <para>The Base64-encoded string of the portrait photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

        /// <summary>
        /// <para>The file stream of the base face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("TargetFacePictureFile")]
        [Validation(Required=false)]
        public string TargetFacePictureFile { get; set; }

        /// <summary>
        /// <para>The URL of the portrait photo. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxxxx.com/1.jpg">https://www.xxxxx.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("TargetFacePictureUrl")]
        [Validation(Required=false)]
        public string TargetFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The custom action pool configuration for liveness detection. This parameter is required when Model is set to TEMPLATE.
        /// Configuration rules: Separate multiple action codes with commas (,). Best Practices: We recommend that you include at least one frontal face action (such as blinking) and keep the total number of actions to a maximum of 3.
        /// Action code lookup table:</para>
        /// <list type="bullet">
        /// <item><description>Blink: 01</description></item>
        /// <item><description>Open Mouth: 02</description></item>
        /// <item><description>Shake Head Left: 03</description></item>
        /// <item><description>Shake Head Right: 04</description></item>
        /// <item><description>Move Farther: 05</description></item>
        /// <item><description>Move Closer: 06</description></item>
        /// <item><description>Photinus: 07</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01,02,07</para>
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The random mode is no longer recommended. This field is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TemplateRanCount")]
        [Validation(Required=false)]
        public string TemplateRanCount { get; set; }

        /// <summary>
        /// <para>The execution sequence of liveness detection actions in TemplateConfig. This parameter is required when Model is set to TEMPLATE. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Seq: Execute from left to right in the sequence configured in TemplateConfig.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Seq</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>Specifies whether to overwrite the existing face with the current face if MerchantUserId already exists during automatic registration. Valid values: Y: Overwrite. N: Do not overwrite and return a message indicating that the UserId already exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("UpdateFaceIfUserExists")]
        [Validation(Required=false)]
        public string UpdateFaceIfUserExists { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable NFC verification when <b>DocType</b> is set to 01000000 (global passport). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Enable.</description></item>
        /// <item><description><b>N</b>: Disable.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("UseNFC")]
        [Validation(Required=false)]
        public string UseNFC { get; set; }

        /// <summary>
        /// <para>The type of verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VerifyModel")]
        [Validation(Required=false)]
        public string VerifyModel { get; set; }

    }

}
