// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class FindUserReport4AlinlpResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<FindUserReport4AlinlpResponseBodyData> Data { get; set; }
        public class FindUserReport4AlinlpResponseBodyData : TeaModel {
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            [NameInMap("QpsMax")]
            [Validation(Required=false)]
            public int? QpsMax { get; set; }

            [NameInMap("RptTime")]
            [Validation(Required=false)]
            public string RptTime { get; set; }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
