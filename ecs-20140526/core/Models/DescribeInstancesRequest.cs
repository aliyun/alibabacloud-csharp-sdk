// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestFilter> Filter { get; set; }
        public class DescribeInstancesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key used to query resources. Set this parameter to <c>CreationStartTime</c>. When you set both <c>Filter.1.Key</c> and <c>Filter.1.Value</c>, you can query resources created after the specified point in time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value used to query resources. You must also specify the <c>Filter.1.Key</c> parameter when you specify this parameter. The value must be in the format <c>yyyy-MM-ddTHH:mmZ</c> (UTC+0).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-05T22:40Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The list of additional instance attributes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>META_OPTIONS</para>
        /// </summary>
        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeviceAvailable")]
        [Validation(Required=false)]
        public bool? DeviceAvailable { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Only checks the request without querying resources. Checks include AccessKey validity, RAM user permissions, and required parameters. If the check fails, an error is returned. If the check passes, the DryRunOperation error code is returned.</para>
        /// </description></item>
        /// <item><description><para>false: Sends a normal request. After passing the checks, a 2XX HTTP status code is returned and resources are queried.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The Elastic IP addresses of instances. This parameter takes effect only when InstanceNetworkType=vpc. Specify multiple IP addresses as a JSON array. You can specify up to 100 IP addresses. Separate IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;42.1.1.<b>&quot;, &quot;42.1.2.</b>&quot;, … &quot;42.1.10.**&quot;]</para>
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public string EipAddresses { get; set; }

        /// <summary>
        /// <para>The ID of the HPC cluster to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hpc-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access to instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enabled: enabled.</para>
        /// </description></item>
        /// <item><description><para>disabled: disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para>For more information about instance metadata, see <a href="https://help.aliyun.com/document_detail/49122.html">Overview of instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("HttpEndpoint")]
        [Validation(Required=false)]
        public string HttpEndpoint { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to enforce the use of IMDSv2 when accessing instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>optional: does not enforce IMDSv2.</para>
        /// </description></item>
        /// <item><description><para>required: enforces IMDSv2. After this value is set, instance metadata cannot be accessed in standard mode.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para>For more information about instance metadata access modes, see <a href="https://help.aliyun.com/document_detail/150575.html">Instance metadata access modes</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The private IP addresses of instances in the classic network. This parameter takes effect only when InstanceNetworkType=classic. Specify multiple IP addresses as a JSON array. You can specify up to 100 IP addresses. Separate IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;10.1.1.1&quot;, &quot;10.1.2.1&quot;, … &quot;10.1.10.1&quot;]</para>
        /// </summary>
        [NameInMap("InnerIpAddresses")]
        [Validation(Required=false)]
        public string InnerIpAddresses { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PostPaid: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para>PrePaid: subscription.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The IDs of instances. Specify multiple instance IDs as a JSON array. You can specify up to 100 IDs. Separate IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp67acfmxazb4p****&quot;, &quot;i-bp67acfmxazb4p****&quot;, … &quot;i-bp67acfmxazb4p****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the instance. You can use the wildcard character \* for fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>classic: classic network.</para>
        /// </description></item>
        /// <item><description><para>vpc: Virtual Private Cloud (VPC).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance family.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The billing method for public bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PayByBandwidth: pay-by-bandwidth.</para>
        /// </description></item>
        /// <item><description><para>PayByTraffic: pay-by-data-transfer.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>In <b>pay-by-data-transfer</b> mode, both inbound and outbound peak bandwidth represent upper limits and are not guaranteed service levels. During resource contention, peak bandwidth may be limited. If your business requires guaranteed bandwidth, use <b>pay-by-bandwidth</b> mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is I/O optimized. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: yes.</para>
        /// </description></item>
        /// <item><description><para>false: no.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public bool? IoOptimized { get; set; }

        /// <summary>
        /// <para>The IPv6 addresses assigned to the ENI.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// <para>The name of the SSH key pair used by the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPairNameTest</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The reason why the resource is locked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>financial: The instance is locked due to overdue payment.</para>
        /// </description></item>
        /// <item><description><para>security: The instance is locked for security reasons.</para>
        /// </description></item>
        /// <item><description><para>Recycling: The spot instance is locked and pending release.</para>
        /// </description></item>
        /// <item><description><para>dedicatedhostfinancial: The ECS instance is locked because the dedicated host has an overdue payment.</para>
        /// </description></item>
        /// <item><description><para>refunded: The instance is locked due to a refund.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>security</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Maximum value: 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter or specify a value less than 10, the default value is 10.</para>
        /// </description></item>
        /// <item><description><para>If you specify a value greater than 100, the default value is 100.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is in invitational preview and is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedSaleCycle")]
        [Validation(Required=false)]
        public bool? NeedSaleCycle { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the <c>NextToken</c> value returned in the last API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be deprecated. We recommend that you use NextToken and MaxResults to perform paged queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter will be deprecated. We recommend that you use NextToken and MaxResults to perform paged queries.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The private IP addresses of instances in a VPC. This parameter takes effect only when InstanceNetworkType=vpc. Specify multiple IP addresses as a JSON array. You can specify up to 100 IP addresses. Separate IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;172.16.1.1&quot;, &quot;172.16.2.1&quot;, … &quot;172.16.10.1&quot;]</para>
        /// </summary>
        [NameInMap("PrivateIpAddresses")]
        [Validation(Required=false)]
        public string PrivateIpAddresses { get; set; }

        /// <summary>
        /// <para>The public IP addresses of instances. Specify multiple IP addresses as a JSON array. You can specify up to 100 IP addresses. Separate IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;42.1.1.<b>&quot;, &quot;42.1.2.</b>&quot;, … &quot;42.1.10.**&quot;]</para>
        /// </summary>
        [NameInMap("PublicIpAddresses")]
        [Validation(Required=false)]
        public string PublicIpAddresses { get; set; }

        /// <summary>
        /// <para>The RDMA IP address of the HPC instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.102</para>
        /// </summary>
        [NameInMap("RdmaIpAddresses")]
        [Validation(Required=false)]
        public string RdmaIpAddresses { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. When you use this parameter to filter resources, the number of resources cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The security group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pending: The instance is being created.</para>
        /// </description></item>
        /// <item><description><para>Running: The instance is running.</para>
        /// </description></item>
        /// <item><description><para>Starting: The instance is starting.</para>
        /// </description></item>
        /// <item><description><para>Stopping: The instance is stopping.</para>
        /// </description></item>
        /// <item><description><para>Stopped: The instance is stopped.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <remarks>
            /// <para>To improve compatibility, we recommend that you use the <c>Tag.N.Key</c> parameter instead.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the Virtual Private Cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
