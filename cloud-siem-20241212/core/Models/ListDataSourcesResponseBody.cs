// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data sources.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<ListDataSourcesResponseBodyDataSources> DataSources { get; set; }
        public class ListDataSourcesResponseBodyDataSources : TeaModel {
            /// <summary>
            /// <para>The time when the data source was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The source of the data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>center</para>
            /// </description></item>
            /// <item><description><para>custom</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>center</para>
            /// </summary>
            [NameInMap("DataSourceFrom")]
            [Validation(Required=false)]
            public string DataSourceFrom { get; set; }

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
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AD_LOG</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>Indicates whether new Logstores are automatically discovered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataSourceRecognizeEnabled")]
            [Validation(Required=false)]
            public bool? DataSourceRecognizeEnabled { get; set; }

            /// <summary>
            /// <para>The data source recognizer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_account_snapshot</para>
            /// </summary>
            [NameInMap("DataSourceRecognizer")]
            [Validation(Required=false)]
            public string DataSourceRecognizer { get; set; }

            /// <summary>
            /// <para>The list of data ingestion IDs that are associated with the data source.</para>
            /// </summary>
            [NameInMap("DataSourceReferences")]
            [Validation(Required=false)]
            public List<ListDataSourcesResponseBodyDataSourcesDataSourceReferences> DataSourceReferences { get; set; }
            public class ListDataSourcesResponseBodyDataSourcesDataSourceReferences : TeaModel {
                /// <summary>
                /// <para>The data ingestion ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas_account_snapshot_log_173326*******</para>
                /// </summary>
                [NameInMap("DataIngestionId")]
                [Validation(Required=false)]
                public string DataIngestionId { get; set; }

            }

            /// <summary>
            /// <para>The status of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>unconfigured</para>
            /// </description></item>
            /// <item><description><para>normal</para>
            /// </description></item>
            /// <item><description><para>abnormal</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unconfigured</para>
            /// </summary>
            [NameInMap("DataSourceStatus")]
            [Validation(Required=false)]
            public string DataSourceStatus { get; set; }

            /// <summary>
            /// <para>The list of Logstores.</para>
            /// </summary>
            [NameInMap("DataSourceStores")]
            [Validation(Required=false)]
            public List<ListDataSourcesResponseBodyDataSourcesDataSourceStores> DataSourceStores { get; set; }
            public class ListDataSourcesResponseBodyDataSourcesDataSourceStores : TeaModel {
                /// <summary>
                /// <para>The time when the check was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1733269771123</para>
                /// </summary>
                [NameInMap("CheckTime")]
                [Validation(Required=false)]
                public long? CheckTime { get; set; }

                /// <summary>
                /// <para>The time when the log storage was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1733269771123</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The source of the data. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>center</para>
                /// </description></item>
                /// <item><description><para>custom</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>center</para>
                /// </summary>
                [NameInMap("DataSourceStoreFrom")]
                [Validation(Required=false)]
                public string DataSourceStoreFrom { get; set; }

                /// <summary>
                /// <para>The ID of the log storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>di_xxxx_source_1</para>
                /// </summary>
                [NameInMap("DataSourceStoreId")]
                [Validation(Required=false)]
                public string DataSourceStoreId { get; set; }

                /// <summary>
                /// <para>The status of the log storage. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>normal</para>
                /// </description></item>
                /// <item><description><para>abnormal</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("DataSourceStoreStatus")]
                [Validation(Required=false)]
                public string DataSourceStoreStatus { get; set; }

                /// <summary>
                /// <para>The status code of the log storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LogStoreNotExist</para>
                /// </summary>
                [NameInMap("DataSourceStoreStatusCode")]
                [Validation(Required=false)]
                public string DataSourceStoreStatusCode { get; set; }

                /// <summary>
                /// <para>The name of the Simple Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun-cloudsiem-data-173326*******-cn-hangzhou</para>
                /// </summary>
                [NameInMap("LogProjectName")]
                [Validation(Required=false)]
                public string LogProjectName { get; set; }

                /// <summary>
                /// <para>The ID of the log storage region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("LogRegionId")]
                [Validation(Required=false)]
                public string LogRegionId { get; set; }

                /// <summary>
                /// <para>The name of the Simple Log Service Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>audit-activity</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <para>The time when the log storage was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1733269771123</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The ID of the data source template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_account_snapshot_log_173326*******</para>
            /// </summary>
            [NameInMap("DataSourceTemplateId")]
            [Validation(Required=false)]
            public string DataSourceTemplateId { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>preset</para>
            /// </description></item>
            /// <item><description><para>custom</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-173326*******-cn-hangzhou</para>
            /// </summary>
            [NameInMap("LogProjectName")]
            [Validation(Required=false)]
            public string LogProjectName { get; set; }

            /// <summary>
            /// <para>The ID of the log storage region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("LogRegionId")]
            [Validation(Required=false)]
            public string LogRegionId { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audit-activity</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>The ID of the user who can access the data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>173326*******</para>
            /// </summary>
            [NameInMap("LogUserId")]
            [Validation(Required=false)]
            public long? LogUserId { get; set; }

            /// <summary>
            /// <para>The time when the data source was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. If a value is returned, it indicates that not all results have been returned. You can use this token in the next query to continue retrieving results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
