// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class Schema : TeaModel {
        [NameInMap("indexSortConfig")]
        [Validation(Required=false)]
        public List<SchemaIndexSortConfig> IndexSortConfig { get; set; }
        public class SchemaIndexSortConfig : TeaModel {
            [NameInMap("direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

        }

        [NameInMap("indexes")]
        [Validation(Required=false)]
        public SchemaIndexes Indexes { get; set; }
        public class SchemaIndexes : TeaModel {
            [NameInMap("filterFields")]
            [Validation(Required=false)]
            public List<string> FilterFields { get; set; }

            [NameInMap("searchFields")]
            [Validation(Required=false)]
            public Dictionary<string, SchemaIndexesSearchFieldsValue> SearchFields { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("routeField")]
        [Validation(Required=false)]
        public string RouteField { get; set; }

        [NameInMap("routeFieldValues")]
        [Validation(Required=false)]
        public List<string> RouteFieldValues { get; set; }

        [NameInMap("secondRouteField")]
        [Validation(Required=false)]
        public string SecondRouteField { get; set; }

        [NameInMap("tables")]
        [Validation(Required=false)]
        public Dictionary<string, SchemaTablesValue> Tables { get; set; }

        [NameInMap("ttlField")]
        [Validation(Required=false)]
        public SchemaTtlField TtlField { get; set; }
        public class SchemaTtlField : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

        }

    }

}
