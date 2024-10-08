// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeOtsTableSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of backup snapshots that are displayed on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token that is required to obtain the next page of backup snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09376812-6290-5E36-B504-E8010D72D1F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The backup snapshots.</para>
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeOtsTableSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeOtsTableSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// <para>The actual data amount of backup snapshots after duplicates are removed. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public string ActualBytes { get; set; }

            /// <summary>
            /// <para>The backup type. Valid value: <b>COMPLETE</b>, which indicates full backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The total amount of data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            /// <summary>
            /// <para>The time when the backup snapshot was completed. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642496679</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public long? CompleteTime { get; set; }

            /// <summary>
            /// <para>The time when the Tablestore instance was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607436917</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the backup snapshot was created. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642496679</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

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
            /// <para>The ID of the backup job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-00030j3chkt******2</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The hash value of the parent backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f2fe..</para>
            /// </summary>
            [NameInMap("ParentSnapshotHash")]
            [Validation(Required=false)]
            public string ParentSnapshotHash { get; set; }

            /// <summary>
            /// <para>The time when the backup job ended. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642521709966</para>
            /// </summary>
            [NameInMap("RangeEnd")]
            [Validation(Required=false)]
            public long? RangeEnd { get; set; }

            /// <summary>
            /// <para>The time when the backup job started. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642492553038</para>
            /// </summary>
            [NameInMap("RangeStart")]
            [Validation(Required=false)]
            public long? RangeStart { get; set; }

            /// <summary>
            /// <para>The retention period of the backup snapshot. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>730</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>The hash value of the backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f2fe...</para>
            /// </summary>
            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            /// <summary>
            /// <para>The ID of the backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-00047mxg17p26*****b</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_FILE</b>: backup snapshots for Elastic Compute Service (ECS) files</description></item>
            /// <item><description><b>OSS</b>: backup snapshots for Object Storage Service (OSS) buckets</description></item>
            /// <item><description><b>NAS</b>: backup snapshots for Apsara File Storage NAS file systems</description></item>
            /// <item><description><b>OTS_TABLE</b>: backup snapshots for Tablestore instances</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OTS_TABLE</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The time when the backup snapshot started. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642496543</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the backup job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>COMPLETE</b>: The backup job is completed.</description></item>
            /// <item><description><b>PARTIAL_COMPLETE</b>: The backup job is partially completed.</description></item>
            /// <item><description><b>FAILED</b>: The backup job has failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the table in the Tablestore instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table2</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The time when the backup snapshot was updated. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1642496679</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the backup vault that stores the backup snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v-00030j*******sn</para>
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
