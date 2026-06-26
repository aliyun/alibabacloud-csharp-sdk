// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CatalogSummary : TeaModel {
        /// <summary>
        /// <para>The total number of metadata requests in the current month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("apiVisitCountMonthly")]
        [Validation(Required=false)]
        public long? ApiVisitCountMonthly { get; set; }

        /// <summary>
        /// <para>The month-over-month data on the total number of databases.</para>
        /// </summary>
        [NameInMap("databaseCount")]
        [Validation(Required=false)]
        public MoMValues DatabaseCount { get; set; }

        /// <summary>
        /// <para>The total number of file requests for the current month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("fileAccessCountMonthly")]
        [Validation(Required=false)]
        public long? FileAccessCountMonthly { get; set; }

        /// <summary>
        /// <para>The date when the storage overview data was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01</para>
        /// </summary>
        [NameInMap("generatedDate")]
        [Validation(Required=false)]
        public string GeneratedDate { get; set; }

        /// <summary>
        /// <para>The storage usage for Archive data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeArchiveSize")]
        [Validation(Required=false)]
        public long? ObjTypeArchiveSize { get; set; }

        /// <summary>
        /// <para>The storage usage for Cold Archive data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeColdArchiveSize")]
        [Validation(Required=false)]
        public long? ObjTypeColdArchiveSize { get; set; }

        /// <summary>
        /// <para>The storage usage for Infrequent Access (IA) data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeIaSize")]
        [Validation(Required=false)]
        public long? ObjTypeIaSize { get; set; }

        /// <summary>
        /// <para>The storage usage for Standard data files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("objTypeStandardSize")]
        [Validation(Required=false)]
        public long? ObjTypeStandardSize { get; set; }

        /// <summary>
        /// <para>The month-over-month data on the total number of partitions.</para>
        /// </summary>
        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public MoMValues PartitionCount { get; set; }

        /// <summary>
        /// <para>The month-over-month data on the total number of tables.</para>
        /// </summary>
        [NameInMap("tableCount")]
        [Validation(Required=false)]
        public MoMValues TableCount { get; set; }

        /// <summary>
        /// <para>The data access traffic for the current month, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("throughputMonthly")]
        [Validation(Required=false)]
        public long? ThroughputMonthly { get; set; }

        /// <summary>
        /// <para>The month-over-month data on the total number of files.</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public MoMValues TotalFileCount { get; set; }

        /// <summary>
        /// <para>The change in storage capacity from the previous period, in bytes.</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public MoMValues TotalFileSizeInBytes { get; set; }

        /// <summary>
        /// <para>The month-over-month data for the total number of metadata files.</para>
        /// </summary>
        [NameInMap("totalMetaFileCount")]
        [Validation(Required=false)]
        public MoMValues TotalMetaFileCount { get; set; }

        /// <summary>
        /// <para>The month-over-month data for the storage usage of metadata files, in bytes.</para>
        /// </summary>
        [NameInMap("totalMetaSizeInBytes")]
        [Validation(Required=false)]
        public MoMValues TotalMetaSizeInBytes { get; set; }

    }

}
