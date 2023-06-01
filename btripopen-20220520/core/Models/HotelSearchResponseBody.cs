// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSearchResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelSearchResponseBodyModule Module { get; set; }
        public class HotelSearchResponseBodyModule : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<HotelSearchResponseBodyModuleItems> Items { get; set; }
            public class HotelSearchResponseBodyModuleItems : TeaModel {
                [NameInMap("brand_name")]
                [Validation(Required=false)]
                public string BrandName { get; set; }

                [NameInMap("btand_code")]
                [Validation(Required=false)]
                public string BtandCode { get; set; }

                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("distance")]
                [Validation(Required=false)]
                public int? Distance { get; set; }

                [NameInMap("district_code")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                [NameInMap("hotel_address")]
                [Validation(Required=false)]
                public string HotelAddress { get; set; }

                [NameInMap("hotel_code")]
                [Validation(Required=false)]
                public string HotelCode { get; set; }

                [NameInMap("hotel_en_name")]
                [Validation(Required=false)]
                public string HotelEnName { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("hotel_star")]
                [Validation(Required=false)]
                public string HotelStar { get; set; }

                [NameInMap("image_url")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("min_price")]
                [Validation(Required=false)]
                public double? MinPrice { get; set; }

                [NameInMap("original_min_price")]
                [Validation(Required=false)]
                public double? OriginalMinPrice { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("tel")]
                [Validation(Required=false)]
                public string Tel { get; set; }

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
