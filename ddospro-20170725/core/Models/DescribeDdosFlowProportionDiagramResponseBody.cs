// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeDdosFlowProportionDiagramResponseBody : TeaModel {
        [NameInMap("TotalBps")]
        [Validation(Required=false)]
        public int? TotalBps { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DropPps")]
        [Validation(Required=false)]
        public int? DropPps { get; set; }

        [NameInMap("DropBps")]
        [Validation(Required=false)]
        public int? DropBps { get; set; }

        [NameInMap("TotalPps")]
        [Validation(Required=false)]
        public int? TotalPps { get; set; }

    }

}
