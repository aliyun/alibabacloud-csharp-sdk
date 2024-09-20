// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class AccountFlowListRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("day_num")]
        [Validation(Required=false)]
        public int? DayNum { get; set; }

        [NameInMap("page_index")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("utc_begin_time")]
        [Validation(Required=false)]
        public long? UtcBeginTime { get; set; }

    }

}
