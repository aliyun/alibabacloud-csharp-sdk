// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLockedSnapshotsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform only a dry run on the request. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: Performs a dry run only. The request is not actually executed. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned. </description></item>
        /// <item><description>false (default): Sends a normal request and executes the request after it passes the dry run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The lock status. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>compliance-cooloff: The snapshot is locked in compliance mode but is still in the cool-off period. The snapshot cannot be deleted, but users with the required RAM permissions can unlock the snapshot, extend or shorten the cool-off period, and extend or shorten the lock duration. </description></item>
        /// <item><description>compliance: The snapshot is locked in compliance mode and the cool-off period has ended. The snapshot cannot be unlocked or deleted, but users with the required RAM permissions can extend the lock duration. </description></item>
        /// <item><description>expired: The snapshot was locked, but the lock duration has ended and the lock has expired. The snapshot is currently unlocked and can be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>compliance-cooloff</para>
        /// </summary>
        [NameInMap("LockStatus")]
        [Validation(Required=false)]
        public string LockStatus { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging in a paged query. Maximum value: 100. </para>
        /// <para>Default value: </para>
        /// <list type="bullet">
        /// <item><description>If no Settings are specified or the Settings value is less than 10, the default value is 10. </description></item>
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
        /// <para>The query token. Set the value to the NextToken parameter value returned from the previous API call to invoke the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>158704318252****</para>
        /// </summary>
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>158704318252****</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://www.alibabacloud.com/help/en/ecs/developer-reference/api-ecs-2014-05-26-describeregions">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>158704318252****</para>
        /// </summary>
        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>158704318252****</para>
        /// </summary>
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The snapshot IDs. Array length: 1 to 100.</para>
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public List<string> SnapshotIds { get; set; }

    }

}
