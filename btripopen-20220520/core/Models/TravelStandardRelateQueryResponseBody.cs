// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardRelateQueryResponseBody : TeaModel {
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TravelStandardRelateQueryResponseBodyModule Module { get; set; }
        public class TravelStandardRelateQueryResponseBodyModule : TeaModel {
            [NameInMap("reserve_bind_entity_list")]
            [Validation(Required=false)]
            public List<TravelStandardRelateQueryResponseBodyModuleReserveBindEntityList> ReserveBindEntityList { get; set; }
            public class TravelStandardRelateQueryResponseBodyModuleReserveBindEntityList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>667104628</para>
                /// </summary>
                [NameInMap("entity_id")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("entity_name")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("entity_type")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("resultCode")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bcc3a16583004579056128d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
