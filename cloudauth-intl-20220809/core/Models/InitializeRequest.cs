// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class InitializeRequest : TeaModel {
        [NameInMap("AppQualityCheck")]
        [Validation(Required=false)]
        public string AppQualityCheck { get; set; }

        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        [NameInMap("DocScanMode")]
        [Validation(Required=false)]
        public string DocScanMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01000000</para>
        /// </summary>
        [NameInMap("DocType")]
        [Validation(Required=false)]
        public string DocType { get; set; }

        [NameInMap("DocVideo")]
        [Validation(Required=false)]
        public string DocVideo { get; set; }

        [NameInMap("ExperienceCode")]
        [Validation(Required=false)]
        public string ExperienceCode { get; set; }

        [NameInMap("FacePictureBase64")]
        [Validation(Required=false)]
        public string FacePictureBase64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("IdFaceQuality")]
        [Validation(Required=false)]
        public string IdFaceQuality { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        [NameInMap("LanguageConfig")]
        [Validation(Required=false)]
        public string LanguageConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e0c34a***353888</para>
        /// </summary>
        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1221****6543</para>
        /// </summary>
        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;bioMetaInfo\&quot;:\&quot;4.1.0:2916352,0\&quot;,\&quot;deviceType\&quot;:\&quot;web\&quot;,\&quot;ua\&quot;:\&quot;Mozilla/5.0 (Macintosh</para>
        /// </summary>
        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>OCR。</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Ocr")]
        [Validation(Required=false)]
        public string Ocr { get; set; }

        [NameInMap("ProcedurePriority")]
        [Validation(Required=false)]
        public string ProcedurePriority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eKYC</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductFlow")]
        [Validation(Required=false)]
        public string ProductFlow { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http*****</para>
        /// </summary>
        [NameInMap("ReturnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PAY**</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public string SecurityLevel { get; set; }

        [NameInMap("ShowAlbumIcon")]
        [Validation(Required=false)]
        public string ShowAlbumIcon { get; set; }

        [NameInMap("ShowGuidePage")]
        [Validation(Required=false)]
        public string ShowGuidePage { get; set; }

        [NameInMap("ShowOcrResult")]
        [Validation(Required=false)]
        public string ShowOcrResult { get; set; }

        [NameInMap("StyleConfig")]
        [Validation(Required=false)]
        public string StyleConfig { get; set; }

    }

}
