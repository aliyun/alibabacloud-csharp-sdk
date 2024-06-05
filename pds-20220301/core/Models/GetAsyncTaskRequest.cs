// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetAsyncTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the asynchronous task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("async_task_id")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

    }

}
