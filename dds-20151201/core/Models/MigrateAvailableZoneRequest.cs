// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class MigrateAvailableZoneRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>If the network type of the instance is VPC, you must also specify the <b>Vswitch</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1ece71ff2f****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The effective time for migrating the zone. The instance must be active. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: Takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: Takes effect during the maintenance window of the instance.</description></item>
        /// </list>
        /// <para>Default value: <b>Immediately</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The ID of destination secondary zone 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-n</para>
        /// </summary>
        [NameInMap("HiddenZoneId")]
        [Validation(Required=false)]
        public string HiddenZoneId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

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
        /// <para>The ID of destination secondary zone 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the destination zone.</para>
        /// <remarks>
        /// <para>This parameter is required when the network type of the instance is VPC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1buy0h9myt5i9e7****</para>
        /// </summary>
        [NameInMap("Vswitch")]
        [Validation(Required=false)]
        public string Vswitch { get; set; }

        /// <summary>
        /// <para>The ID of the destination zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The destination zone and the current zone of the instance are in the same region.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query zone IDs.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
