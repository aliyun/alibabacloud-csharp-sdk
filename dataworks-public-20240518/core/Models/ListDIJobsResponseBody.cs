// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDIJobsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDIJobsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>A list of Data Integration jobs.</para>
            /// </summary>
            [NameInMap("DIJobs")]
            [Validation(Required=false)]
            public List<ListDIJobsResponseBodyPagingInfoDIJobs> DIJobs { get; set; }
            public class ListDIJobsResponseBodyPagingInfoDIJobs : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>This parameter is deprecated. Use the <c>Id</c> parameter instead.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32599</para>
                /// </summary>
                [NameInMap("DIJobId")]
                [Validation(Required=false)]
                [Obsolete]
                public long? DIJobId { get; set; }

                /// <summary>
                /// <para>The type of the destination data source. Valid values: <c>Hologres</c>, <c>OSS-HDFS</c>, <c>OSS</c>, <c>MaxCompute</c>, <c>LogHub</c>, <c>StarRocks</c>, <c>DataHub</c>, <c>AnalyticDB_For_MySQL</c>, <c>Kafka</c>, and <c>Hive</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hologres</para>
                /// </summary>
                [NameInMap("DestinationDataSourceType")]
                [Validation(Required=false)]
                public string DestinationDataSourceType { get; set; }

                /// <summary>
                /// <para>The ID of the Data Integration job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32599</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql_to_holo_sync_35197</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The job status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Finished</c>: The job completed successfully.</para>
                /// </description></item>
                /// <item><description><para><c>Initialized</c>: The job is initialized.</para>
                /// </description></item>
                /// <item><description><para><c>Stopped</c>: The job is stopped.</para>
                /// </description></item>
                /// <item><description><para><c>Failed</c>: The job failed.</para>
                /// </description></item>
                /// <item><description><para><c>Running</c>: The job is running.</para>
                /// </description></item>
                /// <item><description><para><c>Stopping</c>: The job is being stopped.</para>
                /// </description></item>
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
                /// <item><description><para><c>FullAndRealtimeIncremental</c>: full and real-time incremental synchronization</para>
                /// </description></item>
                /// <item><description><para><c>RealtimeIncremental</c>: real-time incremental synchronization</para>
                /// </description></item>
                /// <item><description><para><c>Full</c>: full synchronization</para>
                /// </description></item>
                /// <item><description><para><c>OfflineIncremental</c>: offline incremental synchronization</para>
                /// </description></item>
                /// <item><description><para><c>FullAndOfflineIncremental</c>: full and offline incremental synchronization</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FullAndRealtimeIncremental</para>
                /// </summary>
                [NameInMap("MigrationType")]
                [Validation(Required=false)]
                public string MigrationType { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace that contains the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26442</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The type of the source data source. Valid values: <c>PolarDB</c>, <c>MySQL</c>, <c>Kafka</c>, <c>LogHub</c>, <c>Hologres</c>, <c>Oracle</c>, <c>OceanBase</c>, <c>MongoDB</c>, <c>RedShift</c>, <c>Hive</c>, <c>SQLServer</c>, <c>Doris</c>, and <c>ClickHouse</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mysql</para>
                /// </summary>
                [NameInMap("SourceDataSourceType")]
                [Validation(Required=false)]
                public string SourceDataSourceType { get; set; }

            }

            /// <summary>
            /// <para>The returned page number.</para>
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
            /// <para>The total number of entries that meet the filter criteria.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7263E4AC-9D2E-5B29-B8AF-7C5012E92A41</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
