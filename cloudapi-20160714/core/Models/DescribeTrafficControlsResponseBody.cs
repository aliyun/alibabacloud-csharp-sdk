// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeTrafficControlsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93D91A99-F093-4596-87BA-3C4FBFD3FD8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
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
