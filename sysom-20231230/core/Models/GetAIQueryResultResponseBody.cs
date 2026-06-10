// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAIQueryResultResponseBody : TeaModel {
        /// <summary>
        /// <para>error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return Result, with large Data Volume</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;task_id\&quot;: \&quot;y4ba8uRV\&quot;}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>分析ID: 56dae746-ef55-4f77-8373-cb3594c41457
        /// 机器i-bp164ns76pzirbwv0snt分析失败, 失败原因: Not get GPU trace data for \&quot;56dae746-ef55-4f77-8373-cb3594c41457\&quot; \&quot;[\&quot;93811\&quot;]\&quot;!</para>
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
