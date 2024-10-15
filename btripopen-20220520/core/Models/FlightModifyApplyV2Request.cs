// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyApplyV2Request : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>72e961f8-930b-43c1-a4ca-18a6f28349c6distributionModifyCacheInfo</para>
        /// </summary>
        [NameInMap("cache_key")]
        [Validation(Required=false)]
        public string CacheKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17816963077</para>
        /// </summary>
        [NameInMap("contact_phone")]
        [Validation(Required=false)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fa2fb23a859a4e78b5ddb87a6a23094b_0</para>
        /// </summary>
        [NameInMap("item_id")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>1019195786853020</para>
        /// </summary>
        [NameInMap("out_sub_order_id")]
        [Validation(Required=false)]
        public string OutSubOrderId { get; set; }

        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public List<FlightModifyApplyV2RequestPassengerSegmentRelations> PassengerSegmentRelations { get; set; }
        public class FlightModifyApplyV2RequestPassengerSegmentRelations : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3243028</para>
            /// </summary>
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            [NameInMap("segment_id_list")]
            [Validation(Required=false)]
            public List<string> SegmentIdList { get; set; }

        }

        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>sessionId</para>
        /// 
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
