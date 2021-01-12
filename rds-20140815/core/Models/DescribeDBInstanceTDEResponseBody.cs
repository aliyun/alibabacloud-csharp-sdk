// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceTDEResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeDBInstanceTDEResponseBodyDatabases Databases { get; set; }
        public class DescribeDBInstanceTDEResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceTDEResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeDBInstanceTDEResponseBodyDatabasesDatabase : TeaModel {
                public string DBName { get; set; }
                public string TDEStatus { get; set; }
            }
        };

    }

}
