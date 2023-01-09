/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20221125.Models
{
    public class EntElementVerifyRequest : TeaModel {
        [NameInMap("EntName")]
        [Validation(Required=false)]
        public string EntName { get; set; }

        [NameInMap("InfoVerifyType")]
        [Validation(Required=false)]
        public string InfoVerifyType { get; set; }

        [NameInMap("LegalPersonCertNo")]
        [Validation(Required=false)]
        public string LegalPersonCertNo { get; set; }

        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        [NameInMap("LicenseNo")]
        [Validation(Required=false)]
        public string LicenseNo { get; set; }

        [NameInMap("MerchantBizId")]
        [Validation(Required=false)]
        public string MerchantBizId { get; set; }

        [NameInMap("MerchantUserId")]
        [Validation(Required=false)]
        public string MerchantUserId { get; set; }

        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        [NameInMap("UserAuthorization")]
        [Validation(Required=false)]
        public string UserAuthorization { get; set; }

    }

}
