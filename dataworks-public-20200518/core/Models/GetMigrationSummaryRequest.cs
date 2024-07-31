// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMigrationSummaryRequest : TeaModel {
        /// <summary>
        /// The migration task ID.
        /// 
        /// You can call the [CreateImportMigration](https://help.aliyun.com/document_detail/2809123.html) operation to obtain the ID of the import task and call the [CreateExportMigration](https://help.aliyun.com/document_detail/3241603.html) operation to obtain the ID of the export task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MigrationId")]
        [Validation(Required=false)]
        public long? MigrationId { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Workspace page to obtain the workspace ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
