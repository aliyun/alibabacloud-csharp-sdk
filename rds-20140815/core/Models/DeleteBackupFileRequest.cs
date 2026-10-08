// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteBackupFileRequest : TeaModel {
        /// <summary>
        /// <para>The backup set IDs. Only backup set IDs of individual database backup policies are supported. You can specify up to 100 backup set IDs at a time. Separate multiple IDs with commas (,). You can call DescribeBackups to obtain the backup set IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29304****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>Deletes backup files that were created before the specified point in time. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-11T16:00:00Z</para>
        /// </summary>
        [NameInMap("BackupTime")]
        [Validation(Required=false)]
        public string BackupTime { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeDBInstanceAttribute to obtain the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
