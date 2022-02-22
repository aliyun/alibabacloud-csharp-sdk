// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribeJobLogResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeJobLogResponseBodyResult Result { get; set; }
        public class DescribeJobLogResponseBodyResult : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public long? EnvId { get; set; }
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeJobLogResponseBodyResultEvents> Events { get; set; }
            public class DescribeJobLogResponseBodyResultEvents : TeaModel {
                public string Action { get; set; }
                public int? Count { get; set; }
                public string EventTime { get; set; }
                public string FirstTimestamp { get; set; }
                public string LastTimestamp { get; set; }
                public string Mesage { get; set; }
                public string Reason { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("JobLog")]
            [Validation(Required=false)]
            public string JobLog { get; set; }
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }
        };

    }

}
