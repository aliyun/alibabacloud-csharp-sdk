// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelAskingPriceResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelAskingPriceResponseBodyModule Module { get; set; }
        public class HotelAskingPriceResponseBodyModule : TeaModel {
            [NameInMap("hotel_asking_price_details")]
            [Validation(Required=false)]
            public List<HotelAskingPriceResponseBodyModuleHotelAskingPriceDetails> HotelAskingPriceDetails { get; set; }
            public class HotelAskingPriceResponseBodyModuleHotelAskingPriceDetails : TeaModel {
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("hotel_address")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                [NameInMap("hotel_code")]
                [Validation(Required=false)]
                public string HotelCode { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                [NameInMap("min_price")]
                [Validation(Required=false)]
                public double? MinPrice { get; set; }

                [NameInMap("original_min_price")]
                [Validation(Required=false)]
                public double? OriginalMinPrice { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
