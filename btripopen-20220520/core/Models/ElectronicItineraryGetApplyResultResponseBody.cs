// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ElectronicItineraryGetApplyResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public ElectronicItineraryGetApplyResultResponseBodyModule Module { get; set; }
        public class ElectronicItineraryGetApplyResultResponseBodyModule : TeaModel {
            [NameInMap("apply_ticket_list")]
            [Validation(Required=false)]
            public List<ElectronicItineraryGetApplyResultResponseBodyModuleApplyTicketList> ApplyTicketList { get; set; }
            public class ElectronicItineraryGetApplyResultResponseBodyModuleApplyTicketList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5001</para>
                /// </summary>
                [NameInMap("failed_code")]
                [Validation(Required=false)]
                public int? FailedCode { get; set; }

                [NameInMap("failed_reason")]
                [Validation(Required=false)]
                public string FailedReason { get; set; }

                [NameInMap("itinerary_status")]
                [Validation(Required=false)]
                public int? ItineraryStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>781-6605285563</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            [NameInMap("batch_apply_no")]
            [Validation(Required=false)]
            public string BatchApplyNo { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
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
