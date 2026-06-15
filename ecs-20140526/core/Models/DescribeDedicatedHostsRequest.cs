// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the dedicated host cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-bp12wlf6am0vz9v2****</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=false)]
        public string DedicatedHostClusterId { get; set; }

        /// <summary>
        /// <para>The IDs of dedicated hosts. You can specify up to 100 dedicated host IDs in a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;dh-bp165p6xk2tlw61e****&quot;, &quot;dh-bp1f9vxmno7emy96****&quot;]</para>
        /// </summary>
        [NameInMap("DedicatedHostIds")]
        [Validation(Required=false)]
        public string DedicatedHostIds { get; set; }

        /// <summary>
        /// <para>The name of the dedicated host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyDDHTestName</para>
        /// </summary>
        [NameInMap("DedicatedHostName")]
        [Validation(Required=false)]
        public string DedicatedHostName { get; set; }

        /// <summary>
        /// <para>The dedicated host type. Call the <a href="https://help.aliyun.com/document_detail/134240.html"><c>DescribeDedicatedHostTypes</c></a> operation to get the latest list of dedicated host types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddh.g5</para>
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        /// <summary>
        /// <para>The reason that the dedicated host is locked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>financial</c>: The dedicated host is locked due to an overdue payment.</para>
        /// </description></item>
        /// <item><description><para><c>security</c>: The dedicated host is locked for security reasons.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>financial</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return per page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. Do not set this parameter for the first request. For subsequent requests, set this parameter to the <c>NextToken</c> value returned from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e71d8a535bd9cc11</para>
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
        /// <para>This parameter is deprecated. Use <c>NextToken</c> and <c>MaxResults</c> for pagination.</para>
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
        /// <para>This parameter is deprecated. Use <c>NextToken</c> and <c>MaxResults</c> for pagination.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QueryInventory")]
        [Validation(Required=false)]
        public bool? QueryInventory { get; set; }

        /// <summary>
        /// <para>The ID of the region where the dedicated host resides. Call the <a href="https://help.aliyun.com/document_detail/25609.html"><c>DescribeRegions</c></a> operation to get the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the dedicated host belongs. When you use this parameter to filter resources, the number of resources cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek3b6jzp66****</para>
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
        /// <para>Specifies whether to return socket-level capacity information. You can use the information to check the remaining vCPU and memory resources and determine whether an ECS instance of a specific instance type can be created on the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: returns the information. Only specific dedicated host types support this feature. For more information, see <a href="https://help.aliyun.com/document_detail/68989.html">View and export information about dedicated hosts</a>.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: does not return the information.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>A dedicated host typically has two CPUs, which correspond to Socket 0 and Socket 1. To maximize performance, an ECS instance created on a dedicated host is allocated to a single socket and does not span sockets.</para>
        /// <list type="bullet">
        /// <item><description><para>If the remaining resources on a socket are sufficient for the specified ECS instance type, the instance can be created.</para>
        /// </description></item>
        /// <item><description><para>If the remaining resources on each socket are insufficient for the specified ECS instance type, the instance cannot be created, even if the total remaining resources on both sockets are sufficient.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SocketDetails")]
        [Validation(Required=false)]
        public string SocketDetails { get; set; }

        /// <summary>
        /// <para>The state of the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Available</c>: The dedicated host is running as expected.</para>
        /// </description></item>
        /// <item><description><para><c>UnderAssessment</c>: The dedicated host is being assessed for physical hardware risks. The host is available but may have hardware issues that could affect its ECS instances.</para>
        /// </description></item>
        /// <item><description><para><c>PermanentFailure</c>: The dedicated host has a permanent failure and is unavailable.</para>
        /// </description></item>
        /// <item><description><para><c>TempUnavailable</c>: The dedicated host is temporarily unavailable.</para>
        /// </description></item>
        /// <item><description><para><c>Redeploying</c>: The dedicated host is being redeployed.</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is <c>Available</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags used to filter dedicated hosts. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostsRequestTag> Tag { get; set; }
        public class DescribeDedicatedHostsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 128 characters long. It cannot be an empty string, start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters long and cannot contain <c>http://</c> or <c>https://</c>. You can leave the value empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID. Call the <a href="https://help.aliyun.com/document_detail/25610.html"><c>DescribeZones</c></a> operation to get the latest list of Alibaba Cloud zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
