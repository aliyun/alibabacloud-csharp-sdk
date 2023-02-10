// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportWarningRequest : TeaModel {
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        [NameInMap("IsCleartextPwd")]
        [Validation(Required=false)]
        public int? IsCleartextPwd { get; set; }

        [NameInMap("IsSummaryExport")]
        [Validation(Required=false)]
        public int? IsSummaryExport { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("RiskIds")]
        [Validation(Required=false)]
        public string RiskIds { get; set; }

        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public string RiskLevels { get; set; }

        [NameInMap("RiskName")]
        [Validation(Required=false)]
        public string RiskName { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        [NameInMap("SubTypeNames")]
        [Validation(Required=false)]
        public string SubTypeNames { get; set; }

        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        [NameInMap("TypeNames")]
        [Validation(Required=false)]
        public string TypeNames { get; set; }

        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
