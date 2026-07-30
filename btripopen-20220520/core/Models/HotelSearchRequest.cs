// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelSearchRequest : TeaModel {
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
        /// <para>The list of brand codes to filter by.</para>
        /// </summary>
        [NameInMap("brand_code")]
        [Validation(Required=false)]
        public List<string> BrandCode { get; set; }

        /// <summary>
        /// <para>The user ID. If organization personnel synchronization is enabled, use btripUserId. Otherwise, pass the userId corresponding to the distributor\&quot;s own system user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The check-in date in the format of yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-22</para>
        /// </summary>
        [NameInMap("check_in_date")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        /// <summary>
        /// <para>The check-out date in the format of yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-22</para>
        /// </summary>
        [NameInMap("check_out_date")]
        [Validation(Required=false)]
        public string CheckOutDate { get; set; }

        /// <summary>
        /// <para>The city code. Obtained from the basic city data in the travel approval. Required for international hotels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330100</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        /// <summary>
        /// <para>The sort direction. This filter is not available for international hotels. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: descending</description></item>
        /// <item><description>1: ascending</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dir")]
        [Validation(Required=false)]
        public int? Dir { get; set; }

        /// <summary>
        /// <para>The search distance range. Unit: meters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("distance")]
        [Validation(Required=false)]
        public int? Distance { get; set; }

        /// <summary>
        /// <para>The district code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330000</para>
        /// </summary>
        [NameInMap("district_code")]
        [Validation(Required=false)]
        public string DistrictCode { get; set; }

        /// <summary>
        /// <para>The list of star ratings to filter by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("hotel_star")]
        [Validation(Required=false)]
        public string HotelStar { get; set; }

        /// <summary>
        /// <para>Specifies whether to query only protocol hotels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("is_protocol")]
        [Validation(Required=false)]
        public bool? IsProtocol { get; set; }

        /// <summary>
        /// <para>The keywords for keyword-based search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>万豪</para>
        /// </summary>
        [NameInMap("key_words")]
        [Validation(Required=false)]
        public string KeyWords { get; set; }

        /// <summary>
        /// <para>The coordinates (AMAP). Longitude comes first, followed by latitude.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.010059, 30.284666</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The maximum price. Unit: CNY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("max_price")]
        [Validation(Required=false)]
        public double? MaxPrice { get; set; }

        /// <summary>
        /// <para>The minimum price. Unit: CNY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("min_price")]
        [Validation(Required=false)]
        public double? MinPrice { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether mixed payment is supported. 0: supported. 1: not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pay_over_type")]
        [Validation(Required=false)]
        public int? PayOverType { get; set; }

        /// <summary>
        /// <para>The payment method. 0: corporate payment. 1: personal payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("payment_type")]
        [Validation(Required=false)]
        public int? PaymentType { get; set; }

        [NameInMap("poi")]
        [Validation(Required=false)]
        public string Poi { get; set; }

        /// <summary>
        /// <para>The list of hotel IDs. Maximum: 20.</para>
        /// </summary>
        [NameInMap("shids")]
        [Validation(Required=false)]
        public List<long?> Shids { get; set; }

        /// <summary>
        /// <para>The sort method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: default</description></item>
        /// <item><description>1: lowest price first</description></item>
        /// <item><description>2: highest price first</description></item>
        /// <item><description>3: nearest distance first</description></item>
        /// <item><description>4: highest rating first</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("sort_code")]
        [Validation(Required=false)]
        public int? SortCode { get; set; }

        /// <summary>
        /// <para>The role. 0 indicates a regular user. 1 indicates a special applicant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("super_man")]
        [Validation(Required=false)]
        public int? SuperMan { get; set; }

    }

}
