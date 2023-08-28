// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDataSourceSchemasResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDataSourceSchemasResponseBodyResult> Result { get; set; }
        public class ListDataSourceSchemasResponseBodyResult : TeaModel {
            [NameInMap("addIndex")]
            [Validation(Required=false)]
            public bool? AddIndex { get; set; }

            [NameInMap("attribute")]
            [Validation(Required=false)]
            public bool? Attribute { get; set; }

            [NameInMap("custom")]
            [Validation(Required=false)]
            public bool? Custom { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public ListDataSourceSchemasResponseBodyResultPrimaryKey PrimaryKey { get; set; }
            public class ListDataSourceSchemasResponseBodyResultPrimaryKey : TeaModel {
                [NameInMap("hasPrimaryKeyAttribute")]
                [Validation(Required=false)]
                public bool? HasPrimaryKeyAttribute { get; set; }

                [NameInMap("isPrimaryKey")]
                [Validation(Required=false)]
                public bool? IsPrimaryKey { get; set; }

                [NameInMap("isPrimaryKeySorted")]
                [Validation(Required=false)]
                public bool? IsPrimaryKeySorted { get; set; }

            }

            [NameInMap("summary")]
            [Validation(Required=false)]
            public bool? Summary { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
