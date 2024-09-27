// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDeploymentSetRequest : TeaModel {
        /// <summary>
        /// <para>The description of the deployment set. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the deployment set. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, letters, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDeploymentSetName</para>
        /// </summary>
        [NameInMap("DeploymentSetName")]
        [Validation(Required=false)]
        public string DeploymentSetName { get; set; }

        /// <summary>
        /// <para>The emergency solution to use in the situation where instances in the deployment set cannot be evenly distributed to different zones due to resource insufficiency after the instances failover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CancelMembershipAndStart: removes the instances from the deployment set and starts the instances immediately after they are failed over.</description></item>
        /// <item><description>KeepStopped: leaves the instances in the Stopped state and starts them after resources are replenished.</description></item>
        /// </list>
        /// <para>Default value: CancelMembershipAndStart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>host</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>The deployment strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Availability: high availability strategy.</description></item>
        /// <item><description>AvailabilityGroup: high availability group strategy.</description></item>
        /// </list>
        /// <para>Default value: Availability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupCount")]
        [Validation(Required=false)]
        public long? GroupCount { get; set; }

        /// <summary>
        /// <para>The region ID of the deployment set. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent list of regions.</para>
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
        /// <para>Creates a deployment set in a specific region.</para>
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
        /// <item><description>Availability: high availability strategy</description></item>
        /// <item><description>AvailabilityGroup: high availability group strategy</description></item>
        /// <item><description>LowLatency: low latency strategy</description></item>
        /// </list>
        /// <para>Default value: Availability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Availability</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
