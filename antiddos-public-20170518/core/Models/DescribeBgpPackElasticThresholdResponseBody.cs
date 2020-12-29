// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeBgpPackElasticThresholdResponseBody : TeaModel {
        [NameInMap("MaxThreshold")]
        [Validation(Required=false)]
        public int? MaxThreshold { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Openable")]
        [Validation(Required=false)]
        public bool? Openable { get; set; }

    }

}
