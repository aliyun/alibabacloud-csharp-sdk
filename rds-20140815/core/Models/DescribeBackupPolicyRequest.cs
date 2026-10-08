// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DataBackupPolicy</b>: data backup</description></item>
        /// <item><description><b>LogBackupPolicy</b>: log backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DataBackupPolicy</para>
        /// </summary>
        [NameInMap("BackupPolicyMode")]
        [Validation(Required=false)]
        public string BackupPolicyMode { get; set; }

        /// <summary>
        /// <para>The backup compression method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no compression</description></item>
        /// <item><description><b>1</b>: zlib compression</description></item>
        /// <item><description><b>2</b>: parallel zlib compression</description></item>
        /// <item><description><b>4</b>: QuickLZ compression with fast restoration for individual databases and tables enabled</description></item>
        /// <item><description><b>8</b>: QuickLZ compression without fast restoration for individual databases and tables supported</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
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

        /// <summary>
        /// <para>The archived backup data retention policy for deleted <b>MySQL</b> instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>None</b>: No archived backups are retained.</description></item>
        /// <item><description><b>Lastest</b>: Only the last archived backup is retained.</description></item>
        /// <item><description><b>All</b>: All archived backups are retained.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Lastest</para>
        /// </summary>
        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
