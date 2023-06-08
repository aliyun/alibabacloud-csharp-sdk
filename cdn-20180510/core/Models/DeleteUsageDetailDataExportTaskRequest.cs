// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DeleteUsageDetailDataExportTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the task. You can call the [DescribeUserUsageDataExportTask](~~91062~~) operation to query tasks.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
