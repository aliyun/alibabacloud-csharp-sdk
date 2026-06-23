// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDIJobsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the destination data source. If you do not specify this parameter, jobs are not filtered by this criterion. Valid values: <c>Hologres</c>, <c>OSS-HDFS</c>, <c>OSS</c>, <c>MaxCompute</c>, <c>LogHub</c>, <c>StarRocks</c>, <c>DataHub</c>, <c>AnalyticDB_For_MySQL</c>, <c>Kafka</c>, and <c>Hive</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hologres</para>
        /// </summary>
        [NameInMap("DestinationDataSourceType")]
        [Validation(Required=false)]
        public string DestinationDataSourceType { get; set; }

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

        /// <summary>
        /// <para>The name of the Data Integration job.</para>
        /// <para>The name must be unique within the DataWorks workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_export_01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Pages are numbered starting from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default: 10. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1967</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The type of the source data source. If you do not specify this parameter, jobs are not filtered by this criterion. Valid values: <c>PolarDB</c>, <c>MySQL</c>, <c>Kafka</c>, <c>LogHub</c>, <c>Hologres</c>, <c>Oracle</c>, <c>OceanBase</c>, <c>MongoDB</c>, <c>RedShift</c>, <c>Hive</c>, <c>SQLServer</c>, <c>Doris</c>, and <c>ClickHouse</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SourceDataSourceType")]
        [Validation(Required=false)]
        public string SourceDataSourceType { get; set; }

        /// <summary>
        /// <para>The configuration type of the job. Valid values: <c>FILESPEC</c>, <c>CLASSIC</c>, and <c>ALL</c>. <c>FILESPEC</c> indicates a new job type configured based on a structured file specification. <c>CLASSIC</c> indicates a job configured in the traditional mode. If you set this parameter to <c>ALL</c>, jobs of both types are returned.</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

    }

}
