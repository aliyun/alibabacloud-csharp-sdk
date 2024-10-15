// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelGoodsQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("adult_num")]
        [Validation(Required=false)]
        public string AdultNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("agreement_price")]
        [Validation(Required=false)]
        public bool? AgreementPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-27</para>
        /// </summary>
        [NameInMap("begin_date")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("breakfast_included")]
        [Validation(Required=false)]
        public bool? BreakfastIncluded { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>330100</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-28</para>
        /// </summary>
        [NameInMap("end_date")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>182873</para>
        /// </summary>
        [NameInMap("hotel_id")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("pay_over_type")]
        [Validation(Required=false)]
        public int? PayOverType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("special_invoice")]
        [Validation(Required=false)]
        public bool? SpecialInvoice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("super_man")]
        [Validation(Required=false)]
        public int? SuperMan { get; set; }

    }

}
