// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CancelAutoSnapshotPolicyRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy that you want to cancel.</para>
        /// <list type="bullet">
        /// <item><description>Default value: empty. If you use the default value, note the following items:<list type="bullet">
        /// <item><description>If only one automatic snapshot policy is applied to the cloud disk, the automatic snapshot policy is canceled.</description></item>
        /// <item><description>If more than one automatic snapshot policy is applied to the cloud disk, the <c>OperationDenied.TooManyAutoSnapshotPolicies</c> error code is returned and the request fails. Specify the <c>autoSnapshotPolicyId</c> parameter to specify the ID of the automatic snapshot policy that you want to cancel.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sp-bp14yziiuvu3s6jn****</para>
        /// </summary>
        [NameInMap("autoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud disks. To cancel the automatic snapshot policy for multiple cloud disks, specify the cloud disk IDs in a JSON array in the format of &quot;d-xxxxxxxxx&quot;, &quot;d-yyyyyyyyy&quot;, … &quot;d-zzzzzzzzz&quot;. Separate multiple cloud disk IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;d-bp14k9cxvr5uzy54****&quot;, &quot;d-bp1dtj8v7x6u08iw****&quot;, &quot;d-bp1c0tyj9tfli2r8****&quot;]</para>
        /// </summary>
        [NameInMap("diskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// <para>The region ID of the automatic snapshot policy and cloud disks. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
