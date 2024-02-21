// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class RunCloudBenchTaskRequest : TeaModel {
        /// <summary>
        /// The stress testing task ID. You can call the [DescribeCloudBenchTasks](~~230670~~) operation to query the task ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
