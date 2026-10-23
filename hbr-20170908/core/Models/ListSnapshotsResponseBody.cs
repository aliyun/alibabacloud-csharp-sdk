// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class ListSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The maximum number of returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned message. A value of successful indicates success. If an error occurs, the corresponding error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next page. If NextToken is empty, no more pages exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aWQj********MCMy</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17189276-<b><b>-</b></b>-****-0FF51B5A41A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of backup points.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<ListSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class ListSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>The actual amount of data written, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public long? ActualBytes { get; set; }

            /// <summary>
            /// <para>The actual number of items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("ActualItems")]
            [Validation(Required=false)]
            public long? ActualItems { get; set; }

            /// <summary>
            /// <para>The archive time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640334062</para>
            /// </summary>
            [NameInMap("ArchiveTime")]
            [Validation(Required=false)]
            public long? ArchiveTime { get; set; }

            /// <summary>
            /// <para>The backup type. A value of <b>COMPLETE</b> indicates a full backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The amount of backed up data, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("BytesDone")]
            [Validation(Required=false)]
            public long? BytesDone { get; set; }

            /// <summary>
            /// <para>The total amount of data to back up, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("BytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            /// <summary>
            /// <para>The ID of the backup client when the value of <b>SourceType</b> is <b>ECS_FILE</b> or <b>File</b>. In other cases, this parameter indicates the ID of the backup data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-*********************</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The backup completion time. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642496679</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public long? CompleteTime { get; set; }

            /// <summary>
            /// <para>The creation time of the backup point, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607436917</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The backup creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642496679</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The file that records backup failure information, including information about partially completed backups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>temp/report/123456789/job-xxxxxxxxx_failed.zip</para>
            /// </summary>
            [NameInMap("ErrorFile")]
            [Validation(Required=false)]
            public string ErrorFile { get; set; }

            /// <summary>
            /// <para>The source paths excluded from the backup job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;/test/example_cn-hangzhou_7.txt\&quot;, \&quot;/test/example_cn-hangzhou_1.txt\&quot;, \&quot;/test/example_cn-hangzhou_3.txt\&quot;, \&quot;/test/example_cn-hangzhou_9.txt\&quot;, \&quot;/test/example_cn-hangzhou_6.txt\&quot;]</para>
            /// </summary>
            [NameInMap("Exclude")]
            [Validation(Required=false)]
            public string Exclude { get; set; }

            /// <summary>
            /// <para>The expiration time of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1771901707</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The source paths included in the backup job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;/test/example_cn-huhehaote_3.txt\&quot;, \&quot;/test/example_cn-huhehaote_9.txt\&quot;, \&quot;/test/example_cn-huhehaote_5.txt\&quot;, \&quot;/test/example_cn-huhehaote_1.txt\&quot;, \&quot;/test/example_cn-huhehaote_7.txt\&quot;]</para>
            /// </summary>
            [NameInMap("Include")]
            [Validation(Required=false)]
            public string Include { get; set; }

            /// <summary>
            /// <para>The instance ID of the backup data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-*********************</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the Tablestore instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instancename</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The number of backed up items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("ItemsDone")]
            [Validation(Required=false)]
            public long? ItemsDone { get; set; }

            /// <summary>
            /// <para>The total number of items to back up.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ItemsTotal")]
            [Validation(Required=false)]
            public long? ItemsTotal { get; set; }

            /// <summary>
            /// <para>The ID of the backup job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-00030j3chkt******2</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The backup path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The list of backup paths.</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// <para>The ID of the backup plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>po-123***7890</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The size of the protected source data, in bytes. When the value of SourceType is ECS_FILE, this parameter indicates the capacity of the protected cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42949672960</para>
            /// </summary>
            [NameInMap("ProtectedDataSize")]
            [Validation(Required=false)]
            public long? ProtectedDataSize { get; set; }

            /// <summary>
            /// <para>The end time of the Tablestore backup job. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642521709966</para>
            /// </summary>
            [NameInMap("RangeEnd")]
            [Validation(Required=false)]
            public long? RangeEnd { get; set; }

            /// <summary>
            /// <para>The start time of the Tablestore backup job. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642492553038</para>
            /// </summary>
            [NameInMap("RangeStart")]
            [Validation(Required=false)]
            public long? RangeStart { get; set; }

            /// <summary>
            /// <para>The retention period of the backup, in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>The hash value of the backup point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f2ac5fd243**********************bc4451777be019</para>
            /// </summary>
            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            /// <summary>
            /// <para>The ID of the backup point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-00047mxg17p26*****b</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_FILE</b>: ECS file backup</description></item>
            /// <item><description><b>File</b>: on-premises file backup</description></item>
            /// <item><description><b>OSS</b>: OSS backup</description></item>
            /// <item><description><b>NAS</b>: Alibaba Cloud NAS backup</description></item>
            /// <item><description><b>COMMON_NAS</b>: on-premises NAS backup</description></item>
            /// <item><description><b>CONTAINER</b>: container backup</description></item>
            /// <item><description><b>OTS_TABLE</b>: Tablestore backup</description></item>
            /// <item><description><b>COMMON_FILE_SYSTEM</b>: CPFS backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_FILE</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The status of the backup point. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage class. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// <para>The name of the data table in the Tablestore instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table2</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The ID of the vault that stores the backup data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v-00030j*******sn</para>
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
