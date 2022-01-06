// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeDriverVersionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEdgeDriverVersionResponseBodyData Data { get; set; }
        public class GetEdgeDriverVersionResponseBodyData : TeaModel {
            [NameInMap("Argument")]
            [Validation(Required=false)]
            public string Argument { get; set; }
            [NameInMap("ConfigCheckRule")]
            [Validation(Required=false)]
            public string ConfigCheckRule { get; set; }
            [NameInMap("ContainerConfig")]
            [Validation(Required=false)]
            public string ContainerConfig { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DriverConfig")]
            [Validation(Required=false)]
            public string DriverConfig { get; set; }
            [NameInMap("DriverId")]
            [Validation(Required=false)]
            public string DriverId { get; set; }
            [NameInMap("DriverVersion")]
            [Validation(Required=false)]
            public string DriverVersion { get; set; }
            [NameInMap("EdgeVersion")]
            [Validation(Required=false)]
            public string EdgeVersion { get; set; }
            [NameInMap("GmtCreateTimestamp")]
            [Validation(Required=false)]
            public long? GmtCreateTimestamp { get; set; }
            [NameInMap("GmtModifiedTimestamp")]
            [Validation(Required=false)]
            public long? GmtModifiedTimestamp { get; set; }
            [NameInMap("SourceConfig")]
            [Validation(Required=false)]
            public string SourceConfig { get; set; }
            [NameInMap("VersionState")]
            [Validation(Required=false)]
            public string VersionState { get; set; }
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
