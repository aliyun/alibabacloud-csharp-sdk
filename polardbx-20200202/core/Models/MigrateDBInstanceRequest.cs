// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class MigrateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-xxx</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary zone for a multi-zone instance. <b>This parameter is required if you want to create a multi-zone instance.</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou-b</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The secondary zone ID.</para>
        /// <remarks>
        /// <para>This parameter cannot be set to the same value as ZoneId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-l</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The switchover mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: immediately switches over.</description></item>
        /// <item><description>1: switches over within the O&amp;M window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

        /// <summary>
        /// <para>The zone ID for Three-zone deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("TertiaryZoneId")]
        [Validation(Required=false)]
        public string TertiaryZoneId { get; set; }

        /// <summary>
        /// <para>The topology type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3azones</b>: three-zone deployment.</description></item>
        /// <item><description><b>1azone</b>: single-zone deployment.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3azones</para>
        /// </summary>
        [NameInMap("TopologyType")]
        [Validation(Required=false)]
        public string TopologyType { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) where the access endpoint resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. This parameter is required when you create a DRDS instance of the VPC network type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
