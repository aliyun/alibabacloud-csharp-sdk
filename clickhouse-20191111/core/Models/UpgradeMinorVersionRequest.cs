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
        /// <para>Specifies whether to upgrade the minor engine version immediately. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Upgrades the minor engine version immediately.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Upgrades the minor engine version at a specified time or during the maintenance window.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify a time to upgrade the minor engine version, <b>UpgradeTime</b> is required.</para>
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
        /// <para>The specified upgrade time. Format: yyyy-MM-ddTHH:mmZ (UTC time).</para>
        /// <remarks>
        /// <para>If this parameter is left empty, the ApsaraDB for ClickHouse cluster performs a minor kernel version upgrade during the maintenance window.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-07T16:38Z</para>
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

        /// <summary>
        /// <para>The target minor engine version.</para>
        /// <remarks>
        /// <para>By default, this parameter is left empty, and the minor engine version is upgraded to the latest version.</para>
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
