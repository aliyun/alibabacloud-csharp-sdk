// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ElectronicItineraryBatchApplyResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

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
        /// <para>The batch application result for electronic itinerary receipts.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public ElectronicItineraryBatchApplyResponseBodyModule Module { get; set; }
        public class ElectronicItineraryBatchApplyResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of tickets that failed to be applied.</para>
            /// </summary>
            [NameInMap("apply_failed_ticket_list")]
            [Validation(Required=false)]
            public List<ElectronicItineraryBatchApplyResponseBodyModuleApplyFailedTicketList> ApplyFailedTicketList { get; set; }
            public class ElectronicItineraryBatchApplyResponseBodyModuleApplyFailedTicketList : TeaModel {
                /// <summary>
                /// <para>The failure reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5001</para>
                /// </summary>
                [NameInMap("failed_code")]
                [Validation(Required=false)]
                public int? FailedCode { get; set; }

                /// <summary>
                /// <para>The failure reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>票号不存在</para>
                /// </summary>
                [NameInMap("failed_reason")]
                [Validation(Required=false)]
                public string FailedReason { get; set; }

                /// <summary>
                /// <para>The ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>018-6605785754</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            /// <summary>
            /// <para>The batch number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0c7b5944608953479a9a4d40c1eec618</para>
            /// </summary>
            [NameInMap("batch_no")]
            [Validation(Required=false)]
            public string BatchNo { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
