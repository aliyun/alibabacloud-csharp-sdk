// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopOversoldGroupResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDesktopOversoldGroupResponseBodyData Data { get; set; }
        public class ModifyDesktopOversoldGroupResponseBodyData : TeaModel {
            [NameInMap("OversoldGroupId")]
            [Validation(Required=false)]
            public string OversoldGroupId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
