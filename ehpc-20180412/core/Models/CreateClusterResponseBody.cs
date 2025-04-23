// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class CreateClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6757FA4-8FED-4602-B7F5-3550C084****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <remarks>
        /// <para> CreateCluster is an asynchronous operation. A response is returned if the request succeeds. However, this does not mean that a cluster is created. You can call the <a href="https://help.aliyun.com/document_detail/268225.html">ListTasks</a> operation to query the result of the task.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>F6757FA4-8FED-4602-B7F5-3550C084****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
