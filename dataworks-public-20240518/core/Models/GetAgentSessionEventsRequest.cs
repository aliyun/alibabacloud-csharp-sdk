// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentSessionEventsRequest : TeaModel {
        /// <summary>
        /// <para>The epoch identifier of the event stream, obtained from data.eventEpoch in the stream_open control frame of the server. Pass the original value only when Last-Event-Id of the same native session and the same epoch is provided. Omit this parameter when subscribing for the first time or when the epoch is not obtained. Do not construct it yourself or reuse it across native sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epoch_example</para>
        /// </summary>
        [NameInMap("EventEpoch")]
        [Validation(Required=false)]
        public string EventEpoch { get; set; }

        /// <summary>
        /// <para>The ID of the target agent session. Set the value to the SessionId returned by CreateAgentSession. The parameter name for this API operation is SessionCode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>session_example</para>
        /// </summary>
        [NameInMap("SessionCode")]
        [Validation(Required=false)]
        public string SessionCode { get; set; }

    }

}
