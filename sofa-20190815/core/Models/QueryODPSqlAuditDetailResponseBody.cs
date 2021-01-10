// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPSqlAuditDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryODPSqlAuditDetailResponseBodyData Data { get; set; }
        public class QueryODPSqlAuditDetailResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<QueryODPSqlAuditDetailResponseBodyDataContent> Content { get; set; }
            public class QueryODPSqlAuditDetailResponseBodyDataContent : TeaModel {
                public string PhysicalTableName { get; set; }
                public string Result { get; set; }
                public long? Row { get; set; }
                public string SchemaName { get; set; }
                public string Sql { get; set; }
                public string TableName { get; set; }
                public string Time { get; set; }
                public long? TotalTime { get; set; }
            }
        };

    }

}
