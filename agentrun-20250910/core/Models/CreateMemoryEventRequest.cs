// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateMemoryEventRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("events")]
        [Validation(Required=false)]
        public List<CreateMemoryEventRequestEvents> Events { get; set; }
        public class CreateMemoryEventRequestEvents : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33.63.112.139_29914368_MTEE3_1754878127662_117007</para>
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> Message { get; set; }

            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd0bbf26-3c0c-4d91-a392-42d59501e12b</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uid1</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
