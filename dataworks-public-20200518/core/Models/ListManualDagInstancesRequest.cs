// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListManualDagInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the directed acyclic graph (DAG) for the manually triggered workflow. You can call the [RunManualDagNodes](https://help.aliyun.com/document_detail/212830.html) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public string DagId { get; set; }

        /// <summary>
        /// The environment of Operation Center. Valid values: PROD and DEV.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// The name of the workspace to which the manually triggered workflow belongs. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
