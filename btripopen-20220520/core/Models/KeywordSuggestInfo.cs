/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class KeywordSuggestInfo : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("business_area_with_city")]
        [Validation(Required=false)]
        public KeywordSuggestInfo BusinessAreaWithCity { get; set; }

        [NameInMap("city_code")]
        [Validation(Required=false)]
        public int? CityCode { get; set; }

        [NameInMap("city_name")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        [NameInMap("display_name")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("hotel_id")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("point")]
        [Validation(Required=false)]
        public string Point { get; set; }

        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public int? Region { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("type_desc")]
        [Validation(Required=false)]
        public string TypeDesc { get; set; }

    }

}
