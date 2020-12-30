// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeQosPoliciesResponseBody : TeaModel {
        [NameInMap("QosPolicies")]
        [Validation(Required=false)]
        public DescribeQosPoliciesResponseBodyQosPolicies QosPolicies { get; set; }
        public class DescribeQosPoliciesResponseBodyQosPolicies : TeaModel {
            [NameInMap("QosPolicy")]
            [Validation(Required=false)]
            public List<DescribeQosPoliciesResponseBodyQosPoliciesQosPolicy> QosPolicy { get; set; }
            public class DescribeQosPoliciesResponseBodyQosPoliciesQosPolicy : TeaModel {
                [NameInMap("DpiSignatureId")]
                [Validation(Required=false)]
                public List<string> DpiSignatureId { get; set; }

            }
        };

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

    }

}
