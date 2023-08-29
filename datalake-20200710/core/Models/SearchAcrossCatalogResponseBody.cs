// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class SearchAcrossCatalogResponseBody : TeaModel {
        [NameInMap("CatalogResult")]
        [Validation(Required=false)]
        public SearchAcrossCatalogResponseBodyCatalogResult CatalogResult { get; set; }
        public class SearchAcrossCatalogResponseBodyCatalogResult : TeaModel {
            [NameInMap("Catalogs")]
            [Validation(Required=false)]
            public List<SearchAcrossCatalogResponseBodyCatalogResultCatalogs> Catalogs { get; set; }
            public class SearchAcrossCatalogResponseBodyCatalogResultCatalogs : TeaModel {
                [NameInMap("Catalog")]
                [Validation(Required=false)]
                public Catalog Catalog { get; set; }

                [NameInMap("HighLightList")]
                [Validation(Required=false)]
                public List<HighLight> HighLightList { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DatabaseResult")]
        [Validation(Required=false)]
        public SearchAcrossCatalogResponseBodyDatabaseResult DatabaseResult { get; set; }
        public class SearchAcrossCatalogResponseBodyDatabaseResult : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<SearchAcrossCatalogResponseBodyDatabaseResultDatabases> Databases { get; set; }
            public class SearchAcrossCatalogResponseBodyDatabaseResultDatabases : TeaModel {
                [NameInMap("Database")]
                [Validation(Required=false)]
                public Database Database { get; set; }

                [NameInMap("HighLightList")]
                [Validation(Required=false)]
                public List<HighLight> HighLightList { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TableResult")]
        [Validation(Required=false)]
        public SearchAcrossCatalogResponseBodyTableResult TableResult { get; set; }
        public class SearchAcrossCatalogResponseBodyTableResult : TeaModel {
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<SearchAcrossCatalogResponseBodyTableResultTables> Tables { get; set; }
            public class SearchAcrossCatalogResponseBodyTableResultTables : TeaModel {
                [NameInMap("HighLightList")]
                [Validation(Required=false)]
                public List<HighLight> HighLightList { get; set; }

                [NameInMap("Table")]
                [Validation(Required=false)]
                public Table Table { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
