// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDISyncTaskRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. This parameter can be left empty.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace Management page to obtain the workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The configuration of the synchronization node to be created. This operation is equivalent to node creation by using the code editor in the DataWorks console. For more information, see [Create a synchronization node by using the code editor](~~137717~~).
        /// 
        /// You can call the CreateDISyncTask operation to create only batch synchronization nodes.
        /// </summary>
        [NameInMap("TaskContent")]
        [Validation(Required=false)]
        public string TaskContent { get; set; }

        /// <summary>
        /// The name of the synchronization node.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The settings that specify the storage path of the synchronization node and the resource group used by the node. The following fields are supported:
        /// 
        /// *   FileFolderPath: the storage path of the node.
        /// *   ResourceGroup: the identifier of the resource group for Data Integration that is used by the node. To query the identifier of the resource group, call the [ListResourceGroup](~~173913~~) operation.
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// The type of the synchronization node.
        /// 
        /// You can call the CreateDISyncTask operation to create only batch synchronization nodes. Set the value to DI_OFFLINE.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
