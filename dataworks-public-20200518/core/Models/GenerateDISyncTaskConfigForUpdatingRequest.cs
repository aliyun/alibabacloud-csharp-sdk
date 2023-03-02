// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GenerateDISyncTaskConfigForUpdatingRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. This parameter is used to prevent repeated operations that are caused by multiple calls.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace Management page to obtain the workspace ID.
        /// 
        /// This parameter specifies the DataWorks workspace to which the operation is applied.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The ID of the real-time synchronization node or synchronization solution.
        /// 
        /// *   If you set the TaskType parameter to DI_REALTIME, set the TaskId parameter to the value of the FileId parameter for the real-time synchronization node.
        /// *   If you set the TaskType parameter to DI_SOLUTION, set the TaskId parameter to the value of the FileId parameter for the synchronization solution.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// The script for updating the real-time synchronization node or synchronization solution in Data Integration.
        /// 
        /// DataWorks allows you to add or remove tables for a real-time synchronization node or a synchronization solution in Data Integration only in asynchronous mode. The following types of real-time synchronization nodes and synchronization solutions are supported:
        /// 
        /// *   Real-time synchronization node or synchronization solution that is used to synchronize data from MySQL to MaxCompute
        /// *   Real-time synchronization node or synchronization solution that is used to synchronize data from MySQL data to Kafka
        /// *   Real-time synchronization node or synchronization solution that is used to synchronize data from MySQL to Hologres
        /// 
        /// The SelectedTables parameter is used to specify tables that you want to synchronize from multiple databases. The Tables parameter is used to specify tables that you want to synchronize from a single database.
        /// 
        /// *   If the script contains the SelectedTables parameter, the system synchronizes the tables that you specify in the SelectedTables parameter.
        /// *   If the script contains the Tables parameter, the system synchronizes the tables that you specify in the Tables parameter.
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// The type of the object that you want to update in Data Integration in asynchronous mode. Valid values:
        /// 
        /// *   DI_REALTIME: real-time synchronization node
        /// 
        /// *   DI_SOLUTION: synchronization solution
        /// 
        ///     DataWorks allows you to update real-time synchronization nodes and synchronization solutions in Data Integration only in asynchronous mode.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
