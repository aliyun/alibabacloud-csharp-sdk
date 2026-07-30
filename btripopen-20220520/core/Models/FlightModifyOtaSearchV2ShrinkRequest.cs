// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOtaSearchV2ShrinkRequest : TeaModel {
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
        /// <para>1017002195370467200</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467200</para>
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
        /// <para>The flight information selected by the user during search. This parameter is required.</para>
        /// </summary>
        [NameInMap("selected_segments")]
        [Validation(Required=false)]
        public string SelectedSegmentsShrink { get; set; }

        /// <summary>
        /// <para>The session ID. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>590f17eca9374f20ac7e8ed8a7db2f35</para>
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
