// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetTableInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTableInfoResponseBodyData Data { get; set; }
        public class GetTableInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the materialized view is automatically refreshed. This response parameter is returned when type is set to materializedView.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("autoRefreshEnabled")]
            [Validation(Required=false)]
            public bool? AutoRefreshEnabled { get; set; }

            /// <summary>
            /// <para>The clustering attribute. This response parameter is returned when the table is a clustered table.</para>
            /// </summary>
            [NameInMap("clusterInfo")]
            [Validation(Required=false)]
            public GetTableInfoResponseBodyDataClusterInfo ClusterInfo { get; set; }
            public class GetTableInfoResponseBodyDataClusterInfo : TeaModel {
                /// <summary>
                /// <para>Optional. The number of buckets in the clustered table. The value 0 indicates that the number of buckets dynamically changes when a job is running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("bucketNum")]
                [Validation(Required=false)]
                public long? BucketNum { get; set; }

                /// <summary>
                /// <para>The cluster keys.</para>
                /// </summary>
                [NameInMap("clusterCols")]
                [Validation(Required=false)]
                public List<string> ClusterCols { get; set; }

                /// <summary>
                /// <para>The clustering type of the table. MaxCompute supports <a href="https://www.alibabacloud.com/help/maxcompute/use-cases/hash-clustering">hash clustering</a> and</para>
                /// <para><a href="https://www.alibabacloud.com/help/maxcompute/use-cases/range-clustering">range clustering</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hash</para>
                /// </summary>
                [NameInMap("clusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// <para>The condition by which the results are sorted.</para>
                /// </summary>
                [NameInMap("sortCols")]
                [Validation(Required=false)]
                public List<GetTableInfoResponseBodyDataClusterInfoSortCols> SortCols { get; set; }
                public class GetTableInfoResponseBodyDataClusterInfoSortCols : TeaModel {
                    /// <summary>
                    /// <para>The name of the sorting field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>col_2</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The sorting order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DESC</para>
                    /// </summary>
                    [NameInMap("order")]
                    [Validation(Required=false)]
                    public string Order { get; set; }

                }

            }

            /// <summary>
            /// <para>The comments of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sale_detail</para>
            /// </summary>
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>DDL statement to create a table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>create table if not exists sale_detail( shop_name STRING, customer_id STRING, total_price DOUBLE) partitioned by (sale_date STRING, region STRING);</para>
            /// </summary>
            [NameInMap("createTableDDL")]
            [Validation(Required=false)]
            public string CreateTableDDL { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-17T07:07:47Z</para>
            /// </summary>
            [NameInMap("creationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project_name.schema_name.table_name</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The number of file of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("fileNum")]
            [Validation(Required=false)]
            public long? FileNum { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is an external table. This response parameter is returned when type is set to external.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isExternalTable")]
            [Validation(Required=false)]
            public bool? IsExternalTable { get; set; }

            /// <summary>
            /// <para>Indicates whether data of the materialized view is invalid due to changes in the data of the source table. This response parameter is returned when type is set to materializedView.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isOutdated")]
            [Validation(Required=false)]
            public bool? IsOutdated { get; set; }

            /// <summary>
            /// <para>The time when data of the table or view was last accessed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T02:05:56Z</para>
            /// </summary>
            [NameInMap("lastAccessTime")]
            [Validation(Required=false)]
            public long? LastAccessTime { get; set; }

            /// <summary>
            /// <para>The time when the data definition language (DDL) statement of the table or view was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T02:05:56Z</para>
            /// </summary>
            [NameInMap("lastDDLTime")]
            [Validation(Required=false)]
            public long? LastDDLTime { get; set; }

            /// <summary>
            /// <para>The time when data of the table or view was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T02:05:56Z</para>
            /// </summary>
            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

            /// <summary>
            /// <para>The lifecycle. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("lifecycle")]
            [Validation(Required=false)]
            public string Lifecycle { get; set; }

            /// <summary>
            /// <para>The path of the external table. This response parameter is returned when type is set to external.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://oss-cn-hangzhou-internal.aliyuncs.com/oss-mc-test/Demo1/</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>Indicates whether the table or view is a <a href="https://www.alibabacloud.com/help/maxcompute/user-guide/materialized-view-operations">materialize view</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("materializedView")]
            [Validation(Required=false)]
            public bool? MaterializedView { get; set; }

            /// <summary>
            /// <para>The name of the table or view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sale_detail</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The field information.</para>
            /// </summary>
            [NameInMap("nativeColumns")]
            [Validation(Required=false)]
            public List<GetTableInfoResponseBodyDataNativeColumns> NativeColumns { get; set; }
            public class GetTableInfoResponseBodyDataNativeColumns : TeaModel {
                /// <summary>
                /// <para>The column comments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of shop.</para>
                /// </summary>
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The sensitivity-level label of the column. For more information, see <a href="https://www.alibabacloud.com/help/maxcompute/user-guide/label-based-access-control">Label-based access control</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The column name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>shop_name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The column type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the role AliyunODPSDefaultRole in Resource Access Management (RAM). This response parameter is returned when type is set to external.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::xxxxx:role/aliyunodpsdefaultrole</para>
            /// </summary>
            [NameInMap("odpsPropertiesRolearn")]
            [Validation(Required=false)]
            public string OdpsPropertiesRolearn { get; set; }

            /// <summary>
            /// <para>Indicates whether the table header is ignored. This response parameter is returned when type is set to external.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("odpsSqlTextOptionFlushHeader")]
            [Validation(Required=false)]
            public bool? OdpsSqlTextOptionFlushHeader { get; set; }

            /// <summary>
            /// <para>The first N rows that were ignored in the table header. This response parameter is returned when type is set to external.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("odpsTextOptionHeaderLinesCount")]
            [Validation(Required=false)]
            public long? OdpsTextOptionHeaderLinesCount { get; set; }

            /// <summary>
            /// <para>The account information of the table or view owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188785396123****</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The information about partition key columns. This response parameter is returned only for partitioned tables.</para>
            /// </summary>
            [NameInMap("partitionColumns")]
            [Validation(Required=false)]
            public List<GetTableInfoResponseBodyDataPartitionColumns> PartitionColumns { get; set; }
            public class GetTableInfoResponseBodyDataPartitionColumns : TeaModel {
                /// <summary>
                /// <para>The comments of the partition key column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sale date.</para>
                /// </summary>
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The sensitivity-level label of the column. For more information, see <a href="https://www.alibabacloud.com/help/maxcompute/user-guide/label-based-access-control">Label-based access control</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The partition name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sale_date</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The partition column type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The physical size of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2763</para>
            /// </summary>
            [NameInMap("physicalSize")]
            [Validation(Required=false)]
            public long? PhysicalSize { get; set; }

            /// <summary>
            /// <para>The name of the project to which the table or view belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>projectA</para>
            /// </summary>
            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>Indicates whether the query rewrite operation can be performed by using the materialized view. This response parameter is returned when type is set to materializedView.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("rewriteEnabled")]
            [Validation(Required=false)]
            public bool? RewriteEnabled { get; set; }

            /// <summary>
            /// <para>The name of the schema to which the table or the view belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>The data size of the non-partitioned table. If the table is a partitioned table, the system does not calculate the data size of the table. In this case, the value of this parameter is NULL. The PARTITIONS view includes the data size of each partition in a partitioned table. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5372</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The storage handler of the external table. This response parameter is returned when type is set to external.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aliyun.odps.CsvStorageHandler</para>
            /// </summary>
            [NameInMap("storageHandler")]
            [Validation(Required=false)]
            public string StorageHandler { get; set; }

            /// <summary>
            /// <para>The sensitivity-level label of the table. For more information, see <a href="https://www.alibabacloud.com/help/maxcompute/user-guide/label-based-access-control">Label-based access control</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("tableLabel")]
            [Validation(Required=false)]
            public string TableLabel { get; set; }

            /// <summary>
            /// <para>The name of the Tablestore table to be accessed. This response parameter is returned when type is set to external.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ots_tpch_orders</para>
            /// </summary>
            [NameInMap("tablesotreTableName")]
            [Validation(Required=false)]
            public string TablesotreTableName { get; set; }

            /// <summary>
            /// <para>The columns of the Tablestore table to be accessed, including the primary key column and attribute column. This response parameter is returned when type is set to external.</para>
            /// 
            /// <b>Example:</b>
            /// <para>:o_orderkey,:o_orderdate,o_custkey,o_orderstatus,o_totalprice</para>
            /// </summary>
            [NameInMap("tablestoreColumnsMapping")]
            [Validation(Required=false)]
            public string TablestoreColumnsMapping { get; set; }

            /// <summary>
            /// <para>The type of the table or view. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>internal</b>: internal table</description></item>
            /// <item><description><b>external</b>: external table</description></item>
            /// <item><description><b>view</b>: view</description></item>
            /// <item><description><b>materializedView</b>: <a href="https://www.alibabacloud.com/help/maxcompute/user-guide/materialized-view-operations">materialize view</a></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internal</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The statement that generates the view. This response parameter is returned when type is set to view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select shop_name, sum(total_price) from sale_detail group by shop_name</para>
            /// </summary>
            [NameInMap("viewText")]
            [Validation(Required=false)]
            public string ViewText { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a06dd4516687375802853481ec9fd</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
