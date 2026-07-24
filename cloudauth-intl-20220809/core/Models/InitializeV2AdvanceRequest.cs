// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class InitializeV2AdvanceRequest : TeaModel {
        /// <summary>
        /// <para><warning>This feature is <b>not supported by Web SDK</b>. To use this feature, use the App SDK.</warning></para>
        /// <para>Specifies whether to enable strict face quality detection:</para>
        /// <list type="bullet">
        /// <item><description>Y: enable (default)</description></item>
        /// <item><description>N: do not enable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("AppQualityCheck")]
        [Validation(Required=false)]
        public string AppQualityCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authoritative identity verification. Currently, this applies only to second-generation ID cards in the Chinese mainland. This is an input parameter for the IDV product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        [NameInMap("AutoDocPageConfig")]
        [Validation(Required=false)]
        public string AutoDocPageConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoRegistration")]
        [Validation(Required=false)]
        public string AutoRegistration { get; set; }

        /// <summary>
        /// <para>The security token used for anti-replay and anti-tampering verification. If this parameter is passed in, the CallbackToken field is displayed in the callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ca5c68d869344ea8eeb30cdfd544544-6358700</para>
        /// </summary>
        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        /// <summary>
        /// <para>The callback URL for authentication results. The default callback request method is GET, and the callback URL must start with https. After authentication is complete, the platform calls back this URL and automatically appends the transactionId, passed, and subcode fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com?callbackToken=1000004826&transactionId=shaxxxx&passed=Y&subCode=200">https://www.aliyun.com?callbackToken=1000004826&amp;transactionId=shaxxxx&amp;passed=Y&amp;subCode=200</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the adaptive color-changing window frame.</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: enable</description></item>
        /// <item><description><b>N</b>: do not enable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("ChameleonFrameEnable")]
        [Validation(Required=false)]
        public string ChameleonFrameEnable { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cropping. This is an input parameter for the IDV product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>The date of birth on the document.</para>
        /// <para>Required when <b>MRTDInput = 2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("DateOfBirth")]
        [Validation(Required=false)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// <para>The expiry date on the document.</para>
        /// <para>Required when <b>MRTDInput</b> = 2.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
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
        /// <para>The custom configuration for collecting additional pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OCR_ID_BACK</para>
        /// </summary>
        [NameInMap("DocPageConfig")]
        [Validation(Required=false)]
        public List<string> DocPageConfig { get; set; }

        /// <summary>
        /// <para>The document capture photo mode.</para>
        /// <list type="bullet">
        /// <item><description>manual: manual photo capture.</description></item>
        /// <item><description>auto: automatic photo capture (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("DocScanMode")]
        [Validation(Required=false)]
        public string DocScanMode { get; set; }

        /// <summary>
        /// <para>The document type.</para>
        /// <remarks>
        /// <para>For eKYC_PRO and ID_OCR_MAX solutions, see the official documentation: <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/certificate-code-table?spm=a2c63.p38356.help-menu-445633.d_2_8_2_0.279147abwKAWbr">https://www.alibabacloud.com/help/zh/ekyc/latest/certificate-code-table?spm=a2c63.p38356.help-menu-445633.d_2_8_2_0.279147abwKAWbr</a></para>
        /// </remarks>
        /// <remarks>
        /// <para>For ID_OCR, eKYC, and eKYC_MIN solutions, see the official documentation for the document type list: <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/gnhekqy05ni51m4c?spm=a2c63.p38356.help-menu-445633.d_2_3_1_0_0_0.6243244777KoZ7">https://www.alibabacloud.com/help/zh/ekyc/latest/gnhekqy05ni51m4c?spm=a2c63.p38356.help-menu-445633.d_2_3_1_0_0_0.6243244777KoZ7</a></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>00000001</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Specifies whether to record an evidence video.</para>
        /// <list type="bullet">
        /// <item><description><para>N: not required (default).</para>
        /// </description></item>
        /// <item><description><para>Y: a face verification video (1–2 seconds) is captured during authentication and returned through the query API.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Because video files are large, the system discards video files when the network is unstable to prioritize the transmission of essential authentication images.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("DocVideo")]
        [Validation(Required=false)]
        public string DocVideo { get; set; }

        /// <summary>
        /// <para>The document number.</para>
        /// <para>Required when <b>MRTDInput = 2</b>.</para>
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
        /// <para>Specifies whether the recognition result page is editable during the document OCR recognition step:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: not editable</para>
        /// </description></item>
        /// <item><description><para><b>1</b> (default): editable</para>
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
        /// <para>The Indonesian email address. This field takes effect only when Authorize=T.</para>
        /// <remarks>
        /// <para>Note:
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

        [NameInMap("FaceAttributeCheck")]
        [Validation(Required=false)]
        public string FaceAttributeCheck { get; set; }

        /// <summary>
        /// <para>The face libraries for comparison.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceGroupCodes")]
        [Validation(Required=false)]
        public string FaceGroupCodes { get; set; }

        /// <summary>
        /// <para>The Base64-encoded face photo. If you use FacePictureBase64 to pass in the face photo, check the photo size and do not pass in an excessively large photo.</para>
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
        public Stream FacePictureFileObject { get; set; }

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
        /// <para>The face registration library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceRegisterGroupCode")]
        [Validation(Required=false)]
        public string FaceRegisterGroupCode { get; set; }

        /// <summary>
        /// <para>The face verification threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("FaceVerifyThreshold")]
        [Validation(Required=false)]
        public string FaceVerifyThreshold { get; set; }

        /// <summary>
        /// <para>The face image quality. This is an input parameter for the IDV product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdFaceQuality")]
        [Validation(Required=false)]
        public string IdFaceQuality { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable document anti-forgery detection. This is an input parameter for the IDV product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
        /// <para>The custom OCR quality detection threshold mode:</para>
        /// <list type="bullet">
        /// <item><description>0: system default</description></item>
        /// <item><description>1: strict mode</description></item>
        /// <item><description>2: loose mode</description></item>
        /// <item><description>3 (default): disable quality detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>The language configuration. This is an input parameter for the IDV product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("LanguageConfig")]
        [Validation(Required=false)]
        public string LanguageConfig { get; set; }

        /// <summary>
        /// <para>The input source for MRTD verification parameters. This parameter is required for decrypting information when reading document chip data via NFC.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: user input</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: OCR reading</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: API input</para>
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
        /// <para>The merchant-defined unique business ID used for subsequent troubleshooting. The value can contain letters and digits with a maximum length of 32 characters. Ensure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>A custom user ID or other identifier that can identify a specific user, such as a phone number or email address. We strongly recommend that you desensitize this field value in advance, for example, by hashing the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1221****6543</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>The Metainfo environment parameter. Obtain this value by using the client SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;bioMetaInfo\&quot;:\&quot;4.1.0:2916352,0\&quot;,\&quot;deviceType\&quot;:\&quot;web\&quot;,\&quot;ua\&quot;:\&quot;Mozilla/5.0\&quot;}</para>
        /// </summary>
        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        /// <summary>
        /// <para>The Indonesian phone number. The format must start with +62 followed by 9 to 11 digits. This field takes effect only when Authorize=T.</para>
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
        /// <para>The type of liveness detection to perform:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LIVENESS</b> (default): blink action liveness detection.</para>
        /// </description></item>
        /// <item><description><para><b>PHOTINUS_LIVENESS</b>: blink action liveness + colorful liveness dual detection.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For supported SDK versions, see <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/sdk-publishing-record?spm=a2c63.p38356.0.i99">SDK release notes</a>.</description></item>
        /// <item><description>Colorful liveness dual detection is not supported on PC.</description></item>
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
        /// <para>Specifies whether to enable OCR. This is an input parameter for the IDV product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("Ocr")]
        [Validation(Required=false)]
        public string Ocr { get; set; }

        /// <summary>
        /// <para>Specifies whether to return additional OCR recognition standardized format fields:</para>
        /// <para>0: no (default)</para>
        /// <para>1: yes</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrValueStandard")]
        [Validation(Required=false)]
        public string OcrValueStandard { get; set; }

        /// <summary>
        /// <para>The collection page configuration. Use commas to connect multiple pages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>01</b>: document portrait page</para>
        /// </description></item>
        /// <item><description><para><b>01,02</b>: document portrait page and back page</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When this value is set to 01,02, only Chinese ID cards and Vietnamese ID cards are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("Pages")]
        [Validation(Required=false)]
        public string Pages { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow a degraded processing method when compatibility issues occur during mobile H5 authentication.</para>
        /// <list type="bullet">
        /// <item><description><para><b>url (default)</b>: degradation is supported. The page displays the authentication URL, and the user can copy the URL or switch browsers to continue authentication.</para>
        /// </description></item>
        /// <item><description><para><b>keep</b>: degradation is not supported. The error reason is returned directly, and the authentication flow ends.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This switch is not supported on PC.</description></item>
        /// <item><description>If the business scenario involves completing authentication within an in-app web page, set this parameter to keep to disallow URL degradation.</description></item>
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
        /// <para>The product solution to use.</para>
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
        /// <para>The order of document and face verification:</para>
        /// <list type="bullet">
        /// <item><description>DOC_FACE (default)</description></item>
        /// <item><description>FACE_DOC</description></item>
        /// </list>
        /// <para>Note: This parameter is required only when ProductCode is KYC_GLOBAL.</para>
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
        /// <para>Specifies whether to save the face picture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SaveFacePicture")]
        [Validation(Required=false)]
        public string SaveFacePicture { get; set; }

        /// <summary>
        /// <para>The scene code. This is an input parameter for the IDV product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The pattern that represents different security levels of the authentication flow. Valid values:</para>
        /// <para>01: normal pattern (default).
        /// 02: safe mode, a relatively strict pattern that is active for high-risk scenarios. This is an input parameter for the IDV product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public string SecurityLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the album upload entry during the document OCR recognition step:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: display (default)</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: do not display</para>
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
        /// <para>Specifies whether to display the guide page:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: display (default)</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: do not display</para>
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
        /// <para>Specifies whether to display the recognition result page during the document OCR recognition step:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: display (default)</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: do not display</para>
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
        /// <para>The custom UI configuration. Convert your custom UI configuration to a JSON string based on the configuration template and pass it in through this parameter. For more information, see <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/idv-kyc-custom-skin?spm=a2c63.p38356.0.i60">IDV UI style customization</a>.</para>
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
        /// <para>The Base64-encoded portrait photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

        /// <summary>
        /// <para>The file stream of the target face image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InputStream</para>
        /// </summary>
        [NameInMap("TargetFacePictureFile")]
        [Validation(Required=false)]
        public Stream TargetFacePictureFileObject { get; set; }

        /// <summary>
        /// <para>The URL of the portrait image. The URL must be a publicly accessible HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxxxx.com/1.jpg">https://www.xxxxx.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("TargetFacePictureUrl")]
        [Validation(Required=false)]
        public string TargetFacePictureUrl { get; set; }

        /// <summary>
        /// <para>The custom action pool configuration for liveness detection.
        /// Required when Model is TEMPLATE.
        /// Configuration rule: separate multiple action codes with commas. Best practice: include at least one frontal face action (such as blink), and do not exceed 3 actions in total.
        /// Action code table:</para>
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
        /// <para>The number of actions to randomly select from TemplateConfig.
        /// Takes effect only when TemplateType is Ran.</para>
        /// <list type="bullet">
        /// <item><description>Validation rules:</description></item>
        /// <item><description>The value must be greater than 1. The value must be less than or equal to the total number of actions configured in TemplateConfig. If not specified, the default value equals the total number of actions in TemplateConfig.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TemplateRanCount")]
        [Validation(Required=false)]
        public string TemplateRanCount { get; set; }

        /// <summary>
        /// <para>The execution order of liveness detection actions in TemplateConfig.
        /// Required when Model is TEMPLATE.</para>
        /// <list type="bullet">
        /// <item><description>Seq: execute in the order configured in TemplateConfig from left to right.</description></item>
        /// <item><description>Ran: execute in random order. When this option is selected, TemplateConfig must contain more than one action.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Seq</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable NFC verification when <b>DocType</b> = 01000000 (global passport).</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b> (enable)</description></item>
        /// <item><description><b>N</b> (do not enable)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("UseNFC")]
        [Validation(Required=false)]
        public string UseNFC { get; set; }

        /// <summary>
        /// <para>The verification type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VerifyModel")]
        [Validation(Required=false)]
        public string VerifyModel { get; set; }

    }

}
