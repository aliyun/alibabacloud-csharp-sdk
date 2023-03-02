// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateMetaTableRequest : TeaModel {
        /// <summary>
        /// The names of the labels that you want to add. Separate the labels with commas (,).
        /// </summary>
        [NameInMap("AddedLabels")]
        [Validation(Required=false)]
        public string AddedLabels { get; set; }

        /// <summary>
        /// The display name of the table.
        /// </summary>
        [NameInMap("Caption")]
        [Validation(Required=false)]
        public string Caption { get; set; }

        /// <summary>
        /// The ID of the category that you want to associate.
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// The environment of the DataWorks workspace. Valid values: 0 and 1. The value 0 indicates the development environment. The value 1 indicates the production environment.
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        /// <summary>
        /// The ID of the new owner. If this parameter is not specified, the owner ID is not updated.
        /// </summary>
        [NameInMap("NewOwnerId")]
        [Validation(Required=false)]
        public string NewOwnerId { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The names of labels that you want to delete. Separate the labels with commas (,).
        /// </summary>
        [NameInMap("RemovedLabels")]
        [Validation(Required=false)]
        public string RemovedLabels { get; set; }

        /// <summary>
        /// The schema information of the table. You need to configure this parameter if you enable the table schema in MaxCompute.
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public string Schema { get; set; }

        /// <summary>
        /// The globally unique identifier (GUID) of the table. Specify the GUID in the format of odps.{projectName}.{tableName}.
        /// </summary>
        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The scope in which the table is visible. Valid values: 0, 1, and 2. The value 0 indicates that the table is invisible to all workspace members. The value 1 indicates that the table is visible to all workspace members. The value 2 indicates that the table is visible to workspace members.
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public int? Visibility { get; set; }

    }

}
