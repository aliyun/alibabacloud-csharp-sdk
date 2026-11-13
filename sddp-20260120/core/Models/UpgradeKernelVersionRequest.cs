// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class UpgradeKernelVersionRequest : TeaModel {
        /// <summary>
        /// <para>The database instance identity. You can obtain this value from the Items[].InstanceId field in the ListDataMaskingInstances response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1abcdefgh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target Milvus version. You can obtain this value from the KernelVersions[].KernelVersion field in the ListMiniEngineVersions response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_20220731</para>
        /// </summary>
        [NameInMap("KernelVersion")]
        [Validation(Required=false)]
        public string KernelVersion { get; set; }

        /// <summary>
        /// <para>The language of the response description. Valid values: zh: Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The product code. Column encryption supports RDS, POLARDB, and PolarDBX2. If you specify both ProductCode and ProductId, they must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product type identifier. Valid values: 5: RDS. 8: POLARDB. 27: PolarDBX2. If you specify both ProductId and ProductCode, they must match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The specified upgrade time. The value is a UNIX timestamp in milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Specify this parameter only when UpgradeTime is set to SpecifyTime. The time must be later than the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1893456000000</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public long? SwitchTime { get; set; }

        /// <summary>
        /// <para>The execution time for the kernel upgrade. Valid values: Immediate: Executes the upgrade immediately. MaintainTime: Executes the upgrade during the maintenance window. SpecifyTime: Executes the upgrade at a specified time. PolarDB-X 2.0 does not support SpecifyTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaintainTime</para>
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

    }

}
