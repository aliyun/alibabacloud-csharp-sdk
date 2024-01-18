// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class SubmitReturnGoodLogisticsRequest : TeaModel {
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizUid")]
        [Validation(Required=false)]
        public string BizUid { get; set; }

        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        [NameInMap("DisputeId")]
        [Validation(Required=false)]
        public long? DisputeId { get; set; }

        [NameInMap("LogisticsNo")]
        [Validation(Required=false)]
        public string LogisticsNo { get; set; }

        [NameInMap("SubLmOrderId")]
        [Validation(Required=false)]
        public string SubLmOrderId { get; set; }

        [NameInMap("ThirdPartyUserId")]
        [Validation(Required=false)]
        public string ThirdPartyUserId { get; set; }

        [NameInMap("UseAnonymousTbAccount")]
        [Validation(Required=false)]
        public bool? UseAnonymousTbAccount { get; set; }

    }

}
