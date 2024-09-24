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
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public string DataFlowId { get; set; }

                [NameInMap("DataFlowSubTaskId")]
                [Validation(Required=false)]
                public string DataFlowSubTaskId { get; set; }

                [NameInMap("DataFlowTaskId")]
                [Validation(Required=false)]
                public string DataFlowTaskId { get; set; }

                [NameInMap("DstFilePath")]
                [Validation(Required=false)]
                public string DstFilePath { get; set; }

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
                    [NameInMap("Checksum")]
                    [Validation(Required=false)]
                    public string Checksum { get; set; }

                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("ProgressStats")]
                [Validation(Required=false)]
                public DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskProgressStats ProgressStats { get; set; }
                public class DescribeDataFlowSubTasksResponseBodyDataFlowSubTaskDataFlowSubTaskProgressStats : TeaModel {
                    [NameInMap("ActualBytes")]
                    [Validation(Required=false)]
                    public long? ActualBytes { get; set; }

                    [NameInMap("AverageSpeed")]
                    [Validation(Required=false)]
                    public long? AverageSpeed { get; set; }

                    [NameInMap("BytesDone")]
                    [Validation(Required=false)]
                    public long? BytesDone { get; set; }

                    [NameInMap("BytesTotal")]
                    [Validation(Required=false)]
                    public long? BytesTotal { get; set; }

                }

                [NameInMap("SrcFilePath")]
                [Validation(Required=false)]
                public string SrcFilePath { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
