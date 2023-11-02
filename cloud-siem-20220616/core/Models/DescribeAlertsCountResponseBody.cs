// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsCountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAlertsCountResponseBodyData Data { get; set; }
        public class DescribeAlertsCountResponseBodyData : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public long? All { get; set; }

            [NameInMap("High")]
            [Validation(Required=false)]
            public long? High { get; set; }

            [NameInMap("Low")]
            [Validation(Required=false)]
            public long? Low { get; set; }

            [NameInMap("Medium")]
            [Validation(Required=false)]
            public long? Medium { get; set; }

            [NameInMap("ProductNum")]
            [Validation(Required=false)]
            public int? ProductNum { get; set; }

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
