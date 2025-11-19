// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class SandboxHealthCheckResult : TeaModel {
        /// <summary>
        /// <para>SUCCESS 为成功</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public SandboxHealthCheckOut Data { get; set; }

        /// <summary>
        /// <para>唯一的请求标识符，用于问题追踪</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
