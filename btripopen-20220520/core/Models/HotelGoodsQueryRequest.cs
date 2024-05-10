// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelGoodsQueryRequest : TeaModel {
        [NameInMap("adult_num")]
        [Validation(Required=false)]
        public string AdultNum { get; set; }

        [NameInMap("agreement_price")]
        [Validation(Required=false)]
        public bool? AgreementPrice { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("begin_date")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        [NameInMap("breakfast_included")]
        [Validation(Required=false)]
        public bool? BreakfastIncluded { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("end_date")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hotel_id")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("pay_over_type")]
        [Validation(Required=false)]
        public int? PayOverType { get; set; }

        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

        [NameInMap("special_invoice")]
        [Validation(Required=false)]
        public bool? SpecialInvoice { get; set; }

        [NameInMap("super_man")]
        [Validation(Required=false)]
        public int? SuperMan { get; set; }

    }

}
