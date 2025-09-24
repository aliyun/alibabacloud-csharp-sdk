// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class InitializeShrinkRequest : TeaModel {
        /// <summary>
        /// <para><warning>This feature is currently not supported by <b>Web SDK</b>. Please refer to the App SDK integration if needed.</warning></para>
        /// <para>Whether to enable strict face quality detection:</para>
        /// <list type="bullet">
        /// <item><description>Y: Enable (default)</description></item>
        /// <item><description>N: Disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("AppQualityCheck")]
        [Validation(Required=false)]
        public string AppQualityCheck { get; set; }

        /// <summary>
        /// <para>Whether to enable authoritative identity verification, currently applicable only to the second-generation ID card in mainland China. (IDV product input parameter)</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        /// <summary>
        /// <para>Whether to enable automatic registration</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoRegistration")]
        [Validation(Required=false)]
        public string AutoRegistration { get; set; }

        /// <summary>
        /// <para>Security Token, used for preventing duplication and tampering. If this parameter is passed, the CallbackToken field will be displayed in the callback address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ca5c68d869344ea8eeb30cdfd544544-6358700</para>
        /// </summary>
        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        /// <summary>
        /// <para>Callback notification address for authentication results. The default callback request method is GET, and the callback address must start with https. After completing the authentication, the platform will call back this address and automatically add the transactionId, passed, and subcode fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com?callbackToken=1000004826&transactionId=shaxxxx&passed=Y&subCode=200">https://www.aliyun.com?callbackToken=1000004826&amp;transactionId=shaxxxx&amp;passed=Y&amp;subCode=200</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>Whether to enable adaptive color-changing window border</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b>: Enable</description></item>
        /// <item><description><b>N</b>: Disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("ChameleonFrameEnable")]
        [Validation(Required=false)]
        public string ChameleonFrameEnable { get; set; }

        /// <summary>
        /// <para>Whether to crop. (IDV product input parameter)</para>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        /// <summary>
        /// <para>Date of birth on the document</para>
        /// <para><b>MRTDInput = 2</b> is required.</para>
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
        /// <para>Expiration date on the document</para>
        /// <para><b>MRTDInput = 2</b> is required.</para>
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
        /// <para>User\&quot;s real name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        /// <summary>
        /// <para>User\&quot;s document number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>411xxxxxxxxxxx0001</para>
        /// </summary>
        [NameInMap("DocNo")]
        [Validation(Required=false)]
        public string DocNo { get; set; }

        /// <summary>
        /// <para>Customer-defined input to specify whether to collect more pages</para>
        /// </summary>
        [NameInMap("DocPageConfig")]
        [Validation(Required=false)]
        public string DocPageConfigShrink { get; set; }

        /// <summary>
        /// <para>Document capture mode.</para>
        /// <list type="bullet">
        /// <item><description>manual: Manual capture.</description></item>
        /// <item><description>auto: Automatic capture (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("DocScanMode")]
        [Validation(Required=false)]
        public string DocScanMode { get; set; }

        /// <summary>
        /// <para>Document type, uniquely identified by an 8-digit combination.
        /// Note: This parameter is required only when ProductCode is KYC_GLOBAL, OCR_GLOBAL, or IDR_GLOBAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>​01560000</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        /// <summary>
        /// <para>Whether to require a video for evidence.</para>
        /// <list type="bullet">
        /// <item><description><para>N: Not required (default).</para>
        /// </description></item>
        /// <item><description><para>Y: During the authentication process, a 1~2 second video of the user\&quot;s face will be captured and returned via the query interface.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Due to the large size of the video file, the system may discard it when the network is unstable, prioritizing the transmission of necessary images for authentication.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("DocVideo")]
        [Validation(Required=false)]
        public string DocVideo { get; set; }

        /// <summary>
        /// <para>Document number</para>
        /// <para><b>MRTDInput = 2</b> is required.</para>
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
        /// <para>In the document OCR recognition step, whether the recognition result page is editable:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Not editable</para>
        /// </description></item>
        /// <item><description><para><b>1</b> (default): Editable</para>
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
        /// <para>Experience code</para>
        /// 
        /// <b>Example:</b>
        /// <para>9be7b7d0180041219e5ab03ac6dab5fb</para>
        /// </summary>
        [NameInMap("ExperienceCode")]
        [Validation(Required=false)]
        public string ExperienceCode { get; set; }

        /// <summary>
        /// <para>Face library to be compared</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceGroupCodes")]
        [Validation(Required=false)]
        public string FaceGroupCodes { get; set; }

        /// <summary>
        /// <para>Base64 encoded face image. If you choose to pass the face image via FacePictureBase64, please check the image size and do not upload images larger than 1 MB.
        /// When productCode is FV_GLOBAL, choose one of the parameters between FacePictureBase64 and FacePictureUrl to pass in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Base64</para>
        /// </summary>
        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        /// <summary>
        /// <para>Face image URL. A publicly accessible HTTP or HTTPS link. When productCode is FV_GLOBAL, choose one of the parameters between FacePictureUrl and FacePictureBase to pass in.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        /// <summary>
        /// <para>Face library for registration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e0c34a77f</para>
        /// </summary>
        [NameInMap("FaceRegisterGroupCode")]
        [Validation(Required=false)]
        public string FaceRegisterGroupCode { get; set; }

        /// <summary>
        /// <para>Face verification threshold</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("FaceVerifyThreshold")]
        [Validation(Required=false)]
        public string FaceVerifyThreshold { get; set; }

        /// <summary>
        /// <para>Face image quality. (IDV product input parameter)</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdFaceQuality")]
        [Validation(Required=false)]
        public string IdFaceQuality { get; set; }

        /// <summary>
        /// <para>Whether to enable certificate anti-counterfeiting detection. (IDV product input parameter)</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        /// <summary>
        /// <para>Custom OCR quality detection threshold mode:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Standard mode</description></item>
        /// <item><description><b>1</b>: Strict mode</description></item>
        /// <item><description><b>2</b>: Lenient mode</description></item>
        /// <item><description><b>3</b> (default): Disable quality detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        /// <summary>
        /// <para>Language configuration. (IDV product input parameter)</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("LanguageConfig")]
        [Validation(Required=false)]
        public string LanguageConfig { get; set; }

        /// <summary>
        /// <para>Source of MRTD verification parameters. This parameter is required to decrypt information when reading the document chip via NFC.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: User input</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: OCR read</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Passed through the API</para>
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
        /// <para>A unique business identifier defined by the merchant, used for subsequent troubleshooting. It supports a combination of letters and numbers, with a maximum length of 32 characters. Please ensure its uniqueness.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <para>Your custom user ID or other identifiers that can recognize specific users, such as phone numbers or email addresses. It is strongly recommended to pre-desensitize the value of this field, for example, by hashing it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1221****6543</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <para>Metainfo environment parameter, which needs to be obtained through the client SDK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;bioMetaInfo\&quot;:\&quot;4.1.0:2916352,0\&quot;,\&quot;deviceType\&quot;:\&quot;web\&quot;,\&quot;ua\&quot;:\&quot;Mozilla/5.0 (Macintosh</para>
        /// </summary>
        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        /// <summary>
        /// <para>The type of liveness detection to be performed:</para>
        /// <list type="bullet">
        /// <item><description><para><b>LIVENESS</b> (default): Blinking action liveness detection.</para>
        /// </description></item>
        /// <item><description><para><b>PHOTINUS_LIVENESS</b>: Blinking action liveness + photinus liveness dual detection.</para>
        /// </description></item>
        /// <item><description><para><b>PHOTINUS_FAR_NEAR_LIVENESS</b>:
        /// Blinking action + far/near + photinus liveness detection.
        /// (Only supported by APP SDK or Flutter integration based on APP SDK)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For supported SDK versions, see <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/sdk-publishing-record?spm=a2c63.p38356.0.i99">SDK Publishing Record</a>.</description></item>
        /// <item><description>PC does not support photinus liveness dual detection.</description></item>
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
        /// <para>Whether to enable OCR. (IDV product input parameter)</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("Ocr")]
        [Validation(Required=false)]
        public string Ocr { get; set; }

        /// <summary>
        /// <para>Page configuration for collection, multiple pages are connected using commas. The value range is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>01</b>: Front side of the document</para>
        /// </description></item>
        /// <item><description><para><b>01,02</b>: Front and back sides of the document</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When this value is 01,02, currently only Chinese and Vietnamese IDs are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("Pages")]
        [Validation(Required=false)]
        public string Pages { get; set; }

        /// <summary>
        /// <para>When compatibility issues occur with H5-based mobile authentication, whether to allow a fallback handling method.</para>
        /// <list type="bullet">
        /// <item><description><para><b>url</b> (default): Support fallback. The page displays the authentication URL, which users can copy and open in another browser to continue the authentication process.</para>
        /// </description></item>
        /// <item><description><para><b>keep</b>: Do not support fallback. Directly return the error reason and end the authentication process.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This switch is not supported on PC.</description></item>
        /// <item><description>If the business scenario involves completing authentication through an embedded web page in an app, it is recommended to set this parameter to <c>keep</c> to disallow URL fallback.</description></item>
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
        /// <para>The product solution to be integrated. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>KYC_GLOBAL (eKYC product solution)</description></item>
        /// <item><description>FV_GLOBAL (Live Face Verification)</description></item>
        /// <item><description>FL_GLOBAL (Liveness Detection)</description></item>
        /// <item><description>IDR_GLOBAL (Single Document Verification)</description></item>
        /// <item><description>OCR_GLOBAL (Single Document OCR)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KYC_GLOBAL</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Supports card and face sequential arrangement:</para>
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
        /// <para>Number of duplicate faces returned</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnFaces")]
        [Validation(Required=false)]
        public string ReturnFaces { get; set; }

        /// <summary>
        /// <para>Client-side callback address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http*****</para>
        /// </summary>
        [NameInMap("ReturnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// <para>Whether to save the face image</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SaveFacePicture")]
        [Validation(Required=false)]
        public string SaveFacePicture { get; set; }

        /// <summary>
        /// <para>Scene code. (IDV product input parameter)</para>
        /// 
        /// <b>Example:</b>
        /// <para>123****123</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>Represents different security levels in the authentication process. The available values are as follows:</para>
        /// <para>01: Normal mode (default).
        /// 02: Secure mode, a relatively strict mode, suitable for high-risk scenarios. (IDV product input parameter)</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public string SecurityLevel { get; set; }

        /// <summary>
        /// <para>In the document OCR recognition step, whether to display the album upload entry:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Display (default)</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Do not display</para>
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
        /// <para>Switch to control whether to display the guide page:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Display (default)</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Do not display</para>
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
        /// <para>In the document OCR recognition step, whether to display the recognition result page:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Display (default)</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Do not display</para>
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
        /// <para>Custom UI configuration. Based on the configuration template, convert your custom UI configuration into a JSON string and pass it through this interface. For more information, see <a href="https://www.alibabacloud.com/help/zh/ekyc/latest/idv-kyc-custom-skin?spm=a2c63.p38356.0.i60">IDV UI Customization</a>.</para>
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
        /// <para>Base64 encoding of the portrait photo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base64</para>
        /// </summary>
        [NameInMap("TargetFacePicture")]
        [Validation(Required=false)]
        public string TargetFacePicture { get; set; }

        /// <summary>
        /// <para>Portrait image URL, accessible via public HTTP or HTTPS link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.xxxxx.com/1.jpg">https://www.xxxxx.com/1.jpg</a></para>
        /// </summary>
        [NameInMap("TargetFacePictureUrl")]
        [Validation(Required=false)]
        public string TargetFacePictureUrl { get; set; }

        /// <summary>
        /// <para>When <b>DocType</b>=01000000 (global passport), you can choose whether to enable NFC verification.</para>
        /// <list type="bullet">
        /// <item><description><b>Y</b> (enable)</description></item>
        /// <item><description><b>N</b> (disable)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N</para>
        /// </summary>
        [NameInMap("UseNFC")]
        [Validation(Required=false)]
        public string UseNFC { get; set; }

        /// <summary>
        /// <para>Type of verification</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VerifyModel")]
        [Validation(Required=false)]
        public string VerifyModel { get; set; }

    }

}
