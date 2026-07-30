// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardRelateQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TravelStandardRelateQueryResponseBodyModule Module { get; set; }
        public class TravelStandardRelateQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of entities bound to the travel standard. A maximum of 5000 bound entities are returned in a single query.</para>
            /// </summary>
            [NameInMap("reserve_bind_entity_list")]
            [Validation(Required=false)]
            public List<TravelStandardRelateQueryResponseBodyModuleReserveBindEntityList> ReserveBindEntityList { get; set; }
            public class TravelStandardRelateQueryResponseBodyModuleReserveBindEntityList : TeaModel {
                /// <summary>
                /// <para>The entity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>667104628</para>
                /// </summary>
                [NameInMap("entity_id")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The entity name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>主管</para>
                /// </summary>
                [NameInMap("entity_name")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                /// <summary>
                /// <para>The entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("entity_type")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

            }

            /// <summary>
            /// <para>The number of entities bound to the travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("resultCode")]
        [Validation(Required=false)]
        public int? ResultCode { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
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
