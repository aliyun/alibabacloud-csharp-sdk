// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ExportConnectionsResponse : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=true)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ExportConnectionsResponseData Data { get; set; }
        public class ExportConnectionsResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("DataSources")]
            [Validation(Required=true)]
            public List<ExportConnectionsResponseDataDataSources> DataSources { get; set; }
            public class ExportConnectionsResponseDataDataSources : TeaModel {
                public bool? Shared { get; set; }
                public string GmtModified { get; set; }
                public int? ConnectStatus { get; set; }
                public int? BindingCalcEngineId { get; set; }
                public string Description { get; set; }
                public string DataSourceType { get; set; }
                public string GmtCreate { get; set; }
                public bool? DefaultEngine { get; set; }
                public string Operator { get; set; }
                public int? Sequence { get; set; }
                public int? EnvType { get; set; }
                public long? TenantId { get; set; }
                public string Name { get; set; }
                public string SubType { get; set; }
                public int? Id { get; set; }
                public int? ProjectId { get; set; }
                public int? Status { get; set; }
                public string Content { get; set; }
            }
        };

    }

}
