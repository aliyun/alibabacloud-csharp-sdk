// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListEmrHiveTablesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEmrHiveTablesResponseBodyData Data { get; set; }
        public class ListEmrHiveTablesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("PagedData")]
            [Validation(Required=false)]
            public List<ListEmrHiveTablesResponseBodyDataPagedData> PagedData { get; set; }
            public class ListEmrHiveTablesResponseBodyDataPagedData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>C-D033DD5FB82436A6</para>
                /// </summary>
                [NameInMap("ClusterBizId")]
                [Validation(Required=false)]
                public string ClusterBizId { get; set; }

                [NameInMap("ClusterBizName")]
                [Validation(Required=false)]
                public string ClusterBizName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-09-09 20:23:47</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-09-09 20:23:47</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>org.apache.hadoop.hive.ql.io.orc.OrcInputFormat</para>
                /// </summary>
                [NameInMap("InputFormat")]
                [Validation(Required=false)]
                public string InputFormat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsCompressed")]
                [Validation(Required=false)]
                public bool? IsCompressed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsTemporary")]
                [Validation(Required=false)]
                public bool? IsTemporary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1970-01-01 08:00:00</para>
                /// </summary>
                [NameInMap("LastAccessTime")]
                [Validation(Required=false)]
                public string LastAccessTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-09-09 20:23:47</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hdfs://emr-header-1.cluster-136574:9000/user/hive/warehouse/pt_table_090901_emr</para>
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>org.apache.hadoop.hive.ql.io.HiveIgnoreKeyTextOutputFormat</para>
                /// </summary>
                [NameInMap("OutputFormat")]
                [Validation(Required=false)]
                public string OutputFormat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18612767103****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ROLE</para>
                /// </summary>
                [NameInMap("OwnerType")]
                [Validation(Required=false)]
                public string OwnerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DS,HR,REGION</para>
                /// </summary>
                [NameInMap("PartitionKeys")]
                [Validation(Required=false)]
                public string PartitionKeys { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>org.apache.hadoop.hive.serde2.lazy.LazySimpleSerDe</para>
                /// </summary>
                [NameInMap("SerializationLib")]
                [Validation(Required=false)]
                public string SerializationLib { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RANDOM GENERATED TEST DATA BY FUNCTION OF RANDOM_TEST_DATA</para>
                /// </summary>
                [NameInMap("TableComment")]
                [Validation(Required=false)]
                public string TableComment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RANDOM GENERATED TEST DATA BY FUNCTION OF RANDOM_TEST_DATA</para>
                /// </summary>
                [NameInMap("TableDesc")]
                [Validation(Required=false)]
                public string TableDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pt_table_090901_emr_orc</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;transient_lastDdlTime\&quot;:\&quot;1568031823\&quot;,\&quot;bucketing_version\&quot;:\&quot;2\&quot;,\&quot;comment\&quot;:\&quot;RANDOM GENERATED TEST DATA BY FUNCTION OF RANDOM_TEST_DATA\&quot;}</para>
                /// </summary>
                [NameInMap("TableParameters")]
                [Validation(Required=false)]
                public string TableParameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MANAGED_TABLE</para>
                /// </summary>
                [NameInMap("TableType")]
                [Validation(Required=false)]
                public string TableType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E6F0DBDD-5AD8-4870-A6A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
