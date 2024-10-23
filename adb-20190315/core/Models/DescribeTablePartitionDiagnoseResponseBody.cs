// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTablePartitionDiagnoseResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1xxxxxxxx47</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The queried detection items and detection results.</para>
        /// </summary>
        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeTablePartitionDiagnoseResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeTablePartitionDiagnoseResponseBodyDetectionItems : TeaModel {
            /// <summary>
            /// <para>The detection result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A total of 10 tables have an improper partition field</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the detection item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Improper Partition Field Diagnosis</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The severity level of the detection result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL</description></item>
            /// <item><description>WARNING</description></item>
            /// <item><description>CRITICAL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WARNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The table statistics.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTablePartitionDiagnoseResponseBodyItems> Items { get; set; }
        public class DescribeTablePartitionDiagnoseResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The information about inappropriate partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202005,202006</para>
            /// </summary>
            [NameInMap("PartitionDetail")]
            [Validation(Required=false)]
            public string PartitionDetail { get; set; }

            /// <summary>
            /// <para>The number of partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PartitionNumber")]
            [Validation(Required=false)]
            public int? PartitionNumber { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The storage percentage of the table. Unit: %.</para>
            /// <remarks>
            /// <para> Formula: Table storage percentage = Total data size of a table/Total data size of the cluster × 100%.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>66.23</para>
            /// </summary>
            [NameInMap("SpaceRatio")]
            [Validation(Required=false)]
            public double? SpaceRatio { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The total data size of the table. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42949672960</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The recommended maximum number of rows in each list partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>640000000</para>
        /// </summary>
        [NameInMap("SuggestMaxRecordsPerPartition")]
        [Validation(Required=false)]
        public long? SuggestMaxRecordsPerPartition { get; set; }

        /// <summary>
        /// <para>The recommended minimum number of rows in each list partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64000000</para>
        /// </summary>
        [NameInMap("SuggestMinRecordsPerPartition")]
        [Validation(Required=false)]
        public long? SuggestMinRecordsPerPartition { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
