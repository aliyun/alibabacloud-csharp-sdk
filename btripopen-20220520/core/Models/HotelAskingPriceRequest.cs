// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelAskingPriceRequest : TeaModel {
        [NameInMap("adult_num")]
        [Validation(Required=false)]
        public string AdultNum { get; set; }

        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("check_in_date")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        [NameInMap("check_out_date")]
        [Validation(Required=false)]
        public string CheckOutDate { get; set; }

        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        [NameInMap("city_name")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        [NameInMap("dir")]
        [Validation(Required=false)]
        public int? Dir { get; set; }

        [NameInMap("hotel_star")]
        [Validation(Required=false)]
        public string HotelStar { get; set; }

        [NameInMap("is_protocol")]
        [Validation(Required=false)]
        public bool? IsProtocol { get; set; }

        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

        [NameInMap("shids")]
        [Validation(Required=false)]
        public List<long?> Shids { get; set; }

        [NameInMap("sort_code")]
        [Validation(Required=false)]
        public int? SortCode { get; set; }

    }

}
