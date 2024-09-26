// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCDeploymentSetsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the deployment sets. The value can be a JSON array that consists of deployment set IDs in the format of <c>[&quot;ds-xxxxxxxxx&quot;, &quot;ds-yyyyyyyyy&quot;, ... &quot;ds-zzzzzzzzz&quot;]</c>. You can specify up to 100 deployment set IDs in each request. Separate the deployment set IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ds-2zeeuw16zo2gr9e6****&quot;]</para>
        /// </summary>
        [NameInMap("DeploymentSetIds")]
        [Validation(Required=false)]
        public string DeploymentSetIds { get; set; }

        /// <summary>
        /// <para>The deployment set name. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, letters, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>deployment_test</para>
        /// </summary>
        [NameInMap("DeploymentSetName")]
        [Validation(Required=false)]
        public string DeploymentSetName { get; set; }

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
        /// <item><description><b>Availability</b>: high availability strategy</description></item>
        /// <item><description><b>AvailabilityGroup</b>: high availability group strategy</description></item>
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
