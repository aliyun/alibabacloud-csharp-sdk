// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TenantUsers")]
        [Validation(Required=false)]
        public List<DescribeTenantUsersResponseBodyTenantUsers> TenantUsers { get; set; }
        public class DescribeTenantUsersResponseBodyTenantUsers : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<DescribeTenantUsersResponseBodyTenantUsersDatabases> Databases { get; set; }
            public class DescribeTenantUsersResponseBodyTenantUsersDatabases : TeaModel {
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
