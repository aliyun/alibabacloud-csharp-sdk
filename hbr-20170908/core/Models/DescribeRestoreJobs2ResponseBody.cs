// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeRestoreJobs2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RestoreJobs")]
        [Validation(Required=false)]
        public DescribeRestoreJobs2ResponseBodyRestoreJobs RestoreJobs { get; set; }
        public class DescribeRestoreJobs2ResponseBodyRestoreJobs : TeaModel {
            [NameInMap("RestoreJob")]
            [Validation(Required=false)]
            public List<DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJob> RestoreJob { get; set; }
            public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJob : TeaModel {
                [NameInMap("ActualBytes")]
                [Validation(Required=false)]
                public long? ActualBytes { get; set; }

                [NameInMap("ActualItems")]
                [Validation(Required=false)]
                public long? ActualItems { get; set; }

                [NameInMap("BytesDone")]
                [Validation(Required=false)]
                public long? BytesDone { get; set; }

                [NameInMap("BytesTotal")]
                [Validation(Required=false)]
                public long? BytesTotal { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public long? CompleteTime { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("CrossAccountRoleName")]
                [Validation(Required=false)]
                public string CrossAccountRoleName { get; set; }

                [NameInMap("CrossAccountType")]
                [Validation(Required=false)]
                public string CrossAccountType { get; set; }

                [NameInMap("CrossAccountUserId")]
                [Validation(Required=false)]
                public long? CrossAccountUserId { get; set; }

                [NameInMap("ErrorFile")]
                [Validation(Required=false)]
                public string ErrorFile { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public string Exclude { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                [NameInMap("FailbackDetail")]
                [Validation(Required=false)]
                public string FailbackDetail { get; set; }

                [NameInMap("Include")]
                [Validation(Required=false)]
                public string Include { get; set; }

                [NameInMap("ItemsDone")]
                [Validation(Required=false)]
                public long? ItemsDone { get; set; }

                [NameInMap("ItemsTotal")]
                [Validation(Required=false)]
                public long? ItemsTotal { get; set; }

                [NameInMap("MeteringBytesDone")]
                [Validation(Required=false)]
                public long? MeteringBytesDone { get; set; }

                [NameInMap("MeteringBytesTotal")]
                [Validation(Required=false)]
                public long? MeteringBytesTotal { get; set; }

                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                [NameInMap("OtsDetail")]
                [Validation(Required=false)]
                public DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobOtsDetail OtsDetail { get; set; }
                public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobOtsDetail : TeaModel {
                    [NameInMap("BatchChannelCount")]
                    [Validation(Required=false)]
                    public int? BatchChannelCount { get; set; }

                    [NameInMap("OverwriteExisting")]
                    [Validation(Required=false)]
                    public bool? OverwriteExisting { get; set; }

                }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("Report")]
                [Validation(Required=false)]
                public DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobReport Report { get; set; }
                public class DescribeRestoreJobs2ResponseBodyRestoreJobsRestoreJobReport : TeaModel {
                    [NameInMap("FailedFiles")]
                    [Validation(Required=false)]
                    public string FailedFiles { get; set; }

                    [NameInMap("ReportTaskStatus")]
                    [Validation(Required=false)]
                    public string ReportTaskStatus { get; set; }

                    [NameInMap("SkippedFiles")]
                    [Validation(Required=false)]
                    public string SkippedFiles { get; set; }

                    [NameInMap("SuccessFiles")]
                    [Validation(Required=false)]
                    public string SuccessFiles { get; set; }

                    [NameInMap("TotalFiles")]
                    [Validation(Required=false)]
                    public string TotalFiles { get; set; }

                }

                [NameInMap("RestoreId")]
                [Validation(Required=false)]
                public string RestoreId { get; set; }

                [NameInMap("RestoreType")]
                [Validation(Required=false)]
                public string RestoreType { get; set; }

                [NameInMap("SnapshotHash")]
                [Validation(Required=false)]
                public string SnapshotHash { get; set; }

                [NameInMap("SnapshotId")]
                [Validation(Required=false)]
                public string SnapshotId { get; set; }

                [NameInMap("SourceInstanceId")]
                [Validation(Required=false)]
                public string SourceInstanceId { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("Speed")]
                [Validation(Required=false)]
                public long? Speed { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                [NameInMap("TargetBucket")]
                [Validation(Required=false)]
                public string TargetBucket { get; set; }

                [NameInMap("TargetClientId")]
                [Validation(Required=false)]
                public string TargetClientId { get; set; }

                [NameInMap("TargetCreateTime")]
                [Validation(Required=false)]
                public long? TargetCreateTime { get; set; }

                [NameInMap("TargetDataSourceId")]
                [Validation(Required=false)]
                public string TargetDataSourceId { get; set; }

                [NameInMap("TargetFileSystemId")]
                [Validation(Required=false)]
                public string TargetFileSystemId { get; set; }

                [NameInMap("TargetInstanceId")]
                [Validation(Required=false)]
                public string TargetInstanceId { get; set; }

                [NameInMap("TargetInstanceName")]
                [Validation(Required=false)]
                public string TargetInstanceName { get; set; }

                [NameInMap("TargetPath")]
                [Validation(Required=false)]
                public string TargetPath { get; set; }

                [NameInMap("TargetPrefix")]
                [Validation(Required=false)]
                public string TargetPrefix { get; set; }

                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

                [NameInMap("TargetTime")]
                [Validation(Required=false)]
                public long? TargetTime { get; set; }

                [NameInMap("UdmDetail")]
                [Validation(Required=false)]
                public string UdmDetail { get; set; }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

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

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
