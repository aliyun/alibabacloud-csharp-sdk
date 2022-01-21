// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeQosPoliciesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QosPolicies")]
        [Validation(Required=false)]
        public DescribeQosPoliciesResponseBodyQosPolicies QosPolicies { get; set; }
        public class DescribeQosPoliciesResponseBodyQosPolicies : TeaModel {
            [NameInMap("QosPolicy")]
            [Validation(Required=false)]
            public List<DescribeQosPoliciesResponseBodyQosPoliciesQosPolicy> QosPolicy { get; set; }
            public class DescribeQosPoliciesResponseBodyQosPoliciesQosPolicy : TeaModel {
                public string Description { get; set; }
                public string DestCidr { get; set; }
                public string DestPortRange { get; set; }
                public DescribeQosPoliciesResponseBodyQosPoliciesQosPolicyDpiGroupIds DpiGroupIds { get; set; }
                public class DescribeQosPoliciesResponseBodyQosPoliciesQosPolicyDpiGroupIds : TeaModel {
                    [NameInMap("DpiGroupId")]
                    [Validation(Required=false)]
                    public List<string> DpiGroupId { get; set; }

                }
                public DescribeQosPoliciesResponseBodyQosPoliciesQosPolicyDpiSignatureIds DpiSignatureIds { get; set; }
                public class DescribeQosPoliciesResponseBodyQosPoliciesQosPolicyDpiSignatureIds : TeaModel {
                    [NameInMap("DpiSignatureId")]
                    [Validation(Required=false)]
                    public List<string> DpiSignatureId { get; set; }

                }
                public string EndTime { get; set; }
                public string IpProtocol { get; set; }
                public string Name { get; set; }
                public int? Priority { get; set; }
                public string QosId { get; set; }
                public string QosPolicyId { get; set; }
                public string SourceCidr { get; set; }
                public string SourcePortRange { get; set; }
                public string StartTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
