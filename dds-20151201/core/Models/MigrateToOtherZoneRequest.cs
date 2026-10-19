// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class MigrateToOtherZoneRequest : TeaModel {
        /// <summary>
        /// <para>The effective period for the zone migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediately</b> (default): The migration becomes active immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The migration becomes active within the O&amp;M window of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>If the network type of the instance is VPC, you must also specify the <b>VSwitchId</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp2658****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>The ID of the vSwitch in the destination zone.</para>
        /// <remarks>
        /// <para>This parameter is available and required only when the network type of the instance is VPC.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp67ac****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The destination zone must be in the same region as the current zone of the instance.</description></item>
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
