// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelIndexInfoRequest : TeaModel {
        /// <summary>
        /// <para>The city ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>330000</para>
        /// </summary>
        [NameInMap("city_code")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        /// <summary>
        /// <para>The hotel status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("hotel_status")]
        [Validation(Required=false)]
        public int? HotelStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve international hotel IDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: international hotels.</description></item>
        /// <item><description>false: domestic hotels.</description></item>
        /// </list>
        /// <para>Set this parameter to true to retrieve international hotel IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("internation")]
        [Validation(Required=false)]
        public bool? Internation { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The pagination token. Leave this parameter empty for the first request. For subsequent requests, pass in the page_token returned from the previous response. An empty response indicates that all data has been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1038882</para>
        /// </summary>
        [NameInMap("page_token")]
        [Validation(Required=false)]
        public string PageToken { get; set; }

    }

}
