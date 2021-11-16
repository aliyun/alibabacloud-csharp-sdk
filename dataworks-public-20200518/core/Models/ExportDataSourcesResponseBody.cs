// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ExportDataSourcesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExportDataSourcesResponseBodyData Data { get; set; }
        public class ExportDataSourcesResponseBodyData : TeaModel {
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<ExportDataSourcesResponseBodyDataDataSources> DataSources { get; set; }
            public class ExportDataSourcesResponseBodyDataDataSources : TeaModel {
                public int? BindingCalcEngineId { get; set; }
                public int? ConnectStatus { get; set; }
                public string Content { get; set; }
                public string DataSourceType { get; set; }
                public bool? DefaultEngine { get; set; }
                public string Description { get; set; }
                public int? EnvType { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public int? Id { get; set; }
                public string Name { get; set; }
                public string Operator { get; set; }
                public int? ProjectId { get; set; }
                public int? Sequence { get; set; }
                public bool? Shared { get; set; }
                public int? Status { get; set; }
                public string SubType { get; set; }
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
            public int? TotalCount { get; set; }
        };

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
