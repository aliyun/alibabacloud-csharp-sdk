// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDeploymentSetRequest : TeaModel {
        /// <summary>
        /// <para>The affinity level of the deployment set. This level determines how instances are distributed within the set. The value must be an integer from 1 to 10. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public long? Affinity { get; set; }

        /// <summary>
        /// <para>A client-generated token that you can use to ensure request idempotence. The token must be unique across requests.</para>
        /// <para>The <b>ClientToken</b> value must be an ASCII string of up to 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the deployment set. The name must be 2 to 128 characters long and start with a letter. It can contain digits, colons (:), underscores (_), and hyphens (-). The name cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDeploymentSetName</para>
        /// </summary>
        [NameInMap("DeploymentSetName")]
        [Validation(Required=false)]
        public string DeploymentSetName { get; set; }

        /// <summary>
        /// <para>The description of the deployment set. The description must be 2 to 256 characters long and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The number of partitions in the deployment set group. Valid values: 1 to 7.</para>
        /// <para>Default value: 3.</para>
        /// <remarks>
        /// <para>This parameter is valid only when <c>Strategy</c> is set to <c>AvailabilityGroup</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupCount")]
        [Validation(Required=false)]
        public long? GroupCount { get; set; }

        /// <summary>
        /// <para>The policy for an instance that fails to be redeployed after a failover due to insufficient resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CancelMembershipAndStart: Removes the instance from the deployment set and starts the instance immediately after failover.</para>
        /// </description></item>
        /// <item><description><para>KeepStopped: Keeps the instance in the deployment set and in the Stopped state.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: CancelMembershipAndStart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CancelMembershipAndStart</para>
        /// </summary>
        [NameInMap("OnUnableToRedeployFailedInstance")]
        [Validation(Required=false)]
        public string OnUnableToRedeployFailedInstance { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region for the deployment set. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The deployment strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Availability: High availability strategy.</para>
        /// </description></item>
        /// <item><description><para>AvailabilityGroup: High availability strategy for deployment set groups.</para>
        /// </description></item>
        /// <item><description><para>LowLatency: Low-latency strategy.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Availability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Availability</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>The deployment granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>host: Spreads instances across different hosts.</para>
        /// </description></item>
        /// <item><description><para>sw: Spreads instances across different switches.</para>
        /// </description></item>
        /// <item><description><para>rack: Spreads instances across different racks.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
