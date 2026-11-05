// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class UpgradeMinorVersionRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1jyis8p15we****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The specified upgrade time. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// <remarks>
        /// <para>If SwitchTimeMode is set to SpecifyTime, you must use this parameter to specify the upgrade time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-09T05:00:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to upgrade the minor engine version immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: Upgrades immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: Upgrades within the O&amp;M window.</description></item>
        /// <item><description><b>SpecifyTime</b>: Upgrades at a specified time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// <para>The target minor engine version.</para>
        /// <remarks>
        /// <para>By default, this parameter is left empty, and the minor engine version is upgraded to the latest version.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23.8.1.41495_6</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

    }

}
