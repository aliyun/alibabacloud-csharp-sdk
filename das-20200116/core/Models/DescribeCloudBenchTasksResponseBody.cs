// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCloudBenchTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information, including the error codes and the number of entries that are returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudBenchTasksResponseBodyData Data { get; set; }
        public class DescribeCloudBenchTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public DescribeCloudBenchTasksResponseBodyDataList List { get; set; }
            public class DescribeCloudBenchTasksResponseBodyDataList : TeaModel {
                [NameInMap("cloudbenchTasks")]
                [Validation(Required=false)]
                public List<DescribeCloudBenchTasksResponseBodyDataListCloudbenchTasks> CloudbenchTasks { get; set; }
                public class DescribeCloudBenchTasksResponseBodyDataListCloudbenchTasks : TeaModel {
                    [NameInMap("ArchiveJobId")]
                    [Validation(Required=false)]
                    public string ArchiveJobId { get; set; }

                    [NameInMap("ArchiveOssTableName")]
                    [Validation(Required=false)]
                    public string ArchiveOssTableName { get; set; }

                    [NameInMap("ArchiveState")]
                    [Validation(Required=false)]
                    public int? ArchiveState { get; set; }

                    [NameInMap("BackupId")]
                    [Validation(Required=false)]
                    public string BackupId { get; set; }

                    [NameInMap("BackupType")]
                    [Validation(Required=false)]
                    public string BackupType { get; set; }

                    [NameInMap("BenchStep")]
                    [Validation(Required=false)]
                    public string BenchStep { get; set; }

                    [NameInMap("BenchStepStatus")]
                    [Validation(Required=false)]
                    public string BenchStepStatus { get; set; }

                    [NameInMap("ClientGatewayId")]
                    [Validation(Required=false)]
                    public string ClientGatewayId { get; set; }

                    [NameInMap("ClientType")]
                    [Validation(Required=false)]
                    public string ClientType { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("DstInstanceUuid")]
                    [Validation(Required=false)]
                    public string DstInstanceUuid { get; set; }

                    [NameInMap("DstIp")]
                    [Validation(Required=false)]
                    public string DstIp { get; set; }

                    [NameInMap("DstPort")]
                    [Validation(Required=false)]
                    public int? DstPort { get; set; }

                    [NameInMap("DstType")]
                    [Validation(Required=false)]
                    public string DstType { get; set; }

                    [NameInMap("DtsJobClass")]
                    [Validation(Required=false)]
                    public string DtsJobClass { get; set; }

                    [NameInMap("DtsJobId")]
                    [Validation(Required=false)]
                    public string DtsJobId { get; set; }

                    [NameInMap("DtsJobName")]
                    [Validation(Required=false)]
                    public string DtsJobName { get; set; }

                    [NameInMap("DtsJobState")]
                    [Validation(Required=false)]
                    public int? DtsJobState { get; set; }

                    [NameInMap("DtsJobStatus")]
                    [Validation(Required=false)]
                    public string DtsJobStatus { get; set; }

                    [NameInMap("EcsInstanceId")]
                    [Validation(Required=false)]
                    public string EcsInstanceId { get; set; }

                    [NameInMap("EndState")]
                    [Validation(Required=false)]
                    public string EndState { get; set; }

                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("External")]
                    [Validation(Required=false)]
                    public string External { get; set; }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    [NameInMap("RequestDuration")]
                    [Validation(Required=false)]
                    public long? RequestDuration { get; set; }

                    [NameInMap("SmartPressureTime")]
                    [Validation(Required=false)]
                    public int? SmartPressureTime { get; set; }

                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    [NameInMap("SqlCompleteReuse")]
                    [Validation(Required=false)]
                    public string SqlCompleteReuse { get; set; }

                    [NameInMap("SrcInstanceArea")]
                    [Validation(Required=false)]
                    public string SrcInstanceArea { get; set; }

                    [NameInMap("SrcInstanceUuid")]
                    [Validation(Required=false)]
                    public string SrcInstanceUuid { get; set; }

                    [NameInMap("SrcPublicIp")]
                    [Validation(Required=false)]
                    public string SrcPublicIp { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TableSchema")]
                    [Validation(Required=false)]
                    public string TableSchema { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    [NameInMap("TaskType")]
                    [Validation(Required=false)]
                    public string TaskType { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("WorkDir")]
                    [Validation(Required=false)]
                    public string WorkDir { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
