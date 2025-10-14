// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSourceTemplatesResponseBody : TeaModel {
        [NameInMap("DataSourceTemplates")]
        [Validation(Required=false)]
        public List<ListDataSourceTemplatesResponseBodyDataSourceTemplates> DataSourceTemplates { get; set; }
        public class ListDataSourceTemplatesResponseBodyDataSourceTemplates : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled。</para>
            /// </summary>
            [NameInMap("AutoScanNew")]
            [Validation(Required=false)]
            public string AutoScanNew { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>custom。</para>
            /// </summary>
            [NameInMap("DataSourceFrom")]
            [Validation(Required=false)]
            public string DataSourceFrom { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true。</para>
            /// </summary>
            [NameInMap("DataSourceRecognizeEnabled")]
            [Validation(Required=false)]
            public bool? DataSourceRecognizeEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_actiontrail_event_ingestion。</para>
            /// </summary>
            [NameInMap("DataSourceRecognizer")]
            [Validation(Required=false)]
            public string DataSourceRecognizer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_actiontrail_event_ingestion。</para>
            /// </summary>
            [NameInMap("DataSourceTemplateId")]
            [Validation(Required=false)]
            public string DataSourceTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_actiontrail_event_ingestion。</para>
            /// </summary>
            [NameInMap("DataSourceTemplateName")]
            [Validation(Required=false)]
            public string DataSourceTemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-173326*******。</para>
            /// </summary>
            [NameInMap("LogProjectPattern")]
            [Validation(Required=false)]
            public string LogProjectPattern { get; set; }

            [NameInMap("LogRegionIds")]
            [Validation(Required=false)]
            public List<string> LogRegionIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>audit-activity。</para>
            /// </summary>
            [NameInMap("LogStorePattern")]
            [Validation(Required=false)]
            public string LogStorePattern { get; set; }

            [NameInMap("LogUserIds")]
            [Validation(Required=false)]
            public List<string> LogUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-08 10:28:31</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1。</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10。</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
