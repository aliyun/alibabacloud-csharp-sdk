// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class KeywordSuggestInfo : TeaModel {
        /// <summary>
        /// <para>The address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州湖墅南路XX号</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The business area.</para>
        /// </summary>
        [NameInMap("business_area_with_city")]
        [Validation(Required=false)]
        public KeywordSuggestInfo BusinessAreaWithCity { get; set; }

        /// <summary>
        /// <para>The city code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300100</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public int? CityCode { get; set; }

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
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州JW万豪酒店</para>
        /// </summary>
        [NameInMap("display_name")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The hotel ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53853318</para>
        /// </summary>
        [NameInMap("hotel_id")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>The icon.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png">https://gw.alicdn.com/imgextra/i3/O1CN01qKg25r1rKLOKxT3vB_!!6000000005612-2-tps-32-32.png</a></para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>The rating.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.8分</para>
        /// </summary>
        [NameInMap("point")]
        [Validation(Required=false)]
        public string Point { get; set; }

        /// <summary>
        /// <para>The hotel starting price, in CNY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>524</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public int? Region { get; set; }

        /// <summary>
        /// <para>The type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The type description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>酒店</para>
        /// </summary>
        [NameInMap("type_desc")]
        [Validation(Required=false)]
        public string TypeDesc { get; set; }

    }

}
