// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelAskingPriceShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("adult_num")]
        [Validation(Required=false)]
        public string AdultNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-22 00:00:00</para>
        /// </summary>
        [NameInMap("check_in_date")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-22 00:00:00</para>
        /// </summary>
        [NameInMap("check_out_date")]
        [Validation(Required=false)]
        public string CheckOutDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>330100</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        [NameInMap("city_name")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dir")]
        [Validation(Required=false)]
        public int? Dir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("hotel_star")]
        [Validation(Required=false)]
        public string HotelStar { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("is_protocol")]
        [Validation(Required=false)]
        public bool? IsProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("shids")]
        [Validation(Required=false)]
        public string ShidsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("sort_code")]
        [Validation(Required=false)]
        public int? SortCode { get; set; }

    }

}
