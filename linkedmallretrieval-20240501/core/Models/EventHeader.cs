// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkedmallRetrieval20240501.Models
{
    public class EventHeader : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>on_common_search_stream</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ff3de49-cedc-47ea-ba3c-8456acd345d8</para>
        /// </summary>
        [NameInMap("eventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55c2349-cedc-47ea-ba3c-8456acd6c7d8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1403</para>
        /// </summary>
        [NameInMap("responseTime")]
        [Validation(Required=false)]
        public long? ResponseTime { get; set; }

    }

}
