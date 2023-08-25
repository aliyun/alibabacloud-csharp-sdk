// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class FieldSchemaModel : TeaModel {
        [NameInMap("AutoIncrement")]
        [Validation(Required=false)]
        public bool? AutoIncrement { get; set; }

        [NameInMap("ColumnRawName")]
        [Validation(Required=false)]
        public string ColumnRawName { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("CompressFloatUseShort")]
        [Validation(Required=false)]
        public bool? CompressFloatUseShort { get; set; }

        [NameInMap("Compression")]
        [Validation(Required=false)]
        public string Compression { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("DefaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        [NameInMap("Delimiter")]
        [Validation(Required=false)]
        public string Delimiter { get; set; }

        [NameInMap("Encode")]
        [Validation(Required=false)]
        public string Encode { get; set; }

        [NameInMap("IsPartitionKey")]
        [Validation(Required=false)]
        public bool? IsPartitionKey { get; set; }

        [NameInMap("MappedName")]
        [Validation(Required=false)]
        public string MappedName { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

        [NameInMap("OnUpdate")]
        [Validation(Required=false)]
        public string OnUpdate { get; set; }

        [NameInMap("OrdinalPosition")]
        [Validation(Required=false)]
        public long? OrdinalPosition { get; set; }

        [NameInMap("PhysicalColumnName")]
        [Validation(Required=false)]
        public string PhysicalColumnName { get; set; }

        [NameInMap("PkPosition")]
        [Validation(Required=false)]
        public long? PkPosition { get; set; }

        [NameInMap("Precision")]
        [Validation(Required=false)]
        public long? Precision { get; set; }

        [NameInMap("Primarykey")]
        [Validation(Required=false)]
        public bool? Primarykey { get; set; }

        [NameInMap("Scale")]
        [Validation(Required=false)]
        public long? Scale { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("Tokenizer")]
        [Validation(Required=false)]
        public string Tokenizer { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("ValueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

    }

}
