// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ListMetaProfilingResultCatalogPageResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListMetaProfilingResultCatalogPageResponseBodyData> Data { get; set; }
        public class ListMetaProfilingResultCatalogPageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>catalog_hive_prod</para>
            /// </summary>
            [NameInMap("catalogName")]
            [Validation(Required=false)]
            public string CatalogName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100256</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("lastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3001</para>
            /// </summary>
            [NameInMap("metaDatasourceId")]
            [Validation(Required=false)]
            public long? MetaDatasourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HIVE</para>
            /// </summary>
            [NameInMap("metaDatasourceType")]
            [Validation(Required=false)]
            public string MetaDatasourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("migrationProgress")]
            [Validation(Required=false)]
            public double? MigrationProgress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DONE</para>
            /// </summary>
            [NameInMap("migrationStatus")]
            [Validation(Required=false)]
            public string MigrationStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("partitionCount")]
            [Validation(Required=false)]
            public int? PartitionCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>96</para>
            /// </summary>
            [NameInMap("ptTableCount")]
            [Validation(Required=false)]
            public int? PtTableCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("recordCount")]
            [Validation(Required=false)]
            public long? RecordCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("schemaCount")]
            [Validation(Required=false)]
            public int? SchemaCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("storageSize")]
            [Validation(Required=false)]
            public string StorageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("tableCount")]
            [Validation(Required=false)]
            public int? TableCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("viewCount")]
            [Validation(Required=false)]
            public int? ViewCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParameter</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The parameter is invalid or missing.</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3F45B8C1-2A6E-4C9B-9E1F-7D2A1B0C5E66</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
