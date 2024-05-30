// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDISyncTaskRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. This parameter can be left empty
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the workspace ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The configurations of the batch synchronization task to be created. Calling this API operation to create a batch synchronization task is equivalent to creating a batch synchronization task by using the code editor in the DataWorks console. For more information, see [Create a synchronization node by using the code editor](https://help.aliyun.com/document_detail/137717.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskContent")]
        [Validation(Required=false)]
        public string TaskContent { get; set; }

        /// <summary>
        /// The name of the data synchronization task.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The settings that specify the storage path of the data synchronization task and the resource group used by the task. The following parameters are supported:
        /// - FileFolderPath: the storage path of the data synchronization task. 
        /// - ResourceGroup: the identifier of the resource group for Data Integration that is used by the data synchronization task. You can call the [ListResourceGroup](https://help.aliyun.com/document_detail/173913.html) operation to query the identifier of the resource group.
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// The type of the data synchronization task. 
        /// Valid values: DI_OFFLINE, DI_REALTIME, and DI_SOLUTION.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
