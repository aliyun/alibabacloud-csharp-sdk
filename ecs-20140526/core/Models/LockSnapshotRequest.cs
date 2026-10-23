// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class LockSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://www.alibabacloud.com/help/en/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5EC38E7D-389F-1925-ABE2-D7925A8F****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cool-off period. In compliance mode, you can set a cool-off period or skip the cool-off period to lock the snapshot directly. </para>
        /// <para>During the cool-off period, users with the required RAM permissions can unlock the snapshot, extend or shorten the cool-off period, and extend or shorten the lock duration. The snapshot cannot be deleted during the cool-off period. </para>
        /// <para>After the cool-off period ends, you can only extend the lock duration. </para>
        /// <para>Unit: hours. </para>
        /// <para>Valid values: 0 to 72. A value of 0 indicates that the cool-off period is skipped and the snapshot is locked directly. </para>
        /// <para>If the snapshot has entered the compliance mode lock period, you must set this parameter to 0 to extend the lock duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CoolOffPeriod")]
        [Validation(Required=false)]
        public int? CoolOffPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: sends a check request. The operation is not performed. The system checks whether required parameters are specified, the request format is valid, and the service limits are met. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned. </description></item>
        /// <item><description>false (default): sends a normal request. The request is executed after the check succeeds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The lock duration. The snapshot lock automatically expires after the lock duration ends. </para>
        /// <para>Unit: days. </para>
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
        /// <para>The lock mode. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>compliance: locks the snapshot in compliance mode. A snapshot locked in compliance mode cannot be unlocked by any user and can be deleted only after the lock duration expires. Users cannot shorten the lock duration, but users with the required RAM permissions can extend the lock duration at any time. When you lock a snapshot in compliance mode, you can optionally specify a cool-off period.</description></item>
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
