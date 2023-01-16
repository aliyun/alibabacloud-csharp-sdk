// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingEnquiryRequest : TeaModel {
        [NameInMap("arr_city")]
        [Validation(Required=false)]
        public string ArrCity { get; set; }

        [NameInMap("dep_city")]
        [Validation(Required=false)]
        public string DepCity { get; set; }

        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public int? IsVoluntary { get; set; }

        [NameInMap("modify_depart_date")]
        [Validation(Required=false)]
        public string ModifyDepartDate { get; set; }

        [NameInMap("modify_flight_no")]
        [Validation(Required=false)]
        public string ModifyFlightNo { get; set; }

        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
