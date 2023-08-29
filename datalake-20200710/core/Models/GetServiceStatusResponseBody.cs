// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class GetServiceStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceStatusResponseBodyData Data { get; set; }
        public class GetServiceStatusResponseBodyData : TeaModel {
            [NameInMap("HasRamPermissions")]
            [Validation(Required=false)]
            public bool? HasRamPermissions { get; set; }

            [NameInMap("IsDlfServiceOpen")]
            [Validation(Required=false)]
            public bool? IsDlfServiceOpen { get; set; }

            [NameInMap("IsOssOpen")]
            [Validation(Required=false)]
            public bool? IsOssOpen { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
