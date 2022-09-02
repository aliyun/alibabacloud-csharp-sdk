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
                [NameInMap("ApiDefault")]
                [Validation(Required=false)]
                public int? ApiDefault { get; set; }

                [NameInMap("AppDefault")]
                [Validation(Required=false)]
                public int? AppDefault { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("SpecialPolicies")]
                [Validation(Required=false)]
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
                                [NameInMap("SpecialKey")]
                                [Validation(Required=false)]
                                public string SpecialKey { get; set; }

                                [NameInMap("TrafficValue")]
                                [Validation(Required=false)]
                                public int? TrafficValue { get; set; }

                            }

                        }

                    }

                }

                [NameInMap("TrafficControlId")]
                [Validation(Required=false)]
                public string TrafficControlId { get; set; }

                [NameInMap("TrafficControlName")]
                [Validation(Required=false)]
                public string TrafficControlName { get; set; }

                [NameInMap("TrafficControlUnit")]
                [Validation(Required=false)]
                public string TrafficControlUnit { get; set; }

                [NameInMap("UserDefault")]
                [Validation(Required=false)]
                public int? UserDefault { get; set; }

            }

        }

    }

}
