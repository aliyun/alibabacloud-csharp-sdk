// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveColumnsDetailRequest : TeaModel {
        /// <summary>
        /// The details of the sensitive field.
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// The ID of the database.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        /// <summary>
        /// The name of the field.
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// The name of the table.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database. Valid values:
        /// 
        /// *   **true**: The database is a logical database.
        /// *   **false**: The database is a physical database.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
