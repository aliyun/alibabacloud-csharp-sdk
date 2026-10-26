// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class UpgradeKernelVersionRequest : TeaModel {
        /// <summary>
        /// <para>The database instance identity. You can obtain the value from Items[].InstanceId in the response of the ListDataMaskingInstances operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target Milvus version. You can obtain the value from KernelVersions[].KernelVersion in the response of the ListMiniEngineVersions operation.</para>
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
        /// <para>The cloud service code. Column encryption supports RDS, POLARDB, and PolarDBX2. If ProductId is also specified, the two values must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The identifier of the cloud service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: RDS.</description></item>
        /// <item><description>8: POLARDB.</description></item>
        /// <item><description>27: PolarDBX2.
        /// If this parameter is specified together with ProductCode, the values must match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The specified upgrade time. The value is a UNIX timestamp in milliseconds that have elapsed since 1970-01-01 00:00:00 UTC. Specify this parameter only when UpgradeTime is set to SpecifyTime, and the time must be later than the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1893456000000</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public long? SwitchTime { get; set; }

        /// <summary>
        /// <para>The execution time of the kernel upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Immediate: Executes the upgrade immediately.</description></item>
        /// <item><description>MaintainTime: Executes the upgrade during the maintenance window.</description></item>
        /// <item><description>SpecifyTime: Executes the upgrade at a specified time.
        /// PolarDB-X 2.0 does not support SpecifyTime.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MaintainTime</para>
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

    }

}
