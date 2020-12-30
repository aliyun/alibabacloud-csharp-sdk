// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeDdosAttackTypeChartResponseBody : TeaModel {
        [NameInMap("AttckCount")]
        [Validation(Required=false)]
        public int? AttckCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AttckType")]
        [Validation(Required=false)]
        public string AttckType { get; set; }

        [NameInMap("DropCount")]
        [Validation(Required=false)]
        public int? DropCount { get; set; }

        [NameInMap("DropType")]
        [Validation(Required=false)]
        public string DropType { get; set; }

    }

}
