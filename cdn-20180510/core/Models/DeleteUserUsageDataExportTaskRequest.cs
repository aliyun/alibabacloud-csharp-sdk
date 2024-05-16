// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DeleteUserUsageDataExportTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the task to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
