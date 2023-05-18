// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetPhysicalDatabaseResponseBody : TeaModel {
        [NameInMap("Database")]
        [Validation(Required=false)]
        public GetPhysicalDatabaseResponseBodyDatabase Database { get; set; }
        public class GetPhysicalDatabaseResponseBodyDatabase : TeaModel {
            [NameInMap("CatalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            [NameInMap("DbaId")]
            [Validation(Required=false)]
            public string DbaId { get; set; }

            [NameInMap("DbaName")]
            [Validation(Required=false)]
            public string DbaName { get; set; }

            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OwnerIdList")]
            [Validation(Required=false)]
            public GetPhysicalDatabaseResponseBodyDatabaseOwnerIdList OwnerIdList { get; set; }
            public class GetPhysicalDatabaseResponseBodyDatabaseOwnerIdList : TeaModel {
                [NameInMap("OwnerIds")]
                [Validation(Required=false)]
                public List<string> OwnerIds { get; set; }

            }

            [NameInMap("OwnerNameList")]
            [Validation(Required=false)]
            public GetPhysicalDatabaseResponseBodyDatabaseOwnerNameList OwnerNameList { get; set; }
            public class GetPhysicalDatabaseResponseBodyDatabaseOwnerNameList : TeaModel {
                [NameInMap("OwnerNames")]
                [Validation(Required=false)]
                public List<string> OwnerNames { get; set; }

            }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            [NameInMap("Sid")]
            [Validation(Required=false)]
            public string Sid { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
