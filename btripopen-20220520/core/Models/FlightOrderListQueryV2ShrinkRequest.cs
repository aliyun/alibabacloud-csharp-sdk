// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryV2ShrinkRequest : TeaModel {
        [NameInMap("approve_id")]
        [Validation(Required=false)]
        public string ApproveIdShrink { get; set; }

        [NameInMap("booker_id")]
        [Validation(Required=false)]
        public string BookerIdShrink { get; set; }

        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartIdShrink { get; set; }

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
        public string SupplierShrink { get; set; }

        [NameInMap("thirdpart_approve_id")]
        [Validation(Required=false)]
        public string ThirdpartApproveIdShrink { get; set; }

        [NameInMap("update_end_date")]
        [Validation(Required=false)]
        public string UpdateEndDate { get; set; }

        [NameInMap("update_start_date")]
        [Validation(Required=false)]
        public string UpdateStartDate { get; set; }

    }

}
