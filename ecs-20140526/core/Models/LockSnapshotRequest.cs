// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class LockSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>A unique, case-sensitive token that you provide to ensure the idempotence of the request. The token can contain only ASCII characters and must not exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/zh/ecs/developer-reference/how-to-ensure-idempotence?spm=a2c4g.11186623.0.0.2a29d467Bh2sO5">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5EC38E7D-389F-1925-ABE2-D7925A8F****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cool-off period. In compliance mode, you can specify a cool-off period or set this parameter to 0 to lock the snapshot immediately.</para>
        /// <para>During the cool-off period, users with the required RAM permissions can unlock the snapshot, extend or shorten the cool-off period, and extend or shorten the lock duration. The snapshot cannot be deleted during the cool-off period.</para>
        /// <para>After the cool-off period ends, you can only extend the lock duration.</para>
        /// <para>Unit: hours.</para>
        /// <para>Valid values: 0 to 72. A value of 0 indicates that the cool-off period is skipped and the snapshot is locked immediately.</para>
        /// <para>If a snapshot is already locked in compliance mode, you must set this parameter to 0 to extend its lock duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CoolOffPeriod")]
        [Validation(Required=false)]
        public int? CoolOffPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Performs a dry run to check the request without executing it. The system checks for required parameters, request format, business constraints, and permissions. If the check passes, the <c>DryRunOperation</c> error code is returned. If the check fails, a corresponding error is returned.</para>
        /// </description></item>
        /// <item><description><para><c>false</c> (default): Checks the request and, if the checks pass, executes the operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The number of days to lock the snapshot. The lock automatically expires at the end of this period.</para>
        /// <para>Unit: days.</para>
        /// <para>Valid values: 1 to 36500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LockDuration")]
        [Validation(Required=false)]
        public int? LockDuration { get; set; }

        /// <summary>
        /// <para>The lock mode. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>compliance</c>: Locks the snapshot in compliance mode. A snapshot locked in compliance mode cannot be unlocked by any user and can be deleted only after its lock duration expires. You cannot shorten the lock duration. However, users with the required RAM permissions can extend the lock duration at any time. When you lock a snapshot in compliance mode, you can optionally specify a cool-off period.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compliance</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/zh/ecs/developer-reference/api-ecs-2014-05-26-describeregions?spm=a2c4g.11186623.0.i2">DescribeRegions</a> to get the latest list of Alibaba Cloud regions.</para>
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
        /// <para>The snapshot ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-9dp2qojdpdfmgfmf****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
