// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class SearchRDSTablesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public List<SearchRDSTablesResponseBodySchemas> Schemas { get; set; }
        public class SearchRDSTablesResponseBodySchemas : TeaModel {
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<string> Tables { get; set; }

        }

    }

}
