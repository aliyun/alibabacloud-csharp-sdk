// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightListingSearchV2ShrinkRequest : TeaModel {
        [NameInMap("airline_code")]
        [Validation(Required=false)]
        public string AirlineCode { get; set; }

        [NameInMap("cabin_type_list")]
        [Validation(Required=false)]
        public string CabinTypeListShrink { get; set; }

        [NameInMap("direct_only")]
        [Validation(Required=false)]
        public bool? DirectOnly { get; set; }

        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("need_multi_class_price")]
        [Validation(Required=false)]
        public bool? NeedMultiClassPrice { get; set; }

        [NameInMap("need_query_service_fee")]
        [Validation(Required=false)]
        public bool? NeedQueryServiceFee { get; set; }

        [NameInMap("need_share_flight")]
        [Validation(Required=false)]
        public bool? NeedShareFlight { get; set; }

        [NameInMap("need_y_c_best_price")]
        [Validation(Required=false)]
        public bool? NeedYCBestPrice { get; set; }

        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public string SearchJourneysShrink { get; set; }

        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public int? TripType { get; set; }

    }

}
