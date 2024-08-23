// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class InitializeRequest : TeaModel {
        [NameInMap("Authorize")]
        [Validation(Required=false)]
        public string Authorize { get; set; }

        [NameInMap("CallbackToken")]
        [Validation(Required=false)]
        public string CallbackToken { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("Crop")]
        [Validation(Required=false)]
        public string Crop { get; set; }

        [NameInMap("DocScanMode")]
        [Validation(Required=false)]
        public string DocScanMode { get; set; }

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

        [NameInMap("FacePictureUrl")]
        [Validation(Required=false)]
        public string FacePictureUrl { get; set; }

        [NameInMap("IdFaceQuality")]
        [Validation(Required=false)]
        public string IdFaceQuality { get; set; }

        [NameInMap("IdSpoof")]
        [Validation(Required=false)]
        public string IdSpoof { get; set; }

        [NameInMap("IdThreshold")]
        [Validation(Required=false)]
        public string IdThreshold { get; set; }

        [NameInMap("LanguageConfig")]
        [Validation(Required=false)]
        public string LanguageConfig { get; set; }

        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        [NameInMap("MetaInfo")]
        [Validation(Required=false)]
        public string MetaInfo { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// OCR。
        /// </summary>
        [NameInMap("Ocr")]
        [Validation(Required=false)]
        public string Ocr { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductFlow")]
        [Validation(Required=false)]
        public string ProductFlow { get; set; }

        [NameInMap("ReturnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        [NameInMap("SecurityLevel")]
        [Validation(Required=false)]
        public string SecurityLevel { get; set; }

        [NameInMap("ShowAlbumIcon")]
        [Validation(Required=false)]
        public string ShowAlbumIcon { get; set; }

        [NameInMap("ShowOcrResult")]
        [Validation(Required=false)]
        public string ShowOcrResult { get; set; }

        [NameInMap("StyleConfig")]
        [Validation(Required=false)]
        public string StyleConfig { get; set; }

    }

}
