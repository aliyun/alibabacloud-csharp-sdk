// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyListingSearchV2Request : TeaModel {
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public List<int?> CabinClass { get; set; }

        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public List<string> DepDate { get; set; }

        [NameInMap("interface_caller_is_support_retry")]
        [Validation(Required=false)]
        public bool? InterfaceCallerIsSupportRetry { get; set; }

        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public List<FlightModifyListingSearchV2RequestPassengerSegmentRelations> PassengerSegmentRelations { get; set; }
        public class FlightModifyListingSearchV2RequestPassengerSegmentRelations : TeaModel {
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            [NameInMap("segment_id_list")]
            [Validation(Required=false)]
            public List<string> SegmentIdList { get; set; }

        }

        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        [NameInMap("search_retry_token")]
        [Validation(Required=false)]
        public string SearchRetryToken { get; set; }

        [NameInMap("selected_segments")]
        [Validation(Required=false)]
        public List<FlightModifyListingSearchV2RequestSelectedSegments> SelectedSegments { get; set; }
        public class FlightModifyListingSearchV2RequestSelectedSegments : TeaModel {
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            [NameInMap("dep_date_time")]
            [Validation(Required=false)]
            public string DepDateTime { get; set; }

            [NameInMap("journey_seq")]
            [Validation(Required=false)]
            public int? JourneySeq { get; set; }

            [NameInMap("marketing_flight_no")]
            [Validation(Required=false)]
            public string MarketingFlightNo { get; set; }

            [NameInMap("operating_flight_no")]
            [Validation(Required=false)]
            public string OperatingFlightNo { get; set; }

            [NameInMap("segment_seq")]
            [Validation(Required=false)]
            public int? SegmentSeq { get; set; }

        }

        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("voluntary")]
        [Validation(Required=false)]
        public bool? Voluntary { get; set; }

    }

}
