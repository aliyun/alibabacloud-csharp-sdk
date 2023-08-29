// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class SearchResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DatabaseResult")]
        [Validation(Required=false)]
        public SearchResponseBodyDatabaseResult DatabaseResult { get; set; }
        public class SearchResponseBodyDatabaseResult : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<SearchResponseBodyDatabaseResultDatabases> Databases { get; set; }
            public class SearchResponseBodyDatabaseResultDatabases : TeaModel {
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
        public SearchResponseBodyTableResult TableResult { get; set; }
        public class SearchResponseBodyTableResult : TeaModel {
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<SearchResponseBodyTableResultTables> Tables { get; set; }
            public class SearchResponseBodyTableResultTables : TeaModel {
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
