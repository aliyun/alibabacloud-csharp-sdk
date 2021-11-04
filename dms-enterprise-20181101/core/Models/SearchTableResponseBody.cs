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
                public string DBSearchName { get; set; }
                public string DatabaseId { get; set; }
                public string DbName { get; set; }
                public string DbType { get; set; }
                public string Description { get; set; }
                public string Encoding { get; set; }
                public string Engine { get; set; }
                public string EnvType { get; set; }
                public bool? Logic { get; set; }
                public SearchTableResponseBodySearchTableListSearchTableOwnerIdList OwnerIdList { get; set; }
                public class SearchTableResponseBodySearchTableListSearchTableOwnerIdList : TeaModel {
                    [NameInMap("OwnerIds")]
                    [Validation(Required=false)]
                    public List<string> OwnerIds { get; set; }

                }
                public SearchTableResponseBodySearchTableListSearchTableOwnerNameList OwnerNameList { get; set; }
                public class SearchTableResponseBodySearchTableListSearchTableOwnerNameList : TeaModel {
                    [NameInMap("OwnerNames")]
                    [Validation(Required=false)]
                    public List<string> OwnerNames { get; set; }

                }
                public string TableGuid { get; set; }
                public string TableId { get; set; }
                public string TableName { get; set; }
                public string TableSchemaName { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
