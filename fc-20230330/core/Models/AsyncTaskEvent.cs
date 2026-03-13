// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class AsyncTaskEvent : TeaModel {
        /// <summary>
        /// <para>The details of the event payload.</para>
        /// 
        /// <b>Example:</b>
        /// <para>body</para>
        /// </summary>
        [NameInMap("eventDetail")]
        [Validation(Required=false)]
        public string EventDetail { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("eventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The state of the event.</para>
        /// <list type="bullet">
        /// <item><description>Enqueued: The asynchronous invocation is enqueued and is waiting to be executed.</description></item>
        /// <item><description>Succeeded: The invocation is successful.</description></item>
        /// <item><description>Failed: The invocation fails.</description></item>
        /// <item><description>Running: The invocation is being executed.</description></item>
        /// <item><description>Stopped: The invocation is terminated.</description></item>
        /// <item><description>Stopping: The invocation is being terminated.</description></item>
        /// <item><description>Invalid: The invocation is invalid and not executed due to specific reasons. For example, the function is deleted.</description></item>
        /// <item><description>Expired: The maximum validity period of messages is specified for asynchronous invocation. The invocation is discarded and not executed because the specified maximum validity period of has elapsed.</description></item>
        /// <item><description>Retrying: The asynchronous invocation is being retried due to an execution error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The timestamp when the event occurred. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1647420449721</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
