// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// SqlLogTaskDetail
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogTaskResponseBodyData Data { get; set; }
        public class DescribeSqlLogTaskResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            [NameInMap("Expire")]
            [Validation(Required=false)]
            public bool? Expire { get; set; }

            [NameInMap("Export")]
            [Validation(Required=false)]
            public string Export { get; set; }

            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTaskResponseBodyDataFilters> Filters { get; set; }
            public class DescribeSqlLogTaskResponseBodyDataFilters : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Queries")]
            [Validation(Required=false)]
            public List<DescribeSqlLogTaskResponseBodyDataQueries> Queries { get; set; }
            public class DescribeSqlLogTaskResponseBodyDataQueries : TeaModel {
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("Consume")]
                [Validation(Required=false)]
                public long? Consume { get; set; }

                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public long? CpuTime { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// yyyy-MM-dd\\"T\\"HH:mm:ss.SSS\\"Z\\"
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                [NameInMap("Ext")]
                [Validation(Required=false)]
                public string Ext { get; set; }

                [NameInMap("Frows")]
                [Validation(Required=false)]
                public long? Frows { get; set; }

                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                [NameInMap("LockTime")]
                [Validation(Required=false)]
                public long? LockTime { get; set; }

                [NameInMap("LogicRead")]
                [Validation(Required=false)]
                public long? LogicRead { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// ts unix
                /// </summary>
                [NameInMap("OriginTime")]
                [Validation(Required=false)]
                public long? OriginTime { get; set; }

                [NameInMap("ParallelDegree")]
                [Validation(Required=false)]
                public string ParallelDegree { get; set; }

                [NameInMap("ParallelQueueTime")]
                [Validation(Required=false)]
                public string ParallelQueueTime { get; set; }

                [NameInMap("PhysicAsyncRead")]
                [Validation(Required=false)]
                public long? PhysicAsyncRead { get; set; }

                [NameInMap("PhysicRead")]
                [Validation(Required=false)]
                public long? PhysicRead { get; set; }

                [NameInMap("PhysicSyncRead")]
                [Validation(Required=false)]
                public long? PhysicSyncRead { get; set; }

                [NameInMap("ReturnRows")]
                [Validation(Required=false)]
                public long? ReturnRows { get; set; }

                [NameInMap("Rows")]
                [Validation(Required=false)]
                public long? Rows { get; set; }

                [NameInMap("ScanRows")]
                [Validation(Required=false)]
                public long? ScanRows { get; set; }

                [NameInMap("Scnt")]
                [Validation(Required=false)]
                public long? Scnt { get; set; }

                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                [NameInMap("SqlText")]
                [Validation(Required=false)]
                public string SqlText { get; set; }

                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("ThreadId")]
                [Validation(Required=false)]
                public long? ThreadId { get; set; }

                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

                [NameInMap("TrxId")]
                [Validation(Required=false)]
                public long? TrxId { get; set; }

                [NameInMap("UpdateRows")]
                [Validation(Required=false)]
                public long? UpdateRows { get; set; }

                [NameInMap("UseImciEngine")]
                [Validation(Required=false)]
                public string UseImciEngine { get; set; }

                [NameInMap("Vip")]
                [Validation(Required=false)]
                public string Vip { get; set; }

                [NameInMap("Writes")]
                [Validation(Required=false)]
                public long? Writes { get; set; }

            }

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
