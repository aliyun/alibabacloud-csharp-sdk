// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceHAConfigRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk543****</para>
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// <para>The High-availability Mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RPO: Data consistency is preferred. The instance ensures data reliability to the greatest extent, which minimizes the amount of data loss. Use RPO mode if you have high requirements for data consistency.</description></item>
        /// <item><description>RTO: Instance availability is preferred. The instance recovers services as soon as possible, which maximizes the active time. Use RTO mode if you have high requirements for database uptime.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RPO</para>
        /// </summary>
        [NameInMap("HAMode")]
        [Validation(Required=false)]
        public string HAMode { get; set; }

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
        /// <para>The data replication method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Semi-sync: semi-synchronous replication.</description></item>
        /// <item><description>Sync: synchronous replication.</description></item>
        /// <item><description>Async: asynchronous replication.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;- Mgr: MySQL Group Replication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sync</para>
        /// </summary>
        [NameInMap("SyncMode")]
        [Validation(Required=false)]
        public string SyncMode { get; set; }

    }

}
