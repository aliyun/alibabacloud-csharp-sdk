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
        /// <para>The IDs of the dedicated hosts. You can specify up to 100 IDs. Separate multiple IDs with commas (,).</para>
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
        /// <para>The dedicated host type. You can call the <a href="https://help.aliyun.com/document_detail/134240.html">DescribeDedicatedHostTypes</a> operation to query the most recent dedicated host type list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddh.g5</para>
        /// </summary>
        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        /// <summary>
        /// <para>The reason why the dedicated host is locked. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>financial: The dedicated host is locked due to overdue payments.</description></item>
        /// <item><description>security: The dedicated host is locked due to security reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>financial</para>
        /// </summary>
        [NameInMap("LockReason")]
        [Validation(Required=false)]
        public string LockReason { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query. If you specify this parameter, the query is performed by using the combination of MaxResults and NextToken.</para>
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
        /// <para>Specifies whether to return the details of the dedicated host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedHostDetail")]
        [Validation(Required=false)]
        public string NeedHostDetail { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value returned from the previous call to this operation. You do not need to specify this parameter when you call this operation for the first time.</para>
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
        /// <para>This parameter will soon be deprecated. We recommend that you use NextToken and MaxResults for pagination.</para>
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
        /// <para>This parameter will soon be deprecated. We recommend that you use NextToken and MaxResults for pagination.</para>
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
        /// <para>The region ID of the dedicated host. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the dedicated host belongs. When you use this parameter to filter resources, the resource count cannot exceed 1,000.</para>
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
        /// <para>Specifies whether to display the capacity information at the socket level. You can view the remaining resource information (vCPU and memory usage, remaining amount, and total amount) at the socket level to determine whether ECS instances of the corresponding types can be created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Display the information. Only dedicated hosts of specific types support displaying socket-level resource information. For more information, see <a href="https://help.aliyun.com/document_detail/68989.html">View and export dedicated host information</a>.</description></item>
        /// <item><description>false: Do not display the information.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Generally, each dedicated host has two CPUs, and the ID of each CPU is Socket 0 or Socket 1. On an exclusive dedicated host, to ensure that the ECS instances on the dedicated host deliver maximum performance, ECS instances are not created across sockets. This means that an ECS instance is created based on only one socket.</para>
        /// <list type="bullet">
        /// <item><description>If the remaining computing resources of one socket are greater than or equal to the requirements of the ECS instance type to be created, the ECS instance is created.</description></item>
        /// <item><description>If the remaining computing resources of each socket are less than the requirements of the ECS instance type to be created, the ECS instance fails to be created. Even if the total remaining resources of the two sockets on the dedicated host meet the requirements of the ECS instance type, the ECS instance still cannot be created.</notice></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SocketDetails")]
        [Validation(Required=false)]
        public string SocketDetails { get; set; }

        /// <summary>
        /// <para>The usage status of the dedicated host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Available: The dedicated host is running. This is the normal running status of the dedicated host.</para>
        /// </description></item>
        /// <item><description><para>UnderAssessment: The physical machine has risks and is in the incubation period of a fault. The physical machine is available, but may cause issues for the ECS instances on the dedicated host.</para>
        /// </description></item>
        /// <item><description><para>PermanentFailure: A permanent failure occurred and the dedicated host is unavailable.</para>
        /// </description></item>
        /// <item><description><para>TempUnavailable: The dedicated host is temporarily unavailable.</para>
        /// </description></item>
        /// <item><description><para>Redeploying: The dedicated host is being recovered.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags. The list can contain 0 to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDedicatedHostsRequestTag> Tag { get; set; }
        public class DescribeDedicatedHostsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the dedicated host. If you specify this parameter, it cannot be an empty string. The tag key can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the dedicated host. If you specify this parameter, it can be an empty string. The tag value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
