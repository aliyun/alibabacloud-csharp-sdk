// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightListingSearchShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business travel user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZHANGSAN</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>The cabin class type. Default value: 0.</br>
        /// Valid values: ALL_CABIN(0, &quot;all cabins&quot;), Y(1, &quot;economy&quot;), FC(2, &quot;first/business&quot;), S(3, &quot;premium economy&quot;), F(4, &quot;first class&quot;), C(5, &quot;business class&quot;), YS(6, &quot;economy and premium economy&quot;), YSC(7, &quot;economy, premium economy, and business&quot;).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cabin_type")]
        [Validation(Required=false)]
        public int? CabinType { get; set; }

        /// <summary>
        /// <para>The custom channel name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEST</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable external polling. When the external frontend controls polling, more flights are returned. Default value: false.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("out_wheel_search")]
        [Validation(Required=false)]
        public bool? OutWheelSearch { get; set; }

        /// <summary>
        /// <para>The query record ID, used for external polling.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This field takes effect only when out_wheel_search is set to true.</description></item>
        /// <item><description>Do not pass a value for the first search. Otherwise, no search results are returned.</description></item>
        /// <item><description>For each subsequent polling request, pass the query_record_id returned from the previous response. Otherwise, no search results are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60b412-cc05-4d10-b570-</para>
        /// </summary>
        [NameInMap("query_record_id")]
        [Validation(Required=false)]
        public string QueryRecordId { get; set; }

        /// <summary>
        /// <para>The search journeys.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public string SearchJourneysShrink { get; set; }

        /// <summary>
        /// <para>The search mode. Default value: 0.</br>
        /// Valid values: OUTBOUND(0, &quot;outbound&quot;), INBOUND(1, &quot;inbound&quot;).</br>
        /// One-way: always 0. Round-trip: outbound-0, return-1. Multi-city: first leg-0, subsequent legs-1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        /// <summary>
        /// <para>The passenger information. Required if the passenger has a managed agreement price.</para>
        /// </summary>
        [NameInMap("search_passenger_list")]
        [Validation(Required=false)]
        public string SearchPassengerListShrink { get; set; }

        /// <summary>
        /// <para>The query record token, used for external polling.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This field takes effect only when out_wheel_search is set to true.</description></item>
        /// <item><description>Do not pass a value for the first search. Otherwise, no search results are returned.</description></item>
        /// <item><description>For each subsequent polling request, pass the token returned from the previous response. Otherwise, no search results are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9960b412-cc05-4d10-b570-93372d816807</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The trip type. Default value: 1.</br>
        /// Valid values: OW(1, &quot;one-way&quot;), RT(2, &quot;round-trip&quot;), MJ(5, &quot;multi-city&quot;).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public int? TripType { get; set; }

    }

}
