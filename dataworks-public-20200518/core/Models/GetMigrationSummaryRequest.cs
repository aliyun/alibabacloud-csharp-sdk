// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMigrationSummaryRequest : TeaModel {
        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MigrationId")]
        [Validation(Required=false)]
        public long? MigrationId { get; set; }

        /// <summary>
        /// The ID of the migration task.
        /// 
        /// You can call the [CreateImportMigration](https://help.aliyun.com/document_detail/2809123.html) operation to obtain the ID of the import task and call the [CreateExportMigration](https://help.aliyun.com/document_detail/3241603.html) operation to obtain the ID of the export task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
