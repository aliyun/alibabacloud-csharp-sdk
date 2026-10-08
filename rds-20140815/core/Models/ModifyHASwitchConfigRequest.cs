// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyHASwitchConfigRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The primary/secondary switchover setting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Auto</b>: The system automatically switches over between the primary and secondary instances upon a fault.</description></item>
        /// <item><description><b>Manual</b>: Temporarily disables automatic switchover.</description></item>
        /// </list>
        /// <para>Default value: <b>Auto</b>.</para>
        /// <remarks>
        /// <para>If you set this parameter to <b>Manual</b>, you must also specify the <b>ManualHATime</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("HAConfig")]
        [Validation(Required=false)]
        public string HAConfig { get; set; }

        /// <summary>
        /// <para>The deadline for temporarily disabling automatic switchover. You can set this parameter to a point in time up to 23:59:59 seven days later. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>HAConfig</b> is set to <b>Manual</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-29T15:00:00Z</para>
        /// </summary>
        [NameInMap("ManualHATime")]
        [Validation(Required=false)]
        public string ManualHATime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the region ID.</para>
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
