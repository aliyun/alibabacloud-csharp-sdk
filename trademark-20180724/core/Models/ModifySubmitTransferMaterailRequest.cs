// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class ModifySubmitTransferMaterailRequest : TeaModel {
        [NameInMap("Addr")]
        [Validation(Required=false)]
        public string Addr { get; set; }

        [NameInMap("AssigneeProxy")]
        [Validation(Required=false)]
        public string AssigneeProxy { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BuyerBusinessLicense")]
        [Validation(Required=false)]
        public string BuyerBusinessLicense { get; set; }

        [NameInMap("BuyerBusinessLicenseTranslation")]
        [Validation(Required=false)]
        public string BuyerBusinessLicenseTranslation { get; set; }

        [NameInMap("BuyerIdCard")]
        [Validation(Required=false)]
        public string BuyerIdCard { get; set; }

        [NameInMap("CardNo")]
        [Validation(Required=false)]
        public string CardNo { get; set; }

        [NameInMap("CardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        [NameInMap("Complete")]
        [Validation(Required=false)]
        public bool? Complete { get; set; }

        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        [NameInMap("ContactMobile")]
        [Validation(Required=false)]
        public string ContactMobile { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Notarization")]
        [Validation(Required=false)]
        public string Notarization { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("Other")]
        [Validation(Required=false)]
        public Dictionary<string, object> Other { get; set; }

        [NameInMap("RegistrationCert")]
        [Validation(Required=false)]
        public string RegistrationCert { get; set; }

        [NameInMap("SellerApply")]
        [Validation(Required=false)]
        public string SellerApply { get; set; }

        [NameInMap("SellerBusinessLicense")]
        [Validation(Required=false)]
        public string SellerBusinessLicense { get; set; }

        [NameInMap("SellerBusinessLicenseTranslation")]
        [Validation(Required=false)]
        public string SellerBusinessLicenseTranslation { get; set; }

        [NameInMap("SellerIdCard")]
        [Validation(Required=false)]
        public string SellerIdCard { get; set; }

        [NameInMap("SellerProxy")]
        [Validation(Required=false)]
        public string SellerProxy { get; set; }

        [NameInMap("TradeMaterialFullUpdate")]
        [Validation(Required=false)]
        public bool? TradeMaterialFullUpdate { get; set; }

    }

}
