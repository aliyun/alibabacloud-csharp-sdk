// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Table : TeaModel {
        [NameInMap("Catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<TableColumns> Columns { get; set; }
        public class TableColumns : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RetentionPolicy")]
        [Validation(Required=false)]
        public TableRetentionPolicy RetentionPolicy { get; set; }
        public class TableRetentionPolicy : TeaModel {
            [NameInMap("ColdTTL")]
            [Validation(Required=false)]
            public int? ColdTTL { get; set; }

            [NameInMap("HotTTL")]
            [Validation(Required=false)]
            public int? HotTTL { get; set; }

        }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
