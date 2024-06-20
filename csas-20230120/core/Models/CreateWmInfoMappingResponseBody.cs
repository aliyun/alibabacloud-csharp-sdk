// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmInfoMappingResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWmInfoMappingResponseBodyData Data { get; set; }
        public class CreateWmInfoMappingResponseBodyData : TeaModel {
            [NameInMap("WmInfoUint")]
            [Validation(Required=false)]
            public long? WmInfoUint { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
