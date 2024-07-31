// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSuggestV2Request : TeaModel {
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
        public string CityCode { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("search_type")]
        [Validation(Required=false)]
        public int? SearchType { get; set; }

    }

}
