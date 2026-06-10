// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpgradeAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID, which can be used for end-to-end Diagnosis</para>
        /// 
        /// <b>Example:</b>
        /// <para>B149FD9C-ED5C-5765-B3AD-05AA4A4D64D7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Status code  </para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, authorization Succeeded.  </description></item>
        /// <item><description>Other status codes indicate Failed to Authorize. When authorization fails, view the <c>message</c> field to obtain the detailed error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned Data</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpgradeAgentResponseBodyData Data { get; set; }
        public class UpgradeAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>391f5aeba2054f66b3aaef0136142fe2</para>
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
        /// <para>SysomOpenAPIException: SysomOpenAPI.InvalidParameter Invalid params, should be json string or dict</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
