// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of CLB instances.</para>
        /// </summary>
        [NameInMap("LoadBalancers")]
        [Validation(Required=false)]
        public DescribeLoadBalancersResponseBodyLoadBalancers LoadBalancers { get; set; }
        public class DescribeLoadBalancersResponseBodyLoadBalancers : TeaModel {
            [NameInMap("LoadBalancer")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer> LoadBalancer { get; set; }
            public class DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancer : TeaModel {
                /// <summary>
                /// <para>The endpoint of the CLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.XX.XX.28</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The IP version that is used by the CLB instance. Valid values: <b>ipv4</b> and <b>ipv6</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("AddressIPVersion")]
                [Validation(Required=false)]
                public string AddressIPVersion { get; set; }

                /// <summary>
                /// <para>The network type of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>internet:</b> After an Internet-facing CLB instance is created, the system assigns a public IP address to the CLB instance. Then, the CLB instance can forward requests over the Internet.</description></item>
                /// <item><description><b>intranet:</b> After an internal-facing CLB instance is created, the system assigns a private IP address to the CLB instance. Then, the CLB instance can forward requests only over internal networks.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>intranet</para>
                /// </summary>
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// <para>The maximum bandwidth of the listener. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The time when the CLB instance was created. The time follows the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-02T02:49:05Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The timestamp when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1504147745000</para>
                /// </summary>
                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                /// <summary>
                /// <para>Indicates whether deletion protection is enabled for the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on:</b> Deletion protection is enabled.</description></item>
                /// <item><description><b>off:</b> Deletion protection is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("DeleteProtection")]
                [Validation(Required=false)]
                public string DeleteProtection { get; set; }

                /// <summary>
                /// <para>The metering method of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PayBySpec:</b> pay-by-specification.</description></item>
                /// <item><description><b>PayByCLCU:</b> pay-by-LCU.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter takes effect only for accounts registered on the China site (aliyun.com) and when the <b>PayType</b> parameter is set to <b>PayOnDemand</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>PayBySpec</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The metering method of the Internet-facing CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>3:</b> pay-by-bandwidth (<b>paybybandwidth</b>).</description></item>
                /// <item><description><b>4:</b> pay-by-data-transfer (<b>paybytraffic</b>).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The metering method of Internet data transfer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>paybybandwidth:</b> pay-by-bandwidth.</description></item>
                /// <item><description><b>paybytraffic:</b> pay-by-data-transfer.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>paybybandwidth</para>
                /// </summary>
                [NameInMap("InternetChargeTypeAlias")]
                [Validation(Required=false)]
                public string InternetChargeTypeAlias { get; set; }

                /// <summary>
                /// <para>The ID of the CLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-bp1b6c719dfa****</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The name of the CLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-bp1o94dp5i6ea****</para>
                /// </summary>
                [NameInMap("LoadBalancerName")]
                [Validation(Required=false)]
                public string LoadBalancerName { get; set; }

                /// <summary>
                /// <para>The specification of the CLB instance.</para>
                /// <remarks>
                /// <para> Pay-as-you-go CLB instances are not subject to specifications. <b>slb.lcu.elastic</b> is returned by default.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>slb.s1.small</para>
                /// </summary>
                [NameInMap("LoadBalancerSpec")]
                [Validation(Required=false)]
                public string LoadBalancerSpec { get; set; }

                /// <summary>
                /// <para>The status of the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>inactive:</b> The CLB instance is disabled. CLB instances in the inactive state do not forward traffic.</description></item>
                /// <item><description><b>active:</b> The CLB instance runs as expected. By default, newly created CLB instances are in the <b>active</b> state.</description></item>
                /// <item><description><b>locked:</b> The CLB instance is locked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("LoadBalancerStatus")]
                [Validation(Required=false)]
                public string LoadBalancerStatus { get; set; }

                /// <summary>
                /// <para>The ID of the primary zone to which the CLB instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("MasterZoneId")]
                [Validation(Required=false)]
                public string MasterZoneId { get; set; }

                /// <summary>
                /// <para>The reason why the configuration read-only mode was enabled. The reason must be 1 to 80 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The reason must start with a letter.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when you set the <c>ModificationProtectionStatus</c> parameter to <b>ConsoleProtection</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ManagedInstance</para>
                /// </summary>
                [NameInMap("ModificationProtectionReason")]
                [Validation(Required=false)]
                public string ModificationProtectionReason { get; set; }

                /// <summary>
                /// <para>Indicates whether the configuration read-only mode is enabled for the CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NonProtection:</b> The configuration read-only mode is disabled. In this case, you cannot specify the ModificationProtectionReason parameter. If you specify the <c>ModificationProtectionReason</c> parameter, the value is cleared.</description></item>
                /// <item><description><b>ConsoleProtection:</b> The configuration read-only mode is enabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para> If you set this parameter to <b>ConsoleProtection</b>, you cannot modify the configurations of the CLB instance in the CLB console. However, you can call API operations to modify the configurations of the CLB instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ConsoleProtection</para>
                /// </summary>
                [NameInMap("ModificationProtectionStatus")]
                [Validation(Required=false)]
                public string ModificationProtectionStatus { get; set; }

                /// <summary>
                /// <para>The network type of the internal-facing CLB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>vpc</b>: VPC</description></item>
                /// <item><description><b>Classic</b>: classic network</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The billing method of the CLB instance.</para>
                /// <list type="bullet">
                /// <item><description><b>PayOnDemand</b> is returned, which indicates the pay-as-you-go billing method.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayOnDemand</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The ID of the region where the CLB instance was deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The region where the CLB instance was deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hangzhou</para>
                /// </summary>
                [NameInMap("RegionIdAlias")]
                [Validation(Required=false)]
                public string RegionIdAlias { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-atstuj3r****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the secondary zone to which the CLB instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-d</para>
                /// </summary>
                [NameInMap("SlaveZoneId")]
                [Validation(Required=false)]
                public string SlaveZoneId { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancerTags Tags { get; set; }
                public class DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancerTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancerTagsTag> Tag { get; set; }
                    public class DescribeLoadBalancersResponseBodyLoadBalancersLoadBalancerTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceJoshua</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the vSwitch to which the internal-facing CLB instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-255ecr****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC in which the internal-facing CLB instance was deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-25dvzy9f8****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

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
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8B9DB03B-ED39-5DB8-9C9F-1ED5F548D61E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of instances returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
