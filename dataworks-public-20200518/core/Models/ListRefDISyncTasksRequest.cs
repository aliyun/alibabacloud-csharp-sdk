// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRefDISyncTasksRequest : TeaModel {
        /// <summary>
        /// The name of the data source. You can call the [ListDataSources](~~211431~~) operation to query the name of the data source.
        /// </summary>
        [NameInMap("DatasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace Management page to obtain the workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The condition used to filter sync nodes. Valid values:
        /// 
        /// *   from: queries the sync nodes that use the data source as the source data source.
        /// *   to: queries the sync nodes that use the data source as the destination data source.
        /// </summary>
        [NameInMap("RefType")]
        [Validation(Required=false)]
        public string RefType { get; set; }

        /// <summary>
        /// The type of the sync node that you want to query. Valid values:
        /// 
        /// *   DI_OFFLINE: batch sync node
        /// *   DI_REALTIME: real-time sync node
        /// 
        /// You can specify only one type. The sync solution type is not supported.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
