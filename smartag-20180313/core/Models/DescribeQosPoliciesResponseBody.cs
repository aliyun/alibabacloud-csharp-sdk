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
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DestCidr")]
                [Validation(Required=false)]
                public string DestCidr { get; set; }

                [NameInMap("DestPortRange")]
                [Validation(Required=false)]
                public string DestPortRange { get; set; }

                [NameInMap("DpiGroupIds")]
                [Validation(Required=false)]
                public DescribeQosPoliciesResponseBodyQosPoliciesQosPolicyDpiGroupIds DpiGroupIds { get; set; }
                public class DescribeQosPoliciesResponseBodyQosPoliciesQosPolicyDpiGroupIds : TeaModel {
                    [NameInMap("DpiGroupId")]
                    [Validation(Required=false)]
                    public List<string> DpiGroupId { get; set; }

                }

                [NameInMap("DpiSignatureIds")]
                [Validation(Required=false)]
                public DescribeQosPoliciesResponseBodyQosPoliciesQosPolicyDpiSignatureIds DpiSignatureIds { get; set; }
                public class DescribeQosPoliciesResponseBodyQosPoliciesQosPolicyDpiSignatureIds : TeaModel {
                    [NameInMap("DpiSignatureId")]
                    [Validation(Required=false)]
                    public List<string> DpiSignatureId { get; set; }

                }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("QosId")]
                [Validation(Required=false)]
                public string QosId { get; set; }

                [NameInMap("QosPolicyId")]
                [Validation(Required=false)]
                public string QosPolicyId { get; set; }

                [NameInMap("SourceCidr")]
                [Validation(Required=false)]
                public string SourceCidr { get; set; }

                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

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
