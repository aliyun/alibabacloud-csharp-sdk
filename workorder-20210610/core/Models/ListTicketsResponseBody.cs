// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ListTicketsResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The return code of the request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The return value is my ticket list data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListTicketsResponseBodyData> Data { get; set; }
        public class ListTicketsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The status of the ticket. The reference values are as follows 1, &quot;assigned&quot;, &quot;Pending Response&quot;, 2, &quot;handling&quot;, &quot;handling&quot;, 3, &quot;wait_feedback&quot;, &quot;Pending feedback&quot;, 4: &quot;feedback&quot;, &quot;Feedback&quot;, 5, &quot;wait_confirm&quot;, &quot;To be confirmed&quot;, 6, &quot;confirmed&quot;, &quot;Completed&quot;</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public ListTicketsResponseBodyDataStatus Status { get; set; }
            public class ListTicketsResponseBodyDataStatus : TeaModel {
                /// <summary>
                /// <para>Status description, if completed</para>
                /// 
                /// <b>Example:</b>
                /// <para>Completed</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>A status value, such as 6, represents completed</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Work Order Number</para>
            /// 
            /// <b>Example:</b>
            /// <para>0005PYGCW</para>
            /// </summary>
            [NameInMap("TicketId")]
            [Validation(Required=false)]
            public string TicketId { get; set; }

            /// <summary>
            /// <para>The title of the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Why ECS backup failed?</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The error message. If success is set to false, the message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page number of the paging query parameter</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a pagination query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the API request. The requestID is unique for each call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC0AB2EC-AFBC-44BA-AE77-132A5A1EC0AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates that the call is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of query results, that is, the total number of my ticket records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
