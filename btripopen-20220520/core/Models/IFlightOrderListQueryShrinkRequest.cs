// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IFlightOrderListQueryShrinkRequest : TeaModel {
        [NameInMap("apply_id_list")]
        [Validation(Required=false)]
        public string ApplyIdListShrink { get; set; }

        [NameInMap("book_type_list")]
        [Validation(Required=false)]
        public string BookTypeListShrink { get; set; }

        [NameInMap("booker_id")]
        [Validation(Required=false)]
        public string BookerIdShrink { get; set; }

        [NameInMap("end_date")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("scroll_id")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        [NameInMap("start_date")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("third_part_apply_id_list")]
        [Validation(Required=false)]
        public string ThirdPartApplyIdListShrink { get; set; }

    }

}
