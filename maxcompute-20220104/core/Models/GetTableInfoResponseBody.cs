// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetTableInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTableInfoResponseBodyData Data { get; set; }
        public class GetTableInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic refresh of the materialized view is enabled. This parameter is returned only when the type is materialized view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("autoRefreshEnabled")]
            [Validation(Required=false)]
            public bool? AutoRefreshEnabled { get; set; }

            /// <summary>
            /// <para>The clustering properties. This parameter is returned only when the table type is clustered table.</para>
            /// </summary>
            [NameInMap("clusterInfo")]
            [Validation(Required=false)]
            public GetTableInfoResponseBodyDataClusterInfo ClusterInfo { get; set; }
            public class GetTableInfoResponseBodyDataClusterInfo : TeaModel {
                /// <summary>
                /// <para>The number of buckets in the clustered table. This is an optional field. A value of 0 indicates that the number of buckets is dynamically determined during job execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("bucketNum")]
                [Validation(Required=false)]
                public long? BucketNum { get; set; }

                /// <summary>
                /// <para>The cluster key.</para>
                /// </summary>
                [NameInMap("clusterCols")]
                [Validation(Required=false)]
                public List<string> ClusterCols { get; set; }

                /// <summary>
                /// <para>The clustering type of the table. MaxCompute currently supports &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/use-cases/hash-clustering">Hash Clustering</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/use-cases/hash-clustering">Hash Clustering</a> and
                /// &lt;props=&quot;china&quot;&gt; <a href="https://www.alibabacloud.com/help/en/maxcompute/use-cases/hash-clustering">Range Clustering</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/use-cases/range-clustering">Range Clustering</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hash</para>
                /// </summary>
                [NameInMap("clusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// <para>The sort columns.</para>
                /// </summary>
                [NameInMap("sortCols")]
                [Validation(Required=false)]
                public List<GetTableInfoResponseBodyDataClusterInfoSortCols> SortCols { get; set; }
                public class GetTableInfoResponseBodyDataClusterInfoSortCols : TeaModel {
                    /// <summary>
                    /// <para>The name of the sort column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>col_2</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The sort order.</para>
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
            /// <para>The table comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sale_detail</para>
            /// </summary>
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The DDL statement used to create the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>create table if not exists sale_detail( shop_name STRING, customer_id STRING, total_price DOUBLE) partitioned by (sale_date STRING, region STRING);</para>
            /// </summary>
            [NameInMap("createTableDDL")]
            [Validation(Required=false)]
            public string CreateTableDDL { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in ISO 8601 format and in the UTC time zone.</para>
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
            /// <para>odps_project.default.sale_detail</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The number of files.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("fileNum")]
            [Validation(Required=false)]
            public long? FileNum { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is an external table. This parameter is returned only when the type is table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isExternalTable")]
            [Validation(Required=false)]
            public bool? IsExternalTable { get; set; }

            /// <summary>
            /// <para>Indicates whether the data in the materialized view is invalid due to changes in the source table data. This parameter is returned only when the type is materialized view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isOutdated")]
            [Validation(Required=false)]
            public bool? IsOutdated { get; set; }

            /// <summary>
            /// <para>The time when the data of the table or view was last accessed. This parameter is returned only when the table is a non-partitioned table.</para>
            /// <remarks>
            /// <para>This data has been gradually collected since July 2023. If the table has not been accessed after the upgrade, or if it is accessed through ALGO jobs or Hologres direct read, the last_access_time cannot be collected.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T02:05:56Z</para>
            /// </summary>
            [NameInMap("lastAccessTime")]
            [Validation(Required=false)]
            public long? LastAccessTime { get; set; }

            /// <summary>
            /// <para>The time when the DDL statement of the table or view was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T02:05:56Z</para>
            /// </summary>
            [NameInMap("lastDDLTime")]
            [Validation(Required=false)]
            public long? LastDDLTime { get; set; }

            /// <summary>
            /// <para>The time when the data of the table or view was last modified. The time is in ISO 8601 format and in the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-21T02:05:56Z</para>
            /// </summary>
            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

            /// <summary>
            /// <para>The lifecycle in days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("lifecycle")]
            [Validation(Required=false)]
            public string Lifecycle { get; set; }

            /// <summary>
            /// <para>The external table location. This parameter is returned only when the type is external table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://oss-cn-hangzhou-internal.aliyuncs.com/oss-mc-test/Demo1/</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is a &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/materialized-view-operations">materialized view</a>
            /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/user-guide/materialized-view-operations">materialized view</a>.</para>
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
            /// <para>The column information.</para>
            /// </summary>
            [NameInMap("nativeColumns")]
            [Validation(Required=false)]
            public List<GetTableInfoResponseBodyDataNativeColumns> NativeColumns { get; set; }
            public class GetTableInfoResponseBodyDataNativeColumns : TeaModel {
                /// <summary>
                /// <para>The column comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Store name</para>
                /// </summary>
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The sensitivity level label of the column. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/label-based-access-control">Label-based access control</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/user-guide/label-based-access-control">Label-based access control</a>.</para>
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
                /// <para>The data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The ARN of AliyunODPSDefaultRole in RAM. This parameter is returned only when the type is external table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::xxxxx:role/aliyunodpsdefaultrole</para>
            /// </summary>
            [NameInMap("odpsPropertiesRolearn")]
            [Validation(Required=false)]
            public string OdpsPropertiesRolearn { get; set; }

            /// <summary>
            /// <para>Indicates whether to ignore the header. This parameter is returned only when the type is external table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("odpsSqlTextOptionFlushHeader")]
            [Validation(Required=false)]
            public bool? OdpsSqlTextOptionFlushHeader { get; set; }

            /// <summary>
            /// <para>The number of header lines to ignore. This parameter is returned only when the type is external table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("odpsTextOptionHeaderLinesCount")]
            [Validation(Required=false)]
            public long? OdpsTextOptionHeaderLinesCount { get; set; }

            /// <summary>
            /// <para>The account information of the owner of the table or view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN$odps****@aliyunid.com</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The partition column information. This parameter is returned only for partitioned tables.</para>
            /// </summary>
            [NameInMap("partitionColumns")]
            [Validation(Required=false)]
            public List<GetTableInfoResponseBodyDataPartitionColumns> PartitionColumns { get; set; }
            public class GetTableInfoResponseBodyDataPartitionColumns : TeaModel {
                /// <summary>
                /// <para>The partition column comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sale date</para>
                /// </summary>
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The sensitivity level label of the column. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/label-based-access-control">Label-based access control</a>
                /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/user-guide/label-based-access-control">Label-based access control</a>.</para>
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
                /// <para>ds=\&quot;20190130\&quot;</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The physical size.</para>
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
            /// <para>odps_project</para>
            /// </summary>
            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>Indicates whether query rewrite through the materialized view is allowed. This parameter is returned only when the type is materialized view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("rewriteEnabled")]
            [Validation(Required=false)]
            public bool? RewriteEnabled { get; set; }

            /// <summary>
            /// <para>The name of the schema to which the table or view belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>The data size of the table. If the table is a non-partitioned table, the value is the data size of the table. If the table is a partitioned table, the system does not calculate the data size of the table, and the value is NULL. The PARTITIONS view contains the data size of each partition in the partitioned table. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5372</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The external table parser. This parameter is returned only when the type is external table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aliyun.odps.CsvStorageHandler</para>
            /// </summary>
            [NameInMap("storageHandler")]
            [Validation(Required=false)]
            public string StorageHandler { get; set; }

            /// <summary>
            /// <para>The sensitivity level label of the table. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/label-based-access-control">Label-based access control</a>
            /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/user-guide/label-based-access-control">Label-based access control</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("tableLabel")]
            [Validation(Required=false)]
            public string TableLabel { get; set; }

            /// <summary>
            /// <para>The name of the Tablestore table to be accessed. This parameter is returned only when the type is external table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ots_tpch_orders</para>
            /// </summary>
            [NameInMap("tablesotreTableName")]
            [Validation(Required=false)]
            public string TablesotreTableName { get; set; }

            /// <summary>
            /// <para>The columns of the Tablestore table to be accessed by MaxCompute, including the primary key columns and attribute columns. This parameter is returned only when the type is external table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>o_orderkey,o_orderdate,o_custkey,o_orderstatus,o_totalprice</para>
            /// </summary>
            [NameInMap("tablestoreColumnsMapping")]
            [Validation(Required=false)]
            public string TablestoreColumnsMapping { get; set; }

            /// <summary>
            /// <para>The type of the table or view. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>internal</b>: Internal table.</description></item>
            /// <item><description><b>external</b>: External table.</description></item>
            /// <item><description><b>view</b>: View.</description></item>
            /// <item><description><b>materializedView</b>: &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/materialized-view-operations">Materialized view</a>
            /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/user-guide/materialized-view-operations">Materialized view</a>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internal</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The statement used to create the view. This parameter is returned only when the type is view.</para>
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
