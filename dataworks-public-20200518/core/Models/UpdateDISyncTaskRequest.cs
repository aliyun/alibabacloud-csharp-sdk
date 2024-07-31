// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDISyncTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the data synchronization task. You can call the [ListFiles](https://help.aliyun.com/document_detail/173942.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public long? FileId { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the workspace ID. You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The updated configurations of the data synchronization task. Calling this API operation to update a data synchronization task is equivalent to updating a data synchronization task by using the code editor in the DataWorks console. For more information, see [Create a synchronization task by using the code editor](https://help.aliyun.com/document_detail/137717.html). You can call the UpdateDISyncTask operation to update only batch synchronization tasks. If you do not need to update the configurations of the data synchronization task, leave this parameter empty.
        /// </summary>
        [NameInMap("TaskContent")]
        [Validation(Required=false)]
        public string TaskContent { get; set; }

        /// <summary>
        /// The setting based on which the resource group used by the data synchronization task is updated. You must configure this parameter in the JSON format.
        /// 
        /// Only the ResourceGroup field is supported. This field specifies the identifier of the resource group for Data Integration that is used by the data synchronization task. You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/173913.html) operation to query the identifier of the resource group. If you do not need to update the resource group for the data synchronization task, leave this parameter empty.
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// The type of the data synchronization task. Set the value to DI_OFFLINE. You can call the UpdateDISyncTask operation to update only batch synchronization tasks.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
