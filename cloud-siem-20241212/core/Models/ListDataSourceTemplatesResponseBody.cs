// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataSourceTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data source templates.</para>
        /// </summary>
        [NameInMap("DataSourceTemplates")]
        [Validation(Required=false)]
        public List<ListDataSourceTemplatesResponseBodyDataSourceTemplates> DataSourceTemplates { get; set; }
        public class ListDataSourceTemplatesResponseBodyDataSourceTemplates : TeaModel {
            /// <summary>
            /// <para>Indicates whether to automatically discover new users. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("AutoScanNew")]
            [Validation(Required=false)]
            public string AutoScanNew { get; set; }

            /// <summary>
            /// <para>The time when the template was created.</para>
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
            /// <para>custom</para>
            /// </summary>
            [NameInMap("DataSourceFrom")]
            [Validation(Required=false)]
            public string DataSourceFrom { get; set; }

            /// <summary>
            /// <para>Indicates whether to automatically discover new data sources.</para>
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
            /// <para>alibaba_cloud_actiontrail_event_ingestion</para>
            /// </summary>
            [NameInMap("DataSourceRecognizer")]
            [Validation(Required=false)]
            public string DataSourceRecognizer { get; set; }

            /// <summary>
            /// <para>The ID of the data source template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_actiontrail_event_ingestion</para>
            /// </summary>
            [NameInMap("DataSourceTemplateId")]
            [Validation(Required=false)]
            public string DataSourceTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the data source template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_actiontrail_event_ingestion</para>
            /// </summary>
            [NameInMap("DataSourceTemplateName")]
            [Validation(Required=false)]
            public string DataSourceTemplateName { get; set; }

            /// <summary>
            /// <para>The rule for matching the name of the Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-cloudsiem-data-173326*******</para>
            /// </summary>
            [NameInMap("LogProjectPattern")]
            [Validation(Required=false)]
            public string LogProjectPattern { get; set; }

            /// <summary>
            /// <para>The list of log storage region IDs.</para>
            /// </summary>
            [NameInMap("LogRegionIds")]
            [Validation(Required=false)]
            public List<string> LogRegionIds { get; set; }

            /// <summary>
            /// <para>The rule for matching the name of the Simple Log Service Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audit-activity</para>
            /// </summary>
            [NameInMap("LogStorePattern")]
            [Validation(Required=false)]
            public string LogStorePattern { get; set; }

            /// <summary>
            /// <para>The list of user IDs for batch data ingestion.</para>
            /// </summary>
            [NameInMap("LogUserIds")]
            [Validation(Required=false)]
            public List<string> LogUserIds { get; set; }

            /// <summary>
            /// <para>The time when the template was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
