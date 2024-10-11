// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class UpgradeMinorVersionRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-bp108z124a8o7****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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
        /// <para>Specifies whether to update the minor engine version of the ApsaraDB for ClickHouse cluster immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: updates the minor engine version of the ApsaraDB for ClickHouse cluster immediately.</description></item>
        /// <item><description><b>false</b>: updates the minor engine version of the ApsaraDB for ClickHouse cluster at the specified time or within the specified maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you want to update the minor engine version of the ApsaraDB for ClickHouse cluster at the specified time, <b>UpgradeTime</b> is required.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpgradeImmediately")]
        [Validation(Required=false)]
        public bool? UpgradeImmediately { get; set; }

        /// <summary>
        /// <para>The update time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in Coordinated Universal Time (UTC).</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the minor engine version of an ApsaraDB for ClickHouse cluster is updated within the specified maintenance window.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-07T16:38Z</para>
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

        /// <summary>
        /// <para>The minor engine version to which you want to update.</para>
        /// <remarks>
        /// <para> By default, UpgradeVersion is not set and the minor engine version of the ApsaraDB for ClickHouse cluster is updated to the latest version.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1.37.0</para>
        /// </summary>
        [NameInMap("UpgradeVersion")]
        [Validation(Required=false)]
        public string UpgradeVersion { get; set; }

    }

}
