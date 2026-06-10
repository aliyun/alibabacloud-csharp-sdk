// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InstallAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D8887FC-4BDB-5A1C-AB19-135C29A9E481</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that authorization succeeded.  </description></item>
        /// <item><description>Any other status code indicates that authorization failed. If authorization fails, view the <c>message</c> field to obtain detailed error information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public InstallAgentResponseBodyData Data { get; set; }
        public class InstallAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Job ID.  </para>
            /// <para>You can use this job ID to invoke the GetAgentTask API to view the job execution status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26b3cd97389c43dcad6bc4901c36fcec</para>
            /// </summary>
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>Error message  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.  </description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
