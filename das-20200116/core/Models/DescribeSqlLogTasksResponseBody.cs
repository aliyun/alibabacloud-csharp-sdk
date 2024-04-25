// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogTasksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// ListResult<SqlLogTask>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogTasksResponseBodyData Data { get; set; }
        public class DescribeSqlLogTasksResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTasksResponseBodyDataList> List { get; set; }
            public class DescribeSqlLogTasksResponseBodyDataList : TeaModel {
                [NameInMap("AnalysisTaskFinishTime")]
                [Validation(Required=false)]
                public long? AnalysisTaskFinishTime { get; set; }

                [NameInMap("AnalysisTaskStatus")]
                [Validation(Required=false)]
                public string AnalysisTaskStatus { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("Expire")]
                [Validation(Required=false)]
                public bool? Expire { get; set; }

                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<DescribeSqlLogTasksResponseBodyDataListFilters> Filters { get; set; }
                public class DescribeSqlLogTasksResponseBodyDataListFilters : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("LogCount")]
                [Validation(Required=false)]
                public long? LogCount { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("ScanFileSize")]
                [Validation(Required=false)]
                public long? ScanFileSize { get; set; }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
