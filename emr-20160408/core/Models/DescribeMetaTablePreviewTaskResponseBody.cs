// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeMetaTablePreviewTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMetaTablePreviewTaskResponseBodyData Data { get; set; }
        public class DescribeMetaTablePreviewTaskResponseBodyData : TeaModel {
            [NameInMap("Headers")]
            [Validation(Required=false)]
            public DescribeMetaTablePreviewTaskResponseBodyDataHeaders Headers { get; set; }
            public class DescribeMetaTablePreviewTaskResponseBodyDataHeaders : TeaModel {
                [NameInMap("Header")]
                [Validation(Required=false)]
                public List<string> Header { get; set; }

            }
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public DescribeMetaTablePreviewTaskResponseBodyDataRows Rows { get; set; }
            public class DescribeMetaTablePreviewTaskResponseBodyDataRows : TeaModel {
                [NameInMap("Row")]
                [Validation(Required=false)]
                public List<DescribeMetaTablePreviewTaskResponseBodyDataRowsRow> Row { get; set; }
                public class DescribeMetaTablePreviewTaskResponseBodyDataRowsRow : TeaModel {
                    [NameInMap("Columns")]
                    [Validation(Required=false)]
                    public DescribeMetaTablePreviewTaskResponseBodyDataRowsRowColumns Columns { get; set; }
                    public class DescribeMetaTablePreviewTaskResponseBodyDataRowsRowColumns : TeaModel {
                        [NameInMap("Column")]
                        [Validation(Required=false)]
                        public List<string> Column { get; set; }
                    };

                }

            }
        };

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ExecuteTime")]
        [Validation(Required=false)]
        public long? ExecuteTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskProcess")]
        [Validation(Required=false)]
        public int? TaskProcess { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
