// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteBackupSnapshotRequest : TeaModel {
        /// <summary>
        /// <para>The backup regions.</para>
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
            /// <para>The ID of the backup client.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-000a4h33w14ka8xa****</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The ID of the server instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-j6cj8vyajp1fo4at****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region of the Security Center instance. Valid values:</para>
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
            /// <para>The ID of the snapshot to delete.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-000f9p6r5trm6u4d****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_FILE</b>: backup snapshot of ECS files.</description></item>
            /// <item><description><b>OSS</b>: backup snapshot of Alibaba Cloud OSS.</description></item>
            /// <item><description><b>NAS</b>: backup snapshot of Alibaba Cloud NAS.</description></item>
            /// <item><description><b>OTS_TABLE</b>: backup snapshot of Alibaba Cloud Tablestore.</description></item>
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
            /// <para>The ID of the backup vault for the restoration task.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~DescribeSnapshots~~">DescribeSnapshots</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v-0004vhwcs2pmacfz****</para>
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to retain the latest snapshot. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: retains the latest snapshot.</description></item>
        /// <item><description><b>false</b>: does not retain the latest snapshot.</description></item>
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
