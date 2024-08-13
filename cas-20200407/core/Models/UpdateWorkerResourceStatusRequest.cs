// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UpdateWorkerResourceStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the deployment task. You can call the [CreateDeploymentJob](https://help.aliyun.com/document_detail/2712234.html) operation to obtain the ID of a deployment task from the **JobId** parameter. You can also call the [ListDeploymentJob](https://help.aliyun.com/document_detail/2712223.html) operation to obtain the ID of a deployment task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// The desired status.
        /// 
        /// Valid values:
        /// 
        /// *   rollback
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The ID of the worker task. You can call the [ListWorkerResource](https://help.aliyun.com/document_detail/2712224.html) operation to obtain the ID of a worker task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkerId")]
        [Validation(Required=false)]
        public long? WorkerId { get; set; }

    }

}
