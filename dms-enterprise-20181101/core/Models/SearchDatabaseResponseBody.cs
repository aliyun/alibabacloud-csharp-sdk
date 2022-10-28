// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDatabaseResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SearchDatabaseList")]
        [Validation(Required=false)]
        public SearchDatabaseResponseBodySearchDatabaseList SearchDatabaseList { get; set; }
        public class SearchDatabaseResponseBodySearchDatabaseList : TeaModel {
            [NameInMap("SearchDatabase")]
            [Validation(Required=false)]
            public List<SearchDatabaseResponseBodySearchDatabaseListSearchDatabase> SearchDatabase { get; set; }
            public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabase : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                [NameInMap("DatalinkName")]
                [Validation(Required=false)]
                public string DatalinkName { get; set; }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("DbaId")]
                [Validation(Required=false)]
                public string DbaId { get; set; }

                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerIdList OwnerIdList { get; set; }
                public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerNameList OwnerNameList { get; set; }
                public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerNameList : TeaModel {
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

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
