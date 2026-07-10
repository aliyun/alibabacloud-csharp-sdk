// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryV2Request : TeaModel {
        [NameInMap("approve_id")]
        [Validation(Required=false)]
        public List<string> ApproveId { get; set; }

        [NameInMap("booker_id")]
        [Validation(Required=false)]
        public List<string> BookerId { get; set; }

        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public List<string> DepartId { get; set; }

        [NameInMap("end_date")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("page_Size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("scroll_id")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        [NameInMap("start_date")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("supplier")]
        [Validation(Required=false)]
        public List<string> Supplier { get; set; }

        [NameInMap("thirdpart_approve_id")]
        [Validation(Required=false)]
        public List<string> ThirdpartApproveId { get; set; }

        [NameInMap("update_end_date")]
        [Validation(Required=false)]
        public string UpdateEndDate { get; set; }

        [NameInMap("update_start_date")]
        [Validation(Required=false)]
        public string UpdateStartDate { get; set; }

    }

}
