// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSqlLogRecordsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// SqlLogDetailResult
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSqlLogRecordsResponseBodyData Data { get; set; }
        public class DescribeSqlLogRecordsResponseBodyData : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Finish")]
            [Validation(Required=false)]
            public string Finish { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public DescribeSqlLogRecordsResponseBodyDataItems Items { get; set; }
            public class DescribeSqlLogRecordsResponseBodyDataItems : TeaModel {
                [NameInMap("SQLLogRecord")]
                [Validation(Required=false)]
                public List<DescribeSqlLogRecordsResponseBodyDataItemsSQLLogRecord> SQLLogRecord { get; set; }
                public class DescribeSqlLogRecordsResponseBodyDataItemsSQLLogRecord : TeaModel {
                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                    [NameInMap("Collection")]
                    [Validation(Required=false)]
                    public string Collection { get; set; }

                    [NameInMap("Consume")]
                    [Validation(Required=false)]
                    public long? Consume { get; set; }

                    [NameInMap("CpuTime")]
                    [Validation(Required=false)]
                    public long? CpuTime { get; set; }

                    [NameInMap("DBName")]
                    [Validation(Required=false)]
                    public string DBName { get; set; }

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

            }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

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
