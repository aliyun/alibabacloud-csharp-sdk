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
            /// <para>The key of filter 1 used to query resources. Set the value to <c>CreationStartTime</c>. You can specify a time by setting both <c>Filter.1.Key</c> and <c>Filter.1.Value</c> to query resources that were created after the specified time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of filter 1 used to query resources. Set the value to a time. If you specify this parameter, you must also specify <c>Filter.1.Key</c>. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mmZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-05T22:40Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The additional instance attributes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>META_OPTIONS</para>
        /// </summary>
        [NameInMap("AdditionalAttributes")]
        [Validation(Required=false)]
        public List<string> AdditionalAttributes { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeviceAvailable")]
        [Validation(Required=false)]
        public bool? DeviceAvailable { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the request for potential issues, including invalid AccessKey pairs, unauthorized RAM users, and missing parameter values. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</description></item>
        /// <item><description>false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
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
        /// <para>The elastic IP addresses (EIPs) of instances. This parameter is valid when InstanceNetworkType is set to vpc. The value can be a JSON array that consists of up to 100 IP addresses. Separate the IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;42.1.1.<b>&quot;, &quot;42.1.2.</b>&quot;, … &quot;42.1.10.**&quot;]</para>
        /// </summary>
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public string EipAddresses { get; set; }

        /// <summary>
        /// <para>The ID of the high-performance computing (HPC) cluster to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hpc-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("HpcClusterId")]
        [Validation(Required=false)]
        public string HpcClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether the access channel is enabled for instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enabled</description></item>
        /// <item><description>disabled</description></item>
        /// </list>
        /// <para>Default value: enabled.</para>
        /// <remarks>
        /// <para> For information about instance metadata, see <a href="https://help.aliyun.com/document_detail/49122.html">Access instance metadata</a>.</para>
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
        /// <para> This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HttpPutResponseHopLimit")]
        [Validation(Required=false)]
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether the security hardening mode (IMDSv2) is forcefully used to access instance metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>optional: The security hardening mode (IMDSv2) is not forcefully used.</description></item>
        /// <item><description>required: The security hardening mode (IMDSv2) is forcefully used. After you set this parameter to required, you cannot access instance metadata in normal mode.</description></item>
        /// </list>
        /// <para>Default value: optional.</para>
        /// <remarks>
        /// <para> For information about modes of accessing instance metadata, see <a href="https://help.aliyun.com/document_detail/150575.html">Access instance metadata</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("HttpTokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

        /// <summary>
        /// <para>The ID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The internal IP addresses of instances located in the classic network. This parameter is valid when InstanceNetworkType is set to classic. The value can be a JSON array that consists of up to 100 IP addresses. Separate the IP addresses with commas (,).</para>
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
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// <item><description>PrePaid: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the instance. The value can be a JSON array that consists of up to 100 instance IDs. Separate the IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp67acfmxazb4p****&quot;, &quot;i-bp67acfmxazb4p****&quot;, … &quot;i-bp67acfmxazb4p****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The name of the instance. Fuzzy search with asterisk (\*) wildcard characters is supported.</para>
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
        /// <item><description>classic</description></item>
        /// <item><description>vpc</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The instance type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The instance family of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5</para>
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// <para>The billing method for network usage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth</description></item>
        /// <item><description>PayByTraffic</description></item>
        /// </list>
        /// <remarks>
        /// <para> When the <b>pay-by-traffic</b> billing method is used for network usage, the maximum inbound and outbound bandwidths are used as the upper limits of bandwidths instead of guaranteed performance specifications. In scenarios in which demands exceed resource supplies, the maximum bandwidths may not be reached. If you want guaranteed bandwidths for your instance, use the <b>pay-by-bandwidth</b> billing method for network usage.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is an I/O optimized instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public bool? IoOptimized { get; set; }

        /// <summary>
        /// <para>The IPv6 addresses assigned to elastic network interfaces (ENIs).</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// <para>The name of the SSH key pair bound to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KeyPairNameTest</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// <para>The reason why the instance is locked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>financial: The instance is locked due to overdue payments.</description></item>
        /// <item><description>security: The instance is locked due to security reasons.</description></item>
        /// <item><description>recycling: The preemptible instance is locked and pending release.</description></item>
        /// <item><description>dedicatedhostfinancial: The instance is locked due to overdue payments for the dedicated host.</description></item>
        /// <item><description>refunded: The instance is locked because a refund is made for the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>security</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter or if you set this parameter to a value that is smaller than 10, the default value is 10.</description></item>
        /// <item><description>If you set this parameter to a value that is greater than 100, the default value is 100.</description></item>
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
        /// <para> This parameter is in invitational preview and is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedSaleCycle")]
        [Validation(Required=false)]
        public bool? NeedSaleCycle { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
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
        /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
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
        /// <para> This parameter will be removed in the future. We recommend that you use NextToken and MaxResults for a paged query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The private IP addresses of instances located in a VPC. This parameter is valid when InstanceNetworkType is set to vpc. The value can be a JSON array that consists of up to 100 IP addresses. Separate the IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;172.16.1.1&quot;, &quot;172.16.2.1&quot;, … &quot;172.16.10.1&quot;]</para>
        /// </summary>
        [NameInMap("PrivateIpAddresses")]
        [Validation(Required=false)]
        public string PrivateIpAddresses { get; set; }

        /// <summary>
        /// <para>The public IP addresses of instances. The value can be a JSON array that consists of up to 100 IP addresses. Separate the IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;42.1.1.<b>&quot;, &quot;42.1.2.</b>&quot;, … &quot;42.1.10.**&quot;]</para>
        /// </summary>
        [NameInMap("PublicIpAddresses")]
        [Validation(Required=false)]
        public string PublicIpAddresses { get; set; }

        /// <summary>
        /// <para>The remote direct memory access (RDMA) IP addresses of the instance in the HPC cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.102</para>
        /// </summary>
        [NameInMap("RdmaIpAddresses")]
        [Validation(Required=false)]
        public string RdmaIpAddresses { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs. If this parameter is specified to query resources, up to 1,000 resources that belong to the specified resource group can be displayed in the response.</para>
        /// <remarks>
        /// <para> Resources in the default resource group are displayed in the response regardless of how this parameter is set.</para>
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
        /// <para>The ID of the security group to which the instance belongs.</para>
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
        /// <item><description>Pending: The instance is being created.</description></item>
        /// <item><description>Running: The instance is running.</description></item>
        /// <item><description>Starting: The instance is being started.</description></item>
        /// <item><description>Stopping: The instance is being stopped.</description></item>
        /// <item><description>Stopped: The instance is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the instance. Valid values of N: 1 to 20.</para>
            /// <para>If you specify a single tag to query resources, up to 1,000 resources to which the tag is added are returned. If you specify multiple tags to query resources, up to 1,000 resources to which all specified tags are added are returned. To query more than 1,000 resources that have specified tags added, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the instance. Valid values of N: 1 to 20.</para>
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
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
