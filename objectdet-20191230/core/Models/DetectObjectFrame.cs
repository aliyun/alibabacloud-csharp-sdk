// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectObjectFrame : TeaModel {
        [NameInMap("Elements")]
        [Validation(Required=false)]
        public List<DetectObjectElement> Elements { get; set; }

        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

    }

}
