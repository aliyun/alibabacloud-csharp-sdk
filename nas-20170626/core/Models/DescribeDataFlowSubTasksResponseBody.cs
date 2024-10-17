// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowSubTasksResponseBody : TeaModel {
        [NameInMap("DataFlowSubTask")]
        [Validation(Required=false)]
        public DescribeDataFlowSubTasksResponseBodyDataFlowSubTask DataFlowSubTask { get; set; }
        public class DescribeDataFlowSubTasksResponseBodyDataFlowSubTask : TeaModel {
            [NameInMap("DataFlowSubTask")]
            [Validation(Required=false)]
            public List<DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTask> DataFlowSubTask { get; set; }
            public class DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTask : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-07-01 19:59:29</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dfid-194433a5be31****</para>
                /// </summary>
                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public string DataFlowId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>subTaskId-370kyfmyknxcyzw****</para>
                /// </summary>
                [NameInMap("DataFlowSubTaskId")]
                [Validation(Required=false)]
                public string DataFlowSubTaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>taskId-12345678</para>
                /// </summary>
                [NameInMap("DataFlowTaskId")]
                [Validation(Required=false)]
                public string DataFlowTaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/mnt/file.png</para>
                /// </summary>
                [NameInMap("DstFilePath")]
                [Validation(Required=false)]
                public string DstFilePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-07-04 11:14:22</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("FileDetail")]
                [Validation(Required=false)]
                public DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskFileDetail FileDetail { get; set; }
                public class DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskFileDetail : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>crc64:850309505450944****</para>
                    /// </summary>
                    [NameInMap("Checksum")]
                    [Validation(Required=false)]
                    public string Checksum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1721167603</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bmcpfs-370lx1ev9ss27o0****</para>
                /// </summary>
                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("ProgressStats")]
                [Validation(Required=false)]
                public DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskProgressStats ProgressStats { get; set; }
                public class DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskProgressStats : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("ActualBytes")]
                    [Validation(Required=false)]
                    public long? ActualBytes { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>34</para>
                    /// </summary>
                    [NameInMap("AverageSpeed")]
                    [Validation(Required=false)]
                    public long? AverageSpeed { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("BytesDone")]
                    [Validation(Required=false)]
                    public long? BytesDone { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("BytesTotal")]
                    [Validation(Required=false)]
                    public long? BytesTotal { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/test/file.png</para>
                /// </summary>
                [NameInMap("SrcFilePath")]
                [Validation(Required=false)]
                public string SrcFilePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-07-03 10:43:16</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>COMPLETE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pUJaUwAAAABhdGUyNTk1MQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>98696EF0-1607-4E9D-B01D-F20930B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
