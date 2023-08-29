// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class GetRegionStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRegionStatusResponseBodyData Data { get; set; }
        public class GetRegionStatusResponseBodyData : TeaModel {
            [NameInMap("AccountStatus")]
            [Validation(Required=false)]
            public string AccountStatus { get; set; }

            [NameInMap("IsDependencyReady")]
            [Validation(Required=false)]
            public bool? IsDependencyReady { get; set; }

            [NameInMap("IsDlfServiceOpen")]
            [Validation(Required=false)]
            public bool? IsDlfServiceOpen { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
