// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAuthVersionStatisticResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public List<GetAuthVersionStatisticResponseBodyStatistics> Statistics { get; set; }
        public class GetAuthVersionStatisticResponseBodyStatistics : TeaModel {
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

    }

}
