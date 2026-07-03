// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataIngestionTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data ingestion templates.</para>
        /// </summary>
        [NameInMap("DataIngestionTemplates")]
        [Validation(Required=false)]
        public List<ListDataIngestionTemplatesResponseBodyDataIngestionTemplates> DataIngestionTemplates { get; set; }
        public class ListDataIngestionTemplatesResponseBodyDataIngestionTemplates : TeaModel {
            /// <summary>
            /// <para>The number of associated security capabilities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CapacityCount")]
            [Validation(Required=false)]
            public string CapacityCount { get; set; }

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
            /// <para>The data ingestion mode. Valid values:</para>
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
            /// <para>The data ingestion status. Valid values:</para>
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
            [NameInMap("DataIngestionStatus")]
            [Validation(Required=false)]
            public string DataIngestionStatus { get; set; }

            /// <summary>
            /// <para>The ID of the data ingestion template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_account_snapshot_log</para>
            /// </summary>
            [NameInMap("DataIngestionTemplateId")]
            [Validation(Required=false)]
            public string DataIngestionTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the data ingestion template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_account_snapshot_log</para>
            /// </summary>
            [NameInMap("DataIngestionTemplateName")]
            [Validation(Required=false)]
            public string DataIngestionTemplateName { get; set; }

            /// <summary>
            /// <para>The status of the data ingestion template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>pending</para>
            /// </description></item>
            /// <item><description><para>running</para>
            /// </description></item>
            /// <item><description><para>success</para>
            /// </description></item>
            /// <item><description><para>failed</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("DataIngestionTemplateStatus")]
            [Validation(Required=false)]
            public string DataIngestionTemplateStatus { get; set; }

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
            /// <para>The ID of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alibaba_cloud_actiontrail_event_rule</para>
            /// </summary>
            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

            /// <summary>
            /// <para>The name of the normalization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normalization_rule_ke1RN</para>
            /// </summary>
            [NameInMap("NormalizationRuleName")]
            [Validation(Required=false)]
            public string NormalizationRuleName { get; set; }

            /// <summary>
            /// <para>The time when the template was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>173326*******</para>
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
