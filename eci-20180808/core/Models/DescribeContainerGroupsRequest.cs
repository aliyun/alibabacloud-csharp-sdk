// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The compute category of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>economy</description></item>
        /// <item><description>general</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>economy</para>
        /// </summary>
        [NameInMap("ComputeCategory")]
        [Validation(Required=false)]
        public string ComputeCategory { get; set; }

        /// <summary>
        /// <para>The IDs of the elastic container instances in JSON format. You can specify up to 20 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;eci-bp17gw49eu09yiwm****&quot;, &quot;eci-bp19aq49du01abcm****&quot;, &quot;eci-2zegym1qhbmdfr1s****&quot;]</para>
        /// </summary>
        [NameInMap("ContainerGroupIds")]
        [Validation(Required=false)]
        public string ContainerGroupIds { get; set; }

        /// <summary>
        /// <para>The name of the elastic container instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        /// <summary>
        /// <para>The maximum number of resources to return. Default value: 20. Maximum value: 20.</para>
        /// <remarks>
        /// <para> The number of returned resources is less than or equal to the specified number.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the query. If this parameter is left empty, all results have been returned.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter in the first request. Starting from the second request, you can obtain the token from the result returned by the previous request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d78f2dd8-5979-42fe-****-b16db43be5bc</para>
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
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzh43v*****</para>
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
        /// <para>sg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The status of the elastic container instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: The instance is being started.</description></item>
        /// <item><description>Running: The instance is running.</description></item>
        /// <item><description>Succeeded: The instance runs successfully.</description></item>
        /// <item><description>Failed: The instance fails to run.</description></item>
        /// <item><description>Scheduling: The instance is being created.</description></item>
        /// <item><description>ScheduleFailed: The instance fails to be created.</description></item>
        /// <item><description>Restarting: The instance is being restarted.</description></item>
        /// <item><description>Updating: The instance is being updated.</description></item>
        /// <item><description>Terminating: The instance is being terminated.</description></item>
        /// <item><description>Expired: The instance expires.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag of the instances.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupsRequestTag> Tag { get; set; }
        public class DescribeContainerGroupsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch to which the elastic container instances are connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1jrgfqqy54kg5hc****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>Specify whether to return event information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithEvent")]
        [Validation(Required=false)]
        public bool? WithEvent { get; set; }

        /// <summary>
        /// <para>The ID of the zone in which the elastic container instances are deployed. If you do not specify this parameter, the system selects a zone.</para>
        /// <para>This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
