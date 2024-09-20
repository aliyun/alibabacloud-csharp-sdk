// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class OrderListRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("book_time_end")]
        [Validation(Required=false)]
        public long? BookTimeEnd { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("book_time_start")]
        [Validation(Required=false)]
        public long? BookTimeStart { get; set; }

        [NameInMap("page_index")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
