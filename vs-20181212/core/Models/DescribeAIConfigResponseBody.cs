// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeAIConfigResponseBody : TeaModel {
        [NameInMap("AIConfig")]
        [Validation(Required=false)]
        public DescribeAIConfigResponseBodyAIConfig AIConfig { get; set; }
        public class DescribeAIConfigResponseBodyAIConfig : TeaModel {
            [NameInMap("CaptureInterval")]
            [Validation(Required=false)]
            public int? CaptureInterval { get; set; }
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public string Configs { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("Features")]
            [Validation(Required=false)]
            public string Features { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
