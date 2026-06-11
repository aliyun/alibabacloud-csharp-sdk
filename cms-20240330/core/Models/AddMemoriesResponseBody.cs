// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AddMemoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Request results.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<AddMemoriesResponseBodyResults> Results { get; set; }
        public class AddMemoriesResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>Event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>897294a7-67a4-4f60-976c-e136edc5f97e</para>
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>Details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Memory processing has been queued for background execution</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Processing status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
