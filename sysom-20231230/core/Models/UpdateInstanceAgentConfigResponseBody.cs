// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateInstanceAgentConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateInstanceAgentConfigResponseBodyData Data { get; set; }
        public class UpdateInstanceAgentConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task ID. You can use this task ID to call the GetAgentTask operation to check the task execution status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bbe94a98-4192-4172-b856-95777e0a55d7</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message. If <c>code == Success</c>, this field is empty. Otherwise, this field contains the error message of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analysis ID: 56dae746-ef55-4f77-8373-cb3594c41457
        /// Analysis failed for instance i-bp164ns76pzirbwv0snt. Cause: Not get GPU trace data for \&quot;56dae746-ef55-4f77-8373-cb3594c41457\&quot; \&quot;[\&quot;93811\&quot;]\&quot;!</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
