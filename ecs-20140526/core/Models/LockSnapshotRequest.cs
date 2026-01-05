// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class LockSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate a client token. Make sure that a unique client token is used for each request. ClientToken only supports ASCII characters and cannot exceed 64 characters. For more information, see <a href="https://help.aliyun.com/zh/ecs/developer-reference/how-to-ensure-idempotence?spm=a2c4g.11186623.0.0.2a29d467Bh2sO5">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5EC38E7D-389F-1925-ABE2-D7925A8F****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Cooling-off period. In compliance mode, you can set a cooling-off period or skip the cooling-off period to directly lock the snapshot.</para>
        /// <para>During the cooling-off period, users with corresponding RAM permissions can unlock snapshots, extend or shorten the cooling-off period, and extend or shorten the lock duration. Snapshots cannot be deleted during the cooling-off period.</para>
        /// <para>After the cooling-off period ends, only extending the lock duration is supported.</para>
        /// <para>Unit: hours.</para>
        /// <para>Valid values: 0 to 72. A value of 0 indicates skipping the cooling-off period and directly locking the snapshot.</para>
        /// <para>If the snapshot has entered the compliance mode lock period, set this parameter to 0 when extending the lock duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CoolOffPeriod")]
        [Validation(Required=false)]
        public int? CoolOffPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is checked and is not executed. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the check fails, the corresponding error is returned. If the check passes, the error code DryRunOperation is returned.</description></item>
        /// <item><description>false (default): Sends a normal request, checks it, and executes the request directly if it passes the check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Lock duration. After the lock duration ends, the snapshot lock will automatically expire.</para>
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
        /// <para>The lock mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>compliance: The snapshot is locked in compliance mode. A snapshot that is locked in compliance mode cannot be unlocked by any user. It can be deleted only after the lock duration expires. Users cannot shorten the lock duration, but users with the corresponding RAM permissions can extend the lock duration at any time. When locking a snapshot in compliance mode, you can optionally specify a cooling-off period.</description></item>
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
        /// <para>The region ID You can call the <a href="https://help.aliyun.com/zh/ecs/developer-reference/api-ecs-2014-05-26-describeregions?spm=a2c4g.11186623.0.i2">DescribeRegions</a> operation to query the most recent region list.</para>
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
