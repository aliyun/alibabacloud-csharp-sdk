// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetBackupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the backup.</para>
        /// </summary>
        [NameInMap("Backup")]
        [Validation(Required=false)]
        public GetBackupResponseBodyBackup Backup { get; set; }
        public class GetBackupResponseBodyBackup : TeaModel {
            /// <summary>
            /// <para>The number of images that are automatically backed up.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoImageCount")]
            [Validation(Required=false)]
            public long? AutoImageCount { get; set; }

            /// <summary>
            /// <para>The backup time in the 24-hour format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BackupHourInDay")]
            [Validation(Required=false)]
            public string BackupHourInDay { get; set; }

            /// <summary>
            /// <para>The ID of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup-fdb897sdf****</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The automatic backup cycle. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BackupPeriod")]
            [Validation(Required=false)]
            public long? BackupPeriod { get; set; }

            /// <summary>
            /// <para>The time when the backup is created. The value is accurate to the millisecond. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1682417553781</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the backup. The value is accurate to the millisecond. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1682417553781</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the hardware security module (HSM) that is associated with the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hsm-cn-5yd35431****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The maximum number of images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxImageCount")]
            [Validation(Required=false)]
            public string MaxImageCount { get; set; }

            /// <summary>
            /// <para>The name of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup-te****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The next time when the image is created. The value is accurate to the millisecond. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1682417553781</para>
            /// </summary>
            [NameInMap("NextImageCreateTime")]
            [Validation(Required=false)]
            public long? NextImageCreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the HSM to which the backup belongs. This parameter is available only for HSM backups outside the Chinese mainland and the value of this parameter is consistent with the value of InstanceId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hsm-cn-huoahd****</para>
            /// </summary>
            [NameInMap("OwnerInstanceId")]
            [Validation(Required=false)]
            public string OwnerInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The time when the backup is released. The value is accurate to the millisecond. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641275680000</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The description of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The ID of the backup. This parameter is available only for HSM backups in the Chinese mainland.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup-fdb897sdfg53****</para>
            /// </summary>
            [NameInMap("SpInstanceId")]
            [Validation(Required=false)]
            public string SpInstanceId { get; set; }

            /// <summary>
            /// <para>The status of the backup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NEW</description></item>
            /// <item><description>EXPIRED</description></item>
            /// <item><description>ENABLED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NEW</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the backup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEFAULT</description></item>
            /// <item><description>NORMAL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-447D-87BC-AC049166F216</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
