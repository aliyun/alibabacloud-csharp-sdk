// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelIndexInfoRequest : TeaModel {
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        [NameInMap("hotel_status")]
        [Validation(Required=false)]
        public int? HotelStatus { get; set; }

        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("page_token")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

    }

}
