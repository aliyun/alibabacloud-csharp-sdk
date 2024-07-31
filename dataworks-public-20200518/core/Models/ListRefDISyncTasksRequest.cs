// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksRequest : TeaModel {
        /// <summary>
        /// The name of the data source. You can call the [ListDataSources](https://help.aliyun.com/document_detail/211431.html) operation to query the name of the data source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// The page number. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The condition used to filter synchronization tasks. Valid values:
        /// 
        /// *   from: queries the synchronization tasks that use the data source as the source.
        /// *   to: queries the synchronization tasks that use the data source as the destination.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RefType")]
        [Validation(Required=false)]
        public string RefType { get; set; }

        /// <summary>
        /// The type of the synchronization task that you want to query. Valid values:
        /// 
        /// *   DI_OFFLINE: batch synchronization task
        /// *   DI_REALTIME: real-time synchronization task
        /// 
        /// You can call the ListRefDISyncTasks operation to query only one type of the task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
