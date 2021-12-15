// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DumpMetaResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DumpMetaResponseBodyData Data { get; set; }
        public class DumpMetaResponseBodyData : TeaModel {
            [NameInMap("DumpMetaStatus")]
            [Validation(Required=false)]
            public string DumpMetaStatus { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
