// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeDriverVersionResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryEdgeDriverVersionResponseData Data { get; set; }
        public class QueryEdgeDriverVersionResponseData : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }
            [NameInMap("DriverVersionList")]
            [Validation(Required=true)]
            public List<QueryEdgeDriverVersionResponseDataDriverVersionList> DriverVersionList { get; set; }
            public class QueryEdgeDriverVersionResponseDataDriverVersionList : TeaModel {
                public string DriverId { get; set; }
                public string DriverVersion { get; set; }
                public string VersionState { get; set; }
                public string EdgeVersion { get; set; }
                public string Description { get; set; }
                public string SourceConfig { get; set; }
                public string DriverConfig { get; set; }
                public string ContainerConfig { get; set; }
                public string ConfigCheckRule { get; set; }
                public long? GmtCreateTimestamp { get; set; }
                public long? GmtModifiedTimestamp { get; set; }
                public string Argument { get; set; }
            }
        };

    }

}
