// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeDriverVersionResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryEdgeDriverVersionResponseData Data { get; set; }
        public class QueryEdgeDriverVersionResponseData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("DriverVersionList")]
            [Validation(Required=true)]
            public List<QueryEdgeDriverVersionResponseDataDriverVersionList> DriverVersionList { get; set; }
            public class QueryEdgeDriverVersionResponseDataDriverVersionList : TeaModel {
                [NameInMap("Argument")]
                [Validation(Required=true)]
                public string Argument { get; set; }

                [NameInMap("ConfigCheckRule")]
                [Validation(Required=true)]
                public string ConfigCheckRule { get; set; }

                [NameInMap("ContainerConfig")]
                [Validation(Required=true)]
                public string ContainerConfig { get; set; }

                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("DriverConfig")]
                [Validation(Required=true)]
                public string DriverConfig { get; set; }

                [NameInMap("DriverId")]
                [Validation(Required=true)]
                public string DriverId { get; set; }

                [NameInMap("DriverVersion")]
                [Validation(Required=true)]
                public string DriverVersion { get; set; }

                [NameInMap("EdgeVersion")]
                [Validation(Required=true)]
                public string EdgeVersion { get; set; }

                [NameInMap("GmtCreateTimestamp")]
                [Validation(Required=true)]
                public long? GmtCreateTimestamp { get; set; }

                [NameInMap("GmtModifiedTimestamp")]
                [Validation(Required=true)]
                public long? GmtModifiedTimestamp { get; set; }

                [NameInMap("SourceConfig")]
                [Validation(Required=true)]
                public string SourceConfig { get; set; }

                [NameInMap("VersionState")]
                [Validation(Required=true)]
                public string VersionState { get; set; }

            }

        }

    }

}
