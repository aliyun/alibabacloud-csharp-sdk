// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class LookupWmInfoMappingResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public LookupWmInfoMappingResponseBodyData Data { get; set; }
        public class LookupWmInfoMappingResponseBodyData : TeaModel {
            [NameInMap("WmInfoBytesB64")]
            [Validation(Required=false)]
            public string WmInfoBytesB64 { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
