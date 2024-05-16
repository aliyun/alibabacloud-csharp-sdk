// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDISyncTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the sync node to be updated. You can call the [ListFiles](https://help.aliyun.com/document_detail/173942.html) operation to query the ID of the node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace Management page to obtain the workspace ID.
        /// 
        /// You must set this parameter to specify the DataWorks workspace in which the node resides.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The updated configuration of the sync node. This operation is equivalent to node update by using the code editor in the DataWorks console. For more information, see [Create a sync node by using the code editor](https://help.aliyun.com/document_detail/137717.html). You can call the UpdateDISyncTask operation to update only batch sync nodes. If you do not need to update the configuration of the sync node, leave this parameter empty.
        /// </summary>
        [NameInMap("TaskContent")]
        [Validation(Required=false)]
        public string TaskContent { get; set; }

        /// <summary>
        /// The setting that updates the resource group used by the node. The value must be in the JSON format.
        /// 
        /// Only the ResourceGroup field is supported. This field specifies the identifier of the resource group for Data Integration that is used by the node. To query the identifier of the resource group, call the [ListResourceGroup](https://help.aliyun.com/document_detail/62055.html) operation.
        /// 
        /// If you do not need to update the resource group for the sync node, leave this parameter empty.
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// The type of the sync node.
        /// 
        /// You can call the UpdateDISyncTask operation to update only batch sync nodes. The value must be DI_OFFLINE.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
