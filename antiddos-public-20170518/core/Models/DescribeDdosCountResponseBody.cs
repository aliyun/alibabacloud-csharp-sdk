// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosCountResponseBody : TeaModel {
        [NameInMap("DdosCount")]
        [Validation(Required=false)]
        public DescribeDdosCountResponseBodyDdosCount DdosCount { get; set; }
        public class DescribeDdosCountResponseBodyDdosCount : TeaModel {
            [NameInMap("BlackholeCount")]
            [Validation(Required=false)]
            public int? BlackholeCount { get; set; }
            [NameInMap("DefenseCount")]
            [Validation(Required=false)]
            public int? DefenseCount { get; set; }
            [NameInMap("InstacenCount")]
            [Validation(Required=false)]
            public int? InstacenCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
