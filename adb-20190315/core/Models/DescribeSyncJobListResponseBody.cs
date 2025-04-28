// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSyncJobListResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-j6c22lubl8d9l3989</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public int? DBClusterId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>482B8BAE-6EC0-5C0E-B2AF-FD42A3FC5B67</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried synchronization jobs.</para>
        /// </summary>
        [NameInMap("SyncJobs")]
        [Validation(Required=false)]
        public List<DescribeSyncJobListResponseBodySyncJobs> SyncJobs { get; set; }
        public class DescribeSyncJobListResponseBodySyncJobs : TeaModel {
            /// <summary>
            /// <para>The ID of the Spark job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dts-xxxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The description of the source instance or cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SourceDBClusterDescription")]
            [Validation(Required=false)]
            public string SourceDBClusterDescription { get; set; }

            /// <summary>
            /// <para>The ID of the source cluster. You can call the <a href="https://help.aliyun.com/document_detail/170879.html">DescribeDBClusters</a> operation to query backup set IDs.</para>
            /// <remarks>
            /// <para> If you want to restore the data of an ApsaraDB for ClickHouse cluster, this parameter is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>pc-t4n766v2llx852n81</para>
            /// </summary>
            [NameInMap("SourceDBClusterId")]
            [Validation(Required=false)]
            public string SourceDBClusterId { get; set; }

            /// <summary>
            /// <para>The database type of the source instance or cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb</para>
            /// </summary>
            [NameInMap("SourceDBType")]
            [Validation(Required=false)]
            public string SourceDBType { get; set; }

            /// <summary>
            /// <para>The storage size of the source instance or cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SourceStorageSize")]
            [Validation(Required=false)]
            public int? SourceStorageSize { get; set; }

            /// <summary>
            /// <para>The number of tables in the source instance or cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SourceTableNumber")]
            [Validation(Required=false)]
            public int? SourceTableNumber { get; set; }

            /// <summary>
            /// <para>The synchronization platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADB-CDC</para>
            /// </summary>
            [NameInMap("SyncPlatform")]
            [Validation(Required=false)]
            public string SyncPlatform { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
