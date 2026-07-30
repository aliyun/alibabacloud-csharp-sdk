// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyListingSearchV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cabin class. This parameter is deprecated. Currently only the lowest price is returned.</para>
        /// </summary>
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClassShrink { get; set; }

        /// <summary>
        /// <para>The intended departure date for the flight change.</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDateShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the caller supports retry.</para>
        /// <para>true: The caller supports retry. When the operation requires a retry, the response returns retry, searchRetryToken, and nextReqWaitTime.
        ///         Boolean retry (whether a retry is required)
        ///         String searchRetryToken (search retry token)
        ///         Integer nextReqWaitTime (retry time interval)
        ///         The caller must invoke the operation again based on the response and include the searchRetryToken parameter.</para>
        /// <para>false: The caller does not support retry. When the operation requires a retry, the system retries internally in a loop. Risk: excessive internal retries may cause this call to timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("interface_caller_is_support_retry")]
        [Validation(Required=false)]
        public bool? InterfaceCallerIsSupportRetry { get; set; }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The business travel order ID (sales order ID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467138</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467137</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The passenger-segment relations. Required at the passenger-segment level.</para>
        /// </summary>
        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public string PassengerSegmentRelationsShrink { get; set; }

        /// <summary>
        /// <para>The search mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        /// <summary>
        /// <para>The search retry token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2c230080358295f99e03aa4e3ccf1bd</para>
        /// </summary>
        [NameInMap("search_retry_token")]
        [Validation(Required=false)]
        public string SearchRetryToken { get; set; }

        /// <summary>
        /// <para>The flight information that the user has selected during the search. For round trips: has a value when searching for the return leg. For multi-leg trips: has a value when searching for legs other than the first.</para>
        /// </summary>
        [NameInMap("selected_segments")]
        [Validation(Required=false)]
        public string SelectedSegmentsShrink { get; set; }

        /// <summary>
        /// <para>The session ID. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2ffebfe733742aab5c491d960ba3d59</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether the change is voluntary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("voluntary")]
        [Validation(Required=false)]
        public bool? Voluntary { get; set; }

    }

}
