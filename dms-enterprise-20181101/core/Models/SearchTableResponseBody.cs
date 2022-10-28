// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class SearchTableResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SearchTableList")]
        [Validation(Required=false)]
        public SearchTableResponseBodySearchTableList SearchTableList { get; set; }
        public class SearchTableResponseBodySearchTableList : TeaModel {
            [NameInMap("SearchTable")]
            [Validation(Required=false)]
            public List<SearchTableResponseBodySearchTableListSearchTable> SearchTable { get; set; }
            public class SearchTableResponseBodySearchTableListSearchTable : TeaModel {
                [NameInMap("DBSearchName")]
                [Validation(Required=false)]
                public string DBSearchName { get; set; }

                [NameInMap("DatabaseId")]
                [Validation(Required=false)]
                public string DatabaseId { get; set; }

                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Encoding")]
                [Validation(Required=false)]
                public string Encoding { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                [NameInMap("OwnerIdList")]
                [Validation(Required=false)]
                public SearchTableResponseBodySearchTableListSearchTableOwnerIdList OwnerIdList { get; set; }
                public class SearchTableResponseBodySearchTableListSearchTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }

                [NameInMap("OwnerNameList")]
                [Validation(Required=false)]
                public SearchTableResponseBodySearchTableListSearchTableOwnerNameList OwnerNameList { get; set; }
                public class SearchTableResponseBodySearchTableListSearchTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }

                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TableSchemaName")]
                [Validation(Required=false)]
                public string TableSchemaName { get; set; }

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
