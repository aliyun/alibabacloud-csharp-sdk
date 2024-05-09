// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainOrderChangeConfirmRequest : TeaModel {
        [NameInMap("change_apply_id")]
        [Validation(Required=false)]
        public string ChangeApplyId { get; set; }

        [NameInMap("change_settle_amount")]
        [Validation(Required=false)]
        public long? ChangeSettleAmount { get; set; }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("out_change_apply_id")]
        [Validation(Required=false)]
        public string OutChangeApplyId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

    }

}
