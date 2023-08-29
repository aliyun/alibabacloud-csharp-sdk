// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class Table : TeaModel {
        [NameInMap("Cascade")]
        [Validation(Required=false)]
        public bool? Cascade { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("LastAccessTime")]
        [Validation(Required=false)]
        public int? LastAccessTime { get; set; }

        [NameInMap("LastAnalyzedTime")]
        [Validation(Required=false)]
        public int? LastAnalyzedTime { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        [NameInMap("PartitionKeys")]
        [Validation(Required=false)]
        public List<FieldSchema> PartitionKeys { get; set; }

        [NameInMap("Privileges")]
        [Validation(Required=false)]
        public PrincipalPrivilegeSet Privileges { get; set; }

        [NameInMap("Retention")]
        [Validation(Required=false)]
        public int? Retention { get; set; }

        [NameInMap("RewriteEnabled")]
        [Validation(Required=false)]
        public bool? RewriteEnabled { get; set; }

        [NameInMap("Sd")]
        [Validation(Required=false)]
        public StorageDescriptor Sd { get; set; }

        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        [NameInMap("TableVersion")]
        [Validation(Required=false)]
        public TableVersion TableVersion { get; set; }

        [NameInMap("Temporary")]
        [Validation(Required=false)]
        public bool? Temporary { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public int? UpdateTime { get; set; }

        [NameInMap("ViewExpandedText")]
        [Validation(Required=false)]
        public string ViewExpandedText { get; set; }

        [NameInMap("ViewOriginalText")]
        [Validation(Required=false)]
        public string ViewOriginalText { get; set; }

    }

}
