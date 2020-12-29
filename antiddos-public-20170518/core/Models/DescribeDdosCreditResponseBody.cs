// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeDdosCreditResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DdosCredit")]
        [Validation(Required=false)]
        public DescribeDdosCreditResponseBodyDdosCredit DdosCredit { get; set; }
        public class DescribeDdosCreditResponseBodyDdosCredit : TeaModel {
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }
            [NameInMap("ScoreLevel")]
            [Validation(Required=false)]
            public string ScoreLevel { get; set; }
            [NameInMap("BlackholeTime")]
            [Validation(Required=false)]
            public int? BlackholeTime { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
