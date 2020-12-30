// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDatabasesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DatabaseList")]
        [Validation(Required=false)]
        public ListDatabasesResponseBodyDatabaseList DatabaseList { get; set; }
        public class ListDatabasesResponseBodyDatabaseList : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public List<ListDatabasesResponseBodyDatabaseListDatabase> Database { get; set; }
            public class ListDatabasesResponseBodyDatabaseListDatabase : TeaModel {
                public string DatabaseId { get; set; }
                public string Host { get; set; }
                public string CatalogName { get; set; }
                public string DbaName { get; set; }
                public string State { get; set; }
                public string DbaId { get; set; }
                public string SchemaName { get; set; }
                public string InstanceId { get; set; }
                public int? Port { get; set; }
                public string EnvType { get; set; }
                public string Sid { get; set; }
                public ListDatabasesResponseBodyDatabaseListDatabaseOwnerIdList OwnerIdList { get; set; }
                public class ListDatabasesResponseBodyDatabaseListDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }
                public string Encoding { get; set; }
                public string DbType { get; set; }
                public ListDatabasesResponseBodyDatabaseListDatabaseOwnerNameList OwnerNameList { get; set; }
                public class ListDatabasesResponseBodyDatabaseListDatabaseOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }
                public string SearchName { get; set; }
            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
