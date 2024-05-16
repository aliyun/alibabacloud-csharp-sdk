// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRefreshTaskByIdRequest : TeaModel {
        /// <summary>
        /// The ID of the task that you want to query.
        /// 
        /// You can call the [RefreshObjectCaches](https://help.aliyun.com/document_detail/91164.html) operation to query task IDs. Then, you can use the task IDs to query task status.
        /// 
        /// You can specify up to 10 task IDs. Separate task IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
