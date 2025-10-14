// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDataSourceTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>enabled。</para>
        /// </summary>
        [NameInMap("AutoScanNew")]
        [Validation(Required=false)]
        public string AutoScanNew { get; set; }

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
        /// <para>zh。</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliyun-cloudsiem-data-173326*******。</para>
        /// </summary>
        [NameInMap("LogProjectPattern")]
        [Validation(Required=false)]
        public string LogProjectPattern { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou。</para>
        /// </summary>
        [NameInMap("LogRegionIds")]
        [Validation(Required=false)]
        public string LogRegionIds { get; set; }

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
