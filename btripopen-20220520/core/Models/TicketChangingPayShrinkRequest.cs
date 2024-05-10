// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingPayShrinkRequest : TeaModel {
        [NameInMap("corp_pay_price")]
        [Validation(Required=false)]
        public long? CorpPayPrice { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dis_sub_order_id")]
        [Validation(Required=false)]
        public string DisSubOrderId { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

        [NameInMap("personal_pay_price")]
        [Validation(Required=false)]
        public long? PersonalPayPrice { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("total_pay_price")]
        [Validation(Required=false)]
        public long? TotalPayPrice { get; set; }

    }

}
