// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAgentTaskRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42172120177e4b3abd6fabb3a6b5e2dd</para>
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
