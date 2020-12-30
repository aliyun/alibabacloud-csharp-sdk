// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeQosesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Qoses")]
        [Validation(Required=false)]
        public DescribeQosesResponseBodyQoses Qoses { get; set; }
        public class DescribeQosesResponseBodyQoses : TeaModel {
            [NameInMap("Qos")]
            [Validation(Required=false)]
            public List<DescribeQosesResponseBodyQosesQos> Qos { get; set; }
            public class DescribeQosesResponseBodyQosesQos : TeaModel {
                public string QosDescription { get; set; }
                public string SagCount { get; set; }
                public string SmartAGIds { get; set; }
                public string QosId { get; set; }
                public string QosName { get; set; }
            }
        };

    }

}
