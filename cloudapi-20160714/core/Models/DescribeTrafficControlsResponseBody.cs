// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeTrafficControlsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TrafficControls")]
        [Validation(Required=false)]
        public DescribeTrafficControlsResponseBodyTrafficControls TrafficControls { get; set; }
        public class DescribeTrafficControlsResponseBodyTrafficControls : TeaModel {
            [NameInMap("TrafficControl")]
            [Validation(Required=false)]
            public List<DescribeTrafficControlsResponseBodyTrafficControlsTrafficControl> TrafficControl { get; set; }
            public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControl : TeaModel {
                public int? ApiDefault { get; set; }
                public int? AppDefault { get; set; }
                public string CreatedTime { get; set; }
                public string Description { get; set; }
                public string ModifiedTime { get; set; }
                public DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPolicies SpecialPolicies { get; set; }
                public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPolicies : TeaModel {
                    [NameInMap("SpecialPolicy")]
                    [Validation(Required=false)]
                    public List<DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicy> SpecialPolicy { get; set; }
                    public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicy : TeaModel {
                        [NameInMap("SpecialType")]
                        [Validation(Required=false)]
                        public string SpecialType { get; set; }

                        [NameInMap("Specials")]
                        [Validation(Required=false)]
                        public DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicySpecials Specials { get; set; }
                        public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicySpecials : TeaModel {
                            [NameInMap("Special")]
                            [Validation(Required=false)]
                            public List<DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicySpecialsSpecial> Special { get; set; }
                            public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicySpecialsSpecial : TeaModel {
                                public string SpecialKey { get; set; }
                                public int? TrafficValue { get; set; }
                            }
                        };

                    }

                }
                public string TrafficControlId { get; set; }
                public string TrafficControlName { get; set; }
                public string TrafficControlUnit { get; set; }
                public int? UserDefault { get; set; }
            }
        };

    }

}
