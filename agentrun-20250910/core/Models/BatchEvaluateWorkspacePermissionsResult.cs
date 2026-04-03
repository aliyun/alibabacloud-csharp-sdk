// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class BatchEvaluateWorkspacePermissionsResult : TeaModel {
        /// <summary>
        /// <para>OK 表示成功</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchEvaluateWorkspacePermissionsOutput Data { get; set; }

        /// <summary>
        /// <para>与响应头 x-funagent-request-id 对应</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
