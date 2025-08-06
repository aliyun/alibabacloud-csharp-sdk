// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDeploymentSetsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of deployment sets. The value can be a JSON array that consists of deployment set IDs in the format of <c>[&quot;ds-xxxxxxxxx&quot;, &quot;ds-yyyyyyyyy&quot;, ... &quot;ds-zzzzzzzzz&quot;]</c>. You can specify up to 100 deployment set IDs in each request. Separate the deployment set IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ds-bp67acfmxazb4ph****&quot;, &quot;ds-bp67acfmxazb4pi****&quot;, … &quot;ds-bp67acfmxazb4pj****&quot;]</para>
        /// </summary>
        [NameInMap("DeploymentSetIds")]
        [Validation(Required=false)]
        public string DeploymentSetIds { get; set; }

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
        /// <remarks>
        /// <para> This parameter is deprecated.</para>
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
        /// <para> This parameter is deprecated.</para>
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
        /// <para> This parameter is deprecated.</para>
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
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the deployment set. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Availability</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
