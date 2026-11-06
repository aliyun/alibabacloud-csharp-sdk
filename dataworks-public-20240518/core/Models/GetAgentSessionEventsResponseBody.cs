// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentSessionEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The event data of the current frame. The content varies with the Event type and should be parsed according to the event type. Preserve the original session, turn, and tool invocation identifiers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The SSE event type, such as session_update. Process control frames and business frames separately.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session_update</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The remote SSE event cursor. Save it after consumption for subsequent resumption using Last-Event-Id. Some control frames may not have a cursor. Do not generate a local cursor for them.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The request ID of the current OpenAPI subscription request, used to troubleshoot subscription failures. It is not an event cursor or an interactive question ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A0B6E0-E005-1465-B5DE-5CD17677426F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
