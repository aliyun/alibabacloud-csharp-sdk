// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDIJobsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDIJobsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The synchronization tasks returned.</para>
            /// </summary>
            [NameInMap("DIJobs")]
            [Validation(Required=false)]
            public List<ListDIJobsResponseBodyPagingInfoDIJobs> DIJobs { get; set; }
            public class ListDIJobsResponseBodyPagingInfoDIJobs : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>This parameter is deprecated. Use the Id parameter instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32599</para>
                /// </summary>
                [NameInMap("DIJobId")]
                [Validation(Required=false)]
                [Obsolete]
                public long? DIJobId { get; set; }

                /// <summary>
                /// <para>The destination type. Valid values: Hologres, OSS-HDFS, OSS, MaxCompute, Loghub, STARROCKS, DataHub, ANALYTICDB_FOR_MYSQL, Kafka, and Hive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hologres</para>
                /// </summary>
                [NameInMap("DestinationDataSourceType")]
                [Validation(Required=false)]
                public string DestinationDataSourceType { get; set; }

                /// <summary>
                /// <para>The ID of the synchronization task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32599</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the synchronization task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql_to_holo_sync_35197</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The status of the synchronization task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Finished</description></item>
                /// <item><description>Initialized</description></item>
                /// <item><description>Stopped</description></item>
                /// <item><description>Failed</description></item>
                /// <item><description>Running</description></item>
                /// <item><description>Stopping</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("JobStatus")]
                [Validation(Required=false)]
                public string JobStatus { get; set; }

                /// <summary>
                /// <para>The synchronization type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FullAndRealtimeIncremental: one-time full synchronization and real-time incremental synchronization</description></item>
                /// <item><description>RealtimeIncremental: real-time incremental synchronization</description></item>
                /// <item><description>Full: full synchronization</description></item>
                /// <item><description>OfflineIncremental: batch incremental synchronization</description></item>
                /// <item><description>FullAndOfflineIncremental: one-time full synchronization and batch incremental synchronization</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FullAndRealtimeIncremental</para>
                /// </summary>
                [NameInMap("MigrationType")]
                [Validation(Required=false)]
                public string MigrationType { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace to which the synchronization task belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26442</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The source type. Valid values: PolarDB, MySQL, Kafka, Loghub, Hologres, Oracle, OceanBase, MongoDB, RedShift, Hive, SqlServer, Doris, and ClickHouse. If you do not configure this parameter, the API operation returns synchronization tasks that use all types of sources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mysql</para>
                /// </summary>
                [NameInMap("SourceDataSourceType")]
                [Validation(Required=false)]
                public string SourceDataSourceType { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7263E4AC-9D2E-5B29-B8AF-7C5012E92A41</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
