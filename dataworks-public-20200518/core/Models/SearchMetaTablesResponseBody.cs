// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SearchMetaTablesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchMetaTablesResponseBodyData Data { get; set; }
        public class SearchMetaTablesResponseBodyData : TeaModel {
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<SearchMetaTablesResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class SearchMetaTablesResponseBodyDataDataEntityList : TeaModel {
                public string ClusterId { get; set; }
                public string DatabaseName { get; set; }
                public int? EntityType { get; set; }
                public int? EnvType { get; set; }
                public string OwnerId { get; set; }
                public long? ProjectId { get; set; }
                public string ProjectName { get; set; }
                public string Schema { get; set; }
                public string TableGuid { get; set; }
                public string TableName { get; set; }
                public long? TenantId { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
