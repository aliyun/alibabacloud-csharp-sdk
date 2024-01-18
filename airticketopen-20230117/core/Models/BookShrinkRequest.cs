// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class BookShrinkRequest : TeaModel {
        [NameInMap("contact")]
        [Validation(Required=false)]
        public string ContactShrink { get; set; }

        [NameInMap("out_order_num")]
        [Validation(Required=false)]
        public string OutOrderNum { get; set; }

        [NameInMap("passenger_ancillary_purchase_map_list")]
        [Validation(Required=false)]
        public string PassengerAncillaryPurchaseMapListShrink { get; set; }

        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public string PassengerListShrink { get; set; }

        /// <summary>
        /// solution_id
        /// </summary>
        [NameInMap("solution_id")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
