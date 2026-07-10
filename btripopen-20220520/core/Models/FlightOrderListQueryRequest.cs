// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryRequest : TeaModel {
        [NameInMap("all_apply")]
        [Validation(Required=false)]
        public bool? AllApply { get; set; }

        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartId { get; set; }

        [NameInMap("end_time")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("start_time")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        [NameInMap("update_end_time")]
        [Validation(Required=false)]
        public string UpdateEndTime { get; set; }

        [NameInMap("update_start_time")]
        [Validation(Required=false)]
        public string UpdateStartTime { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
