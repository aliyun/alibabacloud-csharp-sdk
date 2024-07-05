// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SceneElement : TeaModel {
        [NameInMap("FrameTimes")]
        [Validation(Required=false)]
        public List<long?> FrameTimes { get; set; }

        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public List<long?> TimeRange { get; set; }

    }

}
