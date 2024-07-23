// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class RunCloudBenchTaskRequest : TeaModel {
        /// <summary>
        /// <para>The stress testing task ID. You can call the <a href="https://help.aliyun.com/document_detail/230670.html">DescribeCloudBenchTasks</a> operation to query the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e5cec704-0518-430f-8263-76f4dcds****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
