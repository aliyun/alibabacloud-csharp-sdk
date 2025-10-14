// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDataIngestionRequest : TeaModel {
        [NameInMap("CapacityCount")]
        [Validation(Required=false)]
        public int? CapacityCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>realtime。</para>
        /// </summary>
        [NameInMap("DataIngestionMode")]
        [Validation(Required=false)]
        public string DataIngestionMode { get; set; }

        [NameInMap("DataIngestionStateCode")]
        [Validation(Required=false)]
        public string DataIngestionStateCode { get; set; }

        [NameInMap("DataIngestionType")]
        [Validation(Required=false)]
        public string DataIngestionType { get; set; }

        [NameInMap("DataSourceEditable")]
        [Validation(Required=false)]
        public bool? DataSourceEditable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ds-3g6lyf4eonngyohaq7tr。</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh。</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("NormalizationRuleEditable")]
        [Validation(Required=false)]
        public bool? NormalizationRuleEditable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nr-hdmady54piigkjfv17yp。</para>
        /// </summary>
        [NameInMap("NormalizationRuleId")]
        [Validation(Required=false)]
        public string NormalizationRuleId { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

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

        [NameInMap("ScanDataSourceId")]
        [Validation(Required=false)]
        public string ScanDataSourceId { get; set; }

        [NameInMap("StreamJobId")]
        [Validation(Required=false)]
        public string StreamJobId { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
