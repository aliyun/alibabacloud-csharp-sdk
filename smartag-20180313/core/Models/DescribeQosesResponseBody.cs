// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeQosesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Qoses")]
        [Validation(Required=false)]
        public DescribeQosesResponseBodyQoses Qoses { get; set; }
        public class DescribeQosesResponseBodyQoses : TeaModel {
            [NameInMap("Qos")]
            [Validation(Required=false)]
            public List<DescribeQosesResponseBodyQosesQos> Qos { get; set; }
            public class DescribeQosesResponseBodyQosesQos : TeaModel {
                [NameInMap("QosDescription")]
                [Validation(Required=false)]
                public string QosDescription { get; set; }

                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                [NameInMap("QosName")]
                [Validation(Required=false)]
                public string QosName { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SagCount")]
                [Validation(Required=false)]
                public string SagCount { get; set; }

                [NameInMap("SmartAGIds")]
                [Validation(Required=false)]
                public string SmartAGIds { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
