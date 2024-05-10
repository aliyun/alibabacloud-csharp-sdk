// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSearchRequest : TeaModel {
        [NameInMap("adult_num")]
        [Validation(Required=false)]
        public string AdultNum { get; set; }

        [NameInMap("brand_code")]
        [Validation(Required=false)]
        public List<string> BrandCode { get; set; }

        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("check_in_date")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("check_out_date")]
        [Validation(Required=false)]
        public string CheckOutDate { get; set; }

        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        [NameInMap("dir")]
        [Validation(Required=false)]
        public int? Dir { get; set; }

        [NameInMap("distance")]
        [Validation(Required=false)]
        public int? Distance { get; set; }

        [NameInMap("district_code")]
        [Validation(Required=false)]
        public string DistrictCode { get; set; }

        [NameInMap("hotel_star")]
        [Validation(Required=false)]
        public string HotelStar { get; set; }

        [NameInMap("is_protocol")]
        [Validation(Required=false)]
        public bool? IsProtocol { get; set; }

        [NameInMap("key_words")]
        [Validation(Required=false)]
        public string KeyWords { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("max_price")]
        [Validation(Required=false)]
        public double? MaxPrice { get; set; }

        [NameInMap("min_price")]
        [Validation(Required=false)]
        public double? MinPrice { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("pay_over_type")]
        [Validation(Required=false)]
        public int? PayOverType { get; set; }

        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

        [NameInMap("shids")]
        [Validation(Required=false)]
        public List<long?> Shids { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sort_code")]
        [Validation(Required=false)]
        public int? SortCode { get; set; }

        [NameInMap("super_man")]
        [Validation(Required=false)]
        public int? SuperMan { get; set; }

    }

}
