// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelPricePullRequest : TeaModel {
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        [NameInMap("city_code")]
        [Validation(Required=false)]
        public int? CityCode { get; set; }

        [NameInMap("hotel_ids")]
        [Validation(Required=false)]
        public List<string> HotelIds { get; set; }

        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

    }

}
