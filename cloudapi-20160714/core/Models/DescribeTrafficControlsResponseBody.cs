// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeTrafficControlsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The returned throttling policy information. It is an array consisting of TrafficControl data.
        /// </summary>
        [NameInMap("TrafficControls")]
        [Validation(Required=false)]
        public DescribeTrafficControlsResponseBodyTrafficControls TrafficControls { get; set; }
        public class DescribeTrafficControlsResponseBodyTrafficControls : TeaModel {
            [NameInMap("TrafficControl")]
            [Validation(Required=false)]
            public List<DescribeTrafficControlsResponseBodyTrafficControlsTrafficControl> TrafficControl { get; set; }
            public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControl : TeaModel {
                /// <summary>
                /// The default throttling value for each API.
                /// </summary>
                [NameInMap("ApiDefault")]
                [Validation(Required=false)]
                public int? ApiDefault { get; set; }

                /// <summary>
                /// The default throttling value for each app.
                /// </summary>
                [NameInMap("AppDefault")]
                [Validation(Required=false)]
                public int? AppDefault { get; set; }

                /// <summary>
                /// The creation time (UTC) of the throttling policy.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The description of the throttling policy.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The last modification time (UTC) of the throttling policy.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The returned information about a special throttling policy. It is an array consisting of SpecialPolicy data.
                /// </summary>
                [NameInMap("SpecialPolicies")]
                [Validation(Required=false)]
                public DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPolicies SpecialPolicies { get; set; }
                public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPolicies : TeaModel {
                    [NameInMap("SpecialPolicy")]
                    [Validation(Required=false)]
                    public List<DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicy> SpecialPolicy { get; set; }
                    public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicy : TeaModel {
                        /// <summary>
                        /// The type of the special throttling policy. Valid values:
                        /// 
                        /// *   **APP**
                        /// *   **USER**
                        /// </summary>
                        [NameInMap("SpecialType")]
                        [Validation(Required=false)]
                        public string SpecialType { get; set; }

                        /// <summary>
                        /// The returned information about a special throttling policy. It is an array consisting of Special data.
                        /// </summary>
                        [NameInMap("Specials")]
                        [Validation(Required=false)]
                        public DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicySpecials Specials { get; set; }
                        public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicySpecials : TeaModel {
                            [NameInMap("Special")]
                            [Validation(Required=false)]
                            public List<DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicySpecialsSpecial> Special { get; set; }
                            public class DescribeTrafficControlsResponseBodyTrafficControlsTrafficControlSpecialPoliciesSpecialPolicySpecialsSpecial : TeaModel {
                                /// <summary>
                                /// The AppId or user account corresponding to SpecialType.
                                /// </summary>
                                [NameInMap("SpecialKey")]
                                [Validation(Required=false)]
                                public string SpecialKey { get; set; }

                                /// <summary>
                                /// The throttling value.
                                /// </summary>
                                [NameInMap("TrafficValue")]
                                [Validation(Required=false)]
                                public int? TrafficValue { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// The ID of the throttling policy.
                /// </summary>
                [NameInMap("TrafficControlId")]
                [Validation(Required=false)]
                public string TrafficControlId { get; set; }

                /// <summary>
                /// The name of the throttling policy.
                /// </summary>
                [NameInMap("TrafficControlName")]
                [Validation(Required=false)]
                public string TrafficControlName { get; set; }

                /// <summary>
                /// The unit to be used in the throttling policy. Valid values:
                /// 
                /// *   MINUTE
                /// *   HOUR
                /// *   DAY
                /// </summary>
                [NameInMap("TrafficControlUnit")]
                [Validation(Required=false)]
                public string TrafficControlUnit { get; set; }

                /// <summary>
                /// The default throttling value for each user.
                /// </summary>
                [NameInMap("UserDefault")]
                [Validation(Required=false)]
                public int? UserDefault { get; set; }

            }

        }

    }

}
