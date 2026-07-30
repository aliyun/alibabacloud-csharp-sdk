// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryCompenInfosForOpResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of compensation information.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<QueryCompenInfosForOpResponseBodyModule> Module { get; set; }
        public class QueryCompenInfosForOpResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The total compensation amount in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            /// <summary>
            /// <para>The category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: flight</description></item>
            /// <item><description>2: hotel</description></item>
            /// <item><description>4: car service</description></item>
            /// <item><description>6: business travel train ticket</description></item>
            /// <item><description>11: international flight</description></item>
            /// <item><description>12: international hotel</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The compensation order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>82508250249123456</para>
            /// </summary>
            [NameInMap("compen_id")]
            [Validation(Required=false)]
            public string CompenId { get; set; }

            /// <summary>
            /// <para>The compensation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Platform experience compensation.</description></item>
            /// <item><description>2: Platform refund difference compensation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("compensation_type")]
            [Validation(Required=false)]
            public string CompensationType { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1002086203277812345</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The compensation time in the format of yyyy-MM-dd HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-22 20:13:58</para>
            /// </summary>
            [NameInMap("settle_time")]
            [Validation(Required=false)]
            public string SettleTime { get; set; }

            /// <summary>
            /// <para>The compensation settlement method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Personal payment.</description></item>
            /// <item><description>2: Enterprise immediate payment.</description></item>
            /// <item><description>4: Enterprise monthly settlement.</description></item>
            /// <item><description>5: Enterprise prepaid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public int? SettleType { get; set; }

            /// <summary>
            /// <para>The ticket number associated with the compensation. This field exists only for refund difference compensation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>999-12345678</para>
            /// </summary>
            [NameInMap("ticket_no")]
            [Validation(Required=false)]
            public string TicketNo { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The trace ID of the log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
