// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyListingSearchV2ShrinkRequest : TeaModel {
        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClassShrink { get; set; }

        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDateShrink { get; set; }

        [NameInMap("interface_caller_is_support_retry")]
        [Validation(Required=false)]
        public bool? InterfaceCallerIsSupportRetry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1017002195370467138</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1017002195370467137</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public string PassengerSegmentRelationsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("search_mode")]
        [Validation(Required=false)]
        public int? SearchMode { get; set; }

        [NameInMap("search_retry_token")]
        [Validation(Required=false)]
        public string SearchRetryToken { get; set; }

        [NameInMap("selected_segments")]
        [Validation(Required=false)]
        public string SelectedSegmentsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a2ffebfe733742aab5c491d960ba3d59</para>
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
