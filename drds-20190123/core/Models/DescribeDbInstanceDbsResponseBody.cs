// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDbInstanceDbsResponseBody : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeDbInstanceDbsResponseBodyDatabases Databases { get; set; }
        public class DescribeDbInstanceDbsResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeDbInstanceDbsResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeDbInstanceDbsResponseBodyDatabasesDatabase : TeaModel {
                public int? Status { get; set; }
                public string DbName { get; set; }
                public string Description { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
