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
        /// <item><description><para><b>true</b>: The minor engine version is upgraded immediately.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The minor engine version is upgraded at a specified time or within the maintenance window.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The <b>UpgradeTime</b> parameter is required if you want to upgrade the minor engine version at a specified time.</para>
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
        /// <para>The time to perform the upgrade. Specify the time in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the ApsaraDB for ClickHouse cluster is upgraded within the maintenance window.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-07T16:38Z</para>
        /// </summary>
        [NameInMap("UpgradeTime")]
        [Validation(Required=false)]
        public string UpgradeTime { get; set; }

        /// <summary>
        /// <para>The minor engine version to which you want to upgrade.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the cluster is upgraded to the latest minor engine version.</para>
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
