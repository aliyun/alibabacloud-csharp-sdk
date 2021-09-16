// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribePreCheckStatusResponseBody : TeaModel {
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public long? PageRecordCount { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("ErrorItem")]
        [Validation(Required=false)]
        public int? ErrorItem { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("JobProgress")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodyJobProgress> JobProgress { get; set; }
        public class DescribePreCheckStatusResponseBodyJobProgress : TeaModel {
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("IgnoreFlag")]
            [Validation(Required=false)]
            public string IgnoreFlag { get; set; }

            [NameInMap("DelaySeconds")]
            [Validation(Required=false)]
            public int? DelaySeconds { get; set; }

            [NameInMap("DdlSql")]
            [Validation(Required=false)]
            public string DdlSql { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("BootTime")]
            [Validation(Required=false)]
            public string BootTime { get; set; }

            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            [NameInMap("Sub")]
            [Validation(Required=false)]
            public string Sub { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            [NameInMap("TargetNames")]
            [Validation(Required=false)]
            public string TargetNames { get; set; }

            [NameInMap("CanSkip")]
            [Validation(Required=false)]
            public bool? CanSkip { get; set; }

            [NameInMap("Names")]
            [Validation(Required=false)]
            public string Names { get; set; }

            [NameInMap("ErrDetail")]
            [Validation(Required=false)]
            public string ErrDetail { get; set; }

            [NameInMap("DiffRow")]
            [Validation(Required=false)]
            public long? DiffRow { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("SourceSchema")]
            [Validation(Required=false)]
            public string SourceSchema { get; set; }

            [NameInMap("DestSchema")]
            [Validation(Required=false)]
            public string DestSchema { get; set; }

            [NameInMap("ParentObj")]
            [Validation(Required=false)]
            public string ParentObj { get; set; }

            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            [NameInMap("OrderNum")]
            [Validation(Required=false)]
            public int? OrderNum { get; set; }

            [NameInMap("RepairMethod")]
            [Validation(Required=false)]
            public string RepairMethod { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodyJobProgressLogs> Logs { get; set; }
            public class DescribePreCheckStatusResponseBodyJobProgressLogs : TeaModel {
                [NameInMap("ErrData")]
                [Validation(Required=false)]
                public string ErrData { get; set; }

                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("LogLevel")]
                [Validation(Required=false)]
                public string LogLevel { get; set; }

                [NameInMap("ErrType")]
                [Validation(Required=false)]
                public string ErrType { get; set; }

            }

        }

        [NameInMap("SubDistributedJobStatus")]
        [Validation(Required=false)]
        public List<DescribePreCheckStatusResponseBodySubDistributedJobStatus> SubDistributedJobStatus { get; set; }
        public class DescribePreCheckStatusResponseBodySubDistributedJobStatus : TeaModel {
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("ErrorItem")]
            [Validation(Required=false)]
            public int? ErrorItem { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            [NameInMap("JobProgress")]
            [Validation(Required=false)]
            public List<DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgress> JobProgress { get; set; }
            public class DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgress : TeaModel {
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public bool? Skip { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("IgnoreFlag")]
                [Validation(Required=false)]
                public string IgnoreFlag { get; set; }

                [NameInMap("DelaySeconds")]
                [Validation(Required=false)]
                public int? DelaySeconds { get; set; }

                [NameInMap("DdlSql")]
                [Validation(Required=false)]
                public string DdlSql { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("BootTime")]
                [Validation(Required=false)]
                public string BootTime { get; set; }

                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                [NameInMap("Sub")]
                [Validation(Required=false)]
                public string Sub { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                [NameInMap("TargetNames")]
                [Validation(Required=false)]
                public string TargetNames { get; set; }

                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                [NameInMap("Names")]
                [Validation(Required=false)]
                public string Names { get; set; }

                [NameInMap("ErrDetail")]
                [Validation(Required=false)]
                public string ErrDetail { get; set; }

                [NameInMap("DiffRow")]
                [Validation(Required=false)]
                public long? DiffRow { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("SourceSchema")]
                [Validation(Required=false)]
                public string SourceSchema { get; set; }

                [NameInMap("DestSchema")]
                [Validation(Required=false)]
                public string DestSchema { get; set; }

                [NameInMap("ParentObj")]
                [Validation(Required=false)]
                public string ParentObj { get; set; }

                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("OrderNum")]
                [Validation(Required=false)]
                public int? OrderNum { get; set; }

                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgressLogs> Logs { get; set; }
                public class DescribePreCheckStatusResponseBodySubDistributedJobStatusJobProgressLogs : TeaModel {
                    [NameInMap("ErrData")]
                    [Validation(Required=false)]
                    public string ErrData { get; set; }

                    [NameInMap("ErrMsg")]
                    [Validation(Required=false)]
                    public string ErrMsg { get; set; }

                    [NameInMap("LogLevel")]
                    [Validation(Required=false)]
                    public string LogLevel { get; set; }

                    [NameInMap("ErrType")]
                    [Validation(Required=false)]
                    public string ErrType { get; set; }

                }

            }

        }

    }

}
