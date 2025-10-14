// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDataIngestionTemplatesResponseBody : TeaModel {
        [NameInMap("DataIngestionTemplates")]
        [Validation(Required=false)]
        public List<ListDataIngestionTemplatesResponseBodyDataIngestionTemplates> DataIngestionTemplates { get; set; }
        public class ListDataIngestionTemplatesResponseBodyDataIngestionTemplates : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3。</para>
            /// </summary>
            [NameInMap("CapacityCount")]
            [Validation(Required=false)]
            public string CapacityCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1733269771123。</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>realtime。</para>
            /// </summary>
            [NameInMap("DataIngestionMode")]
            [Validation(Required=false)]
            public string DataIngestionMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled。</para>
            /// </summary>
            [NameInMap("DataIngestionStatus")]
            [Validation(Required=false)]
            public string DataIngestionStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_account_snapshot_log。</para>
            /// </summary>
            [NameInMap("DataIngestionTemplateId")]
            [Validation(Required=false)]
            public string DataIngestionTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_account_snapshot_log。</para>
            /// </summary>
            [NameInMap("DataIngestionTemplateName")]
            [Validation(Required=false)]
            public string DataIngestionTemplateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running。</para>
            /// </summary>
            [NameInMap("DataIngestionTemplateStatus")]
            [Validation(Required=false)]
            public string DataIngestionTemplateStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_sas_account_snapshot_log_173326*******。</para>
            /// </summary>
            [NameInMap("DataSourceTemplateId")]
            [Validation(Required=false)]
            public string DataSourceTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba_cloud_actiontrail_event_rule。</para>
            /// </summary>
            [NameInMap("NormalizationRuleId")]
            [Validation(Required=false)]
            public string NormalizationRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>normalization_rule_ke1RN。</para>
            /// </summary>
            [NameInMap("NormalizationRuleName")]
            [Validation(Required=false)]
            public string NormalizationRuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173326*******。</para>
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
