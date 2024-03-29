// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StartDISyncInstanceRequest : TeaModel {
        /// <summary>
        /// *   If you set the TaskType parameter to DI_REALTIME, the StartParam parameter specifies the startup parameters for the real-time synchronization node. The startup parameters include failover-related parameters, the parameter that specifies the number of dirty data records allowed, and the parameters in the data definition language (DDL) statements.
        /// *   If you set the TaskType parameter to DI_SOLUTION, the StartParam parameter does not take effect.
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// The type of the Data Integration object that you want to start. Valid values:
        /// 
        /// *   DI_REALTIME: real-time synchronization node
        /// *   DI_SOLUTION: data synchronization solution
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request succeeded.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("StartParam")]
        [Validation(Required=false)]
        public string StartParam { get; set; }

        /// <summary>
        /// *   If you set the TaskType parameter to DI_REALTIME, set the FileId parameter to the ID of the real-time synchronization node that you want to start.
        /// *   If you set the TaskType parameter to DI_SOLUTION, set the FileId parameter to the ID of the data synchronization solution that you want to start.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
