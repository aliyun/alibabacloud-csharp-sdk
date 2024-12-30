// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeOversizeNonPartitionTableInfosResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>am-bp16t5ci7r74s****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DetectionItems")]
        [Validation(Required=false)]
        public List<DescribeOversizeNonPartitionTableInfosResponseBodyDetectionItems> DetectionItems { get; set; }
        public class DescribeOversizeNonPartitionTableInfosResponseBodyDetectionItems : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL
            /// WARNING
            /// CRITICAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public List<DescribeOversizeNonPartitionTableInfosResponseBodyTables> Tables { get; set; }
        public class DescribeOversizeNonPartitionTableInfosResponseBodyTables : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2921132457984</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public long? DataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("IndexSize")]
            [Validation(Required=false)]
            public long? IndexSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1223</para>
            /// </summary>
            [NameInMap("LocalDataSize")]
            [Validation(Required=false)]
            public long? LocalDataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PrimaryKeySize")]
            [Validation(Required=false)]
            public long? PrimaryKeySize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>122</para>
            /// </summary>
            [NameInMap("RemoteDataSize")]
            [Validation(Required=false)]
            public long? RemoteDataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1222</para>
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public long? RowCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>adb_demo</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("SpaceRatio")]
            [Validation(Required=false)]
            public double? SpaceRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
