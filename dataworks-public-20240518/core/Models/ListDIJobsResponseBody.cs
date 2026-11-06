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
            /// <para>The data integration tasks.</para>
            /// </summary>
            [NameInMap("DIJobs")]
            [Validation(Required=false)]
            public List<ListDIJobsResponseBodyPagingInfoDIJobs> DIJobs { get; set; }
            public class ListDIJobsResponseBodyPagingInfoDIJobs : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para><b>[Deprecated]</b> This field is deprecated. Use the Id field instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32599</para>
                /// </summary>
                [NameInMap("DIJobId")]
                [Validation(Required=false)]
                [Obsolete]
                public long? DIJobId { get; set; }

                /// <summary>
                /// <para>The type of the destination data source. Valid values: Hologres, OSS-HDFS, OSS, MaxCompute, Loghub, STARROCKS, DataHub, ANALYTICDB_FOR_MYSQL, Kafka, and Hive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hologres</para>
                /// </summary>
                [NameInMap("DestinationDataSourceType")]
                [Validation(Required=false)]
                public string DestinationDataSourceType { get; set; }

                /// <summary>
                /// <para>The ID of the data integration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32599</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql_to_holo_sync_35197</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The synchronization status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Finished: finished successfully</description></item>
                /// <item><description>Initialized: initialized</description></item>
                /// <item><description>Stopped: stopped</description></item>
                /// <item><description>Failed: failed</description></item>
                /// <item><description>Running: running</description></item>
                /// <item><description>Stopping: stopping</description></item>
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
                /// <item><description>FullAndRealtimeIncremental: full and real-time incremental synchronization</description></item>
                /// <item><description>RealtimeIncremental: real-time incremental synchronization</description></item>
                /// <item><description>Full: full synchronization</description></item>
                /// <item><description>OfflineIncremental: batch incremental synchronization</description></item>
                /// <item><description>FullAndOfflineIncremental: full and batch incremental synchronization</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FullAndRealtimeIncremental</para>
                /// </summary>
                [NameInMap("MigrationType")]
                [Validation(Required=false)]
                public string MigrationType { get; set; }

                /// <summary>
                /// <para>The owner of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3726346</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace to which the task belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26442</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The type of the source data source. Valid values: PolarDB, MySQL, Kafka, Loghub, Hologres, Oracle, OceanBase, MongoDB, RedShift, Hive, SqlServer, Doris, and ClickHouse.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mysql</para>
                /// </summary>
                [NameInMap("SourceDataSourceType")]
                [Validation(Required=false)]
                public string SourceDataSourceType { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that meet the conditions.</para>
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
