// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class StartMigrationRequest : TeaModel {
        /// <summary>
        /// <para>The migration package ID. You can call the <a href="https://help.aliyun.com/document_detail/206094.html">CreateImportMigration</a> operation to query the ID of the import package and call the <a href="https://help.aliyun.com/document_detail/349325.html">CreateExportMigration</a> operation to query the ID of the export package.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("MigrationId")]
        [Validation(Required=false)]
        public long? MigrationId { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can log on to the DataWorks console and go to the Workspace page to obtain the workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
