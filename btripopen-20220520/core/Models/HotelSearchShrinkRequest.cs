// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSearchShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("adult_num")]
        [Validation(Required=false)]
        public string AdultNum { get; set; }

        [NameInMap("brand_code")]
        [Validation(Required=false)]
        public string BrandCodeShrink { get; set; }

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
        /// <para>2023-02-22</para>
        /// </summary>
        [NameInMap("check_in_date")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-22</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dir")]
        [Validation(Required=false)]
        public int? Dir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("distance")]
        [Validation(Required=false)]
        public int? Distance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>330000</para>
        /// </summary>
        [NameInMap("district_code")]
        [Validation(Required=false)]
        public string DistrictCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
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

        [NameInMap("key_words")]
        [Validation(Required=false)]
        public string KeyWords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120.010059, 30.284666</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("max_price")]
        [Validation(Required=false)]
        public double? MaxPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("min_price")]
        [Validation(Required=false)]
        public double? MinPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
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

        [NameInMap("shids")]
        [Validation(Required=false)]
        public string ShidsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("sort_code")]
        [Validation(Required=false)]
        public int? SortCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("super_man")]
        [Validation(Required=false)]
        public int? SuperMan { get; set; }

    }

}
