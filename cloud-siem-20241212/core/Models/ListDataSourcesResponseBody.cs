// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSourcesResponseBody : TeaModel {
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<ListDataSourcesResponseBodyDataSources> DataSources { get; set; }
        public class ListDataSourcesResponseBodyDataSources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>center。</para>
            /// </summary>
            [NameInMap("DataSourceFrom")]
            [Validation(Required=false)]
            public string DataSourceFrom { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds-scpfegri73oyoknbc90c。</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AD_LOG。</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true。</para>
            /// </summary>
            [NameInMap("DataSourceRecognizeEnabled")]
            [Validation(Required=false)]
            public bool? DataSourceRecognizeEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_account_snapshot。</para>
            /// </summary>
            [NameInMap("DataSourceRecognizer")]
            [Validation(Required=false)]
            public string DataSourceRecognizer { get; set; }

            [NameInMap("DataSourceReferences")]
            [Validation(Required=false)]
            public List<ListDataSourcesResponseBodyDataSourcesDataSourceReferences> DataSourceReferences { get; set; }
            public class ListDataSourcesResponseBodyDataSourcesDataSourceReferences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>alibaba_cloud_sas_account_snapshot_log_173326*******。</para>
                /// </summary>
                [NameInMap("DataIngestionId")]
                [Validation(Required=false)]
                public string DataIngestionId { get; set; }

            }

            [NameInMap("DataSourceStatus")]
            [Validation(Required=false)]
            public string DataSourceStatus { get; set; }

            [NameInMap("DataSourceStores")]
            [Validation(Required=false)]
            public List<ListDataSourcesResponseBodyDataSourcesDataSourceStores> DataSourceStores { get; set; }
            public class ListDataSourcesResponseBodyDataSourcesDataSourceStores : TeaModel {
                [NameInMap("CheckTime")]
                [Validation(Required=false)]
                public long? CheckTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1733269771123。</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>center。</para>
                /// </summary>
                [NameInMap("DataSourceStoreFrom")]
                [Validation(Required=false)]
                public string DataSourceStoreFrom { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>di_xxxx_source_1。</para>
                /// </summary>
                [NameInMap("DataSourceStoreId")]
                [Validation(Required=false)]
                public string DataSourceStoreId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>normal。</para>
                /// </summary>
                [NameInMap("DataSourceStoreStatus")]
                [Validation(Required=false)]
                public string DataSourceStoreStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LogStoreNotExist</para>
                /// </summary>
                [NameInMap("DataSourceStoreStatusCode")]
                [Validation(Required=false)]
                public string DataSourceStoreStatusCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aliyun-cloudsiem-data-173326*******-cn-hangzhou。</para>
                /// </summary>
                [NameInMap("LogProjectName")]
                [Validation(Required=false)]
                public string LogProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou。</para>
                /// </summary>
                [NameInMap("LogRegionId")]
                [Validation(Required=false)]
                public string LogRegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>audit-activity。</para>
                /// </summary>
                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1733269771123。</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_account_snapshot_log_173326*******。</para>
            /// </summary>
            [NameInMap("DataSourceTemplateId")]
            [Validation(Required=false)]
            public string DataSourceTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>custom。</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-173326*******-cn-hangzhou。</para>
            /// </summary>
            [NameInMap("LogProjectName")]
            [Validation(Required=false)]
            public string LogProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou。</para>
            /// </summary>
            [NameInMap("LogRegionId")]
            [Validation(Required=false)]
            public string LogRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>audit-activity。</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173326*******。</para>
            /// </summary>
            [NameInMap("LogUserId")]
            [Validation(Required=false)]
            public long? LogUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50。</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****。</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1。</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1。</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2。</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1。</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
