// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ColumnMetadata : TeaModel {
        [NameInMap("ColumnDefault")]
        [Validation(Required=false)]
        public string ColumnDefault { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("IsCaseSensitive")]
        [Validation(Required=false)]
        public bool? IsCaseSensitive { get; set; }

        [NameInMap("IsCurrency")]
        [Validation(Required=false)]
        public bool? IsCurrency { get; set; }

        [NameInMap("IsPrimaryKey")]
        [Validation(Required=false)]
        public bool? IsPrimaryKey { get; set; }

        [NameInMap("IsSigned")]
        [Validation(Required=false)]
        public bool? IsSigned { get; set; }

        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public int? MaxLength { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

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

        [NameInMap("UdtName")]
        [Validation(Required=false)]
        public string UdtName { get; set; }

    }

}
