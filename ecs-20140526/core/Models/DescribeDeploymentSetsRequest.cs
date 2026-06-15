// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDeploymentSetsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the deployment sets. The value can be a JSON array that consists of up to 100 deployment set IDs. Sample format: <c>[&quot;ds-xxxxxxxxx&quot;, &quot;ds-yyyyyyyyy&quot;, … &quot;ds-zzzzzzzzz&quot;]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ds-bp67acfmxazb4ph****&quot;, &quot;ds-bp67acfmxazb4pi****&quot;, … &quot;ds-bp67acfmxazb4pj****&quot;]</para>
        /// </summary>
        [NameInMap("DeploymentSetIds")]
        [Validation(Required=false)]
        public string DeploymentSetIds { get; set; }

        /// <summary>
        /// <para>The name of the deployment set. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDeploymentSetName</para>
        /// </summary>
        [NameInMap("DeploymentSetName")]
        [Validation(Required=false)]
        public string DeploymentSetName { get; set; }

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
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Starts at 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the deployment set is located. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
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
        /// <item><description><para>Availability: high availability strategy.</para>
        /// </description></item>
        /// <item><description><para>AvailabilityGroup: high availability group strategy.</para>
        /// </description></item>
        /// <item><description><para>LowLatency: low-latency strategy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Availability</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

        /// <summary>
        /// <para>The deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>host: Ensures that the instances in the deployment set are deployed on different hosts.</para>
        /// </description></item>
        /// <item><description><para>sw: Ensures that the instances in the deployment set are deployed on different switches.</para>
        /// </description></item>
        /// <item><description><para>rack: Ensures that the instances in the deployment set are deployed on different racks.</para>
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
