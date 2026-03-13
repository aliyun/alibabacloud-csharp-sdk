// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryCompenInfosForOpResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<QueryCompenInfosForOpResponseBodyModule> Module { get; set; }
        public class QueryCompenInfosForOpResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>82508250249123456</para>
            /// </summary>
            [NameInMap("compen_id")]
            [Validation(Required=false)]
            public string CompenId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("compensation_type")]
            [Validation(Required=false)]
            public string CompensationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1002086203277812345</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-22 20:13:58</para>
            /// </summary>
            [NameInMap("settle_time")]
            [Validation(Required=false)]
            public string SettleTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public int? SettleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>999-12345678</para>
            /// </summary>
            [NameInMap("ticket_no")]
            [Validation(Required=false)]
            public string TicketNo { get; set; }

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
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
