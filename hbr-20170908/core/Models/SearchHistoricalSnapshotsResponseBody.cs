// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class SearchHistoricalSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The number of historical backup snapshots that are displayed on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The message that is returned. If the call is successful, &quot;successful&quot; is returned. If the call fails, an error message is returned.</para>
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
        /// <para>BE</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public SearchHistoricalSnapshotsResponseBodySnapshots Snapshots { get; set; }
        public class SearchHistoricalSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("Snapshot")]
            [Validation(Required=false)]
            public List<SearchHistoricalSnapshotsResponseBodySnapshotsSnapshot> Snapshot { get; set; }
            public class SearchHistoricalSnapshotsResponseBodySnapshotsSnapshot : TeaModel {
                [NameInMap("ActualBytes")]
                [Validation(Required=false)]
                public long? ActualBytes { get; set; }

                [NameInMap("ActualItems")]
                [Validation(Required=false)]
                public long? ActualItems { get; set; }

                [NameInMap("ArchiveTime")]
                [Validation(Required=false)]
                public long? ArchiveTime { get; set; }

                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("BytesDone")]
                [Validation(Required=false)]
                public long? BytesDone { get; set; }

                [NameInMap("BytesTotal")]
                [Validation(Required=false)]
                public long? BytesTotal { get; set; }

                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public long? CompleteTime { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("ErrorFile")]
                [Validation(Required=false)]
                public string ErrorFile { get; set; }

                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public string Exclude { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("Include")]
                [Validation(Required=false)]
                public string Include { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("ItemsDone")]
                [Validation(Required=false)]
                public long? ItemsDone { get; set; }

                [NameInMap("ItemsTotal")]
                [Validation(Required=false)]
                public long? ItemsTotal { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("ParentSnapshotHash")]
                [Validation(Required=false)]
                public string ParentSnapshotHash { get; set; }

                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public SearchHistoricalSnapshotsResponseBodySnapshotsSnapshotPaths Paths { get; set; }
                public class SearchHistoricalSnapshotsResponseBodySnapshotsSnapshotPaths : TeaModel {
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public List<string> Path { get; set; }

                }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>42949672960</para>
                /// </summary>
                [NameInMap("ProtectedDataSize")]
                [Validation(Required=false)]
                public long? ProtectedDataSize { get; set; }

                [NameInMap("RangeEnd")]
                [Validation(Required=false)]
                public long? RangeEnd { get; set; }

                [NameInMap("RangeStart")]
                [Validation(Required=false)]
                public long? RangeStart { get; set; }

                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                [NameInMap("SnapshotHash")]
                [Validation(Required=false)]
                public string SnapshotHash { get; set; }

                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                [NameInMap("SourceParentSnapshotHash")]
                [Validation(Required=false)]
                public string SourceParentSnapshotHash { get; set; }

                [NameInMap("SourceSnapshotHash")]
                [Validation(Required=false)]
                public string SourceSnapshotHash { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                [NameInMap("UseCommonNas")]
                [Validation(Required=false)]
                public bool? UseCommonNas { get; set; }

                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned backup snapshots that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
