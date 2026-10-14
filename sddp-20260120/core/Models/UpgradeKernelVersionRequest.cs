// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class UpgradeKernelVersionRequest : TeaModel {
        /// <summary>
        /// <para>The database instance identity. You can obtain this value from Items[].InstanceId returned by ListDataMaskingInstances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target kernel version. You can obtain this value from KernelVersions[].KernelVersion returned by ListMiniEngineVersions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_20220731</para>
        /// </summary>
        [NameInMap("KernelVersion")]
        [Validation(Required=false)]
        public string KernelVersion { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The cloud product code. Column encryption supports RDS, POLARDB, and PolarDBX2. If you also specify ProductId, the two values must correspond to each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The cloud product type identifier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: RDS.</description></item>
        /// <item><description>8: POLARDB.</description></item>
        /// <item><description>27: PolarDBX2.</description></item>
        /// </list>
        /// <para>If you specify both ProductId and ProductCode, the values must correspond to each other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The specified upgrade time. This value is a UNIX timestamp in milliseconds since 1970-01-01 00:00:00 UTC. Specify this parameter only when UpgradeTime is set to SpecifyTime. The value must be later than the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1893456000000</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public long? SwitchTime { get; set; }

        /// <summary>
        /// <para>The time at which the kernel upgrade is performed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Immediate: The upgrade is performed immediately.</description></item>
        /// <item><description>MaintainTime: The upgrade is performed during the maintenance window.</description></item>
        /// <item><description>SpecifyTime: The upgrade is performed at a specified time.</description></item>
        /// </list>
        /// <para>PolarDB-X 2.0 does not support SpecifyTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaintainTime</para>
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

    }

}
