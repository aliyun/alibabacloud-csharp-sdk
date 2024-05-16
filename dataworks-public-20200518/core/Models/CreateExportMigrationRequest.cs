// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateExportMigrationRequest : TeaModel {
        /// <summary>
        /// The description of the export task.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The export mode of the export task. Valid values:
        /// 
        /// *   FULL: The export task is used to export all data objects.
        /// *   INCREMENTAL: The export task is used to export data objects that were modified since the specified point in time. If you set this parameter to INCREMENTAL, you must configure the IncrementalSince parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExportMode")]
        [Validation(Required=false)]
        public string ExportMode { get; set; }

        /// <summary>
        /// The status of the data objects that you want to export in the export task. The system exports data objects in the state that is specified by this parameter. Valid values:
        /// 
        /// *   SAVED: Data objects that are in the SAVED state are exported.
        /// *   SUBMITTED: Data objects that are in the SUBMITTED state are exported.
        /// *   DEPLOYED: Data objects that are in the DEPLOYED state are exported.
        /// </summary>
        [NameInMap("ExportObjectStatus")]
        [Validation(Required=false)]
        public string ExportObjectStatus { get; set; }

        /// <summary>
        /// The start time of the incremental export task.
        /// 
        /// The IncrementalSince parameter takes effect only when the ExportMode parameter is set to INCREMENTAL.
        /// </summary>
        [NameInMap("IncrementalSince")]
        [Validation(Required=false)]
        public long? IncrementalSince { get; set; }

        /// <summary>
        /// The name of the export task.
        /// 
        /// The name of each export task must be unique. You must ensure that no duplicate export task exists in the current workspace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the workspace. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace Management page to obtain the workspace ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
