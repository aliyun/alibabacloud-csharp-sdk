// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMigrationsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMigrationsResponseBodyData Data { get; set; }
        public class ListMigrationsResponseBodyData : TeaModel {
            [NameInMap("Migrations")]
            [Validation(Required=false)]
            public List<ListMigrationsResponseBodyDataMigrations> Migrations { get; set; }
            public class ListMigrationsResponseBodyDataMigrations : TeaModel {
                public long? CreateTime { get; set; }
                public string CreateUser { get; set; }
                public string CreateUserName { get; set; }
                public string Description { get; set; }
                public string DownloadUrl { get; set; }
                public long? Id { get; set; }
                public string Message { get; set; }
                public string MigrationType { get; set; }
                public string Name { get; set; }
                public string PackageType { get; set; }
                public long? ProjectId { get; set; }
                public string Status { get; set; }
                public long? TenantId { get; set; }
                public long? UpdateTime { get; set; }
                public string UpdateUser { get; set; }
                public string UpdateUserName { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
