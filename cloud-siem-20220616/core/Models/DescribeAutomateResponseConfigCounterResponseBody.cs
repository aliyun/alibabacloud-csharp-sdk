// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAutomateResponseConfigCounterResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAutomateResponseConfigCounterResponseBodyData Data { get; set; }
        public class DescribeAutomateResponseConfigCounterResponseBodyData : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public long? All { get; set; }

            [NameInMap("Online")]
            [Validation(Required=false)]
            public long? Online { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
