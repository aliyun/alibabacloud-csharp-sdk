// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListTableMetasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TableMetas")]
        [Validation(Required=false)]
        public List<ListTableMetasResponseBodyTableMetas> TableMetas { get; set; }
        public class ListTableMetasResponseBodyTableMetas : TeaModel {
            [NameInMap("CanDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<ListTableMetasResponseBodyTableMetasFields> Fields { get; set; }
            public class ListTableMetasResponseBodyTableMetasFields : TeaModel {
                [NameInMap("IsDimensionField")]
                [Validation(Required=false)]
                public bool? IsDimensionField { get; set; }

                [NameInMap("Meaning")]
                [Validation(Required=false)]
                public string Meaning { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtImportedTime")]
            [Validation(Required=false)]
            public string GmtImportedTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("Module")]
            [Validation(Required=false)]
            public string Module { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("TableMetaId")]
            [Validation(Required=false)]
            public string TableMetaId { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
