// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeDriverVersionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEdgeDriverVersionResponseBodyData Data { get; set; }
        public class QueryEdgeDriverVersionResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("DriverVersionList")]
            [Validation(Required=false)]
            public List<QueryEdgeDriverVersionResponseBodyDataDriverVersionList> DriverVersionList { get; set; }
            public class QueryEdgeDriverVersionResponseBodyDataDriverVersionList : TeaModel {
                public string Argument { get; set; }
                public string ConfigCheckRule { get; set; }
                public string ContainerConfig { get; set; }
                public string Description { get; set; }
                public string DriverConfig { get; set; }
                public string DriverId { get; set; }
                public string DriverVersion { get; set; }
                public string EdgeVersion { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public long? GmtModifiedTimestamp { get; set; }
                public string SourceConfig { get; set; }
                public string VersionState { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

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
