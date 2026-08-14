// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class InstallAgentWithTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><c>code == Success</c> indicates that the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate that the authorization failed. Check the <c>message</c> field for the detailed fault information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public InstallAgentWithTypeResponseBodyData Data { get; set; }
        public class InstallAgentWithTypeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task ID.</para>
            /// <para>You can use this task ID to call the GetAgentTask operation to check the task execution status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26b3cd97389c43dcad6bc4901c36fcec</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used for end-to-end diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D8887FC-4BDB-5A1C-AB19-135C29A9E481</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
