// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CodeInterpreterSessionOut : TeaModel {
        /// <summary>
        /// <para>The Unique Identifier of the associated code interpreter</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("codeInterpreterId")]
        [Validation(Required=false)]
        public string CodeInterpreterId { get; set; }

        /// <summary>
        /// <para>The name of the code interpreter session</para>
        /// </summary>
        [NameInMap("codeInterpreterName")]
        [Validation(Required=false)]
        public string CodeInterpreterName { get; set; }

        /// <summary>
        /// <para>The creation time of the code interpreter session, in ISO 8601 format</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The last update time of the code interpreter session, in ISO 8601 format</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>The Unique Identifier of the code interpreter session</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The idle timeout duration of the code interpreter session, in seconds. After the instance receives no session requests, it enters an idle state, which is billed under the idle billing model. If the idle duration exceeds this timeout, the session automatically expires and can no longer be used.</para>
        /// </summary>
        [NameInMap("sessionIdleTimeoutSeconds")]
        [Validation(Required=false)]
        public int? SessionIdleTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The current status of the code interpreter session</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
