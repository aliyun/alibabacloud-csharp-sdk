// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogHistogramAsyncResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>AsyncResult<Histogram>。</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogHistogramAsyncResponseBodyData Data { get; set; }
        public class DescribeSlowLogHistogramAsyncResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeSlowLogHistogramAsyncResponseBodyDataData Data { get; set; }
            public class DescribeSlowLogHistogramAsyncResponseBodyDataData : TeaModel {
                [NameInMap("AvgCPUTime")]
                [Validation(Required=false)]
                public List<double?> AvgCPUTime { get; set; }

                [NameInMap("AvgDocExamined")]
                [Validation(Required=false)]
                public List<double?> AvgDocExamined { get; set; }

                [NameInMap("AvgFrows")]
                [Validation(Required=false)]
                public List<double?> AvgFrows { get; set; }

                [NameInMap("AvgIOWrites")]
                [Validation(Required=false)]
                public List<double?> AvgIOWrites { get; set; }

                [NameInMap("AvgKeysExamined")]
                [Validation(Required=false)]
                public List<double?> AvgKeysExamined { get; set; }

                [NameInMap("AvgLastRowsCountAffected")]
                [Validation(Required=false)]
                public List<double?> AvgLastRowsCountAffected { get; set; }

                [NameInMap("AvgLockTime")]
                [Validation(Required=false)]
                public List<double?> AvgLockTime { get; set; }

                [NameInMap("AvgLogicalIOReads")]
                [Validation(Required=false)]
                public List<double?> AvgLogicalIOReads { get; set; }

                [NameInMap("AvgPhysicalIOReads")]
                [Validation(Required=false)]
                public List<double?> AvgPhysicalIOReads { get; set; }

                [NameInMap("AvgReturnNum")]
                [Validation(Required=false)]
                public List<double?> AvgReturnNum { get; set; }

                [NameInMap("AvgRows")]
                [Validation(Required=false)]
                public List<double?> AvgRows { get; set; }

                [NameInMap("AvgRowsCountAffected")]
                [Validation(Required=false)]
                public List<double?> AvgRowsCountAffected { get; set; }

                [NameInMap("AvgRowsExamined")]
                [Validation(Required=false)]
                public List<double?> AvgRowsExamined { get; set; }

                [NameInMap("AvgRowsSent")]
                [Validation(Required=false)]
                public List<double?> AvgRowsSent { get; set; }

                [NameInMap("AvgRt")]
                [Validation(Required=false)]
                public List<double?> AvgRt { get; set; }

                [NameInMap("AvgScnt")]
                [Validation(Required=false)]
                public List<double?> AvgScnt { get; set; }

                [NameInMap("CPUTime")]
                [Validation(Required=false)]
                public List<double?> CPUTime { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public List<long?> Count { get; set; }

                [NameInMap("DocExamined")]
                [Validation(Required=false)]
                public List<long?> DocExamined { get; set; }

                [NameInMap("Frows")]
                [Validation(Required=false)]
                public List<long?> Frows { get; set; }

                [NameInMap("IOWrites")]
                [Validation(Required=false)]
                public List<long?> IOWrites { get; set; }

                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<DescribeSlowLogHistogramAsyncResponseBodyDataDataItem> Item { get; set; }
                public class DescribeSlowLogHistogramAsyncResponseBodyDataDataItem : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public List<long?> Count { get; set; }

                    [NameInMap("InsItems")]
                    [Validation(Required=false)]
                    public List<DescribeSlowLogHistogramAsyncResponseBodyDataDataItemInsItems> InsItems { get; set; }
                    public class DescribeSlowLogHistogramAsyncResponseBodyDataDataItemInsItems : TeaModel {
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public List<long?> Count { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2492</para>
                        /// </summary>
                        [NameInMap("InsId")]
                        [Validation(Required=false)]
                        public string InsId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>userAdmin</para>
                        /// </summary>
                        [NameInMap("InsRole")]
                        [Validation(Required=false)]
                        public string InsRole { get; set; }

                        [NameInMap("TotalCount")]
                        [Validation(Required=false)]
                        public long? TotalCount { get; set; }

                    }

                    [NameInMap("InsRole")]
                    [Validation(Required=false)]
                    public string InsRole { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>r-bp1hi0wg57s3n0i3n8-db-0</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                }

                [NameInMap("KeysExamined")]
                [Validation(Required=false)]
                public List<long?> KeysExamined { get; set; }

                [NameInMap("LastRowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> LastRowsCountAffected { get; set; }

                [NameInMap("LockTime")]
                [Validation(Required=false)]
                public List<double?> LockTime { get; set; }

                [NameInMap("LogicalIOReads")]
                [Validation(Required=false)]
                public List<long?> LogicalIOReads { get; set; }

                [NameInMap("MaxCPUTime")]
                [Validation(Required=false)]
                public List<double?> MaxCPUTime { get; set; }

                [NameInMap("MaxDocExamined")]
                [Validation(Required=false)]
                public List<long?> MaxDocExamined { get; set; }

                [NameInMap("MaxFrows")]
                [Validation(Required=false)]
                public List<long?> MaxFrows { get; set; }

                [NameInMap("MaxIOWrites")]
                [Validation(Required=false)]
                public List<long?> MaxIOWrites { get; set; }

                [NameInMap("MaxKeysExamined")]
                [Validation(Required=false)]
                public List<long?> MaxKeysExamined { get; set; }

                [NameInMap("MaxLastRowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> MaxLastRowsCountAffected { get; set; }

                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public List<double?> MaxLockTime { get; set; }

                [NameInMap("MaxLogicalIOReads")]
                [Validation(Required=false)]
                public List<long?> MaxLogicalIOReads { get; set; }

                [NameInMap("MaxPhysicalIOReads")]
                [Validation(Required=false)]
                public List<long?> MaxPhysicalIOReads { get; set; }

                [NameInMap("MaxReturnNum")]
                [Validation(Required=false)]
                public List<long?> MaxReturnNum { get; set; }

                [NameInMap("MaxRows")]
                [Validation(Required=false)]
                public List<long?> MaxRows { get; set; }

                [NameInMap("MaxRowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> MaxRowsCountAffected { get; set; }

                [NameInMap("MaxRowsExamined")]
                [Validation(Required=false)]
                public List<long?> MaxRowsExamined { get; set; }

                [NameInMap("MaxRowsSent")]
                [Validation(Required=false)]
                public List<long?> MaxRowsSent { get; set; }

                [NameInMap("MaxRt")]
                [Validation(Required=false)]
                public List<double?> MaxRt { get; set; }

                [NameInMap("MaxScnt")]
                [Validation(Required=false)]
                public List<long?> MaxScnt { get; set; }

                [NameInMap("PhysicalIOReads")]
                [Validation(Required=false)]
                public List<long?> PhysicalIOReads { get; set; }

                [NameInMap("ReturnNum")]
                [Validation(Required=false)]
                public List<long?> ReturnNum { get; set; }

                [NameInMap("Rows")]
                [Validation(Required=false)]
                public List<long?> Rows { get; set; }

                [NameInMap("RowsCountAffected")]
                [Validation(Required=false)]
                public List<long?> RowsCountAffected { get; set; }

                [NameInMap("RowsExamined")]
                [Validation(Required=false)]
                public List<long?> RowsExamined { get; set; }

                [NameInMap("RowsSent")]
                [Validation(Required=false)]
                public List<long?> RowsSent { get; set; }

                [NameInMap("Rt")]
                [Validation(Required=false)]
                public List<double?> Rt { get; set; }

                [NameInMap("Scnt")]
                [Validation(Required=false)]
                public List<long?> Scnt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("Ts")]
                [Validation(Required=false)]
                public List<long?> Ts { get; set; }

                [NameInMap("TsEnd")]
                [Validation(Required=false)]
                public List<long?> TsEnd { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10910</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("RequestKey")]
            [Validation(Required=false)]
            public string RequestKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>async__20ee808e72257f16a4fe024057ca****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1645668213000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
