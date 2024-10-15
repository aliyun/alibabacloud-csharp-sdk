// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class KeywordSuggestInfo : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("business_area_with_city")]
        [Validation(Required=false)]
        public KeywordSuggestInfo BusinessAreaWithCity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300100</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public int? CityCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>杭州</para>
        /// </summary>
        [NameInMap("city_name")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>杭州东站</para>
        /// </summary>
        [NameInMap("display_name")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>53853318</para>
        /// </summary>
        [NameInMap("hotel_id")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4.8分</para>
        /// </summary>
        [NameInMap("point")]
        [Validation(Required=false)]
        public string Point { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>524</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public int? Region { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>景点</para>
        /// </summary>
        [NameInMap("type_desc")]
        [Validation(Required=false)]
        public string TypeDesc { get; set; }

    }

}
