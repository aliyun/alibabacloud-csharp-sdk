// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EstimatedPriceQueryRequest : TeaModel {
        [NameInMap("arr_city")]
        [Validation(Required=false)]
        public string ArrCity { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("dep_city")]
        [Validation(Required=false)]
        public string DepCity { get; set; }

        [NameInMap("end_time")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("itinerary_id")]
        [Validation(Required=false)]
        public string ItineraryId { get; set; }

        [NameInMap("start_time")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
