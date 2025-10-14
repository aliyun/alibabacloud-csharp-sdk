// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataIngestionTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>enabled。</para>
        /// </summary>
        [NameInMap("DataIngestionStatus")]
        [Validation(Required=false)]
        public string DataIngestionStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_ingestion_173326*******。</para>
        /// </summary>
        [NameInMap("DataIngestionTemplateId")]
        [Validation(Required=false)]
        public string DataIngestionTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_ingestion_173326*******。</para>
        /// </summary>
        [NameInMap("DataIngestionTemplateName")]
        [Validation(Required=false)]
        public string DataIngestionTemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh。</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba_cloud_actiontrail_event_rule。</para>
        /// </summary>
        [NameInMap("NormalizationRuleId")]
        [Validation(Required=false)]
        public string NormalizationRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou。</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173326*******。</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
