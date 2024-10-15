// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOtaSearchV2ShrinkRequest : TeaModel {
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClassShrink { get; set; }

        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDateShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1017002195370467200</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1017002195370467200</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public string PassengerSegmentRelationsShrink { get; set; }

        [NameInMap("selected_segments")]
        [Validation(Required=false)]
        public string SelectedSegmentsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>590f17eca9374f20ac7e8ed8a7db2f35</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("voluntary")]
        [Validation(Required=false)]
        public bool? Voluntary { get; set; }

    }

}
