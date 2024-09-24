// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetBackupResponseBody : TeaModel {
        [NameInMap("Backup")]
        [Validation(Required=false)]
        public GetBackupResponseBodyBackup Backup { get; set; }
        public class GetBackupResponseBodyBackup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoImageCount")]
            [Validation(Required=false)]
            public long? AutoImageCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BackupHourInDay")]
            [Validation(Required=false)]
            public string BackupHourInDay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>backup-fdb897sdf****</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("BackupPeriod")]
            [Validation(Required=false)]
            public long? BackupPeriod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1682417553781</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1682417553781</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hsm-cn-5yd35431****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxImageCount")]
            [Validation(Required=false)]
            public string MaxImageCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>backup-te****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1682417553781</para>
            /// </summary>
            [NameInMap("NextImageCreateTime")]
            [Validation(Required=false)]
            public long? NextImageCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hsm-cn-huoahd****</para>
            /// </summary>
            [NameInMap("OwnerInstanceId")]
            [Validation(Required=false)]
            public string OwnerInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1641275680000</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>backup-fdb897sdfg53****</para>
            /// </summary>
            [NameInMap("SpInstanceId")]
            [Validation(Required=false)]
            public string SpInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NEW</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C467B38-3910-447D-87BC-AC049166F216</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
