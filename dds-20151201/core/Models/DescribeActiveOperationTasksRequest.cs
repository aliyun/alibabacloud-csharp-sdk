// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// Specifies whether the task can be canceled.
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public int? AllowCancel { get; set; }

        /// <summary>
        /// Specifies whether the time can be changed. Valid values: -**0**: The time cannot be changed. **1**: The time can be changed.
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public int? AllowChange { get; set; }

        /// <summary>
        /// The change type.
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// The type of the database engine.
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("InsName")]
        [Validation(Required=false)]
        public string InsName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return per page. Valid values: **30, 50, and 100**. Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the service.
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// The region of the instance.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies the status of the task. Valid values: **0**: The task is waiting to be run. **1**: The task is running. **2**: The task is run. **3**: The task failed to be run.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The task type.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
