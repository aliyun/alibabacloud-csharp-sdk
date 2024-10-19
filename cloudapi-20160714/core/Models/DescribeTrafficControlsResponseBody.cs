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

        /// <summary>
        /// <para>The returned throttling policy information. It is an array consisting of TrafficControl data.</para>
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
                /// <para>The default throttling value for each API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20000</para>
                /// </summary>
                [NameInMap("ApiDefault")]
                [Validation(Required=false)]
                public int? ApiDefault { get; set; }

                /// <summary>
                /// <para>The default throttling value for each app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8000</para>
                /// </summary>
                [NameInMap("AppDefault")]
                [Validation(Required=false)]
                public int? AppDefault { get; set; }

                /// <summary>
                /// <para>The creation time (UTC) of the throttling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-01-27T10:19:39Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The description of the throttling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The last modification time (UTC) of the throttling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-01-27T10:34:38Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The returned information about a special throttling policy. It is an array consisting of SpecialPolicy data.</para>
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
                        /// <para>The type of the special throttling policy. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>APP</b></description></item>
                        /// <item><description><b>USER</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>USER</para>
                        /// </summary>
                        [NameInMap("SpecialType")]
                        [Validation(Required=false)]
                        public string SpecialType { get; set; }

                        /// <summary>
                        /// <para>The returned information about a special throttling policy. It is an array consisting of Special data.</para>
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
                                /// <para>The AppId or user account corresponding to SpecialType.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="mailto:test_wg@aliyun.com">test_wg@aliyun.com</a></para>
                                /// </summary>
                                [NameInMap("SpecialKey")]
                                [Validation(Required=false)]
                                public string SpecialKey { get; set; }

                                /// <summary>
                                /// <para>The throttling value.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("TrafficValue")]
                                [Validation(Required=false)]
                                public int? TrafficValue { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// <para>The ID of the throttling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cfed6c970d45481dbe136d6b5ac68c41</para>
                /// </summary>
                [NameInMap("TrafficControlId")]
                [Validation(Required=false)]
                public string TrafficControlId { get; set; }

                /// <summary>
                /// <para>The name of the throttling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wulingtestq1</para>
                /// </summary>
                [NameInMap("TrafficControlName")]
                [Validation(Required=false)]
                public string TrafficControlName { get; set; }

                /// <summary>
                /// <para>The unit to be used in the throttling policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MINUTE</description></item>
                /// <item><description>HOUR</description></item>
                /// <item><description>DAY</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Minute</para>
                /// </summary>
                [NameInMap("TrafficControlUnit")]
                [Validation(Required=false)]
                public string TrafficControlUnit { get; set; }

                /// <summary>
                /// <para>The default throttling value for each user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15000</para>
                /// </summary>
                [NameInMap("UserDefault")]
                [Validation(Required=false)]
                public int? UserDefault { get; set; }

            }

        }

    }

}
