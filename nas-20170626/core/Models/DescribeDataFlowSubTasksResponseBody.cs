// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowSubTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about data streaming tasks.</para>
        /// </summary>
        [NameInMap("DataFlowSubTask")]
        [Validation(Required=false)]
        public DescribeDataFlowSubTasksResponseBodyDataFlowSubTask DataFlowSubTask { get; set; }
        public class DescribeDataFlowSubTasksResponseBodyDataFlowSubTask : TeaModel {
            [NameInMap("DataFlowSubTask")]
            [Validation(Required=false)]
            public List<DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTask> DataFlowSubTask { get; set; }
            public class DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTask : TeaModel {
                /// <summary>
                /// <para>The time when the data streaming task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-07-01 19:59:29</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the data flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>df-194433a5be31****</para>
                /// </summary>
                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public string DataFlowId { get; set; }

                /// <summary>
                /// <para>The ID of the data streaming task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subTaskId-370kyfmyknxcyzw****</para>
                /// </summary>
                [NameInMap("DataFlowSubTaskId")]
                [Validation(Required=false)]
                public string DataFlowSubTaskId { get; set; }

                /// <summary>
                /// <para>The ID of the data flow task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task-38aa8e890f45****</para>
                /// </summary>
                [NameInMap("DataFlowTaskId")]
                [Validation(Required=false)]
                public string DataFlowTaskId { get; set; }

                /// <summary>
                /// <para>The path of the destination file. Limits:</para>
                /// <list type="bullet">
                /// <item><description>The path must be 1 to 1,023 characters in length.</description></item>
                /// <item><description>The path must be encoded in UTF-8.</description></item>
                /// <item><description>The path must start with a forward slash (/).</description></item>
                /// <item><description>The path must end with the file name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/file.png</para>
                /// </summary>
                [NameInMap("DstFilePath")]
                [Validation(Required=false)]
                public string DstFilePath { get; set; }

                /// <summary>
                /// <para>The time when the data streaming task ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-07-04 11:14:22</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The error message returned when the task failed.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The file information.</para>
                /// </summary>
                [NameInMap("FileDetail")]
                [Validation(Required=false)]
                public DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskFileDetail FileDetail { get; set; }
                public class DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskFileDetail : TeaModel {
                    /// <summary>
                    /// <para>The checksum. Format example: crc64:123456.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>crc64:850309505450944****</para>
                    /// </summary>
                    [NameInMap("Checksum")]
                    [Validation(Required=false)]
                    public string Checksum { get; set; }

                    /// <summary>
                    /// <para>The time when the file was modified. The value is a UNIX timestamp. Unit: ns.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1721167603</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <para>The file size. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                }

                /// <summary>
                /// <para>The ID of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bmcpfs-370lx1ev9ss27o0****</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <para>The progress of the data streaming task. Valid values: 0 to 10000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>The progress information about data streaming tasks.</para>
                /// </summary>
                [NameInMap("ProgressStats")]
                [Validation(Required=false)]
                public DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskProgressStats ProgressStats { get; set; }
                public class DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskProgressStats : TeaModel {
                    /// <summary>
                    /// <para>The actual amount of data for which the data flow task is complete. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("ActualBytes")]
                    [Validation(Required=false)]
                    public long? ActualBytes { get; set; }

                    /// <summary>
                    /// <para>The average flow velocity. Unit: bytes/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34</para>
                    /// </summary>
                    [NameInMap("AverageSpeed")]
                    [Validation(Required=false)]
                    public long? AverageSpeed { get; set; }

                    /// <summary>
                    /// <para>The amount of data (including skipped data) for which the data flow task is complete. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("BytesDone")]
                    [Validation(Required=false)]
                    public long? BytesDone { get; set; }

                    /// <summary>
                    /// <para>The amount of data scanned on the source. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("BytesTotal")]
                    [Validation(Required=false)]
                    public long? BytesTotal { get; set; }

                }

                /// <summary>
                /// <para>The path of the source file. Limits:</para>
                /// <list type="bullet">
                /// <item><description>The path must be 1 to 1,023 characters in length.</description></item>
                /// <item><description>The path must be encoded in UTF-8.</description></item>
                /// <item><description>The path must start with a forward slash (/).</description></item>
                /// <item><description>The path must end with the file name.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>/test/file.png</para>
                /// </summary>
                [NameInMap("SrcFilePath")]
                [Validation(Required=false)]
                public string SrcFilePath { get; set; }

                /// <summary>
                /// <para>The time when the data streaming task started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-07-03 10:43:16</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the data streaming task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>EXPIRED: The task is terminated.</description></item>
                /// <item><description>CREATED: The task is created.</description></item>
                /// <item><description>RUNNING: The task is running.</description></item>
                /// <item><description>COMPLETE: The task is complete.</description></item>
                /// <item><description>CANCELING: The task is being canceled.</description></item>
                /// <item><description>FAILED: The task failed to be executed.</description></item>
                /// <item><description>CANCELED: The task is canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pUJaUwAAAABhdGUyNTk1MQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
