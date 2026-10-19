// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateBackupRequest : TeaModel {
        /// <summary>
        /// <para>The backup method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Snapshot</b>: snapshot backup</description></item>
        /// <item><description><b>Logical</b>: logical backup</description></item>
        /// <item><description><b>Physical</b>: physical backup (default)</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Cloud disk instances support only snapshot backup.</description></item>
        /// <item><description>Only replica set and sharded cluster instances support selecting the backup method. You do not need to specify this parameter for standalone instances. The backup method is fixed to snapshot backup.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Logical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>The retention period of the backup. This parameter is applicable only to replica set and sharded cluster instances with cloud disks.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default backup policy applies. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>7 to 730: 7 to 730 days</description></item>
        /// <item><description>-1: long-term retention</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public long? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp2235****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

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

    }

}
