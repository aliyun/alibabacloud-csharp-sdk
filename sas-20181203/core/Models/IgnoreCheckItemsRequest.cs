// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class IgnoreCheckItemsRequest : TeaModel {
        [NameInMap("CheckAndRiskTypeList")]
        [Validation(Required=false)]
        public List<IgnoreCheckItemsRequestCheckAndRiskTypeList> CheckAndRiskTypeList { get; set; }
        public class IgnoreCheckItemsRequestCheckAndRiskTypeList : TeaModel {
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            [NameInMap("RiskType")]
            [Validation(Required=false)]
            public string RiskType { get; set; }

        }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
