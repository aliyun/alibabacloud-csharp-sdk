// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ComplementTrademarkApplicationRequest : TeaModel {
        [NameInMap("AgreementId")]
        [Validation(Required=false)]
        public string AgreementId { get; set; }

        [NameInMap("AuthorizationOssKey")]
        [Validation(Required=false)]
        public string AuthorizationOssKey { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("IsBlackIcon")]
        [Validation(Required=false)]
        public bool? IsBlackIcon { get; set; }

        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

        [NameInMap("OrderData")]
        [Validation(Required=false)]
        public string OrderData { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TrademarkComment")]
        [Validation(Required=false)]
        public string TrademarkComment { get; set; }

        [NameInMap("TrademarkIconOssKey")]
        [Validation(Required=false)]
        public string TrademarkIconOssKey { get; set; }

        [NameInMap("TrademarkName")]
        [Validation(Required=false)]
        public string TrademarkName { get; set; }

        [NameInMap("TrademarkNameType")]
        [Validation(Required=false)]
        public string TrademarkNameType { get; set; }

        [NameInMap("TrademarkType")]
        [Validation(Required=false)]
        public int? TrademarkType { get; set; }

    }

}
