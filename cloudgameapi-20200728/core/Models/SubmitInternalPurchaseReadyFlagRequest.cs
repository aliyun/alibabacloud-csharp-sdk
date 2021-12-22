// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class SubmitInternalPurchaseReadyFlagRequest : TeaModel {
        [NameInMap("BatchInfoList")]
        [Validation(Required=false)]
        public List<SubmitInternalPurchaseReadyFlagRequestBatchInfoList> BatchInfoList { get; set; }
        public class SubmitInternalPurchaseReadyFlagRequestBatchInfoList : TeaModel {
            [NameInMap("BatchNumbers")]
            [Validation(Required=false)]
            public string BatchNumbers { get; set; }

            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

        }

        [NameInMap("ChargeDate")]
        [Validation(Required=false)]
        public string ChargeDate { get; set; }

        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        [NameInMap("OrderTotalCount")]
        [Validation(Required=false)]
        public int? OrderTotalCount { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
