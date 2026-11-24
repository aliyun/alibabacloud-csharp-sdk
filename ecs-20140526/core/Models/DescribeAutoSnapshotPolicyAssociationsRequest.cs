// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoSnapshotPolicyAssociationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the automatic snapshot policy.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one of the AutoSnapshotPolicyId and DiskId parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sp-bp12quk7gqhhuu1f****</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one of the AutoSnapshotPolicyId and DiskId parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. The maximum paging value is 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify Settings or the Settings value is less than 10, the default value is 10.</description></item>
        /// <item><description>If the Settings value is greater than 100, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. The value is the <c>NextToken</c> parameter value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
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
        /// <para>The region ID of the automatic snapshot policy. You can call the <a href="https://www.alibabacloud.com/help/en/ecs/developer-reference/api-ecs-2014-05-26-describeregions">DescribeRegions</a> operation to query the most recent region list.</para>
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

    }

}
