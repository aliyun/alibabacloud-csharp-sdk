// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListOutboundCallNumbersResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>List of outbound call numbers.</para>
        /// </summary>
        [NameInMap("OutboundCallNumbers")]
        [Validation(Required=false)]
        public ListOutboundCallNumbersResponseBodyOutboundCallNumbers OutboundCallNumbers { get; set; }
        public class ListOutboundCallNumbersResponseBodyOutboundCallNumbers : TeaModel {
            /// <summary>
            /// <para>List of outbound call number data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListOutboundCallNumbersResponseBodyOutboundCallNumbersList> List { get; set; }
            public class ListOutboundCallNumbersResponseBodyOutboundCallNumbersList : TeaModel {
                /// <summary>
                /// <para>Phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10088</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>ID of the phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fa0e21e9-caab-4629-9121-1e341243d599</para>
                /// </summary>
                [NameInMap("OutboundCallNumberId")]
                [Validation(Required=false)]
                public string OutboundCallNumberId { get; set; }

                /// <summary>
                /// <para>Time window for rate limiting, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RateLimitCount")]
                [Validation(Required=false)]
                public string RateLimitCount { get; set; }

                /// <summary>
                /// <para>Maximum number of calls allowed in the time window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RateLimitPeriod")]
                [Validation(Required=false)]
                public string RateLimitPeriod { get; set; }

            }

            /// <summary>
            /// <para>Page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Number of entries on the page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
