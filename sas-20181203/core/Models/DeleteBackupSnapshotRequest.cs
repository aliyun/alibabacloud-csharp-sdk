// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteBackupSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The regions for backup.</para>
        /// </summary>
        [NameInMap("BackupRegionIdList")]
        [Validation(Required=false)]
        public List<string> BackupRegionIdList { get; set; }

        /// <summary>
        /// <para>The backup snapshots.</para>
        /// </summary>
        [NameInMap("BackupSnapshotList")]
        [Validation(Required=false)]
        public List<DeleteBackupSnapshotRequestBackupSnapshotList> BackupSnapshotList { get; set; }
        public class DeleteBackupSnapshotRequestBackupSnapshotList : TeaModel {
            /// <summary>
            /// <para>The ID of the Cloud Backup client.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to query the ID.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-000a4h33w14ka8xagb2s</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The ID of the server.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-j6cj8vyajp1fo4atxkae</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region in which Security Center is deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cn-hangzhou</b>: China (Hangzhou).</description></item>
            /// <item><description><b>ap-southeast-1</b>: Singapore.</description></item>
            /// <item><description><b>cn-beijing</b>: China (Beijing).</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot that you want to delete.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to query the ID.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-000f9p6r5trm6u4dc1iq</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_FILE</b>: Elastic Compute Service (ECS) files.</description></item>
            /// <item><description><b>OSS</b>: Object Storage Service (OSS) buckets.</description></item>
            /// <item><description><b>NAS</b>: Apsara File Storage NAS (NAS) file systems.</description></item>
            /// <item><description><b>OTS_TABLE</b>: Tablestore instances.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_FILE</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The ID of the backup vault that is used in the restoration task.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to query the ID.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v-0004vhwcs2pmacfzrzt5</para>
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to retain the latest snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RetainLatestSnapshot")]
        [Validation(Required=false)]
        public bool? RetainLatestSnapshot { get; set; }

    }

}
