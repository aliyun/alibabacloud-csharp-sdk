// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchDatabaseResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

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
                public string DatabaseId { get; set; }
                public string Host { get; set; }
                public string DbaId { get; set; }
                public string SchemaName { get; set; }
                public bool? Logic { get; set; }
                public string DatalinkName { get; set; }
                public int? Port { get; set; }
                public string EnvType { get; set; }
                public string Sid { get; set; }
                public SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerIdList OwnerIdList { get; set; }
                public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }
                public string Encoding { get; set; }
                public string DbType { get; set; }
                public SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerNameList OwnerNameList { get; set; }
                public class SearchDatabaseResponseBodySearchDatabaseListSearchDatabaseOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }
                public string SearchName { get; set; }
                public string Alias { get; set; }
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
