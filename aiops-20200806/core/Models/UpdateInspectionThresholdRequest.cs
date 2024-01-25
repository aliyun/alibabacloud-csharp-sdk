// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class UpdateInspectionThresholdRequest : TeaModel {
        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("RiskCode")]
        [Validation(Required=false)]
        public string RiskCode { get; set; }

        [NameInMap("ThresholdItemListJson")]
        [Validation(Required=false)]
        public string ThresholdItemListJson { get; set; }

    }

}
