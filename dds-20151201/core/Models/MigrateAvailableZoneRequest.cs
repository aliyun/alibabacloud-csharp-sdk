// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class MigrateAvailableZoneRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>If the instance is deployed in a VPC, you must specify the <b>Vswitch</b> parameter.</para>
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
        /// <para>The time when the instance is migrated to the destination zone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b>: The instance is immediately migrated to the destination zone.</description></item>
        /// <item><description><b>MaintainTime</b>: The instance is migrated to the destination zone during the maintenance window of the instance.</description></item>
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
        /// <para>The ID of the destination hidden zone.</para>
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
        /// <para>The ID of the destination secondary zone.</para>
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
        /// <para>If the instance is deployed in a VPC, you must specify this parameter.</para>
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
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The source zone and the destination zone belong to the same region.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the zone ID.</para>
        /// </description></item>
        /// </list>
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
