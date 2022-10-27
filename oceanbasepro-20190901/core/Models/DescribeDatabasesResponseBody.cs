// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<DescribeDatabasesResponseBodyDatabases> Databases { get; set; }
        public class DescribeDatabasesResponseBodyDatabases : TeaModel {
            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public double? DataSize { get; set; }

            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            [NameInMap("RequiredSize")]
            [Validation(Required=false)]
            public double? RequiredSize { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesTables> Tables { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesTables : TeaModel {
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesUsers> Users { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesUsers : TeaModel {
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
