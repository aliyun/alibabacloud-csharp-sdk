// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetWmExtractTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWmExtractTaskResponseBodyData Data { get; set; }
        public class GetWmExtractTaskResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Filename")]
            [Validation(Required=false)]
            public string Filename { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("WmInfoBytesB64")]
            [Validation(Required=false)]
            public string WmInfoBytesB64 { get; set; }

            [NameInMap("WmInfoSize")]
            [Validation(Required=false)]
            public long? WmInfoSize { get; set; }

            [NameInMap("WmInfoUint")]
            [Validation(Required=false)]
            public long? WmInfoUint { get; set; }

            [NameInMap("WmType")]
            [Validation(Required=false)]
            public string WmType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
