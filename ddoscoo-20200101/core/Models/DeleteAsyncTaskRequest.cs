// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DeleteAsyncTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the task that you want to delete.
        /// 
        /// > You can call the [DescribeAsyncTasks](~~159405~~) operation to query the IDs of all asynchronous export tasks.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public int? TaskId { get; set; }

    }

}
