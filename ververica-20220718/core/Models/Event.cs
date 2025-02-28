// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Event : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-000000680003</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("eventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>STATE_TRANSITION_IS_COMPLETED</para>
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00000000-0000-0000-0000-000000005043</para>
        /// </summary>
        [NameInMap("jobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default-namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>edcef******b4f</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
