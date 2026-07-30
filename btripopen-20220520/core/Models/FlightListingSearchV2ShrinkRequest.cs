// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightListingSearchV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The two-letter IATA airline code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA</para>
        /// </summary>
        [NameInMap("airline_code")]
        [Validation(Required=false)]
        public string AirlineCode { get; set; }

        /// <summary>
        /// <para>The cabin class type for search. Default value: 0 (ALL_CABIN, all cabins).</para>
        /// <remarks>
        /// <para>Notice: Although the parameter structure is a list, only a single cabin class is currently supported. Multiple cabin classes are not supported.</notice></para>
        /// </remarks>
        /// </summary>
        [NameInMap("cabin_type_list")]
        [Validation(Required=false)]
        public string CabinTypeListShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to show only direct flights. Default value: TRUE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("direct_only")]
        [Validation(Required=false)]
        public bool? DirectOnly { get; set; }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>Specifies whether to query multi-cabin prices (aggregated OTA search). Default value: FALSE.</para>
        /// <remarks>
        /// <para>Warning: Deprecated</warning></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("need_multi_class_price")]
        [Validation(Required=false)]
        public bool? NeedMultiClassPrice { get; set; }

        /// <summary>
        /// <para>Specifies whether to query service fees. Default value: TRUE.</para>
        /// <remarks>
        /// <para>Warning: Deprecated</warning></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("need_query_service_fee")]
        [Validation(Required=false)]
        public bool? NeedQueryServiceFee { get; set; }

        /// <summary>
        /// <para>Specifies whether to include codeshare flights. Default value: TRUE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("need_share_flight")]
        [Validation(Required=false)]
        public bool? NeedShareFlight { get; set; }

        /// <summary>
        /// <para>Specifies whether to separately query the lowest prices for Y (economy) and C (business) cabins. Default value: FALSE.</para>
        /// <remarks>
        /// <para>Specifies whether to separately query the lowest prices for Y (economy) and C (business) cabins. Default value: FALSE.</para>
        /// <list type="bullet">
        /// <item><description>Normal case: Set to FALSE. The &quot;item_list&quot; returns only one item, which is the same as &quot;best_price_item&quot;. You can use either one.</description></item>
        /// <item><description>Special case: When set to TRUE, multiple prices are returned in the flight list. The &quot;item_list&quot; may return two items, and &quot;best_price_item&quot; is the lowest-priced item in &quot;item_list&quot; (not recommended).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("need_y_c_best_price")]
        [Validation(Required=false)]
        public bool? NeedYCBestPrice { get; set; }

        /// <summary>
        /// <para>The search journeys.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public string SearchJourneysShrink { get; set; }

        /// <summary>
        /// <para>The search mode.</para>
        /// <remarks>
        /// <para>Search mode:</para>
        /// <list type="bullet">
        /// <item><description>For one-way search: pass 0 (outbound).</description></item>
        /// <item><description>For round-trip outbound search: pass 0 (outbound).</description></item>
        /// <item><description>For round-trip return search: pass 1 (return).</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        /// <summary>
        /// <para>The trip type.</para>
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
