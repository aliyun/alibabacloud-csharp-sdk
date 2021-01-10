// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ImportTSJobsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportTSJobsResponseBodyData Data { get; set; }
        public class ImportTSJobsResponseBodyData : TeaModel {
            [NameInMap("FailedMap")]
            [Validation(Required=false)]
            public string FailedMap { get; set; }
            [NameInMap("SucceedCount")]
            [Validation(Required=false)]
            public long? SucceedCount { get; set; }
        };

    }

}
