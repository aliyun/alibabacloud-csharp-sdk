// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class UpgradeMinorVersionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp1jyis8p15we****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-01-09T05:00:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to update the minor engine version of the cluster immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: The system immediately performs the update.</description></item>
        /// <item><description><b>MaintainTime</b>: The system performs the update during the specified maintenance window.</description></item>
        /// <item><description><b>SpecifyTime</b>: The system performs the update at a specified time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Immediate</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23.8.1.41495_6</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

    }

}
