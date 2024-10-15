// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelIndexInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>330000</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("hotel_status")]
        [Validation(Required=false)]
        public int? HotelStatus { get; set; }

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
        /// <para>1038882</para>
        /// </summary>
        [NameInMap("page_token")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

    }

}
