// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataIngestionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data ingestions.</para>
        /// </summary>
        [NameInMap("DataIngestions")]
        [Validation(Required=false)]
        public List<ListDataIngestionsResponseBodyDataIngestions> DataIngestions { get; set; }
        public class ListDataIngestionsResponseBodyDataIngestions : TeaModel {
            /// <summary>
            /// <para>The time when the data ingestion was enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("ActiveTime")]
            [Validation(Required=false)]
            public long? ActiveTime { get; set; }

            /// <summary>
            /// <para>The number of associated security capabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CapacityCount")]
            [Validation(Required=false)]
            public int? CapacityCount { get; set; }

            /// <summary>
            /// <para>The time when the data ingestion was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the data ingestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_netstat_ingestion_173326*******</para>
            /// </summary>
            [NameInMap("DataIngestionId")]
            [Validation(Required=false)]
            public string DataIngestionId { get; set; }

            /// <summary>
            /// <para>The mode of the data ingestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>realtime</para>
            /// </description></item>
            /// <item><description><para>scan</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>realtime</para>
            /// </summary>
            [NameInMap("DataIngestionMode")]
            [Validation(Required=false)]
            public string DataIngestionMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the data ingestion mode is editable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataIngestionModeEditable")]
            [Validation(Required=false)]
            public bool? DataIngestionModeEditable { get; set; }

            /// <summary>
            /// <para>The state of the data ingestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ingested</para>
            /// </description></item>
            /// <item><description><para>uningested</para>
            /// </description></item>
            /// <item><description><para>abnormal</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ingested</para>
            /// </summary>
            [NameInMap("DataIngestionState")]
            [Validation(Required=false)]
            public string DataIngestionState { get; set; }

            /// <summary>
            /// <para>The error code for the data ingestion anomaly.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UserUnauthorized</para>
            /// </summary>
            [NameInMap("DataIngestionStateCode")]
            [Validation(Required=false)]
            public string DataIngestionStateCode { get; set; }

            /// <summary>
            /// <para>The status of the data ingestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: The data ingestion is enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: The data ingestion is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("DataIngestionStatus")]
            [Validation(Required=false)]
            public string DataIngestionStatus { get; set; }

            /// <summary>
            /// <para>The ID of the data ingestion template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_netstat_ingestion</para>
            /// </summary>
            [NameInMap("DataIngestionTemplateId")]
            [Validation(Required=false)]
            public string DataIngestionTemplateId { get; set; }

            /// <summary>
            /// <para>The type of the data ingestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>preset</para>
            /// </description></item>
            /// <item><description><para>custom</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("DataIngestionType")]
            [Validation(Required=false)]
            public string DataIngestionType { get; set; }

            /// <summary>
            /// <para>Indicates whether the data source is editable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataSourceEditable")]
            [Validation(Required=false)]
            public bool? DataSourceEditable { get; set; }

            /// <summary>
            /// <para>The ID of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-scpfegri73oyoknbc90c</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the normalization rule is editable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationRuleEditable")]
            [Validation(Required=false)]
            public bool? NormalizationRuleEditable { get; set; }

            /// <summary>
            /// <para>The ID of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nr-0aywiqdtaqdvwac7xkbjsf3a</para>
            /// </summary>
            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

            /// <summary>
            /// <para>The ID of the data source for real-time ingestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-scpfegri73oyoknbc90c</para>
            /// </summary>
            [NameInMap("RealtimeDataSourceId")]
            [Validation(Required=false)]
            public string RealtimeDataSourceId { get; set; }

            /// <summary>
            /// <para>The ID of the data source for scan-based ingestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds-scpfegri73oyoknbc90c</para>
            /// </summary>
            [NameInMap("ScanDataSourceId")]
            [Validation(Required=false)]
            public string ScanDataSourceId { get; set; }

            /// <summary>
            /// <para>The job ID of the stream processing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73a78aa245e3b1299d6ceed093de7bd8</para>
            /// </summary>
            [NameInMap("StreamJobId")]
            [Validation(Required=false)]
            public string StreamJobId { get; set; }

            /// <summary>
            /// <para>The time when the data ingestion was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
