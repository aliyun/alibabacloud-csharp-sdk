// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeAIConfigListResponseBody : TeaModel {
        [NameInMap("AIConfigList")]
        [Validation(Required=false)]
        public DescribeAIConfigListResponseBodyAIConfigList AIConfigList { get; set; }
        public class DescribeAIConfigListResponseBodyAIConfigList : TeaModel {
            [NameInMap("AIConfigList")]
            [Validation(Required=false)]
            public List<DescribeAIConfigListResponseBodyAIConfigListAIConfigList> AIConfigList { get; set; }
            public class DescribeAIConfigListResponseBodyAIConfigListAIConfigList : TeaModel {
                public int? CaptureInterval { get; set; }
                public string ConfigId { get; set; }
                public string Configs { get; set; }
                public string Description { get; set; }
                public long? EndTime { get; set; }
                public string Features { get; set; }
                public long? InstanceId { get; set; }
                public string InstanceType { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
