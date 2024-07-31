// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncTaskRequest : TeaModel {
        /// <summary>
        /// *   If you set TaskType to DI_REALTIME, set this parameter to the ID of the real-time synchronization task that you want to deploy.
        /// *   If you set TaskType to DI_SOLUTION, set this parameter to the ID of the data synchronization solution that you want to deploy.
        /// 
        /// You can call the [ListFiles](https://help.aliyun.com/document_detail/173942.html) operation to query the ID of the real-time synchronization task or data synchronization solution.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the workspace ID.
        /// 
        /// You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The type of the object that you want to query. Valid values:
        /// 
        /// *   DI_REALTIME: real-time synchronization task
        /// *   DI_SOLUTION: data synchronization solution
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
