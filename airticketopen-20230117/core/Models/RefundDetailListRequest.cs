// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class RefundDetailListRequest : TeaModel {
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        [NameInMap("page_index")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("refund_create_begin_time")]
        [Validation(Required=false)]
        public long? RefundCreateBeginTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("refund_create_end_time")]
        [Validation(Required=false)]
        public long? RefundCreateEndTime { get; set; }

    }

}
