// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class CreateBackupRequest : TeaModel {
        /// <summary>
        /// <para>The backup method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Snapshot</b>: A snapshot backup.</para>
        /// </description></item>
        /// <item><description><para><b>Logical</b>: A logical backup.</para>
        /// </description></item>
        /// <item><description><para><b>Physical</b> (default): A physical backup.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Instances with cloud disks support only snapshot backups.</para>
        /// </description></item>
        /// <item><description><para>This parameter applies only to replica set and sharded cluster instances. This parameter is not required for standalone instances, which use snapshot backups.</para>
        /// </description></item>
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
        /// <para>The backup retention period in days. This parameter applies only to replica set and sharded cluster instances that use cloud disks.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the retention period from the default backup policy is used. You can set this parameter to one of the following values:</para>
        /// <list type="bullet">
        /// <item><description><para>A value from 7 to 730</para>
        /// </description></item>
        /// <item><description><para>-1 (permanent retention)</para>
        /// </description></item>
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
