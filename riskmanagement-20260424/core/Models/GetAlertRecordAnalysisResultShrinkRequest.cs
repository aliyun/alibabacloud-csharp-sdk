// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAlertRecordAnalysisResultShrinkRequest : TeaModel {
        [NameInMap("AlarmUniqueInfo")]
        [Validation(Required=false)]
        public string AlarmUniqueInfo { get; set; }

        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        [NameInMap("UniqueInfo")]
        [Validation(Required=false)]
        public string UniqueInfo { get; set; }

        [NameInMap("UniqueTagList")]
        [Validation(Required=false)]
        public string UniqueTagListShrink { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
