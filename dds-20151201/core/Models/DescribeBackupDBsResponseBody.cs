// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupDBsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Databases")]
        [Validation(Required=false)]
        public DescribeBackupDBsResponseBodyDatabases Databases { get; set; }
        public class DescribeBackupDBsResponseBodyDatabases : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<DescribeBackupDBsResponseBodyDatabasesDatabase> Database { get; set; }
            public class DescribeBackupDBsResponseBodyDatabasesDatabase : TeaModel {
                public string DBName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
