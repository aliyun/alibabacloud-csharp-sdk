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

        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("NormalizationRuleEditable")]
        [Validation(Required=false)]
        public bool? NormalizationRuleEditable { get; set; }

        [NameInMap("NormalizationRuleId")]
        [Validation(Required=false)]
        public string NormalizationRuleId { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
