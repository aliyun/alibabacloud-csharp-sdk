// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeJobResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public DescribeJobResponseBodyMessage Message { get; set; }
        public class DescribeJobResponseBodyMessage : TeaModel {
            [NameInMap("JobInfo")]
            [Validation(Required=false)]
            public string JobInfo { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
