// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ModifyDesensitizationStrategyRequest : TeaModel {
        /// <summary>
        /// The ID of the masking rule.
        /// </summary>
        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ModifyDesensitizationStrategy**.
        /// </summary>
        [NameInMap("IsLogic")]
        [Validation(Required=false)]
        public bool? IsLogic { get; set; }

        /// <summary>
        /// The name of the table. You can call the [ListSensitiveColumns](~~188103~~) operation to query the table name.
        /// 
        /// >  You can also call the [ListTables](~~141878~~) operation to query the table name.
        /// </summary>
        [NameInMap("IsReset")]
        [Validation(Required=false)]
        public bool? IsReset { get; set; }

        /// <summary>
        /// The ID of the database. You can call the [ListDatabases](~~141873~~) operation to query the ID.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public int? RuleId { get; set; }

        /// <summary>
        /// The name of the field. You can call the [ListSensitiveColumns](~~188103~~) operation to query the field name.
        /// 
        /// >  You can also call the [ListColumns](~~141870~~) operation to query the field name.
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
