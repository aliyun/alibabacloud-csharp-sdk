// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelAskingPriceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of adults.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("adult_num")]
        [Validation(Required=false)]
        public string AdultNum { get; set; }

        /// <summary>
        /// <para>The user ID. If organization members are synchronized, use btripUserId. Otherwise, pass the userId corresponding to the distributor\&quot;s own system user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The check-in date in the format of YYYY-MM-DD HH:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-22 00:00:00</para>
        /// </summary>
        [NameInMap("check_in_date")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        /// <summary>
        /// <para>The check-out date in the format of YYYY-MM-DD HH:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-22 00:00:00</para>
        /// </summary>
        [NameInMap("check_out_date")]
        [Validation(Required=false)]
        public string CheckOutDate { get; set; }

        /// <summary>
        /// <para>The city code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330100</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        /// <summary>
        /// <para>The city name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州</para>
        /// </summary>
        [NameInMap("city_name")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        /// <summary>
        /// <para>The sort direction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dir")]
        [Validation(Required=false)]
        public int? Dir { get; set; }

        /// <summary>
        /// <para>The list of star ratings for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("hotel_star")]
        [Validation(Required=false)]
        public string HotelStar { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only contracted hotels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("is_protocol")]
        [Validation(Required=false)]
        public bool? IsProtocol { get; set; }

        /// <summary>
        /// <para>The payment method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: enterprise payment.</description></item>
        /// <item><description>1: personal payment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

        /// <summary>
        /// <para>The hotel IDs for filtering. A maximum of 20 IDs per page are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("shids")]
        [Validation(Required=false)]
        public string ShidsShrink { get; set; }

        /// <summary>
        /// <para>The sort method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("sort_code")]
        [Validation(Required=false)]
        public int? SortCode { get; set; }

    }

}
