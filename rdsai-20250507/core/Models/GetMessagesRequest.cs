// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The conversation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>941c6f59-acf5-4e11-9adc-31e52e1f****</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The event output type. Valid values: inline and separate. Default value: inline. In inline mode, tool invocation events, child node events, and document events are unified into the answer field of the event where event = message. In separate mode, tool invocation events, child node events, and document events have their own respective events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inline</para>
        /// </summary>
        [NameInMap("EventMode")]
        [Validation(Required=false)]
        public string EventMode { get; set; }

        /// <summary>
        /// <para>The ID of the first message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>038866af-a050-4bc5-bfad-b7bfc838****</para>
        /// </summary>
        [NameInMap("FirstId")]
        [Validation(Required=false)]
        public string FirstId { get; set; }

        /// <summary>
        /// <para>The flow instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-90ea18a8254645968325</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>The number of rows per page for paging. Valid values: 1 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The ContextDB workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
