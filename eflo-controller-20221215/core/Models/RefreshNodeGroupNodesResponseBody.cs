// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class RefreshNodeGroupNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The task ID. Query the task progress by calling DescribeNodeGroupRefreshTask. If no nodes have configuration drift, no task is created and this field returns an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-159136551662516768776</para>
        /// </summary>
        [NameInMap("NodeGroupRefreshTaskId")]
        [Validation(Required=false)]
        public string NodeGroupRefreshTaskId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
