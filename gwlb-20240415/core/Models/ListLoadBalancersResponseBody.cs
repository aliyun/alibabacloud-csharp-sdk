// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class ListLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>The GWLB instances.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public List<ListLoadBalancersResponseBodyLoadBalancers> LoadBalancers { get; set; }
        public class ListLoadBalancersResponseBodyLoadBalancers : TeaModel {
            /// <summary>
            /// <para>The IP version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("AddressIpVersion")]
            [Validation(Required=false)]
            public string AddressIpVersion { get; set; }

            /// <summary>
            /// <para>The time when the resource was created. The time follows the ISO 8601 standard in the <b>yyyy-MM-ddTHH:mm:ssZ</b> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-05 18:24:07</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The business status of the GWLB instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: running as expected</description></item>
            /// <item><description><b>FinancialLocked</b>: locked due to overdue payments</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("LoadBalancerBusinessStatus")]
            [Validation(Required=false)]
            public string LoadBalancerBusinessStatus { get; set; }

            /// <summary>
            /// <para>The GWLB instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gwlb-9njtjmqt7zfcqm****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The GWLB instance name.</para>
            /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testGwlbName</para>
            /// </summary>
            [NameInMap("LoadBalancerName")]
            [Validation(Required=false)]
            public string LoadBalancerName { get; set; }

            /// <summary>
            /// <para>The GWLB instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Active</b>: The GWLB instance is running.</description></item>
            /// <item><description><b>Inactive</b>: The GWLB instance is disabled. Listeners of GWLB instances in the Inactive state do not forward traffic.</description></item>
            /// <item><description><b>Provisioning</b>: The GWLB instance is being created.</description></item>
            /// <item><description><b>Configuring</b>: The GWLB instance is being modified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("LoadBalancerStatus")]
            [Validation(Required=false)]
            public string LoadBalancerStatus { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek26jasguy****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersTags> Tags { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersTags : TeaModel {
                /// <summary>
                /// <para>The tag key. The tag key cannot be an empty string.</para>
                /// <para>The tag key can be up to 128 characters in length. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testTagKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. You can specify at most 20 tag values. The tag value cannot be an empty string.</para>
                /// <para>The tag value can be up to 128 characters in length. It must start with a letter and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testTagValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf6eg0vndlsa84n7r****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The mappings between zones and vSwitches. You must specify at least one zone. You can specify at most 20 zones. If the region supports two or more zones, specify at least two zones.</para>
            /// </summary>
            [NameInMap("ZoneMappings")]
            [Validation(Required=false)]
            public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappings> ZoneMappings { get; set; }
            public class ListLoadBalancersResponseBodyLoadBalancersZoneMappings : TeaModel {
                /// <summary>
                /// <para>The GWLB instance addresses.</para>
                /// </summary>
                [NameInMap("LoadBalancerAddresses")]
                [Validation(Required=false)]
                public List<ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses> LoadBalancerAddresses { get; set; }
                public class ListLoadBalancersResponseBodyLoadBalancersZoneMappingsLoadBalancerAddresses : TeaModel {
                    /// <summary>
                    /// <para>The ID of the elastic network interface (ENI) used by the GWLB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eni-bp17qv9zbzyqy629****</para>
                    /// </summary>
                    [NameInMap("EniId")]
                    [Validation(Required=false)]
                    public string EniId { get; set; }

                    /// <summary>
                    /// <para>The private IPv4 address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.XX.XX</para>
                    /// </summary>
                    [NameInMap("PrivateIpv4Address")]
                    [Validation(Required=false)]
                    public string PrivateIpv4Address { get; set; }

                }

                /// <summary>
                /// <para>The ID of the vSwitch in the zone. By default, each zone contains one vSwitch and one subnet.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-2zemule5dz7okwqfv****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID. You can call the DescribeZones operation to query the most recent zone list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 1000. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If NextToken is empty, no next page exists.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of NextToken.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CAESGgoSChAKDGNvbXBsZXRlVGltZRABCgQiAggAGAAiQAoJAIldD2UAAAAACjMDLgAAADFTNzMyZDMwMzAzMDY5NzQzNDM0NmI3NzM2NjUzNzc4NzM2YTc0NjYzOTYz****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>378A80E9-4262-5D8E-8D62-0969E52D7358</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
