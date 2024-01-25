// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class DescribeInspectionSettingsRequest : TeaModel {
        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public int? ProductType { get; set; }

        [NameInMap("RiskDesc")]
        [Validation(Required=false)]
        public string RiskDesc { get; set; }

        [NameInMap("RiskEnableStatus")]
        [Validation(Required=false)]
        public int? RiskEnableStatus { get; set; }

        [NameInMap("RiskName")]
        [Validation(Required=false)]
        public string RiskName { get; set; }

        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public int? RiskType { get; set; }

    }

}
