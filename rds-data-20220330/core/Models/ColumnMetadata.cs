// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds_data20220330.Models
{
    public class ColumnMetadata : TeaModel {
        [NameInMap("ArrayBaseColumnType")]
        [Validation(Required=false)]
        public int? ArrayBaseColumnType { get; set; }

        [NameInMap("IsAutoIncrement")]
        [Validation(Required=false)]
        public bool? IsAutoIncrement { get; set; }

        [NameInMap("IsCaseSensitive")]
        [Validation(Required=false)]
        public bool? IsCaseSensitive { get; set; }

        [NameInMap("IsCurrency")]
        [Validation(Required=false)]
        public bool? IsCurrency { get; set; }

        [NameInMap("IsSigned")]
        [Validation(Required=false)]
        public bool? IsSigned { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public int? Nullable { get; set; }

        [NameInMap("Precision")]
        [Validation(Required=false)]
        public int? Precision { get; set; }

        [NameInMap("Scale")]
        [Validation(Required=false)]
        public int? Scale { get; set; }

        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

    }

}
