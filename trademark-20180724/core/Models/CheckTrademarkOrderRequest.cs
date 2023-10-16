// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class CheckTrademarkOrderRequest : TeaModel {
        [NameInMap("AgreementId")]
        [Validation(Required=false)]
        public string AgreementId { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("IsBlackIcon")]
        [Validation(Required=false)]
        public bool? IsBlackIcon { get; set; }

        [NameInMap("LoaOssKey")]
        [Validation(Required=false)]
        public string LoaOssKey { get; set; }

        [NameInMap("LogoGoodsId")]
        [Validation(Required=false)]
        public string LogoGoodsId { get; set; }

        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

        [NameInMap("OrderData")]
        [Validation(Required=false)]
        public string OrderData { get; set; }

        [NameInMap("PartnerCode")]
        [Validation(Required=false)]
        public string PartnerCode { get; set; }

        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        [NameInMap("RealUserName")]
        [Validation(Required=false)]
        public string RealUserName { get; set; }

        [NameInMap("RegisterName")]
        [Validation(Required=false)]
        public string RegisterName { get; set; }

        [NameInMap("RegisterNumber")]
        [Validation(Required=false)]
        public string RegisterNumber { get; set; }

        [NameInMap("RenewInfoId")]
        [Validation(Required=false)]
        public string RenewInfoId { get; set; }

        [NameInMap("RootCode")]
        [Validation(Required=false)]
        public string RootCode { get; set; }

        [NameInMap("TmComment")]
        [Validation(Required=false)]
        public string TmComment { get; set; }

        [NameInMap("TmIcon")]
        [Validation(Required=false)]
        public string TmIcon { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("TmNameType")]
        [Validation(Required=false)]
        public string TmNameType { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
