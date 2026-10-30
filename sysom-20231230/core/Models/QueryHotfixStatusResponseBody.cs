// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class QueryHotfixStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, the authorization is successful.</description></item>
        /// <item><description>Other status codes indicate that the authorization failed. If the authorization failed, check the <c>message</c> field for the detailed fault message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryHotfixStatusResponseBodyData Data { get; set; }
        public class QueryHotfixStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asynchronous task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hotfix-da3dcc0b-5019-4b59-b12f-2e500da9083c</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If code is Success, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
