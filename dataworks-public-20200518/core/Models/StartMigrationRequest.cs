// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StartMigrationRequest : TeaModel {
        /// <summary>
        /// The ID of the migration package. You can call the [CreateImportMigration](https://help.aliyun.com/document_detail/206094.html) operation to obtain the ID of the import package and call the [CreateExportMigration](https://help.aliyun.com/document_detail/349325.html) operation to obtain the ID of the export package.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MigrationId")]
        [Validation(Required=false)]
        public long? MigrationId { get; set; }

        /// <summary>
        /// The ID of the workspace. You can go to the Workspace Management page of the DataWorks console to view the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
