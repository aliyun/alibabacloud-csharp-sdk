// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateRCDeploymentSetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deployment set name. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>deployment_test</para>
        /// </summary>
        [NameInMap("DeploymentSetName")]
        [Validation(Required=false)]
        public string DeploymentSetName { get; set; }

        /// <summary>
        /// <para>The description of the deployment set. The value must be 2 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The number of groups in the deployment set. Valid values: 1 to 7.</para>
        /// <para>Default value: 3.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when <c>Strategy is set to AvailabilityGroup</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("GroupCount")]
        [Validation(Required=false)]
        public long? GroupCount { get; set; }

        /// <summary>
        /// <para>The emergency solution to use in the scenario in which instances in the deployment set cannot be evenly distributed to different zones due to resource insufficiency after the instances failover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CancelMembershipAndStart</b>: removes the instances from the deployment set and restarts the instances immediately after the failover is complete.</description></item>
        /// <item><description><b>KeepStopped</b>: does not remove the instances from the deployment set and keeps the instances in the Stopped state.</description></item>
        /// </list>
        /// <para>Default value: CancelMembershipAndStart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CancelMembershipAndStart</para>
        /// </summary>
        [NameInMap("OnUnableToRedeployFailedInstance")]
        [Validation(Required=false)]
        public string OnUnableToRedeployFailedInstance { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The deployment strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Availability</b>: high-availability strategy</description></item>
        /// <item><description><b>AvailabilityGroup</b>: high-availability group strategy</description></item>
        /// <item><description><b>LowLatency</b>: low latency strategy</description></item>
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
