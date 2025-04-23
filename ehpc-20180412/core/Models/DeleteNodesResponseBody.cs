// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// <list type="bullet">
        /// <item><description>If you set the Sync parameter to true, the DeleteNodes operation is synchronous. Valid value: Not Available.</description></item>
        /// <item><description>If you set the Sync parameter to false, the DeleteNodes operation is asynchronous. You can call the <a href="https://help.aliyun.com/document_detail/268225.html">ListTasks</a> operation to query the result of the task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
