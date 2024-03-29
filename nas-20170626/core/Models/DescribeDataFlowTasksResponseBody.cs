// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowTasksResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public DescribeDataFlowTasksResponseBodyTaskInfo TaskInfo { get; set; }
        public class DescribeDataFlowTasksResponseBodyTaskInfo : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDataFlowTasksResponseBodyTaskInfoTask> Task { get; set; }
            public class DescribeDataFlowTasksResponseBodyTaskInfoTask : TeaModel {
                [NameInMap("ConflictPolicy")]
                [Validation(Required=false)]
                public string ConflictPolicy { get; set; }

                /// <summary>
                /// The time when the task was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DataFlowId")]
                [Validation(Required=false)]
                public string DataFlowId { get; set; }

                /// <summary>
                /// null Valid values:
                /// 
                /// *   null null
                /// *   null
                /// *   null
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// The time when the task ended.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// *
                /// *
                /// *
                /// *   null
                /// </summary>
                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                [NameInMap("FilesystemId")]
                [Validation(Required=false)]
                public string FilesystemId { get; set; }

                /// <summary>
                /// null
                /// </summary>
                [NameInMap("FsPath")]
                [Validation(Required=false)]
                public string FsPath { get; set; }

                /// <summary>
                /// null Valid values:
                /// 
                /// *   null
                /// *   null
                /// </summary>
                [NameInMap("Originator")]
                [Validation(Required=false)]
                public string Originator { get; set; }

                /// <summary>
                /// null null
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public long? Progress { get; set; }

                /// <summary>
                /// null
                /// 
                /// null``
                /// 
                /// Limits:
                /// 
                /// *   null
                /// *   The name must be encoded in UTF-8.
                /// </summary>
                [NameInMap("ReportPath")]
                [Validation(Required=false)]
                public string ReportPath { get; set; }

                /// <summary>
                /// ://
                /// 
                /// *
                /// *   *
                ///     *
                ///     *
                ///     *   [](http://https://。)
                /// 
                /// **
                /// 
                /// ****
                /// </summary>
                [NameInMap("SourceStorage")]
                [Validation(Required=false)]
                public string SourceStorage { get; set; }

                /// <summary>
                /// null
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// null Valid values:
                /// 
                /// *   null
                /// *   null
                /// *   null
                /// *   null
                /// *   null
                /// *   null
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// null Valid values:
                /// 
                /// *   null
                /// *   null
                /// *   null null
                /// *   null
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

    }

}
