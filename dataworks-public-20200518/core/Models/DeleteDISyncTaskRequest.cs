// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteDISyncTaskRequest : TeaModel {
        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request is successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// The type of the synchronization node in Data Integration.
        /// 
        /// The parameter value is DI_REALTIME and cannot be changed. The value indicates a real-time synchronization node.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The ID of the real-time synchronization node. You can call the [ListFiles](~~173942~~) operation to query the ID of the node.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
