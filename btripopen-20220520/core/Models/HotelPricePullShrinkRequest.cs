// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelPricePullShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The user ID. If organization members are synchronized, use btripUserId. Otherwise, pass the userId corresponding to the user in the distributor\&quot;s own system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The check-in date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-15</para>
        /// </summary>
        [NameInMap("check_in")]
        [Validation(Required=false)]
        public string CheckIn { get; set; }

        /// <summary>
        /// <para>The check-out date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-15</para>
        /// </summary>
        [NameInMap("check_out")]
        [Validation(Required=false)]
        public string CheckOut { get; set; }

        /// <summary>
        /// <para>The city code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330100</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public int? CityCode { get; set; }

        /// <summary>
        /// <para>The list of hotel codes.</para>
        /// </summary>
        [NameInMap("hotel_ids")]
        [Validation(Required=false)]
        public string HotelIdsShrink { get; set; }

        /// <summary>
        /// <para>The payment method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

    }

}
